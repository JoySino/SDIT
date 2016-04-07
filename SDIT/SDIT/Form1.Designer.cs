namespace SDIT
{
    partial class MianForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MianForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.showPassword = new System.Windows.Forms.CheckBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.defaultPort = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIpAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDBName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioYes = new System.Windows.Forms.RadioButton();
            this.radioNo = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.filePath = new System.Windows.Forms.Label();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.txtItems = new System.Windows.Forms.TextBox();
            this.selectTable = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.chBoxClear = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.showPassword);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.defaultPort);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIpAddress);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDBName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据库连接参数";
            // 
            // showPassword
            // 
            this.showPassword.AutoSize = true;
            this.showPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.showPassword.Location = new System.Drawing.Point(436, 77);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(48, 16);
            this.showPassword.TabIndex = 6;
            this.showPassword.Text = "显示";
            this.showPassword.UseVisualStyleBackColor = true;
            this.showPassword.CheckedChanged += new System.EventHandler(this.showPassword_CheckedChanged);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(383, 26);
            this.txtPort.MaxLength = 10;
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(61, 21);
            this.txtPort.TabIndex = 3;
            this.txtPort.Text = "1521";
            this.txtPort.Visible = false;
            this.txtPort.WordWrap = false;
            this.txtPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.port_KeyPress);
            this.txtPort.Leave += new System.EventHandler(this.generateConnectionString);
            // 
            // defaultPort
            // 
            this.defaultPort.AutoSize = true;
            this.defaultPort.Checked = true;
            this.defaultPort.CheckState = System.Windows.Forms.CheckState.Checked;
            this.defaultPort.ForeColor = System.Drawing.SystemColors.ControlText;
            this.defaultPort.Location = new System.Drawing.Point(383, 30);
            this.defaultPort.Name = "defaultPort";
            this.defaultPort.Size = new System.Drawing.Size(120, 16);
            this.defaultPort.TabIndex = 3;
            this.defaultPort.Text = "默认端口（1521）";
            this.defaultPort.UseVisualStyleBackColor = true;
            this.defaultPort.CheckedChanged += new System.EventHandler(this.defaultPort_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(299, 74);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(119, 21);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.WordWrap = false;
            this.txtPassword.Leave += new System.EventHandler(this.generateConnectionString);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(263, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "密码";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(75, 74);
            this.txtUserName.MaxLength = 50;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(137, 21);
            this.txtUserName.TabIndex = 4;
            this.txtUserName.WordWrap = false;
            this.txtUserName.Leave += new System.EventHandler(this.generateConnectionString);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(28, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "用户名";
            // 
            // txtIpAddress
            // 
            this.txtIpAddress.Location = new System.Drawing.Point(240, 27);
            this.txtIpAddress.MaxLength = 15;
            this.txtIpAddress.Name = "txtIpAddress";
            this.txtIpAddress.Size = new System.Drawing.Size(127, 21);
            this.txtIpAddress.TabIndex = 2;
            this.txtIpAddress.WordWrap = false;
            this.txtIpAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IpAddress_KeyPress);
            this.txtIpAddress.Leave += new System.EventHandler(this.generateConnectionString);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(192, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "IP地址";
            // 
            // txtDBName
            // 
            this.txtDBName.Location = new System.Drawing.Point(75, 27);
            this.txtDBName.MaxLength = 30;
            this.txtDBName.Name = "txtDBName";
            this.txtDBName.Size = new System.Drawing.Size(104, 21);
            this.txtDBName.TabIndex = 1;
            this.txtDBName.WordWrap = false;
            this.txtDBName.Leave += new System.EventHandler(this.generateConnectionString);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "实例名";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.chBoxClear);
            this.groupBox2.Controls.Add(this.txtStatus);
            this.groupBox2.Controls.Add(this.radioYes);
            this.groupBox2.Controls.Add(this.radioNo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnImport);
            this.groupBox2.Controls.Add(this.filePath);
            this.groupBox2.Controls.Add(this.btnSelectFile);
            this.groupBox2.Controls.Add(this.btnAddItem);
            this.groupBox2.Controls.Add(this.txtItems);
            this.groupBox2.Controls.Add(this.selectTable);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(12, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(510, 180);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "导入表";
            // 
            // radioYes
            // 
            this.radioYes.AutoSize = true;
            this.radioYes.Checked = true;
            this.radioYes.Location = new System.Drawing.Point(222, 71);
            this.radioYes.Name = "radioYes";
            this.radioYes.Size = new System.Drawing.Size(35, 16);
            this.radioYes.TabIndex = 4;
            this.radioYes.TabStop = true;
            this.radioYes.Text = "是";
            this.radioYes.UseVisualStyleBackColor = true;
            // 
            // radioNo
            // 
            this.radioNo.AutoSize = true;
            this.radioNo.Location = new System.Drawing.Point(263, 71);
            this.radioNo.Name = "radioNo";
            this.radioNo.Size = new System.Drawing.Size(35, 16);
            this.radioNo.TabIndex = 5;
            this.radioNo.Text = "否";
            this.radioNo.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "是否在导入时生成数据唯一标识：";
            // 
            // btnImport
            // 
            this.btnImport.Enabled = false;
            this.btnImport.Location = new System.Drawing.Point(32, 142);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 7;
            this.btnImport.Text = "数据入库";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // filePath
            // 
            this.filePath.AutoSize = true;
            this.filePath.Location = new System.Drawing.Point(119, 107);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(131, 12);
            this.filePath.TabIndex = 0;
            this.filePath.Text = "请选择要导入的数据...";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(32, 102);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFile.TabIndex = 6;
            this.btnSelectFile.Text = "选择文件";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.selectFile_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddItem.Location = new System.Drawing.Point(217, 31);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddItem.TabIndex = 3;
            this.btnAddItem.Text = "添加表选项";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // txtItems
            // 
            this.txtItems.Location = new System.Drawing.Point(299, 32);
            this.txtItems.Name = "txtItems";
            this.txtItems.Size = new System.Drawing.Size(185, 21);
            this.txtItems.TabIndex = 2;
            this.txtItems.Tag = "";
            // 
            // selectTable
            // 
            this.selectTable.FormattingEnabled = true;
            this.selectTable.Location = new System.Drawing.Point(75, 33);
            this.selectTable.Name = "selectTable";
            this.selectTable.Size = new System.Drawing.Size(137, 20);
            this.selectTable.TabIndex = 1;
            this.selectTable.SelectedIndexChanged += new System.EventHandler(this.selectTable_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "选择表";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(12, 319);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(510, 186);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "表结构";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(6, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(497, 148);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(497, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Visible = false;
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.SystemColors.Control;
            this.txtStatus.ForeColor = System.Drawing.Color.Red;
            this.txtStatus.Location = new System.Drawing.Point(121, 144);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(382, 21);
            this.txtStatus.TabIndex = 8;
            this.txtStatus.Text = "等待入库...";
            this.txtStatus.WordWrap = false;
            // 
            // chBoxClear
            // 
            this.chBoxClear.AutoSize = true;
            this.chBoxClear.Checked = true;
            this.chBoxClear.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBoxClear.Location = new System.Drawing.Point(334, 72);
            this.chBoxClear.Name = "chBoxClear";
            this.chBoxClear.Size = new System.Drawing.Size(96, 16);
            this.chBoxClear.TabIndex = 9;
            this.chBoxClear.Text = "清空表中数据";
            this.chBoxClear.UseVisualStyleBackColor = true;
            // 
            // MianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(534, 510);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MianForm";
            this.Text = "Simple Data Import Tool";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIpAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDBName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.CheckBox defaultPort;
        private System.Windows.Forms.CheckBox showPassword;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.TextBox txtItems;
        private System.Windows.Forms.ComboBox selectTable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Label filePath;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioNo;
        private System.Windows.Forms.RadioButton radioYes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.CheckBox chBoxClear;
    }
}

