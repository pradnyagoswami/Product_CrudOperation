using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_CrudOperation
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public string company { get; set; }

    }

    public class ProductCrud
    {

        private List<Product> productList;
        public ProductCrud()
        {
            productList = new List<Product>()
            {

                new Product{id=101,name="Laptop",price=35000,company="dell"},
                new Product{id=102,name="Laptop",price=45000,company="hp"}

            };
        
        
        }
        public List<Product> GetProducts() // display list
        {
            return productList;

        }
        public Product GetProductById(int id) // get single product
        {
            Product product = new Product();
            foreach (Product p in productList)
            {
                if (p.id == id)
                {

                    product = p;
                    break;
                
                }
            
            }
            return product;


        }
        public void AddProduct(Product p) // add new product
        { 
            productList.Add(p);


        
        }
        public void UpdateProduct(Product p)  // modify the product

        {
            foreach (Product item in productList)
            { 
                if(item.id == p.id)
                { 
                    item.name = p.name;
                    item.price = p.price;
                    item.company = p.company;
                    break;
                
                
                }
            
            
            }

        
        }
        public void DeleteProduct(int Id)    // remove product
        {
            foreach (Product item in productList)
            {
                if(item.id == Id) 
                {

                    productList.Remove(item);
                    break;
                
                }
            
            
            
            }
        
        
        }



    
    
    
    
    
    
    
    
    
    
    }
}
