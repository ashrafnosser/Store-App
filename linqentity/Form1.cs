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
    public partial class Form1 : Form
    {
        Cfirst ent;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gridupdate();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                store so = new store();
                ent = new Cfirst();
                so.storeId = int.Parse(storedId.Text);
                so.name = storedName.Text;
                so.address = storedAddress.Text;
                so.admnistrator = storedAdminstrator.Text;
               
                ent.stores.Add(so);
                ent.SaveChanges();
                storedId.Text = storedName.Text = storedAddress.Text = storedAdminstrator.Text 
                    = string.Empty;
                gridupdate();



            }
            catch (Exception)
            {
                MessageBox.Show("can't add 2 stores witn the same id");
            }
        }
        private void gridupdate()
        {
            ent = new Cfirst();
            dataGridView1.DataSource = ent.stores.ToList();
            dataGridView1.Columns["varieties"].Visible = false;

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                ent = new Cfirst();
                int id = int.Parse(storedId.Text);
                store so = (from en in ent.stores where en.storeId == id select en).FirstOrDefault();
                so.name = storedName.Text == string.Empty ? so.name : storedName.Text;
                so.address = storedAddress.Text == string.Empty ? so.address : storedAddress.Text;
                so.admnistrator = storedAdminstrator.Text == string.Empty ? so.admnistrator : storedAdminstrator.Text;
                ent.SaveChanges();
                gridupdate();
            }
            catch (Exception)
            {

                MessageBox.Show("Fault in data entry");
            }
      
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                ent = new Cfirst();
                int id = int.Parse(storedId.Text);
                store so = (from en in ent.stores where en.storeId == id select en).FirstOrDefault();
                ent.stores.Remove(so);
                ent.SaveChanges();
                gridupdate();
            }
            catch (Exception)
            {

                MessageBox.Show("Fault in data entry");
            }
         
        }
    }
}
