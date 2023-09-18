class CDPlayerCreator : Creator
{

    public override Product FactoryMethod()
    {
        return new CDPlayer();
    }

    public override Product FactoryMethod(string _description)
    {
        return new CDPlayer(_description);
    }

    public override Product FactoryMethod(string _description,
        decimal _purchase_price)
    {
        return new CDPlayer(_description, _purchase_price);
    }

    public override Product FactoryMethod(string _description,
        decimal _purchase_price, decimal _price)
    {
        return new CDPlayer(_description, _purchase_price, _price);
    }
}