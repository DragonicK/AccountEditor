namespace AccountEditor {
    partial class MainForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ButtonNew = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupCharacter = new System.Windows.Forms.GroupBox();
            this.SearchAccountBox = new System.Windows.Forms.GroupBox();
            this.ComboCharacter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextAccount = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.RadioCharacter = new System.Windows.Forms.RadioButton();
            this.RadioAccount = new System.Windows.Forms.RadioButton();
            this.SearchCharacterBox = new System.Windows.Forms.GroupBox();
            this.LabelCharacter = new System.Windows.Forms.Label();
            this.TextCharacter = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.ButtonCharacter = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.GroupCharacter.SuspendLayout();
            this.SearchAccountBox.SuspendLayout();
            this.SearchCharacterBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonNew
            // 
            this.ButtonNew.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNew.Location = new System.Drawing.Point(38, 20);
            this.ButtonNew.Name = "ButtonNew";
            this.ButtonNew.Size = new System.Drawing.Size(96, 28);
            this.ButtonNew.TabIndex = 0;
            this.ButtonNew.Text = "New Account";
            this.ButtonNew.UseVisualStyleBackColor = true;
            this.ButtonNew.Click += new System.EventHandler(this.ButtonNew_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEdit.Location = new System.Drawing.Point(140, 20);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(96, 28);
            this.ButtonEdit.TabIndex = 1;
            this.ButtonEdit.Text = "Edit Account";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ButtonNew);
            this.groupBox1.Controls.Add(this.ButtonEdit);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 60);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account";
            // 
            // GroupCharacter
            // 
            this.GroupCharacter.Controls.Add(this.SearchAccountBox);
            this.GroupCharacter.Controls.Add(this.button4);
            this.GroupCharacter.Controls.Add(this.button5);
            this.GroupCharacter.Controls.Add(this.button6);
            this.GroupCharacter.Controls.Add(this.button1);
            this.GroupCharacter.Controls.Add(this.RadioCharacter);
            this.GroupCharacter.Controls.Add(this.RadioAccount);
            this.GroupCharacter.Controls.Add(this.SearchCharacterBox);
            this.GroupCharacter.Controls.Add(this.button3);
            this.GroupCharacter.Controls.Add(this.ButtonCharacter);
            this.GroupCharacter.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupCharacter.Location = new System.Drawing.Point(12, 78);
            this.GroupCharacter.Name = "GroupCharacter";
            this.GroupCharacter.Size = new System.Drawing.Size(279, 344);
            this.GroupCharacter.TabIndex = 3;
            this.GroupCharacter.TabStop = false;
            this.GroupCharacter.Text = "Character: Selected Character Id: 0";
            // 
            // SearchAccountBox
            // 
            this.SearchAccountBox.Controls.Add(this.ComboCharacter);
            this.SearchAccountBox.Controls.Add(this.label1);
            this.SearchAccountBox.Controls.Add(this.TextAccount);
            this.SearchAccountBox.Location = new System.Drawing.Point(17, 70);
            this.SearchAccountBox.Name = "SearchAccountBox";
            this.SearchAccountBox.Size = new System.Drawing.Size(247, 92);
            this.SearchAccountBox.TabIndex = 4;
            this.SearchAccountBox.TabStop = false;
            this.SearchAccountBox.Text = "Search for account: 0 result(s).";
            // 
            // ComboCharacter
            // 
            this.ComboCharacter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboCharacter.FormattingEnabled = true;
            this.ComboCharacter.Location = new System.Drawing.Point(10, 61);
            this.ComboCharacter.MaxDropDownItems = 10;
            this.ComboCharacter.Name = "ComboCharacter";
            this.ComboCharacter.Size = new System.Drawing.Size(229, 21);
            this.ComboCharacter.TabIndex = 7;
            this.ComboCharacter.SelectedIndexChanged += new System.EventHandler(this.ComboCharacter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Account:";
            // 
            // TextAccount
            // 
            this.TextAccount.Location = new System.Drawing.Point(10, 34);
            this.TextAccount.Name = "TextAccount";
            this.TextAccount.Size = new System.Drawing.Size(229, 21);
            this.TextAccount.TabIndex = 2;
            this.TextAccount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextAccount_KeyDown);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(147, 301);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 25);
            this.button4.TabIndex = 11;
            this.button4.Text = "Edit Spells";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(147, 270);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 25);
            this.button5.TabIndex = 10;
            this.button5.Text = "Edit Equipment";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(147, 239);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(117, 25);
            this.button6.TabIndex = 9;
            this.button6.Text = "Edit Warehouse";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(17, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 25);
            this.button1.TabIndex = 8;
            this.button1.Text = "Edit Spells";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // RadioCharacter
            // 
            this.RadioCharacter.AutoSize = true;
            this.RadioCharacter.Location = new System.Drawing.Point(27, 38);
            this.RadioCharacter.Name = "RadioCharacter";
            this.RadioCharacter.Size = new System.Drawing.Size(143, 17);
            this.RadioCharacter.TabIndex = 7;
            this.RadioCharacter.Text = "Search for character";
            this.RadioCharacter.UseVisualStyleBackColor = true;
            this.RadioCharacter.CheckedChanged += new System.EventHandler(this.CharacterRadio_CheckedChanged);
            // 
            // RadioAccount
            // 
            this.RadioAccount.AutoSize = true;
            this.RadioAccount.Checked = true;
            this.RadioAccount.Location = new System.Drawing.Point(27, 20);
            this.RadioAccount.Name = "RadioAccount";
            this.RadioAccount.Size = new System.Drawing.Size(133, 17);
            this.RadioAccount.TabIndex = 6;
            this.RadioAccount.TabStop = true;
            this.RadioAccount.Text = "Search for account";
            this.RadioAccount.UseVisualStyleBackColor = true;
            this.RadioAccount.CheckedChanged += new System.EventHandler(this.RadioAccount_CheckedChanged);
            // 
            // SearchCharacterBox
            // 
            this.SearchCharacterBox.Controls.Add(this.LabelCharacter);
            this.SearchCharacterBox.Controls.Add(this.TextCharacter);
            this.SearchCharacterBox.Enabled = false;
            this.SearchCharacterBox.Location = new System.Drawing.Point(17, 168);
            this.SearchCharacterBox.Name = "SearchCharacterBox";
            this.SearchCharacterBox.Size = new System.Drawing.Size(247, 65);
            this.SearchCharacterBox.TabIndex = 5;
            this.SearchCharacterBox.TabStop = false;
            this.SearchCharacterBox.Text = "Search for character: Id 0.";
            // 
            // LabelCharacter
            // 
            this.LabelCharacter.AutoSize = true;
            this.LabelCharacter.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCharacter.Location = new System.Drawing.Point(7, 18);
            this.LabelCharacter.Name = "LabelCharacter";
            this.LabelCharacter.Size = new System.Drawing.Size(69, 13);
            this.LabelCharacter.TabIndex = 3;
            this.LabelCharacter.Text = "Character:";
            // 
            // TextCharacter
            // 
            this.TextCharacter.Location = new System.Drawing.Point(10, 34);
            this.TextCharacter.Name = "TextCharacter";
            this.TextCharacter.Size = new System.Drawing.Size(229, 21);
            this.TextCharacter.TabIndex = 2;
            this.TextCharacter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextCharacter_KeyDown);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(17, 270);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 25);
            this.button3.TabIndex = 3;
            this.button3.Text = "Edit Inventory";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ButtonCharacter
            // 
            this.ButtonCharacter.Enabled = false;
            this.ButtonCharacter.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCharacter.Location = new System.Drawing.Point(17, 239);
            this.ButtonCharacter.Name = "ButtonCharacter";
            this.ButtonCharacter.Size = new System.Drawing.Size(117, 25);
            this.ButtonCharacter.TabIndex = 2;
            this.ButtonCharacter.Text = "Edit Character";
            this.ButtonCharacter.UseVisualStyleBackColor = true;
            this.ButtonCharacter.Click += new System.EventHandler(this.ButtonCharacter_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 434);
            this.Controls.Add(this.GroupCharacter);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.GroupCharacter.ResumeLayout(false);
            this.GroupCharacter.PerformLayout();
            this.SearchAccountBox.ResumeLayout(false);
            this.SearchAccountBox.PerformLayout();
            this.SearchCharacterBox.ResumeLayout(false);
            this.SearchCharacterBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonNew;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox GroupCharacter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button ButtonCharacter;
        private System.Windows.Forms.GroupBox SearchAccountBox;
        private System.Windows.Forms.TextBox TextAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboCharacter;
        private System.Windows.Forms.GroupBox SearchCharacterBox;
        private System.Windows.Forms.Label LabelCharacter;
        private System.Windows.Forms.TextBox TextCharacter;
        private System.Windows.Forms.RadioButton RadioCharacter;
        private System.Windows.Forms.RadioButton RadioAccount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

