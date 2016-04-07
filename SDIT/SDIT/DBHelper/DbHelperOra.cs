/* 
    ======================================================================== 
        File name：        DbHelperOra
        Module:                
        Author：            tsq
        Create Time：    2016/4/5 16:46:04
        Modify By:        
        Modify Date:    
    ======================================================================== 
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Text;

namespace SDIT.DBHelper
{
    public static class DbHelperOra
    {
        static OracleDataAccess oracleDataAccess = new OracleDataAccess();

        public static DataTable GetDataTable(string sql, string connectionString)
        {
            try
            {
                return oracleDataAccess.GetDataTable(sql, connectionString);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 清空表中数据
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="connectionString">数据库连接字符串</param>
        /// <returns></returns>
        public static bool ClearTableData(string tableName,string connectionString)
        {
            string sql = String.Format(@"delete from {0}", tableName);
            try
            {
                return oracleDataAccess.Excute(sql, connectionString);
            }
            catch (Exception)
            {
                return false;
            }            
        }

        #region 数据导入
        /// <summary>
        /// 数据导入
        /// </summary>
        /// <param name="datatable">要导入的数据</param>
        /// <param name="tableName">要导入的表</param>
        /// <param name="connectionString">数据库连接字符串</param>
        /// <returns></returns>
        public static ResultModel Import(DataTable datatable, string tableName, string connectionString)
        {
            List<DataRow> wrongList = new List<DataRow>();
            DataTable dtRight = new DataTable();
            ResultModel rm = new ResultModel();

            StringBuilder msg = new StringBuilder();
            msg.AppendFormat(@"共{0}条数据；", datatable.Rows.Count);

            string sql = String.Format(@"select * from {0}", tableName);

            using (OracleDataAdapter adapter = new OracleDataAdapter(sql, connectionString))
            {
                using (OracleCommandBuilder commandBuidler = new OracleCommandBuilder(adapter))
                {
                    try
                    {
                        int count = adapter.Fill(dtRight);
                        //foreach (DataRow row in dtRight.Rows)
                        //{
                        //    row.Delete();
                        //}
                        //dtRight.AcceptChanges();
                        //count = adapter.Update(dtRight);

                        for (int i = 0; i < datatable.Rows.Count; i++)
                        {
                            try
                            {
                                DataRow dr = dtRight.NewRow();
                                for (int j = 0; j < datatable.Columns.Count; j++)
                                {
                                    string colName = dtRight.Columns[j].ColumnName;
                                    dr[colName] = datatable.Rows[i][colName];
                                }
                                dtRight.Rows.Add(dr);
                            }
                            catch (Exception)
                            {
                                wrongList.Add(datatable.Rows[i]);
                            }
                        }

                        adapter.UpdateBatchSize = 9000;
                        count = adapter.Update(dtRight);

                        if (count > 0)
                        {
                            rm.SucceedCount = count;
                            msg.AppendFormat(@"成功导入{0}条数据；", count);
                        }
                        if (wrongList.Count > 0)
                        {
                            rm.FailedData = wrongList.CopyToDataTable();
                            msg.AppendFormat(@"尚有{0}条数据未成功导入，请检查原因！", wrongList.Count);
                        }
                        else
                        {
                            rm.IsAllSucceed = true;
                            rm.FailedData = new DataTable();
                        }
                        rm.FailedCount = wrongList.Count;
                        rm.Total = rm.FailedCount + rm.SucceedCount;
                        rm.Message = msg.ToString();
                        rm.Error = false;
                    }
                    catch (Exception ex)
                    {
                        rm.Error = true;
                        rm.Message = "在导入的时候出现了错误！异常信息如下=>" + ex.Message;
                    }
                }
            }

            return rm;
        }

        #endregion

        #region 用其中一行作列标题的DataTable行列转置
        /// <summary>
        /// DataTable行列转置
        /// </summary>
        /// <param name="dt">要转置的DataTable</param>
        /// <param name="columnHead">要当作转置后的列标题的那一列名称</param>
        /// <returns>转置后的DataTable，只有一行数据</returns>
        public static DataTable Col2Row(DataTable dt, string columnHead)
        {
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                //找到要转置的那一列
                if (dt.Columns[i].ColumnName.ToUpper() == columnHead.ToUpper())
                    return Col2Row(dt, i);
            }
            return new DataTable();
        }

        /// <summary>
        /// DataTable行列转置
        /// </summary>
        /// <param name="dt">要转置的DataTable</param>
        /// <param name="columnHead">要当作转置后的列标题的那一列索引号</param>
        /// <returns>转置后的DataTable</returns>
        public static DataTable Col2Row(DataTable dt, int columnHead)
        {
            DataTable result = new DataTable();
            DataColumn myHead = dt.Columns[columnHead];
            result.Columns.Add(myHead.ColumnName);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                result.Columns.Add(dt.Rows[i][myHead].ToString());
            }

            foreach (DataColumn col in dt.Columns)
            {
                if (col == myHead)
                    continue;
                object[] newRow = new object[dt.Rows.Count + 1];
                newRow[0] = col.ColumnName;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    newRow[i + 1] = dt.Rows[i][col];
                }
                result.Rows.Add(newRow);
            }
            return result;
        }
        #endregion

        #region 不要列标题的DataTable行列转置
        [Obsolete]
        public static DataTable Row2Col(DataTable dt)
        {
            DataTable result = new DataTable();

            for (int i = 0; i < dt.Rows.Count + 1; i++)
            {
                result.Columns.Add(i.ToString());
            }

            foreach (DataColumn col in dt.Columns)
            {
                object[] newRow = new object[dt.Rows.Count + 1];
                newRow[0] = col.ColumnName;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    newRow[i + 1] = dt.Rows[i][col];
                }
                result.Rows.Add(newRow);
            }
            return result;
        }

        #endregion
    }
}
