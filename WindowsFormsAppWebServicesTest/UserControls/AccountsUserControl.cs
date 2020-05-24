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
    
    public partial class AccountsUserControl : UserControl
    {
        private MSSQLServiceReference.MSSQLServiceClient client;
        public AccountsUserControl()
        {
            InitializeComponent();
            client = new MSSQLServiceReference.MSSQLServiceClient();
        }

        private void searchUsernameButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (usernameTextBox.Text == string.Empty)
            {
                usernameTextBox.Focus();
                errorProvider1.SetError(usernameTextBox, "Can't be empty");
                return;
            }
            var account = client.DisplayAccountByUsername(usernameTextBox.Text);
            if (account == null)
            {
                usernameTextBox.Focus();
                errorProvider1.SetError(usernameTextBox, "Account not found");
                return;
            }
            usernameRespTextBox.Text = account.Username;
            amountRespTextBox.Text = account.Amount.ToString();
        }

        private void searchUIDButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (UIDTextBox.Text == string.Empty)
            {
                UIDTextBox.Focus();
                errorProvider1.SetError(UIDTextBox, "Can't be empty");
                return;
            }
            var account = client.DisplayAccountByUID(int.Parse(UIDTextBox.Text));
            if (account == null)
            {
                UIDTextBox.Focus();
                errorProvider1.SetError(UIDTextBox, "Account not found");
                return;
            }
            usernameRespTextBox.Text = account.Username;
            amountRespTextBox.Text = account.Amount.ToString();
        }

        private void UIDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
