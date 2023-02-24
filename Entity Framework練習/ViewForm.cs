using Entity_Framework練習.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_Framework練習
{
    public partial class ViewForm : Form
    {
        public ViewForm()
        {
            InitializeComponent();
            BindData();
        }
        private void BindData()
        {
            var context = new ProductModel();
            var list = context.ProductsTable.ToList();
            dataGridView1.DataSource = list;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductModel del_context = new ProductModel();
            {
                var del_ProductNumber = del_context.ProductsTable.Where(x => x.ProductNumber == (textBox1.Text.Trim()));
                del_context.ProductsTable.RemoveRange(del_ProductNumber);
                del_context.SaveChanges();
            }
            try
            {

                MessageBox.Show("刪除完成");
                textBox1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"發生錯誤{ex.ToString()}");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindData();
        }

      
    }
}
