class ConcreteCreator : Creator
{
    public override IProduct FactoryMethod()
    {
        return new Computer();
    }
    public override IProduct FactoryMethod(string type)
    {
        switch (type)
        {
            case "1": return new Computer();
            case "2": return new CDPlayer();
            default: throw new ArgumentException("Invalid Type", "type");
        }
    }

    public override IProduct FactoryMethod(string type, string _description)
    {
        switch (type)
        {
            case "1": return new Computer(_description);
            case "2": return new CDPlayer(_description);
            default: throw new ArgumentException("Invalid Type", "type");
        }
    }

    public override IProduct FactoryMethod(string type, string _description, decimal _purchase_price)
    {
        switch (type)
        {
            case "1": return new Computer(_description, _purchase_price);
            case "2": return new CDPlayer(_description, _purchase_price);
            default: throw new ArgumentException("Invalid Type", "type");
        }
    }

    public override IProduct FactoryMethod(string type, string _description, decimal _purchase_price, decimal _price)
    {
        switch (type)
        {
            case "1": return new Computer(_description, _purchase_price, _price);
            case "2": return new CDPlayer(_description, _purchase_price, _price);
            default: throw new ArgumentException("Invalid Type", "type");
        }
    }
}