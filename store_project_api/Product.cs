using System.Xml.Linq;

namespace store_project_api
{
    public class Product
    {
        static int idProduct = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }

        public Product()
        {
            Id = idProduct++;
            Name = "default name";
            Price = 5.5f;
        }
        //public Product(int id , string name , float price)
        //{
        //    Id = id ;
        //    Name = name ;
        //    Price = price ;
        //}
    }
}
