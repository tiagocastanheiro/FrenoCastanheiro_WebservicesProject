using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppWebServicesTest.UserControls;
using WindowsFormsAppWebServicesTest.MSSQLServiceReference;

namespace WindowsFormsAppWebServicesTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = homeButton.Height;
            SidePanel.Top = homeButton.Top;
            homeUserControl1.BringToFront();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = homeButton.Height;
            SidePanel.Top = homeButton.Top;
            homeUserControl1.BringToFront();
        }

        private void accountsButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = accountsButton.Height;
            SidePanel.Top = accountsButton.Top;
            accountsUserControl1.BringToFront();
        }

        private void paymentDBButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = paymentDBButton.Height;
            SidePanel.Top = paymentDBButton.Top;
            paymentDBUserControl1.BringToFront();
        }

        private void payOnlineFacultiesButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = payOnlineFacultiesButton.Height;
            SidePanel.Top = payOnlineFacultiesButton.Top;
            payOnlineFacultiesUserControl1.BringToFront();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = printButton.Height;
            SidePanel.Top = printButton.Top;
            printUserControl1.BringToFront();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
