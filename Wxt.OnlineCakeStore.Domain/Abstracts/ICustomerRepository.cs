using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wxt.OnlineCakeStore.Domain
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> Customers { get; }
        IEnumerable<ShoppingCart> ShoppingCarts { get; }
        IEnumerable<Receipt> Receipts { get; }
    }
}
