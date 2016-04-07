/* 
    ======================================================================== 
        File name：        ResultModel
        Module:                
        Author：            tsq
        Create Time：    2016/4/6 10:34:55
        Modify By:        
        Modify Date:    
    ======================================================================== 
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SDIT
{
    public class ResultModel
    {
        private bool _isAllSucceed;
        private bool _error;
        private string _message;
        private int _failedCount;
        private int _succeedCount;
        private int _total;
        private DataTable _failedData;

        /// <summary>
        /// 是否全部成功导入
        /// </summary>
        public bool IsAllSucceed
        {
            get { return _isAllSucceed; }
            set { _isAllSucceed = value; }
        }
        /// <summary>
        /// 导入过程中是否出错
        /// </summary>
        public bool Error
        {
            get { return _error; }
            set { _error = value; }
        }
        /// <summary>
        /// 返回的信息
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// 导入失败的数据条数
        /// </summary>
        public int FailedCount
        {
            get { return _failedCount; }
            set { _failedCount = value; }
        }
        /// <summary>
        /// 成功导入的数据条数
        /// </summary>
        public int SucceedCount
        {
            get { return _succeedCount; }
            set { _succeedCount = value; }
        }
        /// <summary>
        /// 数据总数
        /// </summary>
        public int Total
        {
            get { return _total; }
            set { _total = value; }
        }
        /// <summary>
        /// 返回失败数据列表
        /// </summary>
        public DataTable FailedData { get; set; }
    }
}
