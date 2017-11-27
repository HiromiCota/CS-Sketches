/*'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
'Comments by the prof:
'
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
'Project #2—Fuzzy Dice
'Created by Hiromi Cota
'Date: 10/20/2016 11/7/2016
'Project Name:  FuzzyDice
'Class: CS 218
'Time: Lots
'Platform: PC, Windows 7, C# 2012
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
'This program generates an invoice to be sent to customers.
'
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
'Comments by the student:
'
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
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

namespace CS218_Project_2_Fuzzy_dice
{
    public partial class FuzzyDice : Form
    {
        //Constants
        const float DISCOUNT_THRESHOLD = 500.0f;
        const float DISCOUNT_PERCENTAGE = 0.07f;
        const float TAX_PERCENTAGE = 0.0825f;
        const int FREE_SHIPPING_THRESHOLD = 20;
        const string ORDER = "Order #";

        //Class-level objects
        //NOTE: Dice can't be loaded with their objects before the form loads
        //because the objects don't exist yet.
        Dice dice1 = new Dice(
            "Red/White", //Name
            5.00f //Price
            );
        Dice dice2 = new Dice(
            "White/Black", //Name
            6.25f //Price            
            );
        Dice dice3 = new Dice(
            "Blue/Black", //Name
            7.50f //Price            
            );
    
        Image image1 = Image.FromFile("redWhite.jpg");
        Image image2 = Image.FromFile("whiteBlack.jpg");
        Image image3 = Image.FromFile("blueBlack.jpg");


        //Class-level variables
        float subTotal = 0.00f;
        float[] SHIPPING_COST_ARRAY = {
            8.95F, //UPS Ground
            16.95F, //UPS 3 day
            25.95F, //UPS Next day
            0F };
        int orderNumber = 0;

        //************************************
        //FuzzyDice()
        //************************************
        //Arguments: None
        //Returns: Nothing
        //
        //Initializes everything.
        //************************************
        public FuzzyDice()
        {
            InitializeComponent();
        }

        //************************************
        //FuzzyDice_Load()
        //************************************
        //Arguments: None
        //Returns: Nothing
        //
        //Loads combo boxes and Dice class objects
        //************************************
        private void FuzzyDice_Load(object sender, EventArgs e)
        {
            //Load reporting variables
            bool addressLoaded = false;
            int statesLoaded = 0;
            int shipMethodsLoaded = 0;
            string statusBar = "";

            orderNumber++;

            //Populate combo boxes from file
            statesLoaded = stateComboBoxLoader();
            shipMethodsLoaded = shippingMethodLoader();
            //Populate store address from file
            addressLoaded = storeAddressLoader();

            //Use statusBar to notify user of load states.
            if (addressLoaded) //Address loaded
                statusBar = "Address.txt loaded. ";
            statusBar += statesLoaded.ToString() +
                " states and territories loaded. " +
                shipMethodsLoaded.ToString() + 
                " shipping methods loaded."; 
            lblStatusBar.Text = statusBar;

            //Fully load Dice class objects
            dice1.SetObjects(updDice1, mnuDice1Quantity, lblCostDie1,image1,updDice1.Value,0f);
            dice2.SetObjects(updDice2, mnuDice2Quantity, lblCostDie2,image2,updDice2.Value,0f);
            dice3.SetObjects(updDice3, mnuDice3Quantity, lblCostDie3,image3,updDice3.Value,0f);

            //Sync form and Dice class
            lblDiceType1Static.Text = dice1.name;
            lblDiceType2Static.Text = dice2.name;
            lblDiceType3Static.Text = dice3.name;

            //Set lblOrder
            lblOrderNumber.Text = ORDER + orderNumber.ToString("D6");
        }

        //************************************
        //stateComboBoxLoader()
        //************************************
        //Arguments: None
        //Returns: Number of states and territories loaded.
        //
        //Reads US States from file and populates cboState
        //************************************
        private int stateComboBoxLoader()
        {
            string state = "";
            int counter = 0;
            try
            {
                System.IO.StreamReader file =
                    new System.IO.StreamReader("states.txt");
                while ((state = file.ReadLine()) != null)
                {
                    cboState.Items.Add(state);
                    counter++;
                }
                cboState.SelectedIndex = 0;                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load states.txt!", ex.ToString());                
            }
            return counter;
        }
        //************************************
        //shippingMethodLoader()
        //************************************
        //Arguments: None
        //Returns: int - Number of shipping methods successfully loaded.
        //
        //Reads Shipping methods from file and populates cboShippingMethod
        //************************************
        private int shippingMethodLoader()
        {
            string shipping = "";
            int counter = 0;
            try
            {
                System.IO.StreamReader file =
                    new System.IO.StreamReader("shippingmethods.txt");
                while ((shipping = file.ReadLine()) != null)
                {
                    cboShippingMethod.Items.Add(shipping);
                    counter++;
                }
                cboShippingMethod.SelectedIndex = 0;                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not read shippingmethods.txt", ex.ToString());                
            }
            return counter;
        }
        //************************************
        //storeAddressLoader()
        //************************************
        //Arguments: None
        //Returns: boolean - Load success or failure.
        //
        //Reads store address from file and populates lblStoreAddress
        //************************************
        private bool storeAddressLoader()
        {
            try
            {
                //Get address from file
                using (StreamReader file = new StreamReader("address.txt"))
                {
                    //Read stream to string
                    string address = file.ReadToEnd();
                    lblStoreAddress.Text = address;
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not read address.txt.", ex.ToString());
                return false;                         
            }
        }
        //************************************
        //updDice1_ValueChanged()
        //************************************
        //Arguments: None
        //Returns: Nothing
        //
        //Calls quantityUpdater
        //************************************
        private void updDice1_ValueChanged(object sender, EventArgs e)
        {
            quantityUpdater(dice1);            
        }
        //************************************
        //updDice2_ValueChanged()
        //************************************
        //Arguments: None
        //Returns: Nothing
        //
        //Calls quantityUpdater
        //************************************
        private void updDice2_ValueChanged(object sender, EventArgs e)
        {
            quantityUpdater(dice2);
        }
        //************************************
        //updDice3_ValueChanged()
        //************************************
        //Arguments: None
        //Returns: Nothing
        //
        //Calls quantityUpdater
        //************************************
        private void updDice3_ValueChanged(object sender, EventArgs e)
        {
            quantityUpdater(dice3);
        }
        //************************************
        //totalRecalculate()
        //************************************
        //Arguments: None
        //Returns: Nothing
        //
        //Recalculates dice price totals and outputs to lblTotalOutput
        //************************************
        private void totalRecalculate()
        {
            lblTotalOutput.Text =
                (
                newPrice(dice1) +
                newPrice(dice2) +
                newPrice(dice3)
                ).ToString("C"); 
        }
        //************************************
        //newPrice() Overloaded version
        //************************************
        //Arguments: 
        //Dice - Whatever dice need calculations
        //bool - Is this being called from btnDisplay_Click() via orderBuilder()?
        //
        //Returns: 
        //float - price of whatever quantity of dice are selected.
        //
        //Updates subTotal 
        //Calculates subtotal for one type of dice
        //************************************
        private float newPrice(Dice currentDie, bool subTotalCalculationInProgress)
        {
            float thisPrice = currentDie.price * (float)currentDie.UPD.Value;
            if (subTotalCalculationInProgress)
                subTotal += thisPrice;
            return (thisPrice);
        }
        //************************************
        //newPrice() Basic version
        //************************************
        //Arguments: 
        //Dice - Whatever dice need calculations
        //
        //Returns: 
        //float - price of whatever quantity of dice are selected
        //
        //Calculates subtotal for one type of dice
        //************************************
        private float newPrice(Dice currentDie)
        {
            float thisPrice = currentDie.price * (float)currentDie.UPD.Value;
            return (thisPrice);
        }
        //************************************
        //quantityUpdater()
        //************************************
        //Arguments: 
        //Dice - Whatever dice need calculations
        //Returns: Nothing
        //
        //Updates price label for Dice
        //
        //Depends on totalRecalculate()
        //************************************
        private void quantityUpdater(Dice currentDice)
        {
            currentDice.LBL.Text=(
                currentDice.price * (float)currentDice.UPD.Value
                ).ToString("C");
            totalRecalculate();
            currentDice.CartLabel.Text = currentDice.UPD.Value.ToString() + " " + currentDice.name + " in cart";
        }
        //************************************
        //btnDisplay_Click()
        //************************************
        //Arguments: None
        //Returns: Nothing
        //
        //Builds invoice and outputs to lstOutput.
        //************************************
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            //Clear subtotal to prevent errors.
            subTotal = 0.00f;

            //Clear list box to remove old data.
            lstBillOutput.Items.Clear();
            
            if (customerValidator())
            {
                //Build customer data string
                lstBillOutput.Items.Add(txtCustomerName.Text);
                lstBillOutput.Items.Add(txtAddress1.Text);
                if (txtAddress2.Text != "")
                    lstBillOutput.Items.Add(txtAddress2.Text);
                lstBillOutput.Items.Add(txtCity.Text + ", " + cboState.Text + " " + mtxZip.Text);
            }
            else
            {
                lstBillOutput.Items.Add("Customer information is not complete!");
            }
            
            //Get order data
            lstBillOutput.Items.Add(orderBuilder(dice1, true)); //Triggers overloaded newPrice, which updates subTotal.
            lstBillOutput.Items.Add(orderBuilder(dice2, true)); //Triggers overloaded newPrice, which updates subTotal.
            lstBillOutput.Items.Add(orderBuilder(dice3, true));  //Triggers overloaded newPrice, which updates subTotal.
            
            //Determine discount status
            if (subTotal >= DISCOUNT_THRESHOLD) //Big spender detected!
                subTotal -= subTotal * DISCOUNT_PERCENTAGE;

            lstBillOutput.Items.Add(
                "Subtotal: " + subTotal.ToString("C"));
            //Determine shipping
            if (freeShipping() && //They qualify for free shipping
                cboShippingMethod.SelectedIndex == 0) //And they want free shipping
                cboShippingMethod.SelectedIndex = 3;
            float shippingCost = SHIPPING_COST_ARRAY[cboShippingMethod.SelectedIndex];
            string shippingData =
                "Shipping via: " + (cboShippingMethod.SelectedText) + " for " +
                shippingCost.ToString("C");

            lstBillOutput.Items.Add(shippingData);

            //Determine tax
            float taxAmount = (subTotal + shippingCost) * TAX_PERCENTAGE;

            lstBillOutput.Items.Add(
                "Tax @ " + TAX_PERCENTAGE.ToString("C") + " = " + taxAmount.ToString("C")
                );

            //Final total
            float finalTotal = subTotal + shippingCost + taxAmount;

            lstBillOutput.Items.Add(
                "Final total: " + finalTotal.ToString("C")
                );

        }
        private bool customerValidator()
        {
            if (txtCustomerName.TextLength > 0 &&
                txtAddress1.TextLength > 0 &&
                //Leaving Address 2 blank is OK.                
                txtCity.TextLength > 0)// &&
               // (mtxZip.TextLength == 5 || mtxZip.TextLength==9)) //Need Zip or Zip+4.
                return true;
            else
                return false;
        }
        private bool freeShipping()
        {
            if (
                (dice1.UPD.Value +
                dice2.UPD.Value +
                dice3.UPD.Value) >= FREE_SHIPPING_THRESHOLD)
                return true;
            else
                return false;
        }
        //************************************
        //orderBuilder()
        //************************************
        //Arguments: 
        //Dice- Whatever Dice needs calculations
        //bool - Was this called from btnDisplay_Click()?
        //Returns: Nothing
        //
        //Builds strings for the order information for one type of dice.
        //
        //Depends on overloaded newPrice()
        //************************************
        private string orderBuilder(Dice currentDice,bool subTotalCalculationInProgress)
        {
            if (currentDice.UPD.Value != 0)
            {
                return (
                    currentDice.UPD.Value.ToString() + " "+
                    currentDice.name + " dice @"+ 
                    currentDice.price + "/die = " +
                    newPrice(currentDice, subTotalCalculationInProgress).ToString("C") +
                    "\n"
                    );
            }
            else //There's no reason to build this line.
                return "";
        }
        //************************************
        //btnQuit_Click()
        //************************************
        //Arguments: None
        //Returns: Nothing
        //
        //Exits out.
        //************************************
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //************************************
        //mnuDice1Clear_Click()
        //************************************
        //Arguments: None
        //Returns: Nothing
        //
        //Clears dice1's quantity.
        //************************************
        private void mnuDice1Clear_Click(object sender, EventArgs e)
        {
            dice1.UPD.Value = 0; //This triggers updDice1_ValueChanged
        }
        //************************************
        //mnuDice2Clear_Click()
        //************************************
        //Arguments: None
        //Returns: Nothing
        //
        //Clears dice2's quantity.
        //************************************
        private void mnuDice2Clear_Click(object sender, EventArgs e)
        {
            dice2.UPD.Value = 0; //Triggers updDice2_ValueChanged
        }
        //************************************
        //mnuDice3Clear_Click()
        //************************************
        //Arguments: None
        //Returns: Nothing
        //
        //Clears dice3's quantity.
        //************************************
        private void mnuDice3Clear_Click(object sender, EventArgs e)
        {
            dice3.UPD.Value = 0; //Triggers updDice3_ValueChanged
        }
        //************************************
        //lblDiceType1Static_Click()
        //************************************
        //Arguments: None
        //Returns: Nothing
        //
        //Show picPopUp with dice1's image
        //UNLESS
        //it's already up, then get rid of it.
        //
        //Depends on:
        //picPopUp_Up  ()
        //picPopUp_Down ()
        //************************************
        private void lblDiceType1Static_Click(object sender, EventArgs e)
        {
            if (picPopUp.Visible == true)
                picPopUp_Down();
            else
            {
                picPopUp.Image = dice1.Picture;
                picPopUp_Up();
            }
        }
        //************************************
        //lblDiceType2Static_Click()
        //************************************
        //Arguments: None
        //Returns: Nothing
        //
        //Show picPopUp with dice2's image
        //UNLESS
        //it's already up, then get rid of it.
        //
        //Depends on:
        //picPopUp_Up  ()
        //picPopUp_Down ()
        //************************************
        private void lblDiceType2Static_Click(object sender, EventArgs e)
        {
            if (picPopUp.Visible == true)
                picPopUp_Down();
            else
            {
                picPopUp.Image = dice2.Picture;
                picPopUp_Up();
            }
        }
        //************************************
        //lblDiceType3Static_Click()
        //************************************
        //Arguments: None
        //Returns: Nothing
        //
        //Show picPopUp with dice3's image
        //UNLESS
        //it's already up, then get rid of it.
        //
        //Depends on:
        //picPopUp_Up ()
        //picPopUp_Down ()
        //************************************
        private void lblDiceType3Static_Click(object sender, EventArgs e)
        {
            if (picPopUp.Visible == true)
                picPopUp_Down();
            else
            {
                picPopUp.Image = dice3.Picture;
                picPopUp_Up();
            }
        }
        //************************************
        //picPopUp_Up()
        //************************************
        //Arguments: None
        //Returns: Nothing
        //
        //Makes picPopUp visible.
        //************************************
        private void picPopUp_Up()
        {
            picPopUp.Visible = true;
            picPopUp.BringToFront();
        }
        //************************************
        //picPopUp_Down()
        //************************************
        //Arguments: None
        //Returns: Nothing
        //
        //Makes picPopUp go away.
        //************************************
        private void picPopUp_Down()
        {
            picPopUp.SendToBack();
            picPopUp.Visible = false;
        }
        //************************************
        //picPopUp_Click()
        //************************************
        //Arguments: None
        //Returns: Nothing
        //
        //Also makes picPopUp go away.
        //
        //Depends on: picPopUp_Down()
        //************************************
        private void picPopUp_Click(object sender, EventArgs e)
        {
            picPopUp_Down();
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            orderNumber++;
            lblOrderNumber.Text = ORDER + orderNumber.ToString("D6");
            txtAddress1.Text = "";
            txtAddress2.Text = "";
            txtCity.Text = "";
            txtCustomerName.Text = "";
            mtxZip.Text = "";
            mnuDice1Clear.PerformClick();
            mnuDice2Clear.PerformClick();
            mnuDice3Clear.PerformClick();

            lstBillOutput.Items.Clear();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ppdPreview.ShowDialog();
        }

        private void pdInvoice_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int xCoord = 100;
            int yCoord = 100;
            int oneRow = 40;
            int oneColumn = 60;
            char address2line = ' ';
            if (txtAddress2.Text != "")
                address2line = '\n'; //Otherwise, don't give it a line.

            e.Graphics.DrawString("Fuzzy Dice Invoice for " + txtCustomerName.Text,
                new Font("Arial", 12), Brushes.Black, xCoord, yCoord);

            yCoord += oneRow; //Down a line

            e.Graphics.DrawString("FROM: ",
                new Font("Arial", 12), Brushes.Black, xCoord, yCoord);
            xCoord += oneColumn;
            e.Graphics.DrawString(lblStoreAddress.Text,
                new Font("Arial", 12), Brushes.Black, xCoord, yCoord);

            xCoord += 5 * oneColumn; //Right side block
            e.Graphics.DrawString("TO: ", 
                new Font("Arial", 12), Brushes.Black, xCoord, yCoord);

            xCoord += oneColumn;
            e.Graphics.DrawString(txtCustomerName.Text + '\n' +
                txtAddress1.Text + '\n' +
                txtAddress2.Text + address2line +
                txtCity.Text + ", " + cboState.Text + " " + mtxZip.Text,
                new Font("Arial", 12), Brushes.Black, xCoord, yCoord);

            xCoord -= 7 * oneColumn; //Go back to left margin
            yCoord += 5 * oneRow; //Go below the addresses;
            //Make the header
            e.Graphics.DrawString("Quantity (in pairs)",
                new Font("Arial", 12), Brushes.Black, xCoord, yCoord);
            xCoord += 3* oneColumn;
            e.Graphics.DrawString("Type",
                new Font("Arial", 12), Brushes.Black, xCoord, yCoord);
            xCoord += 2* oneColumn;
            e.Graphics.DrawString("Price/pair",
                new Font("Arial", 12), Brushes.Black, xCoord, yCoord);
            xCoord += 2*oneColumn;
            e.Graphics.DrawString("Cost",
                new Font("Arial", 12), Brushes.Black, xCoord, yCoord);

            //Dice1
            if (dice1.UPD.Value >0)
            {
                e.Graphics.DrawString(dice1.UPD.Value.ToString(),
                     new Font("Arial", 12), Brushes.Black, xCoord, yCoord);
                xCoord += 3 * oneColumn;
                e.Graphics.DrawString(dice1.name,
                    new Font("Arial", 12), Brushes.Black, xCoord, yCoord);
                xCoord += 2 * oneColumn;
                e.Graphics.DrawString(dice1.price.ToString("C"),
                    new Font("Arial", 12), Brushes.Black, xCoord, yCoord);
                xCoord += 2 * oneColumn;
                e.Graphics.DrawString(newPrice(dice1).ToString("C"),
                    new Font("Arial", 12), Brushes.Black, xCoord, yCoord);
            }
            if (dice2.UPD.Value > 0)
            {
                e.Graphics.DrawString(dice1.UPD.Value.ToString(),
                     new Font("Arial", 12), Brushes.Black, xCoord, yCoord);
                xCoord += 3 * oneColumn;
                e.Graphics.DrawString(dice1.name,
                    new Font("Arial", 12), Brushes.Black, xCoord, yCoord);
                xCoord += 2 * oneColumn;
                e.Graphics.DrawString(dice1.price.ToString("C"),
                    new Font("Arial", 12), Brushes.Black, xCoord, yCoord);
                xCoord += 2 * oneColumn;
                e.Graphics.DrawString(newPrice(dice1).ToString("C"),
                    new Font("Arial", 12), Brushes.Black, xCoord, yCoord);
            }
            if (dice3.UPD.Value > 0)
            {
                e.Graphics.DrawString(dice1.UPD.Value.ToString(),
                     new Font("Arial", 12), Brushes.Black, xCoord, yCoord);
                xCoord += 3 * oneColumn;
                e.Graphics.DrawString(dice1.name,
                    new Font("Arial", 12), Brushes.Black, xCoord, yCoord);
                xCoord += 2 * oneColumn;
                e.Graphics.DrawString(dice1.price.ToString("C"),
                    new Font("Arial", 12), Brushes.Black, xCoord, yCoord);
                xCoord += 2 * oneColumn;
                e.Graphics.DrawString(newPrice(dice1).ToString("C"),
                    new Font("Arial", 12), Brushes.Black, xCoord, yCoord);
            }
        }
        

        private void ppdPreview_Load(object sender, EventArgs e)
        {

        }
    }
    //************************************
    //Dice class
    //************************************
    //Handles all of the objects and properties of the dice.
    //
    //************************************
    public class Dice
    {
        //Fields for dice
        public string name; //User-friendly name for labels
        public float price; //price per die
        public NumericUpDown UPD; //Tracks quantity
        public ToolStripMenuItem CartLabel; //Reports quantity in menu strip
        public Label LBL; //Reports quantity in grpDice
        public Image Picture; //Image of dice for picPopUp
        public decimal quantity; //So that we only call the UPD when needed.
        public float cost; //So that newCost() only runs when needed.

        //Default constructor
        public Dice()
        {
            name = "Unnamed dice";
            price = 1.00f;                        
        }

        //Main constructor - The objects have to be loaded in after the form is loaded.
        public Dice(string incomingName, float incomingPrice, Label incomingSubTotal, NumericUpDown incomingUPD, ToolStripMenuItem incomingmenuQuantity, Image incomingPicture, decimal incomingQuantity, float incomingCost)
        {
            name = incomingName;
            price = incomingPrice;
            LBL = incomingSubTotal;
            UPD = incomingUPD;
            CartLabel = incomingmenuQuantity;
            Picture = incomingPicture;
        }
        //Temporary constructor
        public Dice(string incomingName, float incomingPrice)
        {
            name = incomingName;
            price = incomingPrice;            
        }

        //Set methods

        //************************************
        //SetName()
        //************************************
        //Arguments: None
        //Returns: Nothing
        //
        //Sets new name for dice object
        //************************************
        public void SetName(string incomingName)
        {
            name = incomingName;
        }
        //************************************
        //SetPrice()
        //************************************
        //Arguments: None
        //Returns: Nothing
        //
        //Sets new price for dice object
        //NOTE: This should never be needed.
        //************************************
        public void SetPrice(float incomingPrice)
        {
            price = incomingPrice;
        }
        //************************************
        //SetUPD()
        //************************************
        //Arguments: None
        //Returns: Nothing
        //
        //Sets new name for dice object
        //NOTE: This should never be needed.
        //************************************
        public void SetUPD(NumericUpDown incomingUPD)
        {
            UPD = incomingUPD;
        }
        //************************************
        //SetMenu()
        //************************************
        //Arguments: None
        //Returns: Nothing
        //
        //Sets new name for dice object
        //NOTE: This should never be needed.
        //************************************
        public void SetMenu(ToolStripMenuItem incomingMenuQuantity)
        {
            CartLabel = incomingMenuQuantity;
        }
        //************************************
        //SetSubtotal()
        //************************************
        //Arguments: None
        //Returns: Nothing
        //
        //Sets new subTotal label for dice object
        //NOTE: This should never be needed.
        //************************************
        public void SetSubtotal(Label incomingSubTotal)
        {
            LBL= incomingSubTotal;
        }
        //************************************
        //SetImage()
        //************************************
        //Arguments: None
        //Returns: Nothing
        //
        //Sets new image for dice object
        //************************************
        public void SetImage(Image incomingPicture)
        {
            Picture = incomingPicture;
        }
        //************************************
        //SetObjects()
        //************************************
        //Arguments: None
        //Returns: Nothing
        //
        //Sets all objects for dice object
        //Has to be called AFTER dice exist because
        //the dice exist before their objects do.
        //************************************
        public void SetObjects(NumericUpDown incomingUPD, ToolStripMenuItem incomingMenuItem, Label incomingSubtotal, Image incomingPicture, decimal incomingQuantity, float incomingCost)
        {
            UPD = incomingUPD;
            CartLabel = incomingMenuItem;
            LBL = incomingSubtotal;
            Picture = incomingPicture;
            quantity = incomingQuantity;
            cost = incomingCost;
        }
    }

}