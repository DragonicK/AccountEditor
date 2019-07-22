namespace AccountEditor {
    partial class EditAccount {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAccount));
            this.AccountBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextNewService = new System.Windows.Forms.TextBox();
            this.TextNewEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextNewPassword = new System.Windows.Forms.TextBox();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ComboAccount = new System.Windows.Forms.ComboBox();
            this.AccountLabel = new System.Windows.Forms.Label();
            this.TextAccount = new System.Windows.Forms.TextBox();
            this.AccountBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AccountBox
            // 
            this.AccountBox.Controls.Add(this.label5);
            this.AccountBox.Controls.Add(this.label4);
            this.AccountBox.Controls.Add(this.TextNewService);
            this.AccountBox.Controls.Add(this.TextNewEmail);
            this.AccountBox.Controls.Add(this.label2);
            this.AccountBox.Controls.Add(this.TextNewPassword);
            this.AccountBox.Controls.Add(this.ButtonUpdate);
            this.AccountBox.Enabled = false;
            this.AccountBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountBox.Location = new System.Drawing.Point(12, 114);
            this.AccountBox.Name = "AccountBox";
            this.AccountBox.Size = new System.Drawing.Size(329, 177);
            this.AccountBox.TabIndex = 0;
            this.AccountBox.TabStop = false;
            this.AccountBox.Text = "Edit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Service Id:";
            // 
            // TextNewService
            // 
            this.TextNewService.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextNewService.Location = new System.Drawing.Point(6, 116);
            this.TextNewService.Name = "TextNewService";
            this.TextNewService.Size = new System.Drawing.Size(317, 21);
            this.TextNewService.TabIndex = 4;
            this.TextNewService.Text = "0";
            // 
            // TextNewEmail
            // 
            this.TextNewEmail.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextNewEmail.Location = new System.Drawing.Point(6, 72);
            this.TextNewEmail.Name = "TextNewEmail";
            this.TextNewEmail.Size = new System.Drawing.Size(317, 21);
            this.TextNewEmail.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // TextNewPassword
            // 
            this.TextNewPassword.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextNewPassword.Location = new System.Drawing.Point(6, 30);
            this.TextNewPassword.Name = "TextNewPassword";
            this.TextNewPassword.Size = new System.Drawing.Size(317, 21);
            this.TextNewPassword.TabIndex = 2;
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonUpdate.Location = new System.Drawing.Point(88, 143);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(153, 23);
            this.ButtonUpdate.TabIndex = 5;
            this.ButtonUpdate.Text = "Update";
            this.ButtonUpdate.UseVisualStyleBackColor = true;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ComboAccount);
            this.groupBox2.Controls.Add(this.AccountLabel);
            this.groupBox2.Controls.Add(this.TextAccount);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 96);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // ComboAccount
            // 
            this.ComboAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboAccount.FormattingEnabled = true;
            this.ComboAccount.Location = new System.Drawing.Point(6, 60);
            this.ComboAccount.MaxDropDownItems = 10;
            this.ComboAccount.Name = "ComboAccount";
            this.ComboAccount.Size = new System.Drawing.Size(317, 21);
            this.ComboAccount.TabIndex = 1;
            this.ComboAccount.SelectedIndexChanged += new System.EventHandler(this.ComboAccount_SelectedIndexChanged);
            // 
            // AccountLabel
            // 
            this.AccountLabel.AutoSize = true;
            this.AccountLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountLabel.Location = new System.Drawing.Point(6, 16);
            this.AccountLabel.Name = "AccountLabel";
            this.AccountLabel.Size = new System.Drawing.Size(124, 13);
            this.AccountLabel.TabIndex = 4;
            this.AccountLabel.Text = "Account: 0 result(s).";
            // 
            // TextAccount
            // 
            this.TextAccount.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextAccount.Location = new System.Drawing.Point(6, 33);
            this.TextAccount.Name = "TextAccount";
            this.TextAccount.Size = new System.Drawing.Size(317, 21);
            this.TextAccount.TabIndex = 0;
            this.TextAccount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextAccount_KeyDown);
            // 
            // EditAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 304);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.AccountBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Account";
            this.AccountBox.ResumeLayout(false);
            this.AccountBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AccountBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextNewService;
        private System.Windows.Forms.TextBox TextNewEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextNewPassword;
        private System.Windows.Forms.Button ButtonUpdate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label AccountLabel;
        private System.Windows.Forms.TextBox TextAccount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComboAccount;
    }
}