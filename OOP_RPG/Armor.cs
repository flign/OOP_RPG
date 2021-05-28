namespace OOP_RPG
{
    public class Armor : IArmor
    {
        public string Name { get; set; }
        public int Defense { get; set; }
        public int Price { get; set; }
        
        public Armor(string name, int defense, int price)
        {
            Name = name;
            Defense = defense;
            Price = price;
        }

        public string GetDescription()
        {
            return $"Defense ({Defense})";            
        }

        public string GetClass()
        {
            return "Armor";
        }
    }
}