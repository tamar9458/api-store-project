namespace store_project_api
{
    public class Worker
    {
        static int idWorker = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public float Salary { get; set; }
        public Worker()
        {
            Id = idWorker++;
            Name = "default name";
            Address = "default address";
            Phone = "default phone";
            Salary = 5000.05f;

        }
    }
}
