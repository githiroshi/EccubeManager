using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EccubeManager.Model;

namespace EccubeManager.Services 
{
    public class OrderService : IOrderService
    {
        public IList<Order> GetOrder()
        {
            IList<Order> order = new List<Order>();

            using (var connection = new EccubeConnect())
            {
                //コネクションオープン
                connection.ConnectionOpen();

                // データ取得
                order = connection.Select<Order>("SELECT * FROM dtb_order " +
                                                 "WHERE order_date >= now() + '-1 month' " +
                                                 "ORDER BY order_id ASC");

                return order;

            }
        }
    }
}
