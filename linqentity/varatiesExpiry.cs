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
    public partial class varatiesExpiry : Form
    {
        Cfirst ent;
        public varatiesExpiry()
        {
            InitializeComponent();
        }

        private void varatiesExpiry_Load(object sender, EventArgs e)
        {
            ent = new Cfirst();
            DateTime dateTime = DateTime.Today;
            var vi = from em in ent.Varieties select em;
            foreach (var item in vi)
            {
                System.TimeSpan diff = dateTime.Subtract((DateTime)item.productionDate);
               int s= (int)diff.Days;
                int result= (int)(s - item.expire);
                if (result <= 60)
                {
                    if (result <= 0)
                    {
                        varietyName.Items.Add(item.vName + " Expiry End");

                    }
                    else
                    {
                        varietyName.Items.Add(item.vName + " " + result);
                    }
                }
            }
            dataGridView1.DataSource = vi.ToList();
            dataGridView1.Columns["store"].Visible = false;

        }

        private void varietyName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
