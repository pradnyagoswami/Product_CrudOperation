using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_CrudOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int no = 0;
            ProductCrud crud=new ProductCrud();
            do
            {
                Console.WriteLine("1.Product List");
                Console.WriteLine("2.Get Product By id");
                Console.WriteLine("3.Add Product");
                Console.WriteLine("4.UPdate Product");
                Console.WriteLine("5.Delete Product");

                Console.WriteLine("Select your option");
                int option=Convert.ToInt32(Console.ReadLine());

                switch (option)
                {

                    case 1:

                        List<Product>list=crud.GetProducts();
                        Console.WriteLine("Id,name\t,Price\t,Company");
                        foreach (Product product in list)
                        {

                            Console.WriteLine($"{product.id},{product.name},{product.price},{product.company}");

                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter Product id ");
                        int id=Convert.ToInt32(Console.ReadLine());
                        Product p=crud.GetProductById(id);
                        Console.WriteLine("Id\t,name\t,Price\t,Company");
                        Console.WriteLine($"{p.id},{p.name},{p.price},{p.company}");
                        break;
                    case 3:
                        Product p1 = new Product();
                        Console.WriteLine("Enter Product id");
                        p1.id=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter product name");
                        p1.name=Console.ReadLine();
                        Console.WriteLine("Enter Product price");
                        p1.price=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter product company");
                        p1.company=Console.ReadLine();
                        crud.AddProduct(p1);
                        Console.WriteLine("Product saved");
                        break;
                    case 4:
                        Product p2 = new Product();
                        Console.WriteLine("Enter Product id you want to update");
                        p2.id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter product name");
                        p2.name = Console.ReadLine();
                        Console.WriteLine("Enter Product price");
                        p2.price = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter product company");
                        p2.company = Console.ReadLine();
                        crud.UpdateProduct(p2);
                        Console.WriteLine("Product updated");
                        break;
                    case 5:
                        Console.WriteLine("Enter product id");
                        int id1=Convert.ToInt32(Console.ReadLine());
                        crud.DeleteProduct(id1);
                        Console.WriteLine($"{id1} product Deleted");
                        break;
                
                }
                Console.WriteLine("press 1 for continue");
                no=Convert.ToInt32(Console.ReadLine());
            }
            while (no == 1);




        }
    }
}
