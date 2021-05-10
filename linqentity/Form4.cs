using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linqentity
{
    public partial class Form4 : Form
    {
        Cfirst ent = new Cfirst();
        public Form4()
        {
            InitializeComponent();
        }
        private void gridupdate()
        {
            ent = new Cfirst();
            dataGridView1.DataSource = ent.Customers.ToList();
        }
        
        private void Form4_Load(object sender, EventArgs e)
        {
            gridupdate();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                ent = new Cfirst();
                Customer cu = new Customer();
                cu.customerId = int.Parse(customerId.Text);
                cu.telephone = customerphone.Text;
                cu.fax = customerFax.Text;
                cu.Mobile = customerMobile.Text;
                cu.Email = customerEmail.Text;
                cu.Name = name.Text;
                cu.website = customerWebsite.Text;
                ent.Customers.Add(cu);
                ent.SaveChanges();
                customerId.Text = customerEmail.Text = customerFax.Text = customerMobile.Text =
                customerphone.Text = customerWebsite.Text = string.Empty;
                gridupdate();
            }
            catch (Exception)
            {

                MessageBox.Show("fault in data entry");
            }
      
           

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                ent = new Cfirst();
                int id = int.Parse(customerId.Text);
                Customer cu = (from em in ent.Customers where em.customerId == id select em).FirstOrDefault();
                cu.telephone = customerphone.Text == string.Empty ? cu.telephone : customerphone.Text;
                cu.fax = customerFax.Text == string.Empty ? cu.fax : customerFax.Text;
                cu.Mobile = customerMobile.Text == string.Empty ? cu.Mobile : customerMobile.Text;
                cu.Email = customerEmail.Text == string.Empty ? cu.Email : customerEmail.Text;
                cu.Name = name.Text == string.Empty ? cu.Name : name.Text;
                cu.website = customerWebsite.Text == string.Empty ? cu.website : customerWebsite.Text;
                ent.SaveChanges();
                gridupdate();
            }
            catch (Exception)
            {
                MessageBox.Show("fault in data entry");
            }
         
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                ent = new Cfirst();
                int id = int.Parse(customerId.Text);
                Customer cu = (from en in ent.Customers where en.customerId == id select en).FirstOrDefault();
                ent.Customers.Remove(cu);
                ent.SaveChanges();
                gridupdate();
            }
            catch (Exception)
            {

                MessageBox.Show("error in data entry");
            }
        
        }
    }
}
