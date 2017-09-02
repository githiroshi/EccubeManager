using EccubeManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EccubeManager.Common
{
    public class MasterTableRepository
    {
        public static IList<Master> GetMasterTable(string tableName)
        {
            IList<Master> master = new List<Master>();

            using (var connection = new EccubeConnect())
            {
                //コネクションオープン
                connection.ConnectionOpen();

                //DataGridViewComboBoxColumnのDataSourceを設定
                master = connection.SelectMaster<Master>(tableName);

                return master;

            }
        }
    }
}
