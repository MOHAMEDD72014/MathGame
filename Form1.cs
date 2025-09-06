using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathGame
{
    public partial class Form1 : Form
    {
      
       

        public Form1()
        {
            InitializeComponent();
           
        }


        public int Livel { get; set; }
        public int Opretor { get; set; }
        public int rowndRow { get; set; }
        public int TimeGame { get; set; }
       



        private void label6_Click(object sender, EventArgs e)
        {
          
        }

        private void nmTimeGame_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comLivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            Livel = comLivel.SelectedIndex;
            Opretor = comOpretore.SelectedIndex;
            rowndRow =Convert.ToInt16(nmRownd.Value);
            TimeGame= Convert.ToInt16(nmTimeGame.Value);
            
            this.Hide();
        }
    }
}
