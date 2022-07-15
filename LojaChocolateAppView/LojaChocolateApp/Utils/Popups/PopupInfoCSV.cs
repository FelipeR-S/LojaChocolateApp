using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaChocolateApp.Utils.Popups
{
    public partial class PopupInfoCSV : Form
    {
        public PopupInfoCSV()
        {
            InitializeComponent();
        }
        private void btnFechaPopup_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
