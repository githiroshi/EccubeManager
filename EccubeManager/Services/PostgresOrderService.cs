﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EccubeManager.Model;

namespace EccubeManager.Services 
{
    /// <summary>
    /// Postgres用受注サービス
    /// </summary>
    public class PostgresOrderService : IOrderService
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
                        sql.AppendLine(" WHERE order_date >= now() + '-1 month' "); //直近1ヶ月前を取得
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
        public Task<IList<OrderDetail>> GetOrderDetailAsync()
        {
            throw new NotImplementedException();
        }
    }
}
