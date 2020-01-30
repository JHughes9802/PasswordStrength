/* Ermias G.
 * Alicia Nguyen
 * Jordan Hughes
 * This program tests the password the user inputs and gives feedback dependent on how 
 * "strong" or "weak" it is.*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordStrength
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEstimate_Click(object sender, EventArgs e)
        {
            lblResult.Show();
            string password = txtPassword.Text;

            //Instantiation of all necessary variables
            int strength = 0;
            int hasUpper = 0;
            int hasLower = 0;
            int hasSymbol = 0;
            int hasDigit = 0;
            int longEnough = 0;

            /*Numerous if statements instead of using else if 
             * so it doesn't immediately break out after meeting one condition*/
            if (password.Any(char.IsUpper))
            {
                hasUpper = 1;
            }
            if (password.Any(char.IsLower))
            {
                hasLower = 1;
            }
            if (password.Any(char.IsDigit))
            {
                hasDigit = 1;
            }
            if (password.Any(char.IsPunctuation))
            {
                hasSymbol = 1;
            }
            if (password.Length >= 8)
            {
                longEnough = 1;
            }
            
            /*Adding all constraints for the password together for use in the following
             if and else if statements*/
            strength = hasUpper + hasLower + hasSymbol + hasDigit + longEnough;

            //If and else if statements to give the user feedback based on their password
            if(strength == 5)
            {
                lblResult.Text = "Strong";
                lblResult.BackColor = Color.LightGreen;
            }
            else if (strength >=3)
            {
                lblResult.Text = "Medium";
                lblResult.BackColor = Color.Yellow;
            }
            else
            {
                lblResult.Text = "Weak";
                lblResult.BackColor = Color.Red;
            }
        }
    }
}
