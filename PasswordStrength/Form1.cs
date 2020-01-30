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
            int strength = 0;
            int hasUpper = 0;
            int hasLower = 0;
            int hasSymbol = 0;
            int hasDigit = 0;
            int longEnough = 0;

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
            
            strength = hasUpper + hasLower + hasSymbol + hasDigit + longEnough;

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
