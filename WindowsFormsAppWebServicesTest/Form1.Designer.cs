namespace WindowsFormsAppWebServicesTest
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.printButton = new System.Windows.Forms.Button();
            this.payOnlineFacultiesButton = new System.Windows.Forms.Button();
            this.paymentDBButton = new System.Windows.Forms.Button();
            this.accountsButton = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.homeButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.homeUserControl1 = new WindowsFormsAppWebServicesTest.UserControls.HomeUserControl();
            this.accountsUserControl1 = new WindowsFormsAppWebServicesTest.UserControls.AccountsUserControl();
            this.paymentDBUserControl1 = new WindowsFormsAppWebServicesTest.UserControls.PaymentDBUserControl();
            this.payOnlineFacultiesUserControl1 = new WindowsFormsAppWebServicesTest.UserControls.PayOnlineFacultiesUserControl();
            this.printUserControl1 = new WindowsFormsAppWebServicesTest.UserControls.PrintUserControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.printButton);
            this.panel1.Controls.Add(this.payOnlineFacultiesButton);
            this.panel1.Controls.Add(this.paymentDBButton);
            this.panel1.Controls.Add(this.accountsButton);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.homeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 690);
            this.panel1.TabIndex = 0;
            // 
            // printButton
            // 
            this.printButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.printButton.FlatAppearance.BorderSize = 0;
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.ForeColor = System.Drawing.Color.White;
            this.printButton.Image = ((System.Drawing.Image)(resources.GetObject("printButton.Image")));
            this.printButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.printButton.Location = new System.Drawing.Point(12, 544);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(303, 69);
            this.printButton.TabIndex = 10;
            this.printButton.Text = "      Print";
            this.printButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // payOnlineFacultiesButton
            // 
            this.payOnlineFacultiesButton.FlatAppearance.BorderSize = 0;
            this.payOnlineFacultiesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payOnlineFacultiesButton.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payOnlineFacultiesButton.ForeColor = System.Drawing.Color.White;
            this.payOnlineFacultiesButton.Image = ((System.Drawing.Image)(resources.GetObject("payOnlineFacultiesButton.Image")));
            this.payOnlineFacultiesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.payOnlineFacultiesButton.Location = new System.Drawing.Point(12, 439);
            this.payOnlineFacultiesButton.Name = "payOnlineFacultiesButton";
            this.payOnlineFacultiesButton.Size = new System.Drawing.Size(303, 69);
            this.payOnlineFacultiesButton.TabIndex = 9;
            this.payOnlineFacultiesButton.Text = "      PayOnline/Faculties";
            this.payOnlineFacultiesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.payOnlineFacultiesButton.UseVisualStyleBackColor = true;
            this.payOnlineFacultiesButton.Click += new System.EventHandler(this.payOnlineFacultiesButton_Click);
            // 
            // paymentDBButton
            // 
            this.paymentDBButton.FlatAppearance.BorderSize = 0;
            this.paymentDBButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paymentDBButton.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentDBButton.ForeColor = System.Drawing.Color.White;
            this.paymentDBButton.Image = ((System.Drawing.Image)(resources.GetObject("paymentDBButton.Image")));
            this.paymentDBButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.paymentDBButton.Location = new System.Drawing.Point(12, 334);
            this.paymentDBButton.Name = "paymentDBButton";
            this.paymentDBButton.Size = new System.Drawing.Size(303, 69);
            this.paymentDBButton.TabIndex = 8;
            this.paymentDBButton.Text = "      Payment DB";
            this.paymentDBButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.paymentDBButton.UseVisualStyleBackColor = true;
            this.paymentDBButton.Click += new System.EventHandler(this.paymentDBButton_Click);
            // 
            // accountsButton
            // 
            this.accountsButton.FlatAppearance.BorderSize = 0;
            this.accountsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountsButton.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountsButton.ForeColor = System.Drawing.Color.White;
            this.accountsButton.Image = ((System.Drawing.Image)(resources.GetObject("accountsButton.Image")));
            this.accountsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accountsButton.Location = new System.Drawing.Point(12, 229);
            this.accountsButton.Name = "accountsButton";
            this.accountsButton.Size = new System.Drawing.Size(303, 69);
            this.accountsButton.TabIndex = 7;
            this.accountsButton.Text = "      Accounts";
            this.accountsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.accountsButton.UseVisualStyleBackColor = true;
            this.accountsButton.Click += new System.EventHandler(this.accountsButton_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.SidePanel.Location = new System.Drawing.Point(3, 124);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 67);
            this.SidePanel.TabIndex = 4;
            // 
            // homeButton
            // 
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.Color.White;
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.Location = new System.Drawing.Point(12, 124);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(303, 69);
            this.homeButton.TabIndex = 3;
            this.homeButton.Text = "      Home";
            this.homeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.CloseButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(320, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(823, 44);
            this.panel2.TabIndex = 1;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(758, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(65, 44);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // homeUserControl1
            // 
            this.homeUserControl1.BackColor = System.Drawing.Color.White;
            this.homeUserControl1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeUserControl1.Location = new System.Drawing.Point(326, 77);
            this.homeUserControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.homeUserControl1.Name = "homeUserControl1";
            this.homeUserControl1.Size = new System.Drawing.Size(817, 613);
            this.homeUserControl1.TabIndex = 2;
            // 
            // accountsUserControl1
            // 
            this.accountsUserControl1.BackColor = System.Drawing.Color.White;
            this.accountsUserControl1.Location = new System.Drawing.Point(326, 77);
            this.accountsUserControl1.Name = "accountsUserControl1";
            this.accountsUserControl1.Size = new System.Drawing.Size(817, 613);
            this.accountsUserControl1.TabIndex = 3;
            // 
            // paymentDBUserControl1
            // 
            this.paymentDBUserControl1.BackColor = System.Drawing.Color.White;
            this.paymentDBUserControl1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentDBUserControl1.Location = new System.Drawing.Point(326, 77);
            this.paymentDBUserControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.paymentDBUserControl1.Name = "paymentDBUserControl1";
            this.paymentDBUserControl1.Size = new System.Drawing.Size(817, 613);
            this.paymentDBUserControl1.TabIndex = 4;
            // 
            // payOnlineFacultiesUserControl1
            // 
            this.payOnlineFacultiesUserControl1.BackColor = System.Drawing.Color.White;
            this.payOnlineFacultiesUserControl1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payOnlineFacultiesUserControl1.Location = new System.Drawing.Point(326, 77);
            this.payOnlineFacultiesUserControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.payOnlineFacultiesUserControl1.Name = "payOnlineFacultiesUserControl1";
            this.payOnlineFacultiesUserControl1.Size = new System.Drawing.Size(817, 613);
            this.payOnlineFacultiesUserControl1.TabIndex = 5;
            // 
            // printUserControl1
            // 
            this.printUserControl1.BackColor = System.Drawing.Color.White;
            this.printUserControl1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printUserControl1.Location = new System.Drawing.Point(327, 77);
            this.printUserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.printUserControl1.Name = "printUserControl1";
            this.printUserControl1.Size = new System.Drawing.Size(817, 613);
            this.printUserControl1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1143, 690);
            this.ControlBox = false;
            this.Controls.Add(this.printUserControl1);
            this.Controls.Add(this.payOnlineFacultiesUserControl1);
            this.Controls.Add(this.paymentDBUserControl1);
            this.Controls.Add(this.accountsUserControl1);
            this.Controls.Add(this.homeUserControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WebService Test";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button accountsButton;
        private System.Windows.Forms.Button paymentDBButton;
        private System.Windows.Forms.Button payOnlineFacultiesButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button CloseButton;
        private UserControls.HomeUserControl homeUserControl1;
        private UserControls.PrintUserControl printUserControl1;
        private UserControls.PayOnlineFacultiesUserControl payOnlineFacultiesUserControl1;
        private UserControls.PaymentDBUserControl paymentDBUserControl1;
        private UserControls.AccountsUserControl accountsUserControl1;
    }
}

