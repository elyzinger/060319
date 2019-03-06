using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    class MyQueue
    {
        private List<Customer> customers = new List<Customer>();
        public void Enqueue (Customer clinet)
        {
            customers.Insert(0, clinet);
        }
        public Customer Dequeue()
        {
            if(customers.Count > 0)
            {
                Customer result = customers[0];
                customers.RemoveAt(0);
                return result;
            }
            return null;      
        }
        public void InIt(List<Customer> x)
        {
            this.customers = x;
        }
        public void Clear()
        {
            customers.Clear();
        }
        public Customer WholsNext()
        {           
            return customers[0];
        }
        public int Count
        {
            get
            {
                return customers.Count;
            }
        }
        public void SortByProtecion()
        {
            SortByProtecion();         
        }
        public void SortByTotalPurchase()
        {
            SortByTotalPurchase();
        }
        public void SortByBirthYear()
        {
            SortByBirthYear();
        }
        public List<Customer> DequeueCustomers(int x)
        {
            return customers.Removeall(x, 0-4);
        }
        public void AniRakSheela(Customer x)
        {

        }
        public Customer DequeueProtectiza()
        {
            Customer result = customers[1];
        }
    }
}
