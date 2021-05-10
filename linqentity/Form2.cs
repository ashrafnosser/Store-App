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
    public partial class Form2 : Form
    {
        Cfirst ent;
        public Form2()
        {
            InitializeComponent();
        }
        private void gridupdate()
        {
            ent = new Cfirst();
            dataGridView1.DataSource = ent.Varieties.ToList();
            dataGridView1.Columns["store"].Visible = false;

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            gridupdate();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                Variety vi = new Variety();
                ent = new Cfirst();
                vi.code = int.Parse(varietiesCode.Text);
                vi.vName = variatiesName.Text;
                vi.measruingUnit = messurementUnit.Text;
                vi.storeID = int.Parse(storedId.Text);
                vi.quantity = int.Parse(qantity.Text);
                vi.productionDate = DateTime.Parse(productionDate.Text);
                vi.supplier = supplierName.Text;
                vi.expire = int.Parse(expire.Text);
                ent.Varieties.Add(vi);
                varietiesCode.Text = variatiesName.Text = messurementUnit.Text = storedId.Text
                    = string.Empty;
                ent.SaveChanges();
                gridupdate();
            }
            catch (Exception)
            {

                MessageBox.Show("fault in data entering");
            }
         

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                ent = new Cfirst();
                int code = int.Parse(varietiesCode.Text);
                Variety vi = (from em in ent.Varieties where em.code == code select em).FirstOrDefault();
                vi.code = varietiesCode.Text == string.Empty ? vi.code : int.Parse(varietiesCode.Text);
                vi.vName = variatiesName.Text == string.Empty ? vi.vName : variatiesName.Text;
                vi.measruingUnit = messurementUnit.Text == string.Empty ? vi.measruingUnit :
                      messurementUnit.Text;
                vi.supplier = supplierName.Text == string.Empty ? vi.supplier : supplierName.Text;
                vi.productionDate = productionDate.Text == string.Empty ? vi.productionDate :
                   DateTime.Parse(productionDate.Text);
                vi.quantity = qantity.Text == string.Empty ? vi.quantity : int.Parse(qantity.Text);
                vi.expire = expire.Text == string.Empty ? vi.expire : int.Parse(expire.Text);

                vi.storeID = storedId.Text == string.Empty ? vi.storeID : int.Parse(storedId.Text);
                ent.SaveChanges();
                gridupdate();
            }
            catch (Exception)
            {
                MessageBox.Show("problem with the data");
                
            }
           

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                ent = new Cfirst();
                int id = int.Parse(varietiesCode.Text);
                Variety vi = (from em in ent.Varieties where em.code == id select em).FirstOrDefault();
                ent.Varieties.Remove(vi);
                ent.SaveChanges();
                gridupdate();
            }
            catch (Exception)
            {
                MessageBox.Show("problem in Data entry");
            }
      
        }

        private void variatiesName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
