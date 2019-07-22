using System;
using System.Windows.Forms;
using AccountEditor.Database;

namespace AccountEditor {
    public partial class NewAccount : Form {
        public NewAccount() {
            InitializeComponent();
        }

        private void ButtonCreate_Click(object sender, EventArgs e) {
            var account = TextAccount.Text.Trim().ToLower();
            var password = TextPassword.Text.Trim();
            var email = TextEmail.Text.Trim();
            var service = TextService.Text.Trim();

            if (ValidateData(account, password, email, ref service)) {
                var db = new AccountDB();
                var dbError = db.Open();

                if (dbError.Number != 0) {
                    var errorText = $"Cannot connect to database {Environment.NewLine}";
                    errorText += $"Error Number: {dbError.Number}{Environment.NewLine}";
                    errorText += $"Error Message: {dbError.Message}";

                    MessageBox.Show(errorText);
                }
                else {
                    if (!db.Exist(account)) {
                        db.Create(account, Hash.GetPassword(account, password), Hash.GetHash(account), email, int.Parse(service));

                        ClearText();
                        MessageBox.Show("Account has been created.");
                    }
                    else {
                        MessageBox.Show("Account is already in use.");
                    }
                }

                db.Close();
            }
        }

        private bool ValidateData(string username, string password, string email, ref string service) {
            if (username.Length <= 0 || username == "") {
                MessageBox.Show("Account cannot be empty.");
                return false;
            }

            if (password.Length <= 0 || password == "") {
                MessageBox.Show("Password cannot be empty.");
                return false;
            }

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
            TextAccount.Text = string.Empty;
            TextPassword.Text = string.Empty;
            TextEmail.Text = string.Empty;
            TextService.Text = string.Empty;
        }
    }
}