namespace AccountEditor.Database {
    public sealed class AccountData {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int ServiceId { get; set; }

        public AccountData() {
            Username = string.Empty;
            Password = string.Empty;
            Email = string.Empty;         
        }
    }
}