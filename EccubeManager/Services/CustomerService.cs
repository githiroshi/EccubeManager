using EccubeManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EccubeManager.Services
{
    class CustomerService : ICustomerService
    {

        public IList<Customer> GetCustomer()
        {
            IList<Customer> customers = new List<Customer>();

            using (var connection = new EccubeConnect())
            {
                //コネクションオープン
                connection.ConnectionOpen();

                // データ取得
                customers = connection.Select<Customer>("SELECT * FROM dtb_customer");

                return customers;
            }
        }
    }
}
