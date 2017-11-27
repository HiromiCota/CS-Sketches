/*'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
'Comments by the prof:
'
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
'Lab #8--Shopping Cart
'Created by Niko Culevski
'Class: CS 218
'Date: 10/26/2016
'Project Name: Shopping Cart
'Hours to Complete: 1 hours 25 minutes
'Platform: PC, VS 2015, Windows 10
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
'Develop an application that works as a shopping cart system. The user should be 
'able to add any of the following 
'Print Books (books on paper):
'I Did It Your Way			$11.95
'The History of Scotland	$14.50
'Learn Calculus in One Day	$29.95
'Feel the Stress			$18.50

'Audio Books (books on CD’s):
'Learn Calculus in One Day	    $29.95
'The History of Scotland		$14.50
'The Science of Body Language	$12.95
'Relaxation Techniques		    $11.50
'
'There is $2 shipping and 6% tax on all orders. To remove an item from the shopping, 
'cart the user selects in the listbox and click the remove button. Printed texts
'and Audio texts are read from externa files.
'
'Required input:
'   1. Select as print book from a separate Print Book order form
'   2. Select an audio book from a separate Audio Book order form
'Output:  Shopping cart total for all orders
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
'Comments by the student:
'
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_Cart
{
    public partial class Cart : Form
    {
        //Class constants for sales tax and shipping cost
        const float TAX_RATE = 0.098f;          //9.8% Seattle tax
        const decimal SHIPPING_CHARGE = 2.0m;   //m for money $2 each item.
        public Cart()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(lstProducts.SelectedIndex > -1)
            {
                lstProducts.Items.Remove(lstProducts.SelectedItem);
                updateCharges();
            }
            
        }
        private void updateCharges()
        {
            //Update the order total. 
            //Need 4 variables for this
            decimal subtotal = 0.0m;
            decimal taxTotal = 0.0m;
            decimal shippingTotal = 0.0m;
            decimal finalTotal = 0.0m;

            //Call a method to update the subtotal
            subtotal = calculateSubtotal();
            txtSubtotal.Text = subtotal.ToString("C");

            //Get tax total & display it
            taxTotal = subtotal * (decimal)TAX_RATE;
            txtTax.Text = taxTotal.ToString("C");

            //Get shipping total & display it
            shippingTotal = lstProducts.Items.Count * SHIPPING_CHARGE;
            txtShipping.Text = shippingTotal.ToString("C");

            //Get & display final total
            finalTotal = subtotal + taxTotal + shippingTotal;
            txtTax.Text = finalTotal.ToString("C");
        }//End updateCharges()
        private decimal calculateSubtotal()
        {
            decimal runningTotal = 0.0m;
            for (int i = 0; i < lstProducts.Items.Count; i++)
            {
                string item = lstProducts.Items[i].ToString();
                if (item.Equals("I Did It Your Way (Print)"))
                    runningTotal += 11.95m;
                else if (item.Equals("The History of Scotland (Print)"))
                    runningTotal += 14.50m;
                else if (item.Equals("Learn Calculus in One Day (Print)"))
                    runningTotal += 29.95m;
                else if (item.Equals("Feel the Stress (Print)"))
                    runningTotal += 18.50m;
                else if (item.Equals("Learn Calculus in One Day (Audio)"))
                    runningTotal += 29.95m;
                else if (item.Equals("The History of Scotland (Audio)"))
                    runningTotal += 14.50m;
                else if (item.Equals("The Science of Body Language (Audio)"))
                    runningTotal += 12.95m;
                else if (item.Equals("Relaxation Techniques (Audio)"))
                    runningTotal += 11.50m;
            }
            return runningTotal;
        }//End calculateSubtotal

        private void PrintBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Bring up book form
            PrintBooks printForm = new PrintBooks();
            printForm.ShowDialog();
            string selectedBook = printForm.getSelection(); //Call to a public method in PrintBooks
            if (selectedBook != string.Empty)
                lstProducts.Items.Add(selectedBook);
            updateCharges();
        }

        private void AudioBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Bring up book form
            AudioBooks audioForm = new AudioBooks();
            audioForm.ShowDialog();
            string selectedBook = audioForm.getSelection(); //Call to a public method in PrintBooks
            if (selectedBook != string.Empty)
                lstProducts.Items.Add(selectedBook);
            updateCharges();
        }
    }
}
