using System;
using System.Windows.Forms;
using System.Collections.Generic;
using AccountEditor.Database;
using AccountEditor.Database.MySql;

namespace AccountEditor {
    public partial class MainForm : Form {
        NewAccount newAccount;
        EditAccount editAccount;
        EditCharacter editCharacter;
        List<CharacterTempData> characters;

        int characterId;

        public MainForm() {
            InitializeComponent();
        }

        private void ButtonNew_Click(object sender, EventArgs e) {
            if (newAccount == null || newAccount.IsDisposed) {
                newAccount = new NewAccount();
            }

            newAccount.Show();
        }

        private void ButtonEdit_Click(object sender, EventArgs e) {
            if (editAccount == null || editAccount.IsDisposed) {
                editAccount = new EditAccount();
            }

            editAccount.Show();
        }

        private void Form1_Load(object sender, EventArgs e) {
            Configuration.CheckFile();

            DBConnection.DataSource = Configuration.ReadValue("MySQL", "Server");
            DBConnection.Database = Configuration.ReadValue("MySQL", "Database");
            DBConnection.UserId = Configuration.ReadValue("MySQL", "Uid");
            DBConnection.Password = Configuration.ReadValue("MySQL", "Pwd");
            DBConnection.MinPoolSize = int.Parse(Configuration.ReadValue("MySQL", "MinimumPoolSize"));
            DBConnection.MaxPoolSize = int.Parse(Configuration.ReadValue("MySQL", "MaximumPoolSize"));
        }

        private void RadioAccount_CheckedChanged(object sender, EventArgs e) {
            if (RadioAccount.Checked) {
                SearchAccountBox.Enabled = true;
                SearchCharacterBox.Enabled = false;

                ClearControls();
                EnableEditControls(false);
            }
        }

        private void CharacterRadio_CheckedChanged(object sender, EventArgs e) {
            if (RadioCharacter.Checked) {
                SearchAccountBox.Enabled = false;
                SearchCharacterBox.Enabled = true;

                ClearControls();
                EnableEditControls(false);
            }
        }

        private void TextAccount_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                var account = TextAccount.Text.Trim().ToLower();

                var db = new AccountDB();
                var dbError = db.Open();

                if (dbError.Number != 0) {
                    var errorText = $"Cannot connect to database {Environment.NewLine}";
                    errorText += $"Error Number: {dbError.Number}{Environment.NewLine}";
                    errorText += $"Error Message: {dbError.Message}";

                    MessageBox.Show(errorText);
                }
                else {
                    if (db.Connected) {
                        var accountId = db.GetAccountId(account);
                        
                        if (accountId == 0) {
                            MessageBox.Show("Account not found.");
                            SearchAccountBox.Text = "Search for account: 0 result(s).";
                        }
                        else {
                            SearchAccountBox.Text = "Search for account: 1 result(s).";                   
                        }

                        characters = db.GetCharacterList(accountId);
                        FillCharacterList();
                    }
                }

                db.Close();
            }
        }

        private void FillCharacterList() {
            ComboCharacter.Items.Clear();

            if (characters != null) {
                if (characters.Count > 0) {
                    for (var i = 0; i < characters.Count; i++) {
                        ComboCharacter.Items.Add($"Id: {characters[i].Id} Name: {characters[i].Character}");
                    }

                    ComboCharacter.SelectedIndex = 0;
                }
            }
        }

        private void ClearControls() {
            characterId = 0;

            TextAccount.Text = string.Empty;
            TextCharacter.Text = string.Empty;
            ComboCharacter.Items.Clear();
            SearchAccountBox.Text = "Search for account: 0 result(s).";
            SearchCharacterBox.Text = "Search for character: Id 0.";
            LabelCharacter.Text = "Character:";
            GroupCharacter.Text = "Character: Selected Character Id: 0";

            if (characters != null) {
                characters.Clear();
            }
        }

        private void EnableEditControls(bool enabled) {
            ButtonCharacter.Enabled = enabled;
        }

        private void TextCharacter_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                var name = TextCharacter.Text.Trim();

                var db = new AccountDB();
                var dbError = db.Open();

                if (dbError.Number != 0) {
                    var errorText = $"Cannot connect to database {Environment.NewLine}";
                    errorText += $"Error Number: {dbError.Number}{Environment.NewLine}";
                    errorText += $"Error Message: {dbError.Message}";

                    MessageBox.Show(errorText);
                }
                else {
                    if (db.Connected) {
                        var character = db.GetCharacterTempData(name);

                        if (character.Id == 0) {
                            EnableEditControls(false);
                            MessageBox.Show("Character not found.");
                        }
                        else {
                            EnableEditControls(true);
                        }

                        characterId = character.Id;

                        LabelCharacter.Text = $"Character: {character.Character}";
                        SearchCharacterBox.Text = $"Search for character: Id {character.Id}.";
                        GroupCharacter.Text = $"Character: Selected Character Id: {character.Id}";               
                    }
                }

                db.Close();
            }
        }

        private void ButtonCharacter_Click(object sender, EventArgs e) {
            if (editCharacter == null || editCharacter.IsDisposed) {
                editCharacter = new EditCharacter();
            }

            if (characterId <= 0) {
                MessageBox.Show($"Invalid character Id: {characterId}.");
                return;
            }

            editCharacter.Show(characterId);
        }

        private void ComboCharacter_SelectedIndexChanged(object sender, EventArgs e) {
            if (characters != null) {
                if (characters.Count > 0) {
                    characterId = characters[ComboCharacter.SelectedIndex].Id;

                    GroupCharacter.Text = $"Character: Selected Character Id: {characterId}";
                    EnableEditControls(true);
                }
                else {
                    characterId = 0;
                    EnableEditControls(false);
                }
            }
            else {
                characterId = 0;
                EnableEditControls(false);
            }
        }
    }
}