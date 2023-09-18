abstract class Creator
{
    public abstract IProduct FactoryMethod();
    public abstract IProduct FactoryMethod(string type);
    public abstract IProduct FactoryMethod(string type, string _description);
    public abstract IProduct FactoryMethod(string type, string _description,
        decimal _purchase_price);
    public abstract IProduct FactoryMethod(string type, string _description,
        decimal _purchase_price, decimal _price);
}