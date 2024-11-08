using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedDocs
{
    public partial class Principala_medic : Form
    {
        public Principala_medic()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lista_pacienti form2 = new Lista_pacienti();
            form2.Show();
            this.Hide();
        }

    }
}
