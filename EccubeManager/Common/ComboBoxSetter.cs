using EccubeManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EccubeManager.Common
{
    class ComboBoxSetter
    {
        public static void SetComboBox(DataGridView dataGridView, string columnName)
        {
            using (var connection = new EccubeConnect())
            {
                //コネクションオープン
                connection.ConnectionOpen();

                //DataGridViewComboBoxColumnを作成
                DataGridViewComboBoxColumn column = new DataGridViewComboBoxColumn();
                //表示する列の名前を設定する
                column.DataPropertyName = dataGridView.Columns[columnName].DataPropertyName;

                var masterTable = columnName;

                if (columnName.Contains("pref"))
                {
                    masterTable = "pref";
                }else if (columnName.Contains("job"))
                {
                    masterTable = "job";
                }else if (columnName.Contains("status"))
                {
                    masterTable = "order_status";
                }

                //DataGridViewComboBoxColumnのDataSourceを設定
                var master = connection.SelectMaster<Master>(masterTable);

                column.DataSource = master;
                //実際の値が"id"列、表示するテキストが"name"列とする
                column.ValueMember = "id";
                column.DisplayMember = "name";
                //ReadOnlyに変更
                column.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
                column.ReadOnly = true;

                //現在の列が存在している位置に挿入する
                dataGridView.Columns.Insert(dataGridView.Columns[columnName].Index, column);
                //挿入した列の名前を変更する
                column.Name = dataGridView.Columns[columnName].HeaderText;
                //今までの列を削除する
                dataGridView.Columns.Remove(columnName);

            }
        }
    }
}
