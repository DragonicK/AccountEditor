namespace AccountEditor {
    public sealed class Character {
        public string Name { get; set; }
        public int Class { get; set; }
        public byte Sex { get; set; }
        public int Sprite { get; set; }
        public int Access { get; set; }
        public byte PK { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public int Points { get; set; }
        public int Map { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public int Strength { get; set; }
        public int Endurance { get; set; }
        public int Intelligence { get; set; }
        public int Agility { get; set; }
        public int Vitality { get; set; }
        public int Dexterity { get; set; }

        public Character() {
            Name = string.Empty;
        }
    }
}