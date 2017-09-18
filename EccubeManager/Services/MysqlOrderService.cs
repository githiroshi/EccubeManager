using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EccubeManager.Model;

namespace EccubeManager.Services
{
    class MysqlOrderService : IOrderService
    {
        /// <summary>
        /// 受注データを非同期で取得
        /// </summary>
        /// <returns></returns>
        public async Task<IList<Order>> GetOrderAsync()
        {
            IList<Order> order = new List<Order>();

            var task = await Task.Run(() =>
            {
                using (var connection = new EccubeConnect())
                {
                    try
                    {
                        //コネクションオープン
                        connection.ConnectionOpen();

                        var sql = new StringBuilder();
                        sql.AppendLine(" SELECT * FROM dtb_order ");
                        sql.AppendLine(" WHERE order_date >= DATE_ADD(NOW(), INTERVAL -1 MONTH) ");//直近1ヶ月前を取得
                        sql.AppendLine(" ORDER BY order_id ASC");

                        // データ取得
                        order = connection.Select<Order>(sql.ToString());
                        return true;
                    }
                    catch
                    {
                        return false;
                    }

                }
            });

            return order;
        }

        /// <summary>
        /// 受注明細データを非同期で取得
        /// </summary>
        /// <returns></returns>
        public async Task<IList<OrderDetail>> GetOrderDetailAsync()
        {
            IList<OrderDetail> order = new List<OrderDetail>();

            var task = await Task.Run(() =>
            {
                using (var connection = new EccubeConnect())
                {
                    //コネクションオープン
                    connection.ConnectionOpen();

                    var sql = new StringBuilder();
                    sql.AppendLine(" SELECT * FROM dtb_order_detail ");
                    sql.AppendLine(" INNER JOIN dtb_order ON dtb_order.order_id = dtb_order_detail.order_id ");
                    sql.AppendLine(" WHERE DATE(dtb_order.order_date) = CURDATE() ");//本日データ
                    sql.AppendLine(" ORDER BY order_detail_id DESC");

                    // データ取得
                    order = connection.Select<OrderDetail>(sql.ToString());
                    return true;
                }
            });

            return order;
        }
    }
}
