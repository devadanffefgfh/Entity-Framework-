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
    public partial class QueryForm : Form
    {
        public QueryForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductModel query_conext = new ProductModel();
            
            var products = query_conext.ProductsTable.ToList();//將資料庫的資料放到記憶體


            
            if(!string.IsNullOrEmpty(textBox1.Text) )
            {
                products = products.Where(x => x.ProductNumber == textBox1.Text.Trim()).ToList();
                //var Query_ProductNumber =query_conext.ProductsTable.Where(x=>x.ProductNumber ==textBox1.Text.Trim()).ToList();
                //dataGridView1.DataSource = Query_ProductNumber;
            }
            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                products = products.Where(x => x.ProductName == textBox2.Text.Trim()).ToList();
                //var Query_ProductName = query_conext.ProductsTable.Where(x => x.ProductName == textBox2.Text.Trim()).ToList();
                //dataGridView1.DataSource = Query_ProductName;
            }
            
            if (!string.IsNullOrEmpty(textBox3.Text))
            {
                products = products.Where(x => x.AmountOfProducts == int.Parse(textBox3.Text.Trim())).ToList();
                //var Query_AmountProduct = products.Where(x =>x.AmountOfProducts  == int.Parse(textBox3.Text.Trim()) ).ToList();
                //dataGridView1.DataSource = Query_AmountProduct;
            }

            
            if (!string.IsNullOrEmpty(textBox4.Text))
            {
                products = products.Where(x => x.ProductPrice == decimal.Parse(textBox4.Text.Trim())).ToList();
                //var Query_ProductPrice = products.Where(x => x.ProductPrice == decimal.Parse(textBox4.Text.Trim())).ToList();
                //dataGridView1.DataSource = Query_ProductPrice;
            }
            
           
            if (!string.IsNullOrEmpty(textBox5.Text))
            {
                products = products.Where(x => x.ProductCategory == textBox5.Text.Trim()).ToList();
                //var Query_ProductCategory = query_conext.ProductsTable.Where(x => x.ProductCategory == textBox5.Text.Trim()).ToList();
                //dataGridView1.DataSource = Query_ProductCategory;
            }
            dataGridView1.DataSource= products;
            
            MessageBox.Show("查詢成功");
            
           
        }
       
    }
}
