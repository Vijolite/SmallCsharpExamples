abstract class Creator
{
    public abstract Product FactoryMethod();
    public abstract Product FactoryMethod(string _description);
    public abstract Product FactoryMethod(string _description,
        decimal _purchase_price);
    public abstract Product FactoryMethod(string _description,
        decimal _purchase_price, decimal _price);
}