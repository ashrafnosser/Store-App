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
    public partial class dialogeLanguage : Form
    {
        public dialogeLanguage()
        {
            InitializeComponent();
        }

        private void arabic_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void English_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
