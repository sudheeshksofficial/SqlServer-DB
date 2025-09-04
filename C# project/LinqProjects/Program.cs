namespace LinqProjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            List<Customer> custlist = new List<Customer>();
            custlist.Add(new Customer() { Name = "kabuga", Country = "Africa" });
            custlist.Add(new Customer() { Name = "kevin", Country = "USA" });
            custlist.Add(new Customer() { Name = "rahul", Country = "India" });
            custlist.Add(new Customer() { Name = "san", Country = "Japan" });
            custlist.Add(new Customer() { Name = "ranjini", Country = "India" });


            custlist.Where(cust => cust.Country == "India").ToList<Customer>().ForEach(cust => Console.WriteLine($"customer name : {cust.Name} and his nationality is {cust.Country}"));

            

            foreach (Customer cust in (from custitems in custlist
                                       where custitems.Country == "India"
                                       select custitems).ToList<Customer>())
            {
                Console.WriteLine($"customer name : {cust.Name} and his nationality is {cust.Country}");
            }

           // without linq
            foreach (Customer customer in custlist)
            {
                if (customer.Country == "India")
                {
                    Console.WriteLine($"customer name : {customer.Name} and his nationality is {customer.Country}");
                }
            }

            //var item = (from custitems in custlist
            //            where custitems.Country == "India"
            //            select custitems).ToList<Customer>();

            Console.ReadKey();
        }


    }

    class Customer
    {
        public string Name { get; set; }
        public string Country { get; set; }
    }
}
