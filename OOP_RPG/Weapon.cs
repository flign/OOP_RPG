namespace OOP_RPG
{
    public class Weapon : IWeapon
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Price { get; set; }

        public Weapon(string name, int strength, int price)
        {
            Name = name;
            Strength = strength;
            Price = price;
        }

        public string GetDescription()
        {
            return $"Strenth ({Strength})";
        }

        public string GetClass()
        {
            return "Weapon";
        }
    }
}