using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alpargatas_IoT
{
    public partial class Notes : Form
    {
        public Notes()
        {
            InitializeComponent();
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Save_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }
    }
}
