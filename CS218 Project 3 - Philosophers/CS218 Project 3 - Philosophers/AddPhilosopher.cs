using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;


namespace CS218_Project_3___Philosophers
{
    public partial class AddPhilosopher : Form
    {
        public string name;       //What was their name?
        public string nationality; //Where were they from?
        public int born;          //When were they born?
        public int died;          //When did they die?
        public string famousWorks; //What are their most famous works.
        public string biography; //What is a short biography of them?
        public string URL;        //Where can we learn more?

        public AddPhilosopher()
        {
            InitializeComponent();
        }

        public int validateMyData()
        {
            int temp = 0;
            if (int.TryParse(txtBorn.Text, out born))
            {
                if (born > 0 && born < DateTime.Today.Year) //Can't test before TryParse completes
                    temp++;
                if (chkBornBCE.Checked) //Flip to negative to check that Died is greater.
                    born *= -1;
            }
            if (int.TryParse(txtDied.Text, out died))
            {
                if (chkDiedBCE.Checked)
                    died *= -1;
                //Allow for 0 to denote living philosopher
                if (died == 0) //Still living is always greater than a past number.
                    temp += 2;
                else if ((died > born && chkDiedBCE.Checked == false) || //One of these should be true
                    (-1 * died) > born && chkDiedBCE.Checked)
                    temp += 2;
            }
            return temp; //0 = both bad, 1 = born bad, 2 = died bad, 3 = all OK.
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int allValuesOK = 0;
            bool isUrlOK = false;
            
            allValuesOK = validateMyData();
            if (!txtURL.Text.StartsWith("http"))
                txtURL.Text = "http://" + txtURL.Text;
            isUrlOK = validateURL(txtURL.Text);

            DialogResult addUnverifiedSite = new DialogResult();
            if (isUrlOK == false)
            {
                addUnverifiedSite = MessageBox.Show("No response from website. Add anyway?","Error",MessageBoxButtons.YesNo);
                if (addUnverifiedSite == DialogResult.Yes)
                    isUrlOK = true;
                else
                    DialogResult = DialogResult.No;
            }

                if (allValuesOK == 3 && isUrlOK == true)
            {
                name = txtName.Text;
                nationality = txtNation.Text;
                born = int.Parse(txtBorn.Text);
                died = int.Parse(txtDied.Text);
                famousWorks = txtWorks.Text;
                biography = txtBiography.Text;
                URL = txtURL.Text;

                //If the user selected a checkbox, then the year is negative (kind of)
                if (chkBornBCE.Checked)
                    born *= -1;
                if (chkDiedBCE.Checked)
                    died *= -1;

                DialogResult = DialogResult.OK;
            }
            else 
                errorGenerator(allValuesOK);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void errorGenerator(int errorCode)
        {
            switch (errorCode)
            {
                case 2:
                    MessageBox.Show("Year of birth must be greater than 0.");
                    txtBorn.SelectAll();
                    txtBorn.Focus();
                    DialogResult = DialogResult.No;
                    break;
                case 1:
                    MessageBox.Show("Year of death must be zero or greater than the birth year.");
                    txtDied.SelectAll();
                    txtDied.Focus();
                    DialogResult = DialogResult.No;
                    break;
                case 0:
                    MessageBox.Show("Please check the philosopher's years of birth and death.");
                    txtDied.Text = "";
                    txtBorn.SelectAll();
                    txtBorn.Focus();
                    DialogResult = DialogResult.No;
                    break;
            }
    }

        private void AddPhilosopher_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.No)
            {                
                e.Cancel = true;
            }
        }
        private bool validateURL (string URL)
        {
            WebResponse response = null;
            try
            {
                WebRequest request = WebRequest.Create(URL);
                request.Timeout = 10000; //10 seconds should be plenty.
                request.Method = "HEAD"; //Don't need the body
                response = request.GetResponse();
                return true;
            }
            catch (WebException)
            {
                return false; //Domain not responding.
            }
            catch (Exception)
            {
                return false; //URL malformed somehow.
            }            
        }
    }
}
