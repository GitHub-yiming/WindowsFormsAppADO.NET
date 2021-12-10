using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppADO.NET
{
    public partial class Form2 : Form
    {
        Calorimeter1Entities db = new Calorimeter1Entities();
        public Form2(Table_Numbers1 obj)
        {
            InitializeComponent();
            if(obj == null)
            {
                tableNumbers1BindingSource.DataSource = new Table_Numbers1();
                db.Table_Numbers1.Add(tableNumbers1BindingSource.Current as Table_Numbers1);
            }
            else
            {
                tableNumbers1BindingSource.DataSource = obj;
                db.Table_Numbers1.Attach(tableNumbers1BindingSource.Current as Table_Numbers1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //using (var db = new Calorimeter1Entities())
            //{
            //    var blog = new Table_Numbers1
            //    {
            //        Table_Number1 = textBox1.Text,
            //        NumberofLayersId = Convert.ToInt32(textBox2.Text),
            //        ControlAddress = textBox3.Text,
            //        Port_diection = textBox4.Text
            //    };
            //    db.Table_Numbers1.Add(blog);
            //    db.SaveChanges();
            //}
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                db.SaveChanges();
                e.Cancel = false;
            }
            e.Cancel = false;
        }
    }
}
