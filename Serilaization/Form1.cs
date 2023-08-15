using System;
using System.Windows.Forms;
using System.IO;
//xml serialization
using System.Xml.Serialization;
//Binary serialization 
using System.Runtime.Serialization.Formatters.Binary;
//soap serialization
using System.Runtime.Serialization.Formatters.Soap;
//JSON serilalization
using System.Text.Json;

namespace Serilaization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnbinarywrite_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DP4-2-Aug\product.dat";
                FileStream fileStream = new FileStream(path,FileMode.Create, FileAccess.Write); 
                BinaryFormatter formatter = new BinaryFormatter();
                Product p1 = new Product();
                p1.Id = Convert.ToInt32(txtpid.Text);
                p1.Name = txtpname.Text;
                p1.Price = Convert.ToInt32(txtprice.Text);
                formatter.Serialize(fileStream, p1);
                fileStream.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnbinaryread_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DP4-2-Aug\product.dat";
                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryFormatter formatter = new BinaryFormatter();
                Product p1 = new Product();
                // we done explicit type casting from Object --> Product
                p1 = (Product)formatter.Deserialize(fileStream);
                txtpid.Text = p1.Id.ToString();
                txtpname.Text = p1.Name;
                txtprice.Text = p1.Price.ToString();

                fileStream.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnxmlwrite_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DP4-2-Aug\product.xml";
                FileStream fileStream = new FileStream(path,FileMode.Create, FileAccess.Write); 
                XmlSerializer xmlSerializer =new XmlSerializer(typeof(Product));
                Product p1 = new Product();
                p1.Id = Convert.ToInt32(txtpid.Text);
                p1.Name = txtpname.Text;
                p1.Price = Convert.ToInt32(txtprice.Text);
                xmlSerializer.Serialize(fileStream, p1);
                fileStream.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnxmlread_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DP4-2-Aug\product.xml";
                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                XmlSerializer serializer = new XmlSerializer(typeof(Product));  
                Product p1 = new Product();
                // we done explicit type casting from Object --> Product
                p1 = (Product)serializer.Deserialize(fileStream);
                txtpid.Text = p1.Id.ToString();
                txtpname.Text = p1.Name;
                txtprice.Text = p1.Price.ToString();

                fileStream.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsoapwrite_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DP4-2-Aug\product.soap";
                FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                SoapFormatter soapFormatter = new SoapFormatter();
                Product p1 = new Product();
                p1.Id = Convert.ToInt32(txtpid.Text);
                p1.Name = txtpname.Text;
                p1.Price = Convert.ToInt32(txtprice.Text);
                soapFormatter.Serialize(fileStream, p1);
                fileStream.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsoapread_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DP4-2-Aug\product.soap";
                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                SoapFormatter soapFormatter = new SoapFormatter();
                Product p1 = new Product();
                // we done explicit type casting from Object --> Product
                p1 = (Product)soapFormatter.Deserialize(fileStream);
                txtpid.Text = p1.Id.ToString();
                txtpname.Text = p1.Name;
                txtprice.Text = p1.Price.ToString();

                fileStream.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnjasonwrite_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DP4-2-Aug\product.json";
                FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                Product p1 = new Product();
                p1.Id = Convert.ToInt32(txtpid.Text);
                p1.Name = txtpname.Text;
                p1.Price = Convert.ToInt32(txtprice.Text);
                JsonSerializer.Serialize<Product>(fileStream,p1);
                fileStream.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnjsonread_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DP4-2-Aug\product.json";
                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                Product p1 = new Product();
                // we done explicit type casting from Object --> Product
                p1=JsonSerializer.Deserialize<Product>(fileStream);
                txtpid.Text = p1.Id.ToString();
                txtpname.Text = p1.Name;
                txtprice.Text = p1.Price.ToString();

                fileStream.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
