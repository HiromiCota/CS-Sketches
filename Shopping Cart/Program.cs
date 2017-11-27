/*'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
'Comments by the prof:
'
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
'Lab #8--Shopping Cart
'Created by Niko Culevski
'Class: CS 218
'Date: 11/17/2010
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
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_Cart
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Cart());
        }
    }
}
