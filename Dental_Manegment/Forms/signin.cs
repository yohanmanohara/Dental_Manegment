
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Manegment.Forms
{
    public partial class signin : Form
    {
        public signin()
        {
            InitializeComponent();
        }

    

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

      
        

        

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            loading _load = new loading();
            _load.Show();
            this.Close();   

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {


            System.Windows.Forms.Application.Exit();
        }
    }
}
