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
    public partial class VarietiesDurationReport : Form
    {
        Cfirst ent;
        public VarietiesDurationReport()
        {
            InitializeComponent();
        }

        private void VarietiesDurationReport_Load(object sender, EventArgs e)
        {
            ent = new Cfirst();
            var va = (from em in ent.Varieties_supplypermessions select em);
            foreach (var item in va)
            {
                vName.Items.Add(item.Varieties);
            }
        }

        private void vName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ent = new Cfirst();
            DateTime dateTime = DateTime.Today;
         Varieties_supplypermessions vsp= (from em in ent.Varieties_supplypermessions where
                                           em.Varieties==vName.Text select em).First();
            supplyPermession sp = (from en in ent.supplyPermessions where en.SuplyId == vsp.SupplyId select en).First();
            System.TimeSpan diff = dateTime.Subtract((DateTime)sp.history);
            Duration.Text = diff.ToString();

        }
    }
}
