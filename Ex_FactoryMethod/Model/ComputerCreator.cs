class ComputerCreator : Creator
{
    public override Product FactoryMethod()
    {
        return new Computer();
    }

    public override Product FactoryMethod(string _description)
    {
        return new Computer(_description);
    }

    public override Product FactoryMethod(string _description,
        decimal _purchase_price)
    {
        return new Computer(_description, _purchase_price);
    }

    public override Product FactoryMethod(string _description,
        decimal _purchase_price, decimal _price)
    {
        return new Computer(_description, _purchase_price, _price);
    }
}