using System;
using System.Text;
using System.Collections.Generic;
using AccountEditor.Database.MySql;

namespace AccountEditor.Database {
    public sealed class AccountDB : DBTemplate {

        public AccountDB() : base(new DBFactory()) {
 
        }

        public bool Exist(string username) {
            var query = "SELECT AccountId FROM AccountData WHERE Username = @Username";
            var sqlCommand = factory.GetCommand(sqlConnection);

            sqlCommand.SetCommand(query);
            sqlCommand.AddParameter("@Username", username);

            var sqlReader = sqlCommand.ExecuteReader();
            var result = sqlReader.Read();

            sqlReader.Close();
            return result;
        }

        public int GetAccountId(string username) {
            var query = "SELECT AccountID FROM AccountData WHERE Username = @Username";
            var sqlCommand = factory.GetCommand(sqlConnection);

            sqlCommand.SetCommand(query);
            sqlCommand.AddParameter("@Username", username);

            var sqlReader = sqlCommand.ExecuteReader();
            var result = 0;

            if (sqlReader.Read()) {
                result = Convert.ToInt32(sqlReader.GetData("AccountID"));
            }

            sqlReader.Close();
            return result;
        }

        public void Create(string username, string password, string salt, string email, int serviceId) {
            var query = "INSERT INTO AccountData (Username, Password, Salt, Email, ServiceID) VALUES (@Username, @Password, @Salt, @Email, @ServiceId)";
            var sqlCommand = factory.GetCommand(sqlConnection);

            sqlCommand.SetCommand(query);
            sqlCommand.AddParameter("@Username", username);
            sqlCommand.AddParameter("@Password", password);
            sqlCommand.AddParameter("@Salt", salt);
            sqlCommand.AddParameter("@Email", email);
            sqlCommand.AddParameter("@ServiceId", serviceId);

            sqlCommand.ExecuteNonQuery();
        }

        public void Update(int accountId, string password, string salt, string email, int serviceId) {
            var query = "UPDATE AccountData SET Password = @Password, Salt = @Salt, Email = @Email, ServiceID = @ServiceId WHERE AccountId = @AccountId";
            var sqlCommand = factory.GetCommand(sqlConnection);

            sqlCommand.SetCommand(query);

            sqlCommand.AddParameter("@AccountId", accountId);
            sqlCommand.AddParameter("@Password", password);
            sqlCommand.AddParameter("@Salt", salt);
            sqlCommand.AddParameter("@Email", email);
            sqlCommand.AddParameter("@ServiceId", serviceId);

            sqlCommand.ExecuteNonQuery();
        }

        public List<AccountData> GetAccounts(string username) {
            var query = $"SELECT AccountID, Username, Password, Email, ServiceID FROM AccountData WHERE Username LIKE @Username";
            var sqlCommand = factory.GetCommand(sqlConnection);

            sqlCommand.SetCommand(query);
            sqlCommand.AddParameter("@Username", "%" + username + "%");

            var sqlReader = sqlCommand.ExecuteReader();
            var accounts = new List<AccountData>();

            while (sqlReader.Read()) {
                var account = new AccountData() {
                    Id = (int)sqlReader.GetData("AccountID"),
                    Username = (string)sqlReader.GetData("Username"),
                    Password = (string)sqlReader.GetData("Password"),
                    Email = (string)sqlReader.GetData("Email"),
                    ServiceId = Convert.ToInt32(sqlReader.GetData("ServiceID"))
                };

                accounts.Add(account);
            }

            sqlReader.Close();
            return accounts;             
        }

        public List<CharacterTempData> GetCharacterList(int accountId) {
            var query = "SELECT CharacterID, Name FROM CharacterData WHERE AccountID = @AccountId";
            var sqlCommand = factory.GetCommand(sqlConnection);

            sqlCommand.SetCommand(query);
            sqlCommand.AddParameter("@AccountId", accountId);

            var sqlReader = sqlCommand.ExecuteReader();
            var characters = new List<CharacterTempData>();

            while (sqlReader.Read()) {
                characters.Add(
                    new CharacterTempData() {
                        Id = Convert.ToInt32(sqlReader.GetData("CharacterID")),
                        Character = (string)sqlReader.GetData("Name")
                    });
            }

            sqlReader.Close();
            return characters;
        }

        public CharacterTempData GetCharacterTempData(string  name) {
            var query = "SELECT CharacterID, Name FROM CharacterData WHERE Name = @Character";
            var sqlCommand = factory.GetCommand(sqlConnection);

            sqlCommand.SetCommand(query);
            sqlCommand.AddParameter("@Character", name);

            var sqlReader = sqlCommand.ExecuteReader();
            var character = new CharacterTempData() {
                Character = string.Empty
            };

            if (sqlReader.Read()) {
                character.Id = Convert.ToInt32(sqlReader.GetData("CharacterID"));
                character.Character = (string)sqlReader.GetData("Name");
            }

            sqlReader.Close();
            return character;
        }

