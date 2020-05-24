namespace WindowsFormsAppWebServicesTest.UserControls
{
    partial class AccountsUserControl
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.amountRespTextBox = new System.Windows.Forms.TextBox();
            this.usernameRespTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.searchTabControl = new System.Windows.Forms.TabControl();
            this.searchByUsername = new System.Windows.Forms.TabPage();
            this.searchUsernameButton = new System.Windows.Forms.Button();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchByUID = new System.Windows.Forms.TabPage();
            this.searchUIDButton = new System.Windows.Forms.Button();
            this.UIDTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.searchTabControl.SuspendLayout();
            this.searchByUsername.SuspendLayout();
            this.searchByUID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // amountRespTextBox
            // 
            this.amountRespTextBox.Enabled = false;
            this.amountRespTextBox.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountRespTextBox.Location = new System.Drawing.Point(246, 293);
            this.amountRespTextBox.Name = "amountRespTextBox";
            this.amountRespTextBox.ReadOnly = true;
            this.amountRespTextBox.Size = new System.Drawing.Size(226, 28);
            this.amountRespTextBox.TabIndex = 9;
            // 
            // usernameRespTextBox
            // 
            this.usernameRespTextBox.Enabled = false;
            this.usernameRespTextBox.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameRespTextBox.Location = new System.Drawing.Point(246, 241);
            this.usernameRespTextBox.Name = "usernameRespTextBox";
            this.usernameRespTextBox.ReadOnly = true;
            this.usernameRespTextBox.Size = new System.Drawing.Size(226, 28);
            this.usernameRespTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Amount :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Username :";
            // 
            // searchTabControl
            // 
            this.searchTabControl.Controls.Add(this.searchByUsername);
            this.searchTabControl.Controls.Add(this.searchByUID);
            this.searchTabControl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTabControl.Location = new System.Drawing.Point(53, 70);
            this.searchTabControl.Name = "searchTabControl";
            this.searchTabControl.SelectedIndex = 0;
            this.searchTabControl.Size = new System.Drawing.Size(668, 118);
            this.searchTabControl.TabIndex = 5;
            // 
            // searchByUsername
            // 
            this.searchByUsername.Controls.Add(this.searchUsernameButton);
            this.searchByUsername.Controls.Add(this.usernameTextBox);
            this.searchByUsername.Controls.Add(this.label1);
            this.searchByUsername.Location = new System.Drawing.Point(4, 28);
            this.searchByUsername.Name = "searchByUsername";
            this.searchByUsername.Padding = new System.Windows.Forms.Padding(3);
            this.searchByUsername.Size = new System.Drawing.Size(660, 86);
            this.searchByUsername.TabIndex = 0;
            this.searchByUsername.Text = "Search by username";
            this.searchByUsername.UseVisualStyleBackColor = true;
            // 
            // searchUsernameButton
            // 
            this.searchUsernameButton.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchUsernameButton.Location = new System.Drawing.Point(472, 25);
            this.searchUsernameButton.Name = "searchUsernameButton";
            this.searchUsernameButton.Size = new System.Drawing.Size(135, 35);
            this.searchUsernameButton.TabIndex = 2;
            this.searchUsernameButton.Text = "Search";
            this.searchUsernameButton.UseVisualStyleBackColor = true;
            this.searchUsernameButton.Click += new System.EventHandler(this.searchUsernameButton_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(166, 29);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(206, 28);
            this.usernameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username :";
            // 
            // searchByUID
            // 
            this.searchByUID.Controls.Add(this.searchUIDButton);
            this.searchByUID.Controls.Add(this.UIDTextBox);
            this.searchByUID.Controls.Add(this.label2);
            this.searchByUID.Location = new System.Drawing.Point(4, 28);
            this.searchByUID.Name = "searchByUID";
            this.searchByUID.Padding = new System.Windows.Forms.Padding(3);
            this.searchByUID.Size = new System.Drawing.Size(660, 86);
            this.searchByUID.TabIndex = 1;
            this.searchByUID.Text = "Search by UID";
            this.searchByUID.UseVisualStyleBackColor = true;
            // 
            // searchUIDButton
            // 
            this.searchUIDButton.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchUIDButton.Location = new System.Drawing.Point(483, 28);
            this.searchUIDButton.Name = "searchUIDButton";
            this.searchUIDButton.Size = new System.Drawing.Size(135, 35);
            this.searchUIDButton.TabIndex = 5;
            this.searchUIDButton.Text = "Search";
            this.searchUIDButton.UseVisualStyleBackColor = true;
            this.searchUIDButton.Click += new System.EventHandler(this.searchUIDButton_Click);
            // 
            // UIDTextBox
            // 
            this.UIDTextBox.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UIDTextBox.Location = new System.Drawing.Point(107, 31);
            this.UIDTextBox.Name = "UIDTextBox";
            this.UIDTextBox.Size = new System.Drawing.Size(206, 28);
            this.UIDTextBox.TabIndex = 4;
            this.UIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UIDTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "UID :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AccountsUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.amountRespTextBox);
            this.Controls.Add(this.usernameRespTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchTabControl);
            this.Name = "AccountsUserControl";
            this.Size = new System.Drawing.Size(817, 613);
            this.searchTabControl.ResumeLayout(false);
            this.searchByUsername.ResumeLayout(false);
            this.searchByUsername.PerformLayout();
            this.searchByUID.ResumeLayout(false);
            this.searchByUID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox amountRespTextBox;
        private System.Windows.Forms.TextBox usernameRespTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl searchTabControl;
        private System.Windows.Forms.TabPage searchByUsername;
        private System.Windows.Forms.Button searchUsernameButton;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage searchByUID;
        private System.Windows.Forms.Button searchUIDButton;
        private System.Windows.Forms.TextBox UIDTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
