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
    public partial class varitiesSituation : Form
    {
        Cfirst ent;
        public varitiesSituation()
        {
            InitializeComponent();
        }

        private void varitiesSituation_Load(object sender, EventArgs e)
        {
            ent = new Cfirst();
            var sp = from em in ent.Varieties_supplypermessions select em;
            foreach (var item in sp)
            {
                varietyName.Items.Add(item.Varieties);
            }
        }

        private void storeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ent = new Cfirst();
            var sp = (from em in ent.supplyPermessions where em.Storename == storeName.Text select em).ToList();
            dataGridView1.DataSource = sp;
            dataGridView1.Columns["Varieties_supplypermessions"].Visible = false;


        }

        private void varietyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ent = new Cfirst();
            Varieties_supplypermessions vsp = (from em in ent.Varieties_supplypermessions
                                               where em.Varieties == varietyName.Text
                                               select em).First();
            int si = vsp.SupplyId;
            var sp = (from en in ent.supplyPermessions where en.SuplyId == si select en);
            storeName.Items.Clear();
            foreach (var item in sp)
            {
                storeName.Items.Add(item.Storename);
            }
        }
    }
}
