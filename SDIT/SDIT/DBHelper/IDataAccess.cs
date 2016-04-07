using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SDIT.DBHelper
{
    public interface IDataAccess
    {
        /// <summary>
        /// 根据自定义sql获取DataTable
        /// </summary>
        /// <param name="sql">自定义sql查询语句（Select）</param>
        /// <param name="connectionString">数据库连接字符串</param>
        /// <returns>DataTable</returns>
        DataTable GetDataTable(string sql, string connectionString);

        /// <summary>
        /// 执行自定义SQL语句
        /// </summary>
        /// <param name="sql">自定义sql语句（Insert、Delete、Update）</param>
        /// <param name="connectionString">数据库连接字符串</param>
        /// <returns>true:执行成功；false:执行失败</returns>
        bool Excute(string sql, string connectionString);
    }
}
