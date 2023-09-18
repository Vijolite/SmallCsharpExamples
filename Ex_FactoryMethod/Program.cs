
//Console.WriteLine("Hello, World!");
namespace Ex_FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> productList = new List<Product>();

            Creator[] creators = new Creator[2];
            creators[0] = new ComputerCreator();
            creators[1] = new CDPlayerCreator();

            foreach (Creator cr in creators)
            {
                if (cr is ComputerCreator)
                    productList.Add(cr.FactoryMethod("MS Laptop", 600, 800));

                if (cr is CDPlayerCreator)
                    productList.Add(cr.FactoryMethod("audio,mp3,mp4", 250, 360));
            }

            var c1 = new ComputerCreator();
            productList.Add(c1.FactoryMethod("Macbook", 1000));
            var c2 = new CDPlayerCreator();
            productList.Add(c2.FactoryMethod("CD Player Best Model", 500, 550));

            var c3 = new Computer("Another computer", 700, 800);
            productList.Add(c3);

            foreach (Product pr in productList)
            {
                Console.WriteLine("Object from class {0};\n" +
                    "Description: {1};\n" +
                    "Purchase Price: {2};\n" +
                    "Selling Price: {3};\n",
                    pr.GetType().Name,
                    pr.Description,
                    pr.PurchasePrice,
                    pr.Price);
            }

            Console.ReadLine();
        }

    }
}
