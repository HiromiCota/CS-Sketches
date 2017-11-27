using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using CS218_Project_3___Philosophers;


namespace CS218_Project_3___Philosophers
{
    public partial class LearnPhilosophy : Form
    {
        public const string DELETE = "&Delete ";
        public const string EDIT = "&Edit ";
        public string xmlFile = "philosophers.xml";
        public bool dbAccessed = false;
        public Image defaultImage = Resource1.Aristotle;
                
        public List<string> nameList = new List<string>();          //What was their name?
        public List<string> nationalityList = new List<string>();   //Where were they from?
        public List<int> bornList = new List<int>();                //When were they born?
        public List<int> diedList = new List<int>();                //When did they die?
        public List<string> famousWorksList = new List<string>();   //What are their most famous works.
        public List<string> biographyList = new List<string>();     //What is a short biography of them?
        public List<string> URLList = new List<string>();           //Where can we learn more?
        public List<Image> imageList = new List<Image>();           //Where is their image?

        
        public LearnPhilosophy()
        {
            InitializeComponent();
        }

        private void LearnPhilosophy_Load(object sender, EventArgs e)
        {
            //Load philosophers from external XML file
            xmlLoader();

            //Populate listbox
            populateListBox();
            
        }
        
        private void xmlLoader()
        {
            nameList.Clear();
            bornList.Clear();
            diedList.Clear();
            nationalityList.Clear();
            famousWorksList.Clear();
            biographyList.Clear();
            URLList.Clear();
            imageList.Clear();
            
           try
            {
                XDocument reader = XDocument.Load(xmlFile);
                var nameX = from incomingPhilosopher in reader.Descendants("philosopher")
                    select new
                    {
                        name = incomingPhilosopher.Element("name").Value,
                        born = incomingPhilosopher.Element("born").Value,
                        died = incomingPhilosopher.Element("died").Value,
                        nationality = incomingPhilosopher.Element("nationality").Value,
                        works = incomingPhilosopher.Element("works").Value,
                        biography = incomingPhilosopher.Element("biography").Value,
                        URL = incomingPhilosopher.Element("URL").Value,
                        image = incomingPhilosopher.Element("image").Value
                    };
                foreach (var incomingPhilosopher in nameX)
                {                    
                    nameList.Add(incomingPhilosopher.name);
                    nationalityList.Add(incomingPhilosopher.nationality);
                    bornList.Add(int.Parse(incomingPhilosopher.born));
                    diedList.Add(int.Parse(incomingPhilosopher.died));
                    famousWorksList.Add(incomingPhilosopher.works);
                    biographyList.Add(incomingPhilosopher.biography);
                    URLList.Add(incomingPhilosopher.URL);
                    //imageList.Add(Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, incomingPhilosopher.image)));
                    imageList.Add(Image.FromFile(incomingPhilosopher.image));
                    //                    Uri imageLink = new Uri(incomingPhilosopher.image);
                }               
            }
           catch
           {
                //Flip out if we can't read the XML file.
           }
        }        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var form = new AddPhilosopher())
            {
                Philosophers newGuy = new Philosophers();
                var result = form.ShowDialog(this);
                if (result == DialogResult.OK)       //Grab values as it closes
                {
                    //Verify that this is a new philosopher.
                    newGuy.setName(form.name);
                    newGuy.setNation(form.nationality);
                    newGuy.setBorn(form.born);
                    if (duplicateCheck(newGuy)) //Only add if this isn't a duplicate
                    {
                        nameList.Add(form.name);
                        nationalityList.Add(form.nationality);
                        bornList.Add(form.born);
                        diedList.Add(form.died);
                        famousWorksList.Add(form.famousWorks);
                        biographyList.Add(form.biography);
                        URLList.Add(form.URL);
                        imageList.Add(defaultImage); //File uploads not supported for this version
                        populateListBox();
                        dbAccessed = true;
                    }
                }
            }//Last chance to grab AddPhilosopher values.
        }
        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int choice = lstSelector.SelectedIndex;
            Philosophers Edit = new Philosophers();
            Edit.superSet(nameList[choice], nationalityList[choice],
                bornList[choice], diedList[choice], famousWorksList[choice], 
                biographyList[choice], URLList[choice], imageList[choice]);

            using (var form = new EditPhilosopher(Edit))
            {                
                var result = form.ShowDialog();
                if (result == DialogResult.OK)     //Grab values as it closes                    
                {
                    //Don't check for duplicates because it's already in the database and will always return true.
                    nameList[choice] =          (form.name);
                    nationalityList[choice] =   (form.nationality);
                    bornList[choice] =          (form.born);
                    diedList[choice] =          (form.died);
                    famousWorksList[choice] =   (form.famousWorks);
                    biographyList[choice] =     (form.biography);
                    URLList[choice] =           (form.URL);
                    populateListBox();
                    dbAccessed = true;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int choice = lstSelector.SelectedIndex;
            DialogResult delete = MessageBox.Show("Are you sure you want to delete this item?", "Delete Data?", MessageBoxButtons.YesNo);
            if (delete  == DialogResult.Yes)
            {
                //Oh, boy.
                nameList.RemoveAt(choice);
                nationalityList.RemoveAt(choice);
                bornList.RemoveAt(choice);
                diedList.RemoveAt(choice);
                famousWorksList.RemoveAt(choice);
                biographyList.RemoveAt(choice);
                URLList.RemoveAt(choice);
                populateListBox();
                dbAccessed = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult really = new DialogResult();
            if (dbAccessed == true)
                really = MessageBox.Show("You have unsaved changes. Do you want to save before exiting?", "Confirm", MessageBoxButtons.YesNo);
            if (really == DialogResult.Yes)
                sfdSaveFile.ShowDialog();
            
            Close();
        }

        private void lstSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            int currentIndex = lstSelector.SelectedIndex; //Capture so the object only gets referenced once
            txtName.Text = (nameList[currentIndex]);
            txtNation.Text = (nationalityList[currentIndex]);
            txtBorn.Text = yearStringBuilder(bornList[currentIndex]);
            txtDied.Text = yearStringBuilder(diedList[currentIndex]);
            txtWorks.Text = (famousWorksList[currentIndex]);
            txtBio.Text = (biographyList[currentIndex]);
            rtxURL.Text = (URLList[currentIndex]);            
            picShowImage.Image = (imageList[currentIndex]) ;
            updateMenus(nameList[currentIndex]);
        }
        private string yearStringBuilder(int year)
        {
            //Strip out negative signs & add era abbreviations
            string temp = "";
            if (year > 0)
                temp = year.ToString() + " CE";
            else if (year < 0)
                temp = (Math.Abs(year)).ToString() + " BCE"; 

            //If year == 0, philosopher is still alive, or there's an input error

            return temp;

        }
        private void populateListBox()
        {
            lstSelector.Items.Clear();
            for (int i = 0; i <= nameList.Count - 1; i++)
            {
                lstSelector.Items.Add(nameList[i]);
            }

            //This triggers lstSelector_SelectedIndexChanged
            lstSelector.SelectedIndex = 0;
        }

        private void rtxURL_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText); //Opens in default browser.
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfdSaveFile.ShowDialog();
        }

        private void sfdSaveFile_FileOk(object sender, CancelEventArgs e)
        {
            string fileName = sfdSaveFile.FileName;
            string fileContents = @"<?xml version=""1.0"" encoding=""UTF-8""?>";
            fileContents += "\n<container>\n"; //The literal marker prevents the line breaks.

            for (int i = 0; i < nameList.Count; i++)
            {
                fileContents += "\t<philosopher>\n"; //The tabs and lines aren't needed, but it's easier to read.

                fileContents += "\t\t<name>"; //These blocks could be one line, but this is easier to read.
                fileContents += nameList[i];
                fileContents += "</name>\n";

                fileContents += "\t\t<born>";
                fileContents += (bornList[i].ToString());
                fileContents += "</born>\n";

                fileContents += "\t\t<died>";
                fileContents += (diedList[i].ToString());
                fileContents += "</died>\n";

                fileContents += "\t\t<nationality>";
                fileContents += nationalityList[i];
                fileContents += "</nationality>\n";

                fileContents += "\t\t<works>";
                fileContents += famousWorksList[i];
                fileContents += "</works>\n";

                fileContents += "\t\t<biography>";
                fileContents += biographyList[i];
                fileContents += "</biography>\n";

                fileContents += "\t\t<URL>";
                fileContents += URLList[i];
                fileContents += "</URL>\n";

                fileContents += "\t</philosopher>\n";
            }//End for loop
            fileContents += "</container>";
            File.WriteAllText(fileName, fileContents);
            dbAccessed = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofdOpenFile.ShowDialog();
        }

        public void ofdOpenFile_FileOk(object sender, CancelEventArgs e)
        {
            xmlFile = ofdOpenFile.FileName;
            xmlLoader();
            populateListBox();
        }

        public void updateMenus(string name)
        {
            mnuEdit.Text = EDIT + name;
            mnuDelete.Text = DELETE + name;
        }
        public bool duplicateCheck(Philosophers toBeChecked)
        {
            for (int i = 0; i < nameList.Count; i++)
            {
                if (toBeChecked.areDuplicate(nameList[i], bornList[i], nationalityList[i]))
                    return false;                
            }
            return true;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            btnExit.PerformClick();
        }

        private void mnuAdd_Click(object sender, EventArgs e)
        {
            btnAdd.PerformClick();
        }

        private void mnuEdit_Click(object sender, EventArgs e)
        {
            btnEdit.PerformClick();
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            btnDelete.PerformClick();
        }

        private void mnuSearchName_Click(object sender, EventArgs e)
        {
            //Get the search key
            string key = "";            
            getInput(ref key, "name");

            //Do the search
            if (key != "")
                search(key, nameList);
        }
        private void search(string key, List<string> data)
        {
            bool done = false;
            for (int i = 0; done == false && i < nameList.Count; i++)
            {
                if (data[i].ToUpper().Contains(key.ToUpper()))
                {
                    MessageBox.Show(key + " found!");
                    lstSelector.SelectedIndex = i;
                    done = true;
                }
            }
            if (!done)
                MessageBox.Show(key + " not found.");
        }
        public string getInput(ref string input, string dialogTitle)
        {
            Form inputBox = new Form();
            Size sizeVariable = new Size(220, 70);
            inputBox.ClientSize = sizeVariable;
            inputBox.Text = "Enter full or partial " + dialogTitle;
            inputBox.StartPosition = FormStartPosition.CenterScreen;
            inputBox.MinimizeBox = false;
            inputBox.MaximizeBox = false;
            inputBox.FormBorderStyle = FormBorderStyle.FixedSingle;

            //Make a textbox
            TextBox typeHere = new TextBox();
            typeHere.Size = new Size(sizeVariable.Width - 10, FontHeight + 2);
            typeHere.Location = new Point(5, 5);
            typeHere.Text = input;

            inputBox.Controls.Add(typeHere);

            Button okButton = new Button();
            okButton.DialogResult = DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.Location = new Point(sizeVariable.Width - 180, typeHere.Size.Height + 10);
            okButton.Text = "&OK";
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.Location = new Point(sizeVariable.Width - 100, typeHere.Size.Height + 10);
            cancelButton.Text = "&Cancel";
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();
            if (result == DialogResult.OK)
                input = typeHere.Text;
            else
                input = "";

            return input;
        }

        private void mnuSearchNationality_Click(object sender, EventArgs e)
        {
            //Get the search key
            string key = "";
            getInput(ref key, "nation of origin");

            //Do the search
            if (key != "")
                search(key, nationalityList);
        }


        private void mnuSortAZ_Click(object sender, EventArgs e)
        {
            sortStrings(nameList, true);            
        }

        private void mnuSortZA_Click(object sender, EventArgs e)
        {
            sortStrings(nameList, false);
        }

        private void mnuSortBornFirst_Click(object sender, EventArgs e)
        {
            sortInts(bornList, true);
        }

        private void mnuSortBornLast_Click(object sender, EventArgs e)
        {
            sortInts(bornList, false);
        }

        private void mnuSortDiedFirst_Click(object sender, EventArgs e)
        {
            sortInts(diedList, true);
        }

        private void mnuSortDiedLast_Click(object sender, EventArgs e)
        {
            sortInts(diedList, false);
        }
        private void sortStrings(List<string> sortMethod, bool ascending)
        {
            //ascending true = A-Z, 1-10; false = Z-A, 10-1
            int interesting = 0;
            int searchDirection = 0;
            if (ascending == true)
                searchDirection = 1;
            else
                searchDirection = -1;
            Philosophers temp = new Philosophers();
            
            for (int i = 0; i < sortMethod.Count-1;i++)
            {
                interesting = i;
                for (int j = i+1; j < sortMethod.Count; j++)
                {
                    if (sortMethod[interesting].CompareTo(sortMethod[j]) == searchDirection)
                        interesting = j;
                }
                if (i != interesting)                       //No reason to do this if i is in the right spot.
                {
                    loadPhilosopher(ref temp, i);           //Save values
                    listMover(i, interesting);              //All values at i are replaced.
                    unLoadPhilosopher(temp, interesting);   //Data that was at i is now at interesting
                }                
            }
            populateListBox();
        }
        private void sortInts(List<int> sortMethod, bool ascending)
        {
            //ascending true = A-Z, 1-10; false = Z-A, 10-1
            int interesting = 0;
            int searchDirection = 0;
            if (ascending == true)
                searchDirection = 1;
            else
                searchDirection = -1;
            Philosophers temp = new Philosophers();

            for (int i = 0; i < sortMethod.Count-1; i++)
            {
                interesting = i;
                for (int j = i + 1; j < sortMethod.Count; j++)
                {
                    if (sortMethod[interesting].CompareTo(sortMethod[j]) == searchDirection)
                        interesting = j;
                }
                if (i != interesting)                       //No reason to do this if i is in the right spot.
                {
                    loadPhilosopher(ref temp, i);           //Save values
                    listMover(i, interesting);              //All values at i are replaced.
                    unLoadPhilosopher(temp, interesting);   //Data that was at i is now at interesting
                }
            }
            populateListBox();
        }
        public void loadPhilosopher (ref Philosophers empty, int index)
        {
            empty.name = nameList[index];
            empty.nationality = nationalityList[index];
            empty.born = bornList[index];
            empty.died = diedList[index];
            empty.famousWorks = famousWorksList[index];
            empty.biography = biographyList[index];
            empty.URL = URLList[index];
            empty.imageLink = imageList[index];
        }
        public void unLoadPhilosopher(Philosophers full, int index)
        {
            nameList[index] = full.name;
            nationalityList[index] = full.nationality;
            bornList[index] = full.born;
            diedList[index] = full.died;
            famousWorksList[index] = full.famousWorks;
            biographyList[index] = full.biography;
            URLList[index] = full.URL;
            imageList[index] = full.imageLink;
        }
        public void listMover(int dead, int live) //ALL DATA AT INDEX dead IS ABOUT TO GO AWAY!
        {
            nameList[dead] = nameList[live];
            nationalityList[dead] = nationalityList[live];
            bornList[dead] = bornList[live];
            diedList[dead] = diedList[live];
            famousWorksList[dead] = famousWorksList[live];
            biographyList[dead] = biographyList[live];
            URLList[dead] = URLList[live];
            imageList[dead] = imageList[live];
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            picShowImage.Visible = true;
            picShowImage.BringToFront();
        }

        private void picShowImage_Click(object sender, EventArgs e)
        {
            picShowImage.Visible = false;
            picShowImage.SendToBack();
        }
    }
}
