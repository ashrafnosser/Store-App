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
    public partial class storesReport : Form
    {
        Cfirst ent;
        public storesReport()
        {
            InitializeComponent();
        }

        private void storesReport_Load(object sender, EventArgs e)
        {
            ent = new Cfirst();
            var so=from em in ent.stores select em;
            foreach (var item in so)
            {
                storeName.Items.Add(item.name);
            }

        }

        private void storeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ent = new Cfirst();
            store so = (from em in ent.stores where em.name == storeName.Text select em).First();
            address.Text = so.address;
            adminstrator.Text = so.admnistrator;
            int id = so.storeId;
            var vr = (from en in ent.Varieties where en.storeID == id select en).ToList();
            dataGridView1.DataSource = vr;
            dataGridView1.Columns["store"].Visible = false;

        }
    }
}
