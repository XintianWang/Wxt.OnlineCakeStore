using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wxt.OnlineCakeStore.Domain
{
    interface ICustomerRepository
    {
        List<Customer> Customers { get; }
        List<ShoppingCart> ShoppingCarts { get; }
        List<Receipt> Receipts { get; }
    }
}
