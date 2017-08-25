using EccubeManager.Model;
using System.Collections.Generic;

namespace EccubeManager.Services
{
    public interface ICustomerService
    {
        IList<Customer> GetCustomer();
    }
}