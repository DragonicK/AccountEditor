using System;
using System.Windows.Forms;
using AccountEditor.Database;

namespace AccountEditor {
    public partial class EditCharacter : Form {
        private int CharacterId { get; set; }
        string name = string.Empty;

        public EditCharacter() {
            InitializeComponent();
        }

        public void Show(int characterId) {
            CharacterId = characterId;

            Show();
            LoadData();
        }

        private void LoadData() {
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
                    var character = db.GetCharacter(CharacterId);

                    FillControlData(ref character);

                    name = character.Name;
                }
                else {
                    MessageBox.Show("Database is not connected.");
                }
            }
        }

        private void FillControlData(ref Character character) {
            TextName.Text = character.Name;
            TextClass.Text = character.Class.ToString();
            TextSex.Text = character.Sex.ToString();
            TextSprite.Text = character.Sprite.ToString();
            TextAccess.Text = character.Access.ToString();
            TextPK.Text = character.PK.ToString();
            TextLevel.Text = character.Level.ToString();
            TextExperience.Text = character.Experience.ToString();
            TextPoints.Text = character.Points.ToString();
            TextMap.Text = character.Map.ToString();
            TextY.Text = character.Y.ToString();
            TextX.Text = character.X.ToString();

            TextStr.Text = character.Strength.ToString();
            TextEnd.Text = character.Endurance.ToString();
            TextInt.Text = character.Intelligence.ToString();
            TextAgi.Text = character.Agility.ToString();
            TextVit.Text = character.Vitality.ToString();
            TextDex.Text = character.Dexterity.ToString();
        }

        private bool IsNumber(string text) {
            for (var i = 0; i < text.Length; i++) {
                if (!char.IsNumber(text[i])) {
                    return false;
                }
            }

            return true;
        }

        private bool ValidateData() {
            foreach(var control in CharacterBox.Controls) {
                if (control is TextBox) {
                    if (((TextBox)control).Name != "TextName") {
                        if (!IsNumber(((TextBox)control).Text)) {
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        private void ButtonUpdate_Click(object sender, EventArgs e) {
            if (!ValidateData()) {
                MessageBox.Show("You must use numbers in fields except for name.");
                return;
            }

            int result = 0;
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
                    var character = FillCharacterData();

                    // Se hovuer alguma alteração no nome, procura na db.
                    if (name != character.Name) {
                        if (db.ExistCharacter(character.Name)) {
                            MessageBox.Show("Name is already in use.");
                            db.Close();

                            return;
                        }
                    }

                    result = db.UpdateCharacter(CharacterId, ref character);
                    MessageBox.Show("Character updated.");           
                }
                else {
                    MessageBox.Show("Database is not connected.");
                }
            }

            db.Close();

            if (result > 0) {
                Close();
            }
        }

        private Character FillCharacterData() {
            var character = new Character() {
                Name = TextName.Text,
                Class = int.Parse(TextClass.Text.Trim()),
                Sex = byte.Parse(TextSex.Text.Trim()),
                Sprite = int.Parse(TextSprite.Text.Trim()),
                Access = int.Parse(TextAccess.Text.Trim()),
                PK = byte.Parse(TextPK.Text.Trim()),
                Level = int.Parse(TextLevel.Text.Trim()),
                Experience = int.Parse(TextExperience.Text.Trim()),
                Points = int.Parse(TextPoints.Text.Trim()),
                Map = int.Parse(TextMap.Text.Trim()),
                X = int.Parse(TextX.Text.Trim()),
                Y = int.Parse(TextY.Text.Trim()),
                Strength = int.Parse(TextStr.Text.Trim()),
                Endurance = int.Parse(TextEnd.Text.Trim()),
                Intelligence = int.Parse(TextInt.Text.Trim()),
                Agility = int.Parse(TextAgi.Text.Trim()),
                Vitality = int.Parse(TextVit.Text.Trim()),
                Dexterity = int.Parse(TextDex.Text.Trim()),
            };

            return character;
        }
    }
}