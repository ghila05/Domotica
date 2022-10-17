using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_telecomando
{
    public partial class Form1 : Form
    {
        private Class_telecomando t;
        private Class_televisore tv;

        public Form1()
        {
            InitializeComponent();
            tv = new Class_televisore("SAMSUNG", "skyglass");
            t = new Class_telecomando("Sony","x5 Bravia",1,tv);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            t.accendi();
            label3.Text=("Stato: On");
            
            butn_alzavol.Visible = true;
            butn_abbassavol.Visible = true;
            textBox1.Visible = true;
            label2.Visible = true;
          
        }

        private void butn_spegni_Click(object sender, EventArgs e)
        {
            t.spegni();
            label3.Text=("Stato: Off");
            butn_alzavol.Visible = false;
            butn_abbassavol.Visible = false;
            textBox1.Visible = false;
            label2.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void butn_alzavol_Click(object sender, EventArgs e)
        {
            t.AlzaVolume();
            label1.Text = "Volume: " + Convert.ToString(t.getVolume());
        }

        private void butn_abbassavol_Click(object sender, EventArgs e)
        {
            t.AbbassaVolume();
            label1.Text = "Volume: " + Convert.ToString(t.getVolume());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Enter))
            {
                butn_vaicanale.PerformClick();
                t.CambiaCanale(int.Parse(textBox1.Text));
                labl_canale.Text = ("Canale: " + Convert.ToString(t.getCanale()));
                
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        
    }
}
