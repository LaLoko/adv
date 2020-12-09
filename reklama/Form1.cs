using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reklama
{
    public partial class AD : Form
    {
        public AD()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            Left = r.Next(1600 - Width);
            Top = r.Next(900 - Height);
        }
    }
}
