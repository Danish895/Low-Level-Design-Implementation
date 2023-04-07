namespace LowLevelDesign.SOLID.Dependency_Inversion_Principle
{
    //Violation 

    /*
    public class CustomerRepository
    {
        public List<Customer> GetCustomers()
        {
            // logic to fetch customers from the database
        }
    }

    public class CustomerService
    {
        private CustomerRepository _customerRepository;

        public CustomerService()
        {
            _customerRepository = new CustomerRepository();
        }

        public List<Customer> GetCustomers()
        {
            return _customerRepository.GetCustomers();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CustomerService customerService = new CustomerService();
            List<Customer> customers = customerService.GetCustomers();
            // do something with the customers
        }
    }

    */





    public interface ICustomerRepository
    {
        List<Customer> GetCustomers();
    }

    public class CustomerRepository : ICustomerRepository
    {
        public List<Customer> GetCustomers()
        {
            // logic to fetch customers from the database
            List<Customer> myList = new List<Customer>()
            {
                new Customer
                {
                    FirstName = "Danish",
                    LastName = "Khan",
                    Email = "dkhan895@gmail.com",
                    DateOfBirth = DateTime.Now 
                }
            };
            return myList;
        }
    }

    public class CustomerService
    {
        private ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public List<Customer> GetCustomers()
        {
            return _customerRepository.GetCustomers();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ICustomerRepository customerRepository = new CustomerRepository();
            CustomerService customerService = new CustomerService(customerRepository);
            List<Customer> customers = customerService.GetCustomers();
            // do something with the customers
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
    }


}
