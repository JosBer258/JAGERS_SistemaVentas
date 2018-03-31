using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desarrollo.Pantallas.Manueales
{
    public partial class Manuales : Form
    {
        public Manuales()
        {
            InitializeComponent();
        }

        private void Manuales_Load(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(Application.StartupPath + @"\ManualesHTML\index.html");
        }
    }
}
