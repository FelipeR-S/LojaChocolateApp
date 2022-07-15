using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaChocolateApp.Utils
{
    public class BackGroundPopup
    {
        /// <summary>
        /// Escurece o background quando um popup aparece
        /// </summary>
        /// <param name="background">Recebe background que é a aplicação que fica abaixo do popup</param>
        public void BackGroundPopupDesign(Form background)
        {
            background.StartPosition = FormStartPosition.Manual;
            background.FormBorderStyle = FormBorderStyle.None;
            background.Opacity = 0.7d;
            background.BackColor = Color.Black;
            background.WindowState = FormWindowState.Maximized;
            background.TopMost = true;
            //background.Location = this.Location;
            background.ShowInTaskbar = false;
            background.Show();
        }
    }
}
