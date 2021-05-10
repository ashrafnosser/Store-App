using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linqentity
{
    public partial class start : Form
    {
        
        public start()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
     
            InitializeComponent();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void englishToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            this.Controls.Clear();
            InitializeComponent();

        }

        private void start_Load(object sender, EventArgs e)
        {
            dialogeLanguage dg = new dialogeLanguage();
            DialogResult dialogResult;
            dialogResult = dg.ShowDialog();
            if (dialogResult==DialogResult.OK)
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar-EG");
                this.Controls.Clear();
                InitializeComponent();
            }
            else 
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
                this.Controls.Clear();
                InitializeComponent();
            }
        }

        private void arabicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar-EG");
            this.Controls.Clear();
            InitializeComponent();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void storeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.MdiParent = this;
            f1.Show();
        }

        private void formsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.MdiParent = this;
            f4.Show();
        }

        private void supplypermissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.MdiParent = this;
            f5.Show();
        }

        private void varietiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.MdiParent = this;
            f2.Show();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.MdiParent = this;
            f3.Show();
        }

        private void dismissalPermissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.MdiParent = this;
            f6.Show();
        }

        private void transformToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.MdiParent = this;
            f7.Show();
        }

        private void varityExpiryEndToolStripMenuItem_Click(object sender, EventArgs e)
        {
            varatiesExpiry f1 = new varatiesExpiry();
            f1.MdiParent = this;
            f1.Show();
        }

        private void variatyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VarietyReport f1 = new VarietyReport();
            f1.MdiParent = this;
            f1.Show();
        }

        private void storeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            storesReport f1 = new storesReport();
            f1.MdiParent = this;
            f1.Show();
        }

        private void variatySituationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            varitiesSituation f1 = new varitiesSituation();
            f1.MdiParent = this;
            f1.Show();
        }

        private void variatyDurationReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VarietiesDurationReport f1 = new VarietiesDurationReport();
            f1.MdiParent = this;
            f1.Show();
        }
    }
}
