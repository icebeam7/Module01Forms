using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module01Forms
{
    public partial class Form1 : Form
    {
        // The object we are going to use
        BankAccount savings;

        public Form1()
        {
            InitializeComponent();
        }

        // When clicking this button, call the constructor and create a BankAccount object 
        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Get the input values from textboxes
            string number = txtNumber.Text;
            float interestRate = float.Parse(txtInterestRate.Text);

            // Create the BankAccount object
            savings = new BankAccount(number, 0, interestRate);

            // Show the Balance in the specific textbox
            txtBalance.Text = savings.Balance.ToString("C");

            // Disable the textboxes and button
            txtNumber.Enabled = false;
            txtInterestRate.Enabled = false;
            btnCreate.Enabled = false;

            // Display a message to the user
            MessageBox.Show("The account has been created!");
        }

        // When clicking this button, call the Deposit method
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            // Get the input value from textbox
            float amount = float.Parse(txtAmount.Text);

            // Call the Deposit method from BankAccount
            savings.Deposit(amount);

            // Show the new Balance in the specific textbox
            txtBalance.Text = savings.Balance.ToString("C");

            // Display a message to the user
            MessageBox.Show("The account balance has been updated!");
        }

        // When clicking this button, call the Withdraw method
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            // Get the input value from textbox
            float amount = float.Parse(txtAmount.Text);

            // Call the Withdraw method from BankAccount
            savings.Withdraw(amount);

            // Show the new Balance in the specific textbox
            txtBalance.Text = savings.Balance.ToString("C");

            // Display a message to the user
            MessageBox.Show("The account balance has been updated!");
        }

        private void btnAddInterest_Click(object sender, EventArgs e)
        {
            // Call the AddInterest method from BankAccount
            savings.AddInterest();

            // Show the new Balance in the specific textbox
            txtBalance.Text = savings.Balance.ToString("C");

            // Display a message to the user
            MessageBox.Show("The account balance has been updated!");
        }
    }
}
