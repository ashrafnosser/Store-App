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
    public partial class Form6 : Form
    {
        Cfirst ent;
        public Form6()
        {
            InitializeComponent();
        }
        private void gridupdate()
        {
            try
            {
                ent = new Cfirst();
                dataGridView1.DataSource = ent.DismissalPermissions.ToList();
                dataGridView2.DataSource = ent.Varieties_Dismissalpermessions.ToList();
                dataGridView1.Columns["Varieties_Dismissalpermessions"].Visible = false;
                dataGridView2.Columns["DismissalPermission"].Visible = false;
            }
            catch (Exception)
            {

                MessageBox.Show("something wrong in data entry");
            }
          

        }
        private void Form6_Load(object sender, EventArgs e)
        {
            gridupdate();
            ent = new Cfirst();
            var so = from em in ent.stores select em;
            foreach (var s in so)
            {
                storeName.Items.Add(s.name);
            }
        
    }

        private void btAddP_Click(object sender, EventArgs e)
        {
            try
            {
                ent = new Cfirst();
                DismissalPermission dp = new DismissalPermission();
                Varieties_Dismissalpermessions vdp = new Varieties_Dismissalpermessions();

                int id = int.Parse(dissmalId.Text);
                Varieties_supplypermessions vsp = (from en in ent.Varieties_supplypermessions
                                                   where en.SupplyId == id
                                                   select en).FirstOrDefault();
                vsp.quantities = vsp.quantities - int.Parse(varietiesQuantity.Text);
                vdp.dismissalId = int.Parse(dissmalId.Text);
                vdp.Varieties = variatiesName.Text;
                vdp.quantities = int.Parse(varietiesQuantity.Text);
                dp.supplieName = customerName.Text;
                dp.dismissalId = int.Parse(dissmalId.Text);
                dp.history = DateTime.Parse(permissionDate.Text);
                dp.Storename = storeName.Text;
                dp.ptoductionHistory = DateTime.Parse(productionHistory.Text);
                dp.expiry = expiry.Text;
                ent.Varieties_Dismissalpermessions.Add(vdp);
                ent.DismissalPermissions.Add(dp);
                ent.SaveChanges();
                gridupdate();
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

                MessageBox.Show("something wrong in data entry");

            }
           
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                ent = new Cfirst();
                int id = int.Parse(dissmalId.Text);
                DismissalPermission sp = (from em in ent.DismissalPermissions
                                          where em.dismissalId == id
                                          select em).FirstOrDefault();

                var vsp = (from en in ent.Varieties_Dismissalpermessions
                           where en.dismissalId == id
                           select en).FirstOrDefault();


                sp.supplieName = customerName.Text == String.Empty ? sp.supplieName : customerName.Text;
                vsp.Varieties = variatiesName.Text == string.Empty ? vsp.Varieties : variatiesName.Text;
                vsp.quantities = varietiesQuantity.Text == string.Empty ? vsp.quantities :
                    int.Parse(varietiesQuantity.Text);
                sp.expiry = expiry.Text == string.Empty ? sp.expiry : expiry.Text;
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

                MessageBox.Show("somethin is wrong");
            }
                  
        }
    }
}
