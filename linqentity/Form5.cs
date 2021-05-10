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
    public partial class Form5 : Form
    {
        Cfirst ent;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            gridupdate();
            ent = new Cfirst();
            var so = from em in ent.stores select em;
            foreach(var s in so)
            {
                storeName.Items.Add(s.name);
            }
        }

        private void btnAddV_Click(object sender, EventArgs e)
        {
            try
            {
                ent = new Cfirst();
                Varieties_supplypermessions vsp = new Varieties_supplypermessions();
                vsp.SupplyId = int.Parse(supplyId.Text);
                vsp.Varieties = variatiesName.Text;
                vsp.quantities = int.Parse(varietiesQuantity.Text);
                ent.Varieties_supplypermessions.Add(vsp);
                ent.SaveChanges();

            }
            catch (Exception)
            {

                MessageBox.Show("something went wrong in data entry");
            }
      



        }
        private void gridupdate()
        {
            try
            {
                ent = new Cfirst();
                dataGridView1.DataSource = ent.supplyPermessions.ToList();

                ent = new Cfirst();
                dataGridView2.DataSource = ent.Varieties_supplypermessions.ToList();
                dataGridView1.Columns["Varieties_supplypermessions"].Visible = false;
                dataGridView2.Columns["supplyPermession"].Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("something wrong in data entry");

            }
  

        }
        private void storeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ent = new Cfirst();
                store so = (from em in ent.stores where em.name == storeName.Text select em).FirstOrDefault();
                var va = from em in ent.Varieties where em.storeID == so.storeId select em;
                variatiesName.Items.Clear();
                foreach (var i in va)
                {
                    variatiesName.Items.Add(i.vName);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("something went wrong in dataEntry");
            }
           
        }

        private void btAddP_Click(object sender, EventArgs e)
        {
            try
            {
                ent = new Cfirst();
                supplyPermession sp = new supplyPermession();
                Varieties_supplypermessions vsp = new Varieties_supplypermessions();
                vsp.SupplyId = int.Parse(supplyId.Text);
                vsp.Varieties = variatiesName.Text;
                vsp.quantities = int.Parse(varietiesQuantity.Text);
                sp.SuplyId = int.Parse(supplyId.Text);
                sp.supplieName = supplierName.Text;
                sp.history = DateTime.Parse(permissionDate.Text);
                sp.Storename = storeName.Text;
                sp.supplieName = supplierName.Text;
                sp.ptoductionHistory = DateTime.Parse(productionHistory.Text);
                sp.expiry = expiry.Text;
                ent.Varieties_supplypermessions.Add(vsp);
                ent.supplyPermessions.Add(sp);
                ent.SaveChanges();
                gridupdate();
            }
            catch (Exception)
            {

                MessageBox.Show("Problem in Data Entry");
            }
       
        }

        private void button1_Click(object sender, EventArgs e)
        { 
         

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                    ent = new Cfirst();


                    int id = int.Parse(supplyId.Text);
                    supplyPermession sp = (from em in ent.supplyPermessions
                                            where
                  em.SuplyId == id
                                            select em).FirstOrDefault();

                    Varieties_supplypermessions vsp = (from en in ent.Varieties_supplypermessions
                                                        where
                   en.SupplyId == id
                                                        select en).FirstOrDefault();
                    sp.supplieName = supplierName.Text == String.Empty ? sp.supplieName : supplierName.Text;
                    vsp.Varieties = variatiesName.Text == string.Empty ? vsp.Varieties : variatiesName.Text;
                    vsp.quantities = varietiesQuantity.Text == string.Empty ? vsp.quantities :
                        int.Parse(varietiesQuantity.Text);
                    sp.expiry = expiry.Text == string.Empty ? sp.expiry : expiry.Text;
                    sp.supplieName = supplierName.Text == string.Empty ? sp.supplieName : supplierName.Text;
                    sp.history = permissionDate.Text == string.Empty ? sp.history :
                        DateTime.Parse(permissionDate.Text);
                    sp.ptoductionHistory = productionHistory.Text == string.Empty ? sp.ptoductionHistory :
                        DateTime.Parse(productionHistory.Text);
                    sp.Storename = storeName.Text == string.Empty ? sp.supplieName : storeName.Text;
                    ent.SaveChanges();
                    gridupdate();
            }
            catch (Exception)
            {

                MessageBox.Show("Somethig went wrong in Data Entry");
            }
          
        }
    }
}
