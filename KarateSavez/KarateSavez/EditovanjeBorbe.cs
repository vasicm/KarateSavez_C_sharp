using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarateSavez
{
    public partial class EditovanjeBorbe : Form
    {
        public EditovanjeBorbe()
        {
            InitializeComponent();
        }

        private void zatvoriBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Да ли сте сигурни?", "Питање!", MessageBoxButtons.YesNo) == DialogResult.Yes) this.Close();
        }

        private void sacuvajBtn_Click(object sender, EventArgs e)
        {
            //TODO
            MessageBox.Show("Није имплементирано", "Обавјештење!", MessageBoxButtons.YesNo);
        }
    }
}