        public Character GetCharacter(int characterId) {
            var query = "SELECT Name, Classe, Sex, OriginalSprite, Access, Level, Experience, ";
            query += "Strength, Endurance, Intelligence, Agility, Vitality, Dexterity, Points, PK, Map, X, Y ";
            query += "FROM CharacterData WHERE CharacterID = @CharacterId";

            var sqlCommand = factory.GetCommand(sqlConnection);

            sqlCommand.SetCommand(query);
            sqlCommand.AddParameter("@CharacterId", characterId);

            var sqlReader = sqlCommand.ExecuteReader();
            var character = new Character();

            if (sqlReader.Read()) {
                character.Name = (string)sqlReader.GetData("Name");
                character.Class = Convert.ToInt32(sqlReader.GetData("Classe"));
                character.Sex = Convert.ToByte(sqlReader.GetData("Sex"));
                character.Sprite = (int)sqlReader.GetData("OriginalSprite");
                character.Access = Convert.ToInt32(sqlReader.GetData("Access"));
                character.Level = Convert.ToInt32(sqlReader.GetData("Level"));
                character.Experience = Convert.ToInt32(sqlReader.GetData("Experience"));

                character.Strength = Convert.ToInt32(sqlReader.GetData("Strength"));
                character.Endurance = Convert.ToInt32(sqlReader.GetData("Endurance"));
                character.Intelligence = Convert.ToInt32(sqlReader.GetData("Intelligence"));
                character.Agility = Convert.ToInt32(sqlReader.GetData("Agility"));
                character.Vitality = Convert.ToInt32(sqlReader.GetData("Vitality"));
                character.Dexterity = Convert.ToInt32(sqlReader.GetData("Dexterity"));

                character.Points = Convert.ToInt32(sqlReader.GetData("Points"));

                character.PK = Convert.ToByte(sqlReader.GetData("PK"));

                character.Map = Convert.ToInt32(sqlReader.GetData("Map"));
                character.X = Convert.ToInt32(sqlReader.GetData("X"));
                character.Y = Convert.ToInt32(sqlReader.GetData("Y"));
            }

            sqlReader.Close();
            return character;
        }

        public int UpdateCharacter(int characterId, ref Character character) {
            var query = new StringBuilder();
            query.Append("UPDATE CharacterData SET Name = @Name, Classe = @Class, Sex = @Sex, OriginalSprite = @Original, Sprite = @Sprite, Access = @Access, ");
            query.Append("PK = @PK, Level = @Level, Experience = @Experience, Points = @Points, Map = @Map, X = @X, Y = @Y, ");
            query.Append("Strength = @Strength, Endurance = @Endurance, Intelligence = @Intelligence, Agility = @Agility, Vitality = @Vitality, Dexterity = @Dexterity ");
            query.Append("WHERE CharacterID = @CharacterId");

            var sqlCommand = factory.GetCommand(sqlConnection);

            sqlCommand.SetCommand(query.ToString());
            sqlCommand.AddParameter("@Name", character.Name);
            sqlCommand.AddParameter("@Class", character.Class);
            sqlCommand.AddParameter("@Sex", character.Sex);
            sqlCommand.AddParameter("@Original", character.Sprite);
            sqlCommand.AddParameter("@Sprite", character.Sprite);
            sqlCommand.AddParameter("@Access", character.Access);

            sqlCommand.AddParameter("@PK", character.PK);
            sqlCommand.AddParameter("@Level", character.Level);
            sqlCommand.AddParameter("@Experience", character.Experience);
            sqlCommand.AddParameter("@Points", character.Points);
            sqlCommand.AddParameter("@Map", character.Map);
            sqlCommand.AddParameter("@X", character.X);
            sqlCommand.AddParameter("@Y", character.Y);

            sqlCommand.AddParameter("@Strength", character.Access);
            sqlCommand.AddParameter("@Endurance", character.Access);
            sqlCommand.AddParameter("@Intelligence", character.Access);
            sqlCommand.AddParameter("@Agility", character.Access);
            sqlCommand.AddParameter("@Vitality", character.Access);
            sqlCommand.AddParameter("@Dexterity", character.Access);

            sqlCommand.AddParameter("@CharacterId", characterId);

            return sqlCommand.ExecuteNonQuery();
        }

        public bool ExistCharacter(string name) {
            var query = "SELECT CharacterID FROM CharacterData WHERE Name = @Name";
            var sqlCommand = factory.GetCommand(sqlConnection);

            sqlCommand.SetCommand(query);
            sqlCommand.AddParameter("@Name", name);

            var sqlReader = sqlCommand.ExecuteReader();
            var result = sqlReader.Read();

            sqlReader.Close();
            return result;
        }
    }
}