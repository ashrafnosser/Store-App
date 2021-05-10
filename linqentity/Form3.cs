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
    public partial class Form3 : Form
    {
        Cfirst ent = new Cfirst();
        public Form3()
        {
            InitializeComponent();
        }
        private void gridupdate()
        {
            ent = new Cfirst();
            dataGridView1.DataSource = ent.Suppliers.ToList();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            gridupdate();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                ent = new Cfirst();
                Supplier sp = new Supplier();
                sp.supplierId = int.Parse(supplierId.Text);
                sp.telephone = supplierphone.Text;
                sp.fax = supplierFax.Text;
                sp.Email = supplierEmail.Text;
                sp.Mobile = supplierMobile.Text;
                sp.Name = name.Text;
                sp.website = supplierWebsite.Text;
                ent.Suppliers.Add(sp);
                ent.SaveChanges();
                supplierId.Text = supplierMobile.Text = supplierphone.Text = supplierFax.Text =
                    supplierEmail.Text = supplierWebsite.Text = string.Empty;
                gridupdate();
            }
            catch (Exception)
            {

                MessageBox.Show("problem with data entry");
            }
         
                }

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                ent = new Cfirst();
                int id = int.Parse(supplierId.Text);
                Supplier sp = (from em in ent.Suppliers where em.supplierId == id select em).FirstOrDefault();
                sp.telephone = supplierphone.Text == string.Empty ? sp.telephone : supplierphone.Text;
                sp.fax = supplierFax.Text == string.Empty ? sp.fax : supplierFax.Text;
                sp.Mobile = supplierMobile.Text == string.Empty ? sp.Mobile : supplierMobile.Text;
                sp.Email = supplierEmail.Text == string.Empty ? sp.Email : supplierEmail.Text;
                sp.Name = name.Text == string.Empty ? sp.Name : name.Text;
                sp.website = supplierWebsite.Text == string.Empty ? sp.website : supplierWebsite.Text;
                ent.SaveChanges();
                gridupdate();
            }
            catch (Exception)
            {
                MessageBox.Show("problem with data entry");
            }
    
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                ent = new Cfirst();
                int id = int.Parse(supplierId.Text);
                Supplier sp = (from en in ent.Suppliers where en.supplierId == id select en).FirstOrDefault();
                ent.Suppliers.Remove(sp);
                ent.SaveChanges();
                gridupdate();
            }
            catch (Exception)
            {
                MessageBox.Show("problem with data entry");
            }
       
        }
    }
}
