using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppWebServicesTest.UserControls
{
    public partial class PrintUserControl : UserControl
    {
        private MSSQLServiceReference.MSSQLServiceClient client;
        public PrintUserControl()
        {
            InitializeComponent();
            client = new MSSQLServiceReference.MSSQLServiceClient();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            //Managing exceptions
            errorProvider1.Clear();
            if (usernameTextBox.Text == string.Empty)
            {
                usernameTextBox.Focus();
                errorProvider1.SetError(usernameTextBox, "Can't be empty");
                return;
            }
            if ((string)productComboBox.SelectedItem == string.Empty)
            {
                productComboBox.Focus();
                errorProvider1.SetError(productComboBox, "Can't be empty");
                return;
            }
            if(quantityNumericUpDown.Value < 0)
            {
                productComboBox.Focus();
                errorProvider1.SetError(productComboBox, "Can't be empty");
                return;
            }
            //Get Account state before the action
            var account = client.DisplayAccountByUsername(usernameTextBox.Text);
            if (account == null)
            {
                usernameTextBox.Focus();
                errorProvider1.SetError(usernameTextBox, "Account not found");
                return;
            }
            //Do the action
            if (!client.Consume(usernameTextBox.Text, (string)productComboBox.SelectedItem, Decimal.ToInt32(quantityNumericUpDown.Value)))
            {
                usernameTextBox.Focus();
                errorProvider1.SetError(usernameTextBox, "Print error, please retry");
                return;
            }
            //Get Account state after action
            var newAccount = client.DisplayAccountByUsername(usernameTextBox.Text);
            if (newAccount == null)
            {
                usernameTextBox.Focus();
                errorProvider1.SetError(usernameTextBox, "Account not found");
                return;
            }
            usernameRespTextBox.Text = account.Username;
            amountRespTextBox.Text = account.Amount.ToString();
            costRespTextBox.Text = (account.Amount-newAccount.Amount).ToString();
            newAmountTextBox.Text = newAccount.Amount.ToString();
        }
    }
}
