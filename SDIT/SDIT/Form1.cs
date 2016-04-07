using SDIT.DBHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SDIT
{
    public partial class MianForm : Form
    {
        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        private string connectionString = "";

        public MianForm()
        {
            InitializeComponent();

            this.InitDbConnection();
        }

        #region 初始化
        private void InitDbConnection()
        {
            #region 可作调整

            if (null != this.txtDBName && this.txtDBName is TextBox)
            {
                this.txtDBName.Text = "sharepiple";
            }

            if (null != this.txtIpAddress && this.txtIpAddress is TextBox)
            {
                this.txtIpAddress.Text = "192.168.12.66";
            }

            if (null != this.txtPort && this.txtPort is TextBox)
            {
                this.txtPort.Text = "1521";
            }

            if (null != this.txtUserName && this.txtUserName is TextBox)
            {
                this.txtUserName.Text = "dcqpiple";
            }

            if (null != this.txtPassword && this.txtPassword is TextBox)
            {
                this.txtPassword.Text = "123";
            }

            if (null != this.txtItems && this.txtItems is TextBox)
            {
                this.txtItems.Text = "PIPE_USER";
            }

            this.generateConnectionString(null, null);

            #endregion

            if (null != this.listBox1 && this.listBox1 is ListBox)
            {
                this.listBox1.DisplayMember = "COLUMN_NAME";
            }
        }
        #endregion

        #region 一些操作
        /// <summary>
        /// 是否是默认端口，取消选择则显示端口输入框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void defaultPort_CheckedChanged(object sender, EventArgs e)
        {
            if (null == sender)
            {
                MessageBox.Show("非法操作！", "提示");
                return;
            }
            if (!this.defaultPort.Checked)
            {
                this.defaultPort.Hide();
                this.txtPort.Show();
            }
        }

        /// <summary>
        /// 端口输入检测，只允许输入数字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void port_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (null == e)
            {
                MessageBox.Show("非法操作！", "提示");
                return;
            }
            //48~57分别代表数字0~9，8代表撤销键，127代表删除键
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// IP地址输入框检测，只允许输入数字和小数点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IpAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (null == e)
            {
                MessageBox.Show("非法操作！", "提示");
                return;
            }
            //48~57分别代表数字0~9，8代表撤销键，127代表删除键,46代表小数点
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 46 && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// 生成数据库连接字符串
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void generateConnectionString(object sender, EventArgs e)
        {
            string dbNameStr = this.txtDBName.Text;
            string ipAddressStr = this.txtIpAddress.Text;
            string portStr = this.txtPort.Text;
            string userNameStr = this.txtUserName.Text;
            string password = this.txtPassword.Text;

            if (String.IsNullOrEmpty(dbNameStr) || String.IsNullOrEmpty(ipAddressStr) || String.IsNullOrEmpty(portStr) || String.IsNullOrEmpty(userNameStr) || String.IsNullOrEmpty(password))
            {
                return;
            }

            var ipList = ipAddressStr.Trim().Split('.');
            if (ipList == null || ipList.Length != 4)
            {
                MessageBox.Show("请输入正确的IP地址！", "提示");
                return;
            }

            foreach (var item in ipList)
            {
                bool illegal = false;
                try
                {
                    int t = int.Parse(item);
                    if (t < 0 || t > 255)
                    {
                        illegal = true;
                    }
                }
                catch (Exception)
                {
                    illegal = true;
                }
                if (illegal)
                {
                    MessageBox.Show("请输入正确的IP地址！", "提示");
                    return;
                }
            }
            this.connectionString = String.Format(@"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST={0})(PORT={1}))(CONNECT_DATA=(SERVICE_NAME={2})));User Id={3};Password={4};", ipAddressStr, portStr, dbNameStr, userNameStr, password);
            //this.textBox1.Text = this.connectionString;
        }

        /// <summary>
        /// 显示和隐藏密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (null == sender)
            {
                MessageBox.Show("非法操作！", "提示");
                return;
            }
            if (this.showPassword.Checked)
            {
                this.txtPassword.PasswordChar = (char)0;
            }
            else
            {
                this.txtPassword.PasswordChar = '*';
            }
        }

        /// <summary>
        /// 选择文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectFile_Click(object sender, EventArgs e)
        {
            if (null == sender)
            {
                MessageBox.Show("非法操作！", "提示");
                return;
            }
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.InitialDirectory = "d:\\";
                ofd.Filter = "Microsoft Excel files(*.xls)|*.xls;*.xlsx";//过滤一下，只要表格格式的
                ofd.RestoreDirectory = true;
                ofd.FilterIndex = 1;
                ofd.CheckFileExists = true;
                ofd.CheckPathExists = true;
                ofd.ShowHelp = true;//是否显示帮助按钮

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    this.filePath.Text = ofd.FileName;
                }
            }
            catch (Exception)
            {
                //TODO:记录日志
            }
        }
        #endregion

        #region 选择要导入的表
        /// <summary>
        /// 向选择表下拉框中添加选项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (null == sender)
            {
                MessageBox.Show("非法操作！", "提示");
                return;
            }
            var temp = this.txtItems.Text.Split(',').ToList();

            foreach (string item in temp)
            {
                if ((!String.IsNullOrEmpty(item)) && (!this.selectTable.Items.Contains(item)))
                {
                    this.selectTable.Items.Add(item);
                }
            }
            this.dataGridView1.Hide();
            this.txtItems.Text = "";
            this.selectTable.SelectedIndex = 0;
            this.listBox1.Show();
        }

        /// <summary>
        /// 选择的表发生改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (null == sender)
            {
                MessageBox.Show("非法操作！", "提示");
                return;
            }
            if (String.IsNullOrEmpty(this.connectionString))
            {
                MessageBox.Show("请先设置数据库连接参数！", "提示");
                return;
            }

            string tableName = this.selectTable.Text.ToUpper();

            if (String.IsNullOrEmpty(tableName))
            {
                MessageBox.Show("所选表名为空！", "提示");
                return;
            }
            DataTable dt = DbHelperOra.GetDataTable(String.Format(@"select COLUMN_NAME from user_tab_columns where Table_Name='{0}'", tableName), this.connectionString);

            this.listBox1.DataSource = dt;

            this.txtStatus.Text = "等待入库...";

            if (dt == null || dt.Rows.Count < 1)
            {
                this.btnImport.Enabled = false;
                MessageBox.Show("您所选择的表不存在！", "提示");
                return;
            }

            this.btnImport.Enabled = true;
        }
        #endregion

        #region 数据入库
        /// <summary>
        /// 是否清空要导入的表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImport_Click(object sender, EventArgs e)
        {
            if (null == sender)
            {
                MessageBox.Show("非法操作！", "提示");
                return;
            }

            if (String.IsNullOrEmpty(this.connectionString))
            {
                MessageBox.Show("请先设置数据库连接参数！", "提示");
                return;
            }

            string tableStr = this.selectTable.Text;
            string filePathStr = this.filePath.Text;

            if (String.IsNullOrEmpty(tableStr))
            {
                MessageBox.Show("请先设置要导入的表！", "提示");
                return;
            }
            if (String.IsNullOrEmpty(filePathStr))
            {
                MessageBox.Show("请先选择要导入的数据！", "提示");
                return;
            }
            this.txtStatus.Text = "正在导入数据，请稍等...";

            if (this.chBoxClear.Checked)
            {
                var mb = MessageBox.Show("您确定要先清空表中已存在的数据吗？", "确认信息", MessageBoxButtons.OKCancel);

                if (mb == DialogResult.Cancel)
                {
                    Import(tableStr,filePathStr);
                }
                else if(mb==DialogResult.OK)
                {
                    bool result=DbHelperOra.ClearTableData(tableStr,this.connectionString);

                    if (!result)
                    {
                        MessageBox.Show("清空表数据失败！", "提示");
                        return;
                    }
                    Import(tableStr, filePathStr);
                }
            }
            else
            {
                Import(tableStr, filePathStr);
            }
        }

        /// <summary>
        /// 数据导入
        /// </summary>
        private void Import(string tableName,string filePath)
        {
            if (this.radioYes.Checked)
            {
                var mbConfirm = MessageBox.Show("您确定要在导入时生成数据唯一标识(FGUID字段)吗？如果不需要，请取消选择后再试。", "确认信息", MessageBoxButtons.OKCancel);

                if (mbConfirm == DialogResult.Cancel) return;
            }
           
            try
            {
                DataSet ds = new DataSet();
                string readFileStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source =" + filePath + ";Extended Properties=Excel 8.0";

                using (OleDbConnection rfConn = new OleDbConnection(readFileStr))
                {
                    rfConn.Open();

                    DataTable rfdt = rfConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    //由于是单个表导入，只读一个sheet
                    string sheet = rfdt.Rows[0]["TABLE_NAME"].ToString().Trim();
                    OleDbDataAdapter adapter = new OleDbDataAdapter("select * from [" + sheet + "]", rfConn);
                    adapter.Fill(ds);

                    if (ds == null)
                    {
                        this.txtStatus.Show();
                        this.txtStatus.Text = "读取数据失败！";
                        rfConn.Close();
                        return;
                    }
                    DataTable dt = ds.Tables[0];
                    //添加数据唯一标识
                    if (this.radioYes.Checked)
                    {
                        if (!dt.Columns.Contains("FGUID"))
                        {
                            dt.Columns.Add("FGUID", typeof(string));
                        }
                        foreach (DataRow row in dt.Rows)
                        {
                            row["FGUID"] = Guid.NewGuid().ToString("N");
                        }
                    }

                    rfConn.Close();
                }

                ResultModel result = DbHelperOra.Import(ds.Tables[0], tableName, connectionString);

                this.txtStatus.Text = result.Message;

                if (result.Error)
                {
                    return;
                }
                if (!result.IsAllSucceed)
                {
                    this.listBox1.Hide();
                    this.dataGridView1.DataSource = result.FailedData;
                    this.dataGridView1.Show();
                }
            }
            catch (Exception ex)
            {
                //TODO:记录日志
                this.txtStatus.Text = "检测到异常=>" + ex.Message;
            }
        }
        #endregion

    }
}
