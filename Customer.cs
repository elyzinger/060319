using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    class Customer
    {
        public int ID
        {
            get { return this.ID}
            set { this.ID}
        }
        public string Name { get; set; }
        public int BirthYEAR { get; set; }
        public string Address { get; set; }
        public int Protection { get; set; }
        public int TotalPurchase { get; set; }
        public MyQueue(int id, string name, int birthyear, string address, int protection, int totalpurchase)
        {
            this.ID = id;
            this.Name = name;
            this.BirthYEAR = birthyear;
            this.Address = address;
            this.Protection = protection;
            this.TotalPurchase = totalpurchase;

        }

        public override string ToString()
        {
            return $"id: {ID} name: {Name} birthyear: {BirthYEAR} address: {Address} protection: {Protection} totalpurchase {TotalPurchase}"
        }
    }
    class SortByProtection : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            return x.Protection - y.Protection;
        }
    }
    class SortByTotalPurchase : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            return x.TotalPurchase - y.TotalPurchase;
        }
    }
    class SortByBirthYear : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {   
            return -1*(x.TotalPurchase - y.TotalPurchase);
        }
    }
}
