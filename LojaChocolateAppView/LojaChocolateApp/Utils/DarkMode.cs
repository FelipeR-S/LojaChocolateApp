using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaChocolateApp.Utils
{
    public class DarkMode : Form
    {
        private bool _darkMode;
        public DarkMode(bool darkMode)
        {
            _darkMode = darkMode;
        }
        /// <summary>
        /// Gera o darkMode
        /// </summary>
        /// <param name="control"></param>
        public void GetDarkMode(Control control)
        {
            if (_darkMode == true)
            {
                foreach (Control c in control.Controls)
                {
                    if (_darkMode == true)
                    {
                        if (c is TextBox && c.BackColor == Color.White)
                        {
                            ((TextBox)c).BackColor = Color.FromArgb(30, 30, 30);
                            ((TextBox)c).ForeColor = Color.White;
                        }
                    }
                    if (_darkMode == false)
                    {
                        if (c is TextBox && c.BackColor == Color.FromArgb(30, 30, 30))
                        {
                            ((TextBox)c).BackColor = Color.White;
                            ((TextBox)c).ForeColor = Color.Black;
                        }
                    }
                    if (c.HasChildren)
                    {
                        GetDarkMode(c);
                    }
                }
            }
        }

    }
}
