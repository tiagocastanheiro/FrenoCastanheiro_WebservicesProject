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
    public partial class PayOnlineFacultiesUserControl : UserControl
    {
        private MSSQLServiceReference.MSSQLServiceClient client;
        public PayOnlineFacultiesUserControl()
        {
            InitializeComponent();
            client = new MSSQLServiceReference.MSSQLServiceClient();
        }

        private void creditButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (usernameTextBox.Text == string.Empty)
            {
                usernameTextBox.Focus();
                errorProvider1.SetError(usernameTextBox, "Can't be empty");
                return;
            }
            if (amountTextBox.Text == string.Empty)
            {
                amountTextBox.Focus();
                errorProvider1.SetError(amountTextBox, "Can't be empty");
                return;
            }
            var account = client.DisplayAccountByUsername(usernameTextBox.Text);
            if (account == null)
            {
                usernameTextBox.Focus();
                errorProvider1.SetError(usernameTextBox, "Account not found");
                return;
            }
            if (!client.LoadWithUsername(usernameTextBox.Text, decimal.Parse(amountTextBox.Text)))
            {
                usernameTextBox.Focus();
                errorProvider1.SetError(usernameTextBox, "Credit error, please retry");
                return;
            }
            var newAccount = client.DisplayAccountByUsername(usernameTextBox.Text);
            if (newAccount == null)
            {
                usernameTextBox.Focus();
                errorProvider1.SetError(usernameTextBox, "Account not found");
                return;
            }
            usernameRespTextBox.Text = account.Username;
            amountRespTextBox.Text = account.Amount.ToString();
            amountCreditRespTextBox.Text = amountTextBox.Text;
            newAmountTextBox.Text = newAccount.Amount.ToString();
        }

        private void amountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
