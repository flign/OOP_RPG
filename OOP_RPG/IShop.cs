namespace OOP_RPG
{
    public interface IShop
    {
        string Name { get; set; }
        int Price { get; set; }       
        string GetDescription();
        string GetClass();
    }
}
