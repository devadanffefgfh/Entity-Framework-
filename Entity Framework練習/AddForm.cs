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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductsTable data = new ProductsTable()
            {
                ProductNumber = textBox1.Text.Trim(),
                ProductName = textBox2.Text.Trim(),
                AmountOfProducts = int.Parse(textBox3.Text),
                ProductPrice = decimal.Parse(textBox4.Text),
                ProductCategory = textBox5.Text.Trim(),

            };
            try
            {
                ProductModel context = new ProductModel();
                context.ProductsTable.Add(data);
                context.SaveChanges();
                MessageBox.Show("存檔完成");
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"發生錯誤{ex.ToString()}");
            }
        }
        /*
        private void 1(object sender, EventArgs e)
        {

            
            ProductModel del_context = new ProductModel();
            {
                var del_ProductNumber = del_context.ProductsTable.Where(x => x.ProductNumber.Equals(textBox1.Text.Trim()) );
                del_context.ProductsTable.Remove((ProductsTable)del_ProductNumber);
                del_context.SaveChanges();
            }
            
            
            var del_context = new ProductModel();
            var del_ProductNumber = del_context.ProductsTable.SingleOrDefault(x => x.ProductNumber.Equals(textBox1.Text.Trim()));
            if (del_ProductNumber != null)
            {
                del_context.ProductsTable.Remove(del_ProductNumber);
                del_context.SaveChanges();
            }
            
            try
            {
            
                MessageBox.Show("刪除完成");
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"發生錯誤{ex.ToString()}");
            }
        }
        */
        private void ClearTextBoxes()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductModel del_context = new ProductModel();
            {
                var del_ProductNumber = del_context.ProductsTable.Where(x => x.ProductNumber==(textBox1.Text.Trim()));
                del_context.ProductsTable.RemoveRange(del_ProductNumber);
                del_context.SaveChanges();
            }
            try
            {

                MessageBox.Show("刪除完成");
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"發生錯誤{ex.ToString()}");
            }
        }
    }
}
