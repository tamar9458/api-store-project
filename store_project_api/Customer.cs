using System.Xml.Linq;

namespace store_project_api
{
    public class Customer
    {
        static int idCustomer = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public Customer()
        {
            Id = idCustomer++;
            Name = "default name";
            Address = "default address";
            Phone = "default phone";
        }
        //public Customer(int id ,string name,string address,string phone) : this() 
        //{
        //    Name = name;
        //    Address = address;
        //    Phone = phone;

        //}

    }
}
