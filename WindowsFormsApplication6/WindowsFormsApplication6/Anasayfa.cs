using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        ProjeOlusturma projeOlusturma = new ProjeOlusturma();
        private void navBarControl1_Click(object sender, EventArgs e)
        {
            //tabControl.SelectedTabPageIndex = 5;
        }
        private void navBarItem7_LinkClicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.google.com");
        }
        Firma firma = new Firma();
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            firma.Show();
        }
     
    }
}
