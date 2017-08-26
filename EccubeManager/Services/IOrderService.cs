using EccubeManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EccubeManager.Services
{
    public interface IOrderService
    {
        IList<Order> GetOrder();
    }
}
