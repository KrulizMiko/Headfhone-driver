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

namespace VaultSound
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }
        void sw()
        {
            Application.Run(new Main());
        }
        void sw1()
        {
            Application.Run(new Authorization());
        }
        private void General_Click(object sender, EventArgs e)
        {
           this.Close();
           Thread th = new Thread(sw);
           th.Start(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(sw1);
            th.Start(); 
        }
    }
}
