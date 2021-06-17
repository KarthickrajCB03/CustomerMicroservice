using DemoCustMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoCustMS.Services
{
        public static class CustomerService
        {
            static List<Customer> Customers { get; }
            static CustomerService()
            {
                Customers = new List<Customer>
            {
                new Customer {
                    CustomerId = 1001,
                    Name = "Karthik",
                    Address = "Chennai",
                    DOB = Convert.ToDateTime("2000/10/11"),
                    PAN_Number = "BQMPS6580E"
                },
                new Customer {
                    CustomerId = 1002,
                    Name = "Megala",
                    Address = "Chennai",
                    DOB = Convert.ToDateTime("2000/10/11"),
                    PAN_Number = "BQMPS6580F"
                },
                new Customer {
                    CustomerId = 1003,
                    Name = "Nikhil Reddy",
                    Address = "Hyderabad",
                    DOB = Convert.ToDateTime("2000/10/11"),
                    PAN_Number = "BQMPS6580G"
                },
                new Customer {
                    CustomerId = 1004,
                    Name = "Sivani Josyula",
                    Address = "Hyderabad",
                    DOB = Convert.ToDateTime("2000/10/11"),
                    PAN_Number = "BQMPS6580I"
                },
            };
            }

            static int nextId = 1005;

            public static List<Customer> GetAll()
            {
                return Customers;
            }

            public static Customer Get(int id)
            {
                return Customers.FirstOrDefault(p => p.CustomerId == id);
            }

            public static CustomerCreationStatus Add(Customer cust)
            {
                cust.CustomerId = nextId++;
                Customers.Add(cust);
                return new CustomerCreationStatus
                {
                    CustomerId = cust.CustomerId,
                    Customer = cust,
                    Message = "Customer Record Created. Customer Service will connect with AccountService to create Account."
                };
            }

            public static void Delete(int id)
            {
                var Customer = Get(id);

                if (Customer is null)
                    return;

                Customers.Remove(Customer);
            }

            public static void Update(Customer Customer)
            {
                var index = Customers.FindIndex(p => p.CustomerId == Customer.CustomerId);
                if (index == -1)
                    return;

                Customers[index] = Customer;
            }
        }
}
