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
    public partial class PaymentDBUserControl : UserControl
    {
        private MSSQLServiceReference.MSSQLServiceClient client;
        public PaymentDBUserControl()
        {
            InitializeComponent();
            client = new MSSQLServiceReference.MSSQLServiceClient();
        }

        private void creditButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (UIDTextBox.Text == string.Empty)
            {
                UIDTextBox.Focus();
                errorProvider1.SetError(UIDTextBox, "Can't be empty");
                return;
            }
            if (amountTextBox.Text == string.Empty)
            {
                amountTextBox.Focus();
                errorProvider1.SetError(amountTextBox, "Can't be empty");
                return;
            }
            var account = client.DisplayAccountByUID(int.Parse(UIDTextBox.Text));
            if (account == null)
            {
                UIDTextBox.Focus();
                errorProvider1.SetError(UIDTextBox, "Account not found");
                return;
            }
            if (!client.LoadWithUID(int.Parse(UIDTextBox.Text), decimal.Parse(amountTextBox.Text)))
            {
                UIDTextBox.Focus();
                errorProvider1.SetError(UIDTextBox, "Credit error, please retry");
                return;
            }
            var newAccount = client.DisplayAccountByUID(int.Parse(UIDTextBox.Text));
            if (newAccount == null)
            {
                UIDTextBox.Focus();
                errorProvider1.SetError(UIDTextBox, "Account not found");
                return;
            }
            usernameRespTextBox.Text = account.Username;
            amountRespTextBox.Text = account.Amount.ToString();
            amountCreditRespTextBox.Text = amountTextBox.Text;
            newAmountTextBox.Text = newAccount.Amount.ToString();
        }

        private void UIDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

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
