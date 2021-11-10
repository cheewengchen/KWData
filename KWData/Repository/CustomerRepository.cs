using KWData.Contracts;
using KWData.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

namespace KWData.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext _db;
        public CustomerRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(Customer entity)
        {
            _db.Customers.Add(entity);
            return Save();
        }

        public bool Delete(Customer entity)
        {
            _db.Customers.Remove(entity);
            return Save();
        }

        public ICollection<Customer> FindAll()
        {
            var customers = _db.Customers.ToList();
            return customers;
        }

        public Customer FindById(int id)
        {
            var customer = _db.Customers.Find(id);
            return customer;
        }

        public ICollection<Customer> GetCustomerByName(string SearchString, string ICString)
        {
            string SearchColumn = "CustomerName.Contains(\"" + SearchString + "\")";
                                    
            if (!string.IsNullOrEmpty(SearchString))
            {
                SearchColumn = "CustomerName.Contains(\"" + SearchString + "\")";
                
            }

            if (!string.IsNullOrEmpty(ICString))
            {
                SearchColumn += " && IC.Contains(\"" + ICString  + "\")";                
            }

            //var customers = _db.Customers.Where(SearchColumn, SearchValue);

            var customers = _db.Customers.Where(SearchColumn);

            //var customers = from m in _db.Customers where strSQL select m;
            //if (!String.IsNullOrEmpty(SearchString))
            //{
            //    customers = customers.Where(s => s.CustomerName.Contains(SearchString));
            //}

            return customers.ToList();

            
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            return changes > 0;
        }

        public bool Update(Customer entity)
        {
            _db.Customers.Update(entity);
            return Save();
        }
    }
}
