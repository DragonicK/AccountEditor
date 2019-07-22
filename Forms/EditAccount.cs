using System;
using System.Windows.Forms;
using System.Collections.Generic;
using AccountEditor.Database;

namespace AccountEditor {
    public partial class EditAccount : Form {
        List<AccountData> accounts;
        int selectedAccountIndex;

        public EditAccount() {
            InitializeComponent();
        }

        private bool ValidateData(string email, ref string service) {
            if (email.Length <= 0 || email == "") {
                MessageBox.Show("Email cannot be empty.");
                return false;
            }

            // Quando vazio, define como zero.
            if (service.Length <= 0 || service == "") {
                service = "0";
            }

            // Verifica se há números como serviço.
            for (var i = 0; i < service.Length; i++) {
                if (!char.IsNumber(service[i])) {
                    MessageBox.Show("You must use numbers in service Id field.");
                    return false;
                }
            }

            return true;
        }

        private void ClearText() {
            TextNewPassword.Text = string.Empty;
            TextNewEmail.Text = string.Empty;
            TextNewService.Text = string.Empty;

            accounts.Clear();
            ComboAccount.Items.Clear();

            AccountLabel.Text = "Account: 0 result(s).";
        }

        /// <summary>
        /// Preenche o combobox com os dados das contas.
        /// </summary>
        private void FillComboAccount() {
            if (accounts != null) {
                for (var i = 0; i < accounts.Count; i++) {
                    ComboAccount.Items.Add($"Id: {accounts[i].Id} Username: {accounts[i].Username}");
                }

                if (accounts.Count > 0) {
                    ComboAccount.SelectedIndex = 0;
                    SelectAccountData(0);
                }
            }
        }

        private void SelectAccountData(int accountIndex) {
            TextNewPassword.Text = string.Empty;
            TextNewEmail.Text = accounts[accountIndex].Email;
            TextNewService.Text = accounts[accountIndex].ServiceId.ToString();

            selectedAccountIndex = accountIndex;
            AccountBox.Enabled = true;
        }

        private void ComboAccount_SelectedIndexChanged(object sender, EventArgs e) {
            if (ComboAccount.SelectedIndex >= 0) {
                SelectAccountData(ComboAccount.SelectedIndex);
            }
        }

        private void TextAccount_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                // Apaga a lista antiga
                if (accounts != null) {
                    accounts.Clear();
                }

                ComboAccount.Items.Clear();

                if (TextAccount.Text.Length > 0) {
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
                            accounts = db.GetAccounts(TextAccount.Text.Trim().ToLower());
                            FillComboAccount();

                            AccountLabel.Text = $"Account: {accounts.Count} result(s).";
                        }
                        else {
                            MessageBox.Show("Database is not connected.");
                        }
                    }

                    db.Close();
                }
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e) {
            var username = accounts[selectedAccountIndex].Username;

            var password = TextNewPassword.Text.Trim();
            var email = TextNewEmail.Text.Trim();
            var service = TextNewService.Text.Trim();

            if (ValidateData(email, ref service)) {
                var db = new AccountDB();
                var dbError = db.Open();

                if (dbError.Number != 0) {
                    var errorText = $"Cannot connect to database {Environment.NewLine}";
                    errorText += $"Error Number: {dbError.Number}{Environment.NewLine}";
                    errorText += $"Error Message: {dbError.Message}";

                    MessageBox.Show(errorText);
                }
                else {
                    // Se a senha foi modificada, gera uma nova senha.
                    if (password.Length > 0) {
                        password = Hash.GetPassword(username, password);
                    }
                    else {
                        password = accounts[selectedAccountIndex].Password;
                    }

                    if (db.Connected) {
                        db.Update(accounts[selectedAccountIndex].Id, password, Hash.GetHash(username), email, int.Parse(service));
                        ClearText();

                        MessageBox.Show("Updated.");
                    }
                    else {
                        MessageBox.Show("Database is not connected.");
                    }
                }

                db.Close();
            }
        }
    }
}