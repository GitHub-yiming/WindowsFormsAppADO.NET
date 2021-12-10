namespace WindowsFormsAppADO.NET
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableNumber1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberofLayersIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controlAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portdiectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableNumbers1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableNumbers1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tableNumber1DataGridViewTextBoxColumn,
            this.numberofLayersIdDataGridViewTextBoxColumn,
            this.controlAddressDataGridViewTextBoxColumn,
            this.portdiectionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableNumbers1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1239, 456);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // tableNumber1DataGridViewTextBoxColumn
            // 
            this.tableNumber1DataGridViewTextBoxColumn.DataPropertyName = "Table_Number1";
            this.tableNumber1DataGridViewTextBoxColumn.HeaderText = "表号";
            this.tableNumber1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tableNumber1DataGridViewTextBoxColumn.Name = "tableNumber1DataGridViewTextBoxColumn";
            this.tableNumber1DataGridViewTextBoxColumn.Width = 125;
            // 
            // numberofLayersIdDataGridViewTextBoxColumn
            // 
            this.numberofLayersIdDataGridViewTextBoxColumn.DataPropertyName = "NumberofLayersId";
            this.numberofLayersIdDataGridViewTextBoxColumn.HeaderText = "楼层";
            this.numberofLayersIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberofLayersIdDataGridViewTextBoxColumn.Name = "numberofLayersIdDataGridViewTextBoxColumn";
            this.numberofLayersIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // controlAddressDataGridViewTextBoxColumn
            // 
            this.controlAddressDataGridViewTextBoxColumn.DataPropertyName = "ControlAddress";
            this.controlAddressDataGridViewTextBoxColumn.HeaderText = "继电器地址";
            this.controlAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.controlAddressDataGridViewTextBoxColumn.Name = "controlAddressDataGridViewTextBoxColumn";
            this.controlAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // portdiectionDataGridViewTextBoxColumn
            // 
            this.portdiectionDataGridViewTextBoxColumn.DataPropertyName = "Port_diection";
            this.portdiectionDataGridViewTextBoxColumn.HeaderText = "端口号";
            this.portdiectionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.portdiectionDataGridViewTextBoxColumn.Name = "portdiectionDataGridViewTextBoxColumn";
            this.portdiectionDataGridViewTextBoxColumn.Width = 125;
            // 
            // tableNumbers1BindingSource
            // 
            this.tableNumbers1BindingSource.DataSource = typeof(WindowsFormsAppADO.NET.Table_Numbers1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(255, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "刷新";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(93, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 31);
            this.button3.TabIndex = 1;
            this.button3.Text = "编辑";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(174, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 31);
            this.button4.TabIndex = 2;
            this.button4.Text = "删除";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 522);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableNumbers1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tableNumbers1BindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableNumber1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberofLayersIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn controlAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn portdiectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

