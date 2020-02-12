using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaDNI
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void buttonConvert_Click(object sender, EventArgs e)
        {

            int DNI = Convert.ToInt32(textBoxNum.Text);
            char letter = functionDNI(DNI);
            textBoxLetter.Text = letter.ToString();

        }

        private static char functionDNI(int DNI) 
        {
            return "TRWAGMYFPDXBNJZSQVHLCKE"[DNI % 23];
        }


    }
}
