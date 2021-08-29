using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_Semana5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void actualToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has elegido la opcion Aceptar", "Opcion Aceptar", MessageBoxButtons.OK);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has elegido la opcion Aceptar/Cancelar", "Opcion Aceptar/Cancelar", MessageBoxButtons.OKCancel);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has elegido la opcion Si/No", "Opcion Si/No", MessageBoxButtons.YesNo);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has elegido la opcion Exclamacion", "Opcion Exclamacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has elegido la opcion Interrogacion", "Opcion Interrogacion", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has elegido la opcion Error", "Opcion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ayuda f2 = new Ayuda();
            f2.ShowDialog();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 f2 = new AboutBox1();
            f2.ShowDialog();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
