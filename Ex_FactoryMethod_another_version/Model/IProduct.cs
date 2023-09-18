interface IProduct
{
    public decimal PurchasePrice { get; set; }

    public decimal Price { get; set; }

    public string Description { get; set; }

    public void Print() { }
}