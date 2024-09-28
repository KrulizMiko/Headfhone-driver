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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
        void profile()
        {
            Application.Run(new Profile());
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Profile_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread swith = new Thread(profile);
            swith.Start();
        }

        private void ForU_Click(object sender, EventArgs e)
        {

        }
    }
}
