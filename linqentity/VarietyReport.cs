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
    public partial class VarietyReport : Form
    {
        Cfirst ent;
        public VarietyReport()
        {
            InitializeComponent();
        }

        private void VarietyReport_Load(object sender, EventArgs e)
        {
            ent =new Cfirst();
            var va = from em in ent.Varieties select em;
            foreach (var item in va)
            {
                vName.Items.Add(item.vName);
            }

        }

        private void vName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ent = new Cfirst();
            var v = from em in ent.Varieties where em.vName == vName.Text select em;
         
            foreach (var item in v)
            {
                storeName.Items.Clear();
                var so = from em in ent.stores where em.storeId == item.storeID select em;
                foreach (var i in so)
                {
                    storeName.Items.Add(i.name);
                }
           
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void storeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ent = new Cfirst();
            var v = (from em in ent.Varieties where em.vName == vName.Text select em).ToList();
            dataGridView1.DataSource = v;
            dataGridView1.Columns["store"].Visible = false;

        }
    }
}
