class CDPlayer : IProduct
{
    private decimal _purchase_price;
    private decimal _price;
    private string _description;

    public CDPlayer() : this(null) { }
    public CDPlayer(string _description)
       : this(_description, 0) { }
    public CDPlayer(string _description, decimal _purchase_price)
       : this(_description, _purchase_price, 0) { }

    public CDPlayer(string _description,
        decimal _purchase_price, decimal _price)
    {
        this._description = _description;
        this._purchase_price = _purchase_price;
        this._price = _price;
    }

    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }

    public decimal Price
    {
        get { return _price; }
        set { _price = value; }
    }

    public decimal PurchasePrice
    {
        get { return _purchase_price; }
        set { _purchase_price = value; }
    }

    public void Print()
    {
        Console.WriteLine("Object from class {0};\n" +
        "Description: {1};\n" +
        "Purchase Price: {2};\n" +
        "Selling Price: {3};\n",
        this.GetType().Name,
        this.Description,
        this.PurchasePrice,
        this.Price);
    }
}