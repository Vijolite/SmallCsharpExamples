
namespace Ex_FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator factory = new ConcreteCreator();
            List<IProduct> productList = new List<IProduct>();

            IProduct c1 = factory.FactoryMethod("1", "Macbook", 1000, 1200);
            productList.Add(c1);

            IProduct c2 = factory.FactoryMethod("2", "CD Player Best Model", 500, 550);
            productList.Add(c2);

            foreach (IProduct pr in productList)
            {
                pr.Print();
            }
            Console.ReadLine();
        }

    }
}
