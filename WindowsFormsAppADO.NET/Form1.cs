using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsAppADO.NET
{
    public partial class Form1 : Form
    {
        Calorimeter1Entities db = new Calorimeter1Entities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var db = new Calorimeter1Entities())
            {
                tableNumbers1BindingSource.DataSource = db.Table_Numbers1.ToList();
            }
        }

        //添加
        private void button1_Click(object sender, EventArgs e)
        {
            using(Form2 form2 = new Form2(null))
            {
                form2.ShowDialog();
                using (var db = new Calorimeter1Entities())
                    {
                        tableNumbers1BindingSource.DataSource = db.Table_Numbers1.ToList();
                    }
            }
        }

        //刷新
        private void button2_Click(object sender, EventArgs e)
        {
            using (var db = new Calorimeter1Entities())
            {
                tableNumbers1BindingSource.DataSource = db.Table_Numbers1.ToList();
            }

        }

        //编辑
        private void button3_Click(object sender, EventArgs e)
        {
            using (Form2 form2 = new Form2(tableNumbers1BindingSource.Current as Table_Numbers1))
            {
                form2.ShowDialog();
                using (var db = new Calorimeter1Entities())
                {
                    tableNumbers1BindingSource.DataSource = db.Table_Numbers1.ToList();
                }

            }
        }

        //删除
        private void button4_Click(object sender, EventArgs e)
        {
            using(var db = new Calorimeter1Entities())
            {
                //int i = dataGridView1.SelectedRows.Count;
                tableNumbers1BindingSource.DataSource = db.Table_Numbers1.ToList();
                if (tableNumbers1BindingSource.Current != null)
                {
                    if (MessageBox.Show("你确定要删除这条数据吗?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        db.Table_Numbers1.Remove(tableNumbers1BindingSource.Current as Table_Numbers1);
                        tableNumbers1BindingSource.RemoveCurrent();
                        db.SaveChanges();

                    }
                }
            }

        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                //添加行号 
                SolidBrush v_SolidBrush = new SolidBrush(dataGridView1.RowHeadersDefaultCellStyle.ForeColor);
                int v_LineNo = 0;
                v_LineNo = e.RowIndex + 1;

                string v_Line = v_LineNo.ToString();

                e.Graphics.DrawString(v_Line, e.InheritedRowStyle.Font, v_SolidBrush, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + 5);

            }
            catch (Exception ex)
            {
                MessageBox.Show("添加行号时发生错误，错误信息：" + ex.Message, "操作失败");
            }
        }
    }
}
