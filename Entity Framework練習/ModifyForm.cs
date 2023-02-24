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
    public partial class ModifyForm : Form
    {
        public ModifyForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductModel query_conext = new ProductModel();

            var products = query_conext.ProductsTable.ToList();//將資料庫的資料放到記憶體
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                products = products.Where(x => x.ProductNumber == textBox1.Text.Trim()).ToList();
                //var Query_ProductNumber =query_conext.ProductsTable.Where(x=>x.ProductNumber ==textBox1.Text.Trim()).ToList();
                //dataGridView1.DataSource = Query_ProductNumber;
                dataGridView1.DataSource = products;
            }
            else
            {
                MessageBox.Show("查無資料");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductModel modify_context = new ProductModel();
            var products = modify_context.ProductsTable.Where(x => x.ProductNumber == textBox1.Text.Trim()).ToList(); ;
            
            if(!string.IsNullOrEmpty(textBox2.Text))
            {
                foreach (var item in products)
                {
                    item.ProductNumber=textBox2.Text.Trim() ;
                }
            }
            if (!string.IsNullOrEmpty(textBox3.Text))
            {
                foreach (var item in products)
                {
                    item.ProductName = textBox3.Text.Trim();
                }
            }
            if (!string.IsNullOrEmpty(textBox4.Text))
            {
                foreach (var item in products)
                {
                    item.AmountOfProducts = int.Parse(textBox4.Text.Trim()) ;
                }
            }
            if (!string.IsNullOrEmpty(textBox5.Text))
            {
                foreach (var item in products)
                {
                    item.ProductPrice = decimal.Parse(textBox5.Text.Trim());
                }
            }
            if (!string.IsNullOrEmpty(textBox6.Text))
            {
                foreach (var item in products)
                {
                    item.ProductCategory = textBox6.Text.Trim();
                }
            }
            try
            {
                dataGridView1.DataSource = products;
                modify_context.SaveChanges();
                MessageBox.Show("修改成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"發生錯誤{ex.ToString()}");
            }
            
        }
    }
}
