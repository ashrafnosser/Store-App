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
    public partial class Form7 : Form
    {
        Cfirst ent = new Cfirst();
        public Form7()
        {
            InitializeComponent();
        }
        private void gridupdate()
        {
            ent = new Cfirst();
            dataGridView1.DataSource = ent.transforms.ToList();
            dataGridView1.Columns["variety"].Visible = false;

        }
        private void Form7_Load(object sender, EventArgs e)
        {
            gridupdate();
            ent = new Cfirst();
            var so = from em in ent.stores select em;
            foreach (var s in so)
            {
                fromStore.Items.Add(s.name);
                toStore.Items.Add(s.name);
            }
        }

        private void from_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ent = new Cfirst();
                store so = (from en in ent.stores where en.name == fromStore.Text select en).FirstOrDefault();
                var va = from em in ent.Varieties where em.storeID == so.storeId select em;
                varieties.Items.Clear();
                foreach (var i in va)
                {
                    varieties.Items.Add(i.vName);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("something is wrong in data entry");
            }
          
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                ent = new Cfirst();
                //change quantities between tables 
                store sof = (from em in ent.stores where em.name == fromStore.Text select em).First();
                store sot = (from em in ent.stores where em.name == toStore.Text select em).First();

                Variety vf = (from em in ent.Varieties where em.storeID == sof.storeId select em).First();
                Variety vt = (from em in ent.Varieties where em.storeID == sot.storeId select em).First();
                vf.quantity = vf.quantity - int.Parse(quantity.Text);
                vt.quantity = vf.quantity - int.Parse(quantity.Text);
                transform tr = new transform();
                tr.transformid = int.Parse(transformId.Text);
                tr.sfrom = fromStore.Text;
                tr.sto = toStore.Text;
                tr.varieties = varieties.Text;
                tr.supplier = supplier.Text;
                tr.production_history = DateTime.Parse(pHistory.Text);
                tr.quantity = int.Parse(quantity.Text);
                tr.Expiry = expiry.Text;
                ent.transforms.Add(tr);
                ent.SaveChanges();
                gridupdate();
            }
            catch (Exception)
            {

                MessageBox.Show("Something wrong in Data entry");
            }
          
        }
    }
    }

