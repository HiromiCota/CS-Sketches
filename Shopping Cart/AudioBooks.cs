using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Shopping_Cart
{
    public partial class AudioBooks : Form
    {
        private string selection = string.Empty;
        public AudioBooks()
        {
            InitializeComponent();
        }
        public string getSelection()
        {
            return selection;
        }

        private void AudioBooks_Load(object sender, EventArgs e)
        {
            //Load the print books from Books.txt to the listbox
            StreamReader reader = File.OpenText("Audio.txt");
            lstAudio.Items.Clear();
            while (!reader.EndOfStream)
            {
                lstAudio.Items.Add(reader.ReadLine());
            }
            reader.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Add the currently selected item to the shopping cart.
            if (lstAudio.SelectedIndex > -1)
            {
                selection = lstAudio.SelectedItem.ToString();
            }
            else
                selection = string.Empty;
            //Close the form.
            this.Close();
        }
    }
}
