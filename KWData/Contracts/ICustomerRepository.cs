using KWData.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KWData.Contracts
{
    public interface ICustomerRepository : IRepositoryBase<Customer>
    {
        ICollection<Customer> GetCustomerByName (string SearchString);
    }
}
