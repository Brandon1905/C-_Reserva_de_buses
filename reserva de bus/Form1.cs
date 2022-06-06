using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace reserva_de_bus
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("transc#.JPEG");
        }

        private void brandonUgaldeChavarriaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            int monto;
            int cantidad;
            int vuelto;
            int descuento;


            monto = int.Parse(txtmonto.Text);
            cantidad = int.Parse(txtcantidad.Text);
            if (checkOro.Checked == true)
            {

                if (cantidad < monto)
                {
                    MessageBox.Show("Monto insuficiente. ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    descuento = monto * 45 / 100;
                    vuelto = cantidad - descuento;
                    txtvuelto.Text = vuelto.ToString();
                }
            }
            else
            {


                vuelto = cantidad - monto;
                if (cantidad < monto)
                {
                    MessageBox.Show("Monto insuficiente. ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    txtvuelto.Text = vuelto.ToString();
                }
            }

        }
   

        private void button4_Click(object sender, EventArgs e)
        {
            txtmonto.Text = "";
            txtcantidad.Text = "";
            txtvuelto.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cNeilyAGolfitoToolStripMenuItem1_Click(object sender, EventArgs e)
        {


        }

        private void canoasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabPage9_Click(object sender, EventArgs e)
        {

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("desea salir del programa. ", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
        }

        private void va1_Click(object sender, EventArgs e)
        {
            if (va1.BackColor == Color.Lime)
            {
                va1.BackColor = Color.Yellow;
            }
            else
            {
                va1.BackColor = Color.Red;
            }
        }

        private void pa2_Click(object sender, EventArgs e)
        {
            if (pa2.BackColor == Color.Lime)
            {
                pa2.BackColor = Color.Yellow;
            }
            else
            {
                pa2.BackColor = Color.Red;
            }
        }

        private void va3_Click(object sender, EventArgs e)
        {
            if (va3.BackColor == Color.Lime)
            {
                va3.BackColor = Color.Yellow;
            }
            else
            {
                va3.BackColor = Color.Red;
            }
        }

        private void pa4_Click(object sender, EventArgs e)
        {
            if (pa4.BackColor == Color.Lime)
            {
                pa4.BackColor = Color.Yellow;
            }
            else
            {
                pa4.BackColor = Color.Red;
            }
        }

        private void va5_Click(object sender, EventArgs e)
        {
            if (va5.BackColor == Color.Lime)
            {
                va5.BackColor = Color.Yellow;
            }
            else
            {
                va5.BackColor = Color.Red;
            }
        }

        private void pa6_Click(object sender, EventArgs e)
        {
            if (pa6.BackColor == Color.Lime)
            {
                pa6.BackColor = Color.Yellow;
            }
            else
            {
                pa6.BackColor = Color.Red;
            }
        }

        private void va7_Click(object sender, EventArgs e)
        {
            if (va7.BackColor == Color.Lime)
            {
                va7.BackColor = Color.Yellow;
            }
            else
            {
                va7.BackColor = Color.Red;
            }
        }

        private void pa8_Click(object sender, EventArgs e)
        {
            if (pa8.BackColor == Color.Lime)
            {
                pa8.BackColor = Color.Yellow;
            }
            else
            {
                pa8.BackColor = Color.Red;
            }
        }

        private void va9_Click(object sender, EventArgs e)
        {
            if (va9.BackColor == Color.Lime)
            {
                va9.BackColor = Color.Yellow;
            }
            else
            {
                va9.BackColor = Color.Red;
            }
        }

        private void pa10_Click(object sender, EventArgs e)
        {
            if (pa10.BackColor == Color.Lime)
            {
                pa10.BackColor = Color.Yellow;
            }
            else
            {
                pa10.BackColor = Color.Red;
            }
        }

        private void va11_Click(object sender, EventArgs e)
        {
            if (va11.BackColor == Color.Lime)
            {
                va11.BackColor = Color.Yellow;
            }
            else
            {
                va11.BackColor = Color.Red;
            }
        }

        private void pa12_Click(object sender, EventArgs e)
        {
            if (pa12.BackColor == Color.Lime)
            {
                pa12.BackColor = Color.Yellow;
            }
            else
            {
                pa12.BackColor = Color.Red;
            }
        }

        private void va13_Click(object sender, EventArgs e)
        {
            if (va13.BackColor == Color.Lime)
            {
                va13.BackColor = Color.Yellow;
            }
            else
            {
                va13.BackColor = Color.Red;
            }
        }

        private void pa14_Click(object sender, EventArgs e)
        {
            if (pa14.BackColor == Color.Lime)
            {
                pa14.BackColor = Color.Yellow;
            }
            else
            {
                pa14.BackColor = Color.Red;
            }
        }

        private void va15_Click(object sender, EventArgs e)
        {
            if (va15.BackColor == Color.Lime)
            {
                va15.BackColor = Color.Yellow;
            }
            else
            {
                va15.BackColor = Color.Red;
            }
        }

        private void pa16_Click(object sender, EventArgs e)
        {
            if (pa16.BackColor == Color.Lime)
            {
                pa16.BackColor = Color.Yellow;
            }
            else
            {
                pa16.BackColor = Color.Red;
            }
        }

        private void va17_Click(object sender, EventArgs e)
        {
            if (va17.BackColor == Color.Lime)
            {
                va17.BackColor = Color.Yellow;
            }
            else
            {
                va17.BackColor = Color.Red;
            }
        }

        private void pa18_Click(object sender, EventArgs e)
        {
            if (pa18.BackColor == Color.Lime)
            {
                pa18.BackColor = Color.Yellow;
            }
            else
            {
                pa18.BackColor = Color.Red;
            }
        }

        private void va19_Click(object sender, EventArgs e)
        {
            if (va19.BackColor == Color.Lime)
            {
                va19.BackColor = Color.Yellow;
            }
            else
            {
                va19.BackColor = Color.Red;
            }
        }

        private void pa20_Click(object sender, EventArgs e)
        {
            if (pa20.BackColor == Color.Lime)
            {
                pa20.BackColor = Color.Yellow;
            }
            else
            {
                pa20.BackColor = Color.Red;
            }
        }

        private void va21_Click(object sender, EventArgs e)
        {
            if (va21.BackColor == Color.Lime)
            {
                va21.BackColor = Color.Yellow;
            }
            else
            {
                va21.BackColor = Color.Red;
            }
        }

        private void pa22_Click(object sender, EventArgs e)
        {
            if (pa22.BackColor == Color.Lime)
            {
                pa22.BackColor = Color.Yellow;
            }
            else
            {
                pa22.BackColor = Color.Red;
            }
        }

        private void pa24_Click(object sender, EventArgs e)
        {
            if (pa24.BackColor == Color.Lime)
            {
                pa24.BackColor = Color.Yellow;
            }
            else
            {
                pa24.BackColor = Color.Red;
            }
        }

        private void va23_Click(object sender, EventArgs e)
        {
            if (va23.BackColor == Color.Lime)
            {
                va23.BackColor = Color.Yellow;
            }
            else
            {
                va23.BackColor = Color.Red;
            }
        }

        private void va25_Click(object sender, EventArgs e)
        {
            if (va25.BackColor == Color.Lime)
            {
                va25.BackColor = Color.Yellow;
            }
            else
            {
                va25.BackColor = Color.Red;
            }
        }

        private void pa26_Click(object sender, EventArgs e)
        {
            if (pa26.BackColor == Color.Lime)
            {
                pa26.BackColor = Color.Yellow;
            }
            else
            {
                pa26.BackColor = Color.Red;
            }
        }

        private void va27_Click(object sender, EventArgs e)
        {
            if (va27.BackColor == Color.Lime)
            {
                va27.BackColor = Color.Yellow;
            }
            else
            {
                va27.BackColor = Color.Red;
            }
        }

        private void pa28_Click(object sender, EventArgs e)
        {
            if (pa28.BackColor == Color.Lime)
            {
                pa28.BackColor = Color.Yellow;
            }
            else
            {
                pa28.BackColor = Color.Red;
            }
        }

        private void va29_Click(object sender, EventArgs e)
        {
            if (va29.BackColor == Color.Lime)
            {
                va29.BackColor = Color.Yellow;
            }
            else
            {
                va29.BackColor = Color.Red;
            }
        }

        private void va31_Click(object sender, EventArgs e)
        {
            if (va31.BackColor == Color.Lime)
            {
                va31.BackColor = Color.Yellow;
            }
            else
            {
                va31.BackColor = Color.Red;
            }
        }

        private void pa32_Click(object sender, EventArgs e)
        {
            if (pa32.BackColor == Color.Lime)
            {
                pa32.BackColor = Color.Yellow;
            }
            else
            {
                pa32.BackColor = Color.Red;
            }
        }

        private void va33_Click(object sender, EventArgs e)
        {
            if (va33.BackColor == Color.Lime)
            {
                va33.BackColor = Color.Yellow;
            }
            else
            {
                va33.BackColor = Color.Red;
            }
        }

        private void pa34_Click(object sender, EventArgs e)
        {
            if (pa34.BackColor == Color.Lime)
            {
                pa34.BackColor = Color.Yellow;
            }
            else
            {
                pa34.BackColor = Color.Red;
            }
        }

        private void va35_Click(object sender, EventArgs e)
        {
            if (va35.BackColor == Color.Lime)
            {
                va35.BackColor = Color.Yellow;
            }
            else
            {
                va35.BackColor = Color.Red;
            }
        }

        private void pa36_Click(object sender, EventArgs e)
        {
            if (pa36.BackColor == Color.Lime)
            {
                pa36.BackColor = Color.Yellow;
            }
            else
            {
                pa36.BackColor = Color.Red;
            }
        }

        private void va37_Click(object sender, EventArgs e)
        {
            if (va37.BackColor == Color.Lime)
            {
                va37.BackColor = Color.Yellow;
            }
            else
            {
                va37.BackColor = Color.Red;
            }
        }

        private void pa38_Click(object sender, EventArgs e)
        {

            if (pa38.BackColor == Color.Lime)
            {
                pa38.BackColor = Color.Yellow;
            }
            else
            {
                pa38.BackColor = Color.Red;
            }

        }

        private void va39_Click(object sender, EventArgs e)
        {
            if (va39.BackColor == Color.Lime)
            {
                va39.BackColor = Color.Yellow;
            }
            else
            {
                va39.BackColor = Color.Red;
            }
        }

        private void pa40_Click(object sender, EventArgs e)
        {
            if (pa40.BackColor == Color.Lime)
            {
                pa40.BackColor = Color.Yellow;
            }
            else
            {
                pa40.BackColor = Color.Red;
            }
        }

        private void va41_Click(object sender, EventArgs e)
        {
            if (va41.BackColor == Color.Lime)
            {
                va41.BackColor = Color.Yellow;
            }
            else
            {
                va41.BackColor = Color.Red;
            }
        }

        private void pa42_Click(object sender, EventArgs e)
        {
            if (pa42.BackColor == Color.Lime)
            {
                pa42.BackColor = Color.Yellow;
            }
            else
            {
                pa42.BackColor = Color.Red;
            }
        }

        private void va43_Click(object sender, EventArgs e)
        {
            if (va43.BackColor == Color.Lime)
            {
                va43.BackColor = Color.Yellow;
            }
            else
            {
                va43.BackColor = Color.Red;
            }
        }

        private void pa44_Click(object sender, EventArgs e)
        {
            if (pa44.BackColor == Color.Lime)
            {
                pa44.BackColor = Color.Yellow;
            }
            else
            {
                pa44.BackColor = Color.Red;
            }
        }

        private void va45_Click(object sender, EventArgs e)
        {
            if (va45.BackColor == Color.Lime)
            {
                va45.BackColor = Color.Yellow;
            }
            else
            {
                va45.BackColor = Color.Red;
            }
        }

        private void pa46_Click(object sender, EventArgs e)
        {
            if (pa46.BackColor == Color.Lime)
            {
                pa46.BackColor = Color.Yellow;
            }
            else
            {
                pa46.BackColor = Color.Red;
            }
        }

        private void va47_Click(object sender, EventArgs e)
        {
            if (va47.BackColor == Color.Lime)
            {
                va47.BackColor = Color.Yellow;
            }
            else
            {
                va47.BackColor = Color.Red;
            }
        }

        private void pa48_Click(object sender, EventArgs e)
        {
            if (pa48.BackColor == Color.Lime)
            {
                pa48.BackColor = Color.Yellow;
            }
            else
            {
                pa48.BackColor = Color.Red;
            }
        }

        private void va49_Click(object sender, EventArgs e)
        {
            if (va49.BackColor == Color.Lime)
            {
                va49.BackColor = Color.Yellow;
            }
            else
            {
                va49.BackColor = Color.Red;
            }
        }

        private void pa50_Click(object sender, EventArgs e)
        {
            if (pa50.BackColor == Color.Lime)
            {
                pa50.BackColor = Color.Yellow;
            }
            else
            {
                pa50.BackColor = Color.Red;
            }
        }

        private void va51_Click(object sender, EventArgs e)
        {
            if (va51.BackColor == Color.Lime)
            {
                va51.BackColor = Color.Yellow;
            }
            else
            {
                va51.BackColor = Color.Red;
            }
        }

        private void pa52_Click(object sender, EventArgs e)
        {
            if (pa52.BackColor == Color.Lime)
            {
                pa52.BackColor = Color.Yellow;
            }
            else
            {
                pa52.BackColor = Color.Red;
            }
        }

        private void va53_Click(object sender, EventArgs e)
        {
            if (va53.BackColor == Color.Lime)
            {
                va53.BackColor = Color.Yellow;
            }
            else
            {
                va53.BackColor = Color.Red;
            }
        }

        private void pa54_Click(object sender, EventArgs e)
        {
            if (pa54.BackColor == Color.Lime)
            {
                pa54.BackColor = Color.Yellow;
            }
            else
            {
                pa54.BackColor = Color.Red;
            }
        }

        private void va55_Click(object sender, EventArgs e)
        {
            if (va55.BackColor == Color.Lime)
            {
                va55.BackColor = Color.Yellow;
            }
            else
            {
                va55.BackColor = Color.Red;
            }
        }

        private void pa56_Click(object sender, EventArgs e)
        {
            if (pa56.BackColor == Color.Lime)
            {
                pa56.BackColor = Color.Yellow;
            }
            else
            {
                pa56.BackColor = Color.Red;
            }
        }

        private void va57_Click(object sender, EventArgs e)
        {
            if (va57.BackColor == Color.Lime)
            {
                va57.BackColor = Color.Yellow;
            }
            else
            {
                va57.BackColor = Color.Red;
            }
        }

        private void pa58_Click(object sender, EventArgs e)
        {
            if (pa58.BackColor == Color.Lime)
            {
                pa58.BackColor = Color.Yellow;
            }
            else
            {
                pa58.BackColor = Color.Red;
            }
        }

        private void va59_Click(object sender, EventArgs e)
        {
            if (va59.BackColor == Color.Lime)
            {
                va59.BackColor = Color.Yellow;
            }
            else
            {
                va59.BackColor = Color.Red;
            }
        }

        private void pa60_Click(object sender, EventArgs e)
        {
            if (pa60.BackColor == Color.Lime)
            {
                pa60.BackColor = Color.Yellow;
            }
            else
            {
                pa60.BackColor = Color.Red;
            }
        }

        private void pa61_Click(object sender, EventArgs e)
        {
            if (pa61.BackColor == Color.Lime)
            {
                pa61.BackColor = Color.Yellow;
            }
            else
            {
                pa61.BackColor = Color.Red;
            }
        }

        private void pa30_Click(object sender, EventArgs e)
        {
            if (pa30.BackColor == Color.Lime)
            {
                pa30.BackColor = Color.Yellow;
            }
            else
            {
                pa30.BackColor = Color.Red;
            }
        }

        private void button737_Click(object sender, EventArgs e)
        {
            pa2.BackColor = Color.Lime;
            pa6.BackColor = Color.Lime;
            pa10.BackColor = Color.Lime;
            pa14.BackColor = Color.Lime;
            pa18.BackColor = Color.Lime;
            pa22.BackColor = Color.Lime;
            pa26.BackColor = Color.Lime;
            pa30.BackColor = Color.Lime;
            pa34.BackColor = Color.Lime;
            pa38.BackColor = Color.Lime;
            pa42.BackColor = Color.Lime;
            pa46.BackColor = Color.Lime;
            pa50.BackColor = Color.Lime;
            pa54.BackColor = Color.Lime;
            pa58.BackColor = Color.Lime;
            pa61.BackColor = Color.Lime;
            pa60.BackColor = Color.Lime;
            pa56.BackColor = Color.Lime;
            pa52.BackColor = Color.Lime;
            pa48.BackColor = Color.Lime;
            pa44.BackColor = Color.Lime;
            pa40.BackColor = Color.Lime;
            pa36.BackColor = Color.Lime;
            pa32.BackColor = Color.Lime;
            pa28.BackColor = Color.Lime;
            pa24.BackColor = Color.Lime;
            pa20.BackColor = Color.Lime;
            pa16.BackColor = Color.Lime;
            pa12.BackColor = Color.Lime;
            pa8.BackColor = Color.Lime;
            pa4.BackColor = Color.Lime;
            va1.BackColor = Color.Lime;
            va5.BackColor = Color.Lime;
            va9.BackColor = Color.Lime;
            va13.BackColor = Color.Lime;
            va17.BackColor = Color.Lime;
            va21.BackColor = Color.Lime;
            va25.BackColor = Color.Lime;
            va29.BackColor = Color.Lime;
            va33.BackColor = Color.Lime;
            va37.BackColor = Color.Lime;
            va41.BackColor = Color.Lime;
            va45.BackColor = Color.Lime;
            va49.BackColor = Color.Lime;
            va53.BackColor = Color.Lime;
            va57.BackColor = Color.Lime;
            va59.BackColor = Color.Lime;
            va55.BackColor = Color.Lime;
            va51.BackColor = Color.Lime;
            va47.BackColor = Color.Lime;
            va43.BackColor = Color.Lime;
            va39.BackColor = Color.Lime;
            va35.BackColor = Color.Lime;
            va31.BackColor = Color.Lime;
            va27.BackColor = Color.Lime;
            va23.BackColor = Color.Lime;
            va19.BackColor = Color.Lime;
            va15.BackColor = Color.Lime;
            va11.BackColor = Color.Lime;
            va7.BackColor = Color.Lime;
            va3.BackColor = Color.Lime;

        }
        //-------------------------------------------------------------------





        private void button66_Click(object sender, EventArgs e)
        {
            if (button66.BackColor == Color.Lime)
            {
                button66.BackColor = Color.Yellow;
            }
            else
            {
                button66.BackColor = Color.Red;
            }
        }

        private void button67_Click(object sender, EventArgs e)
        {
            if (button67.BackColor == Color.Lime)
            {
                button67.BackColor = Color.Yellow;
            }
            else
            {
                button67.BackColor = Color.Red;
            }
        }

        private void button68_Click(object sender, EventArgs e)
        {
            if (button68.BackColor == Color.Lime)
            {
                button68.BackColor = Color.Yellow;
            }
            else
            {
                button68.BackColor = Color.Red;
            }
        }

        private void button69_Click(object sender, EventArgs e)
        {
            if (button69.BackColor == Color.Lime)
            {
                button69.BackColor = Color.Yellow;
            }
            else
            {
                button69.BackColor = Color.Red;
            }
        }

        private void button70_Click(object sender, EventArgs e)
        {
            if (button70.BackColor == Color.Lime)
            {
                button70.BackColor = Color.Yellow;
            }
            else
            {
                button70.BackColor = Color.Red;
            }
        }

        private void button71_Click(object sender, EventArgs e)
        {
            if (button71.BackColor == Color.Lime)
            {
                button71.BackColor = Color.Yellow;
            }
            else
            {
                button71.BackColor = Color.Red;
            }
        }

        private void button72_Click(object sender, EventArgs e)
        {
            if (button72.BackColor == Color.Lime)
            {
                button72.BackColor = Color.Yellow;
            }
            else
            {
                button72.BackColor = Color.Red;
            }
        }

        private void button73_Click(object sender, EventArgs e)
        {
            if (button73.BackColor == Color.Lime)
            {
                button73.BackColor = Color.Yellow;
            }
            else
            {
                button73.BackColor = Color.Red;
            }
        }

        private void button74_Click(object sender, EventArgs e)
        {
            if (button74.BackColor == Color.Lime)
            {
                button74.BackColor = Color.Yellow;
            }
            else
            {
                button74.BackColor = Color.Red;
            }
        }

        private void button75_Click(object sender, EventArgs e)
        {
            if (button75.BackColor == Color.Lime)
            {
                button75.BackColor = Color.Yellow;
            }
            else
            {
                button75.BackColor = Color.Red;
            }
        }

        private void button76_Click(object sender, EventArgs e)
        {
            if (button76.BackColor == Color.Lime)
            {
                button76.BackColor = Color.Yellow;
            }
            else
            {
                button76.BackColor = Color.Red;
            }
        }

        private void button77_Click(object sender, EventArgs e)
        {
            if (button77.BackColor == Color.Lime)
            {
                button77.BackColor = Color.Yellow;
            }
            else
            {
                button77.BackColor = Color.Red;
            }
        }

        private void button78_Click(object sender, EventArgs e)
        {
            if (button78.BackColor == Color.Lime)
            {
                button78.BackColor = Color.Yellow;
            }
            else
            {
                button78.BackColor = Color.Red;
            }
        }

        private void button79_Click(object sender, EventArgs e)
        {
            if (button79.BackColor == Color.Lime)
            {
                button79.BackColor = Color.Yellow;
            }
            else
            {
                button79.BackColor = Color.Red;
            }
        }

        private void button80_Click(object sender, EventArgs e)
        {
            if (button80.BackColor == Color.Lime)
            {
                button80.BackColor = Color.Yellow;
            }
            else
            {
                button80.BackColor = Color.Red;
            }
        }

        private void button81_Click(object sender, EventArgs e)
        {
            if (button81.BackColor == Color.Lime)
            {
                button81.BackColor = Color.Yellow;
            }
            else
            {
                button81.BackColor = Color.Red;
            }
        }

        private void button82_Click(object sender, EventArgs e)
        {
            if (button82.BackColor == Color.Lime)
            {
                button82.BackColor = Color.Yellow;
            }
            else
            {
                button82.BackColor = Color.Red;
            }
        }

        private void button83_Click(object sender, EventArgs e)
        {
            if (button83.BackColor == Color.Lime)
            {
                button83.BackColor = Color.Yellow;
            }
            else
            {
                button83.BackColor = Color.Red;
            }
        }

        private void button84_Click(object sender, EventArgs e)
        {
            if (button84.BackColor == Color.Lime)
            {
                button84.BackColor = Color.Yellow;
            }
            else
            {
                button84.BackColor = Color.Red;
            }
        }

        private void button85_Click(object sender, EventArgs e)
        {
            if (button85.BackColor == Color.Lime)
            {
                button85.BackColor = Color.Yellow;
            }
            else
            {
                button85.BackColor = Color.Red;
            }
        }

        private void button86_Click(object sender, EventArgs e)
        {
            if (button86.BackColor == Color.Lime)
            {
                button86.BackColor = Color.Yellow;
            }
            else
            {
                button86.BackColor = Color.Red;
            }
        }

        private void button87_Click(object sender, EventArgs e)
        {
            if (button85.BackColor == Color.Lime)
            {
                button87.BackColor = Color.Yellow;
            }
            else
            {
                button87.BackColor = Color.Red;
            }
        }

        private void button88_Click(object sender, EventArgs e)
        {
            if (button88.BackColor == Color.Lime)
            {
                button88.BackColor = Color.Yellow;
            }
            else
            {
                button88.BackColor = Color.Red;
            }
        }

        private void button89_Click(object sender, EventArgs e)
        {
            if (button89.BackColor == Color.Lime)
            {
                button89.BackColor = Color.Yellow;
            }
            else
            {
                button89.BackColor = Color.Red;
            }
        }

        private void button90_Click(object sender, EventArgs e)
        {
            if (button90.BackColor == Color.Lime)
            {
                button90.BackColor = Color.Yellow;
            }
            else
            {
                button90.BackColor = Color.Red;
            }
        }

        private void button91_Click(object sender, EventArgs e)
        {
            if (button91.BackColor == Color.Lime)
            {
                button91.BackColor = Color.Yellow;
            }
            else
            {
                button91.BackColor = Color.Red;
            }
        }

        private void button92_Click(object sender, EventArgs e)
        {
            if (button92.BackColor == Color.Lime)
            {
                button92.BackColor = Color.Yellow;
            }
            else
            {
                button92.BackColor = Color.Red;
            }
        }

        private void button93_Click(object sender, EventArgs e)
        {
            if (button93.BackColor == Color.Lime)
            {
                button93.BackColor = Color.Yellow;
            }
            else
            {
                button93.BackColor = Color.Red;
            }
        }

        private void button94_Click(object sender, EventArgs e)
        {
            if (button94.BackColor == Color.Lime)
            {
                button94.BackColor = Color.Yellow;
            }
            else
            {
                button94.BackColor = Color.Red;
            }
        }

        private void button95_Click(object sender, EventArgs e)
        {
            if (button95.BackColor == Color.Lime)
            {
                button95.BackColor = Color.Yellow;
            }
            else
            {
                button95.BackColor = Color.Red;
            }
        }

        private void button96_Click(object sender, EventArgs e)
        {
            if (button96.BackColor == Color.Lime)
            {
                button96.BackColor = Color.Yellow;
            }
            else
            {
                button96.BackColor = Color.Red;
            }
        }

        private void button97_Click(object sender, EventArgs e)
        {
            if (button97.BackColor == Color.Lime)
            {
                button97.BackColor = Color.Yellow;
            }
            else
            {
                button97.BackColor = Color.Red;
            }
        }

        private void button98_Click(object sender, EventArgs e)
        {
            if (button98.BackColor == Color.Lime)
            {
                button98.BackColor = Color.Yellow;
            }
            else
            {
                button98.BackColor = Color.Red;
            }
        }

        private void button99_Click(object sender, EventArgs e)
        {
            if (button99.BackColor == Color.Lime)
            {
                button99.BackColor = Color.Yellow;
            }
            else
            {
                button99.BackColor = Color.Red;
            }
        }

        private void button100_Click(object sender, EventArgs e)
        {
            if (button100.BackColor == Color.Lime)
            {
                button100.BackColor = Color.Yellow;
            }
            else
            {
                button100.BackColor = Color.Red;
            }
        }

        private void button101_Click(object sender, EventArgs e)
        {
            if (button101.BackColor == Color.Lime)
            {
                button101.BackColor = Color.Yellow;
            }
            else
            {
                button101.BackColor = Color.Red;
            }
        }

        private void button102_Click(object sender, EventArgs e)
        {
            if (button102.BackColor == Color.Lime)
            {
                button102.BackColor = Color.Yellow;
            }
            else
            {
                button102.BackColor = Color.Red;
            }
        }

        private void button103_Click(object sender, EventArgs e)
        {
            if (button103.BackColor == Color.Lime)
            {
                button103.BackColor = Color.Yellow;
            }
            else
            {
                button103.BackColor = Color.Red;
            }
        }

        private void button104_Click(object sender, EventArgs e)
        {
            if (button104.BackColor == Color.Lime)
            {
                button104.BackColor = Color.Yellow;
            }
            else
            {
                button104.BackColor = Color.Red;
            }
        }

        private void button105_Click(object sender, EventArgs e)
        {
            if (button105.BackColor == Color.Lime)
            {
                button105.BackColor = Color.Yellow;
            }
            else
            {
                button105.BackColor = Color.Red;
            }
        }

        private void button106_Click(object sender, EventArgs e)
        {
            if (button106.BackColor == Color.Lime)
            {
                button106.BackColor = Color.Yellow;
            }
            else
            {
                button106.BackColor = Color.Red;
            }
        }

        private void button107_Click(object sender, EventArgs e)
        {
            if (button107.BackColor == Color.Lime)
            {
                button107.BackColor = Color.Yellow;
            }
            else
            {
                button107.BackColor = Color.Red;
            }
        }

        private void button108_Click(object sender, EventArgs e)
        {
            if (button108.BackColor == Color.Lime)
            {
                button108.BackColor = Color.Yellow;
            }
            else
            {
                button108.BackColor = Color.Red;
            }
        }

        private void button109_Click(object sender, EventArgs e)
        {

            if (button109.BackColor == Color.Lime)
            {
                button109.BackColor = Color.Yellow;
            }
            else
            {
                button109.BackColor = Color.Red;
            }
        }

        private void button110_Click(object sender, EventArgs e)
        {
            if (button110.BackColor == Color.Lime)
            {
                button110.BackColor = Color.Yellow;
            }
            else
            {
                button110.BackColor = Color.Red;
            }
        }

        private void button111_Click(object sender, EventArgs e)
        {
            if (button111.BackColor == Color.Lime)
            {
                button111.BackColor = Color.Yellow;
            }
            else
            {
                button111.BackColor = Color.Red;
            }
        }

        private void button112_Click(object sender, EventArgs e)
        {
            if (button112.BackColor == Color.Lime)
            {
                button112.BackColor = Color.Yellow;
            }
            else
            {
                button112.BackColor = Color.Red;
            }
        }

        private void button113_Click(object sender, EventArgs e)
        {
            if (button113.BackColor == Color.Lime)
            {
                button113.BackColor = Color.Yellow;
            }
            else
            {
                button113.BackColor = Color.Red;
            }
        }

        private void button114_Click(object sender, EventArgs e)
        {
            if (button114.BackColor == Color.Lime)
            {
                button114.BackColor = Color.Yellow;
            }
            else
            {
                button114.BackColor = Color.Red;
            }
        }

        private void button115_Click(object sender, EventArgs e)
        {
            if (button115.BackColor == Color.Lime)
            {
                button115.BackColor = Color.Yellow;
            }
            else
            {
                button115.BackColor = Color.Red;
            }
        }

        private void button116_Click(object sender, EventArgs e)
        {
            if (button116.BackColor == Color.Lime)
            {
                button116.BackColor = Color.Yellow;
            }
            else
            {
                button116.BackColor = Color.Red;
            }
        }

        private void button117_Click(object sender, EventArgs e)
        {
            if (button117.BackColor == Color.Lime)
            {
                button117.BackColor = Color.Yellow;
            }
            else
            {
                button117.BackColor = Color.Red;
            }
        }

        private void button118_Click(object sender, EventArgs e)
        {
            if (button118.BackColor == Color.Lime)
            {
                button118.BackColor = Color.Yellow;
            }
            else
            {
                button118.BackColor = Color.Red;
            }
        }

        private void button119_Click(object sender, EventArgs e)
        {
            if (button119.BackColor == Color.Lime)
            {
                button119.BackColor = Color.Yellow;
            }
            else
            {
                button119.BackColor = Color.Red;
            }
        }

        private void button120_Click(object sender, EventArgs e)
        {
            if (button120.BackColor == Color.Lime)
            {
                button120.BackColor = Color.Yellow;
            }
            else
            {
                button120.BackColor = Color.Red;
            }
        }

        private void button121_Click(object sender, EventArgs e)
        {
            if (button121.BackColor == Color.Lime)
            {
                button121.BackColor = Color.Yellow;
            }
            else
            {
                button121.BackColor = Color.Red;
            }
        }

        private void button122_Click(object sender, EventArgs e)
        {
            if (button122.BackColor == Color.Lime)
            {
                button122.BackColor = Color.Yellow;
            }
            else
            {
                button122.BackColor = Color.Red;
            }
        }

        private void button123_Click(object sender, EventArgs e)
        {
            if (button123.BackColor == Color.Lime)
            {
                button123.BackColor = Color.Yellow;
            }
            else
            {
                button123.BackColor = Color.Red;
            }
        }
        private void button124_Click(object sender, EventArgs e)
        {
            if (button124.BackColor == Color.Lime)
            {
                button124.BackColor = Color.Yellow;
            }
            else
            {
                button124.BackColor = Color.Red;
            }
        }


        private void button125_Click(object sender, EventArgs e)
        {
            if (button125.BackColor == Color.Lime)
            {
                button125.BackColor = Color.Yellow;
            }
            else
            {
                button125.BackColor = Color.Red;
            }
        }

        private void button126_Click(object sender, EventArgs e)
        {
            if (button126.BackColor == Color.Lime)
            {
                button126.BackColor = Color.Yellow;
            }
            else
            {
                button126.BackColor = Color.Red;
            }
        }

        private void button738_Click(object sender, EventArgs e)
        {
            button66.BackColor = Color.Lime;
            button67.BackColor = Color.Lime;
            button68.BackColor = Color.Lime;
            button69.BackColor = Color.Lime;
            button70.BackColor = Color.Lime;
            button71.BackColor = Color.Lime;
            button72.BackColor = Color.Lime;
            button73.BackColor = Color.Lime;
            button74.BackColor = Color.Lime;
            button75.BackColor = Color.Lime;
            button76.BackColor = Color.Lime;
            button77.BackColor = Color.Lime;
            button78.BackColor = Color.Lime;
            button79.BackColor = Color.Lime;
            button80.BackColor = Color.Lime;
            button81.BackColor = Color.Lime;
            button82.BackColor = Color.Lime;
            button83.BackColor = Color.Lime;
            button84.BackColor = Color.Lime;
            button85.BackColor = Color.Lime;
            button86.BackColor = Color.Lime;
            button87.BackColor = Color.Lime;
            button88.BackColor = Color.Lime;
            button89.BackColor = Color.Lime;
            button90.BackColor = Color.Lime;
            button91.BackColor = Color.Lime;
            button92.BackColor = Color.Lime;
            button93.BackColor = Color.Lime;
            button94.BackColor = Color.Lime;
            button95.BackColor = Color.Lime;
            button96.BackColor = Color.Lime;
            button97.BackColor = Color.Lime;
            button98.BackColor = Color.Lime;
            button99.BackColor = Color.Lime;
            button100.BackColor = Color.Lime;
            button101.BackColor = Color.Lime;
            button102.BackColor = Color.Lime;
            button103.BackColor = Color.Lime;
            button104.BackColor = Color.Lime;
            button105.BackColor = Color.Lime;
            button106.BackColor = Color.Lime;
            button107.BackColor = Color.Lime;
            button108.BackColor = Color.Lime;
            button109.BackColor = Color.Lime;
            button110.BackColor = Color.Lime;
            button111.BackColor = Color.Lime;
            button112.BackColor = Color.Lime;
            button113.BackColor = Color.Lime;
            button114.BackColor = Color.Lime;
            button115.BackColor = Color.Lime;
            button116.BackColor = Color.Lime;
            button117.BackColor = Color.Lime;
            button118.BackColor = Color.Lime;
            button119.BackColor = Color.Lime;
            button120.BackColor = Color.Lime;
            button121.BackColor = Color.Lime;
            button122.BackColor = Color.Lime;
            button123.BackColor = Color.Lime;
            button124.BackColor = Color.Lime;
            button125.BackColor = Color.Lime;
            button126.BackColor = Color.Lime;

        }
        //-------------------------------------------------------------------------------

        private void button127_Click(object sender, EventArgs e)
        {
            if (button127.BackColor == Color.Lime)
            {
                button127.BackColor = Color.Yellow;
            }
            else
            {
                button127.BackColor = Color.Red;
            }
        }

        private void button128_Click(object sender, EventArgs e)
        {
            if (button128.BackColor == Color.Lime)
            {
                button128.BackColor = Color.Yellow;
            }
            else
            {
                button128.BackColor = Color.Red;
            }
        }

        private void button129_Click(object sender, EventArgs e)
        {
            if (button129.BackColor == Color.Lime)
            {
                button129.BackColor = Color.Yellow;
            }
            else
            {
                button129.BackColor = Color.Red;
            }
        }

        private void button130_Click(object sender, EventArgs e)
        {
            if (button130.BackColor == Color.Lime)
            {
                button130.BackColor = Color.Yellow;
            }
            else
            {
                button130.BackColor = Color.Red;
            }
        }

        private void button131_Click(object sender, EventArgs e)
        {
            if (button131.BackColor == Color.Lime)
            {
                button131.BackColor = Color.Yellow;
            }
            else
            {
                button131.BackColor = Color.Red;
            }
        }

        private void button132_Click(object sender, EventArgs e)
        {
            if (button132.BackColor == Color.Lime)
            {
                button132.BackColor = Color.Yellow;
            }
            else
            {
                button132.BackColor = Color.Red;
            }
        }

        private void button133_Click(object sender, EventArgs e)
        {
            if (button133.BackColor == Color.Lime)
            {
                button133.BackColor = Color.Yellow;
            }
            else
            {
                button133.BackColor = Color.Red;
            }
        }

        private void button134_Click(object sender, EventArgs e)
        {
            if (button134.BackColor == Color.Lime)
            {
                button134.BackColor = Color.Yellow;
            }
            else
            {
                button134.BackColor = Color.Red;
            }
        }

        private void button135_Click(object sender, EventArgs e)
        {
            if (button135.BackColor == Color.Lime)
            {
                button135.BackColor = Color.Yellow;
            }
            else
            {
                button135.BackColor = Color.Red;
            }
        }

        private void button136_Click(object sender, EventArgs e)
        {
            if (button136.BackColor == Color.Lime)
            {
                button136.BackColor = Color.Yellow;
            }
            else
            {
                button136.BackColor = Color.Red;
            }
        }

        private void button137_Click(object sender, EventArgs e)
        {
            if (button137.BackColor == Color.Lime)
            {
                button137.BackColor = Color.Yellow;
            }
            else
            {
                button137.BackColor = Color.Red;
            }
        }

        private void button138_Click(object sender, EventArgs e)
        {
            if (button138.BackColor == Color.Lime)
            {
                button138.BackColor = Color.Yellow;
            }
            else
            {
                button138.BackColor = Color.Red;
            }
        }

        private void button139_Click(object sender, EventArgs e)
        {
            if (button139.BackColor == Color.Lime)
            {
                button139.BackColor = Color.Yellow;
            }
            else
            {
                button139.BackColor = Color.Red;
            }
        }

        private void button140_Click(object sender, EventArgs e)
        {
            if (button140.BackColor == Color.Lime)
            {
                button140.BackColor = Color.Yellow;
            }
            else
            {
                button140.BackColor = Color.Red;
            }
        }

        private void button141_Click(object sender, EventArgs e)
        {
            if (button141.BackColor == Color.Lime)
            {
                button141.BackColor = Color.Yellow;
            }
            else
            {
                button141.BackColor = Color.Red;
            }
        }

        private void button142_Click(object sender, EventArgs e)
        {
            if (button142.BackColor == Color.Lime)
            {
                button142.BackColor = Color.Yellow;
            }
            else
            {
                button142.BackColor = Color.Red;
            }
        }

        private void button143_Click(object sender, EventArgs e)
        {
            if (button143.BackColor == Color.Lime)
            {
                button143.BackColor = Color.Yellow;
            }
            else
            {
                button143.BackColor = Color.Red;
            }
        }

        private void button144_Click(object sender, EventArgs e)
        {
            if (button144.BackColor == Color.Lime)
            {
                button144.BackColor = Color.Yellow;
            }
            else
            {
                button144.BackColor = Color.Red;
            }
        }

        private void button145_Click(object sender, EventArgs e)
        {
            if (button145.BackColor == Color.Lime)
            {
                button145.BackColor = Color.Yellow;
            }
            else
            {
                button145.BackColor = Color.Red;
            }
        }

        private void button146_Click(object sender, EventArgs e)
        {
            if (button146.BackColor == Color.Lime)
            {
                button146.BackColor = Color.Yellow;
            }
            else
            {
                button146.BackColor = Color.Red;
            }
        }

        private void button147_Click(object sender, EventArgs e)
        {
            if (button147.BackColor == Color.Lime)
            {
                button147.BackColor = Color.Yellow;
            }
            else
            {
                button147.BackColor = Color.Red;
            }
        }

        private void button148_Click(object sender, EventArgs e)
        {
            if (button148.BackColor == Color.Lime)
            {
                button148.BackColor = Color.Yellow;
            }
            else
            {
                button148.BackColor = Color.Red;
            }
        }

        private void button149_Click(object sender, EventArgs e)
        {
            if (button149.BackColor == Color.Lime)
            {
                button149.BackColor = Color.Yellow;
            }
            else
            {
                button149.BackColor = Color.Red;
            }
        }

        private void button150_Click(object sender, EventArgs e)
        {
            if (button150.BackColor == Color.Lime)
            {
                button150.BackColor = Color.Yellow;
            }
            else
            {
                button150.BackColor = Color.Red;
            }
        }

        private void button151_Click(object sender, EventArgs e)
        {
            if (button151.BackColor == Color.Lime)
            {
                button151.BackColor = Color.Yellow;
            }
            else
            {
                button151.BackColor = Color.Red;
            }
        }

        private void button152_Click(object sender, EventArgs e)
        {
            if (button152.BackColor == Color.Lime)
            {
                button152.BackColor = Color.Yellow;
            }
            else
            {
                button152.BackColor = Color.Red;
            }
        }

        private void button153_Click(object sender, EventArgs e)
        {
            if (button153.BackColor == Color.Lime)
            {
                button153.BackColor = Color.Yellow;
            }
            else
            {
                button153.BackColor = Color.Red;
            }
        }

        private void button154_Click(object sender, EventArgs e)
        {
            if (button154.BackColor == Color.Lime)
            {
                button154.BackColor = Color.Yellow;
            }
            else
            {
                button154.BackColor = Color.Red;
            }
        }

        private void button155_Click(object sender, EventArgs e)
        {
            if (button155.BackColor == Color.Lime)
            {
                button155.BackColor = Color.Yellow;
            }
            else
            {
                button155.BackColor = Color.Red;
            }
        }

        private void button156_Click(object sender, EventArgs e)
        {
            if (button156.BackColor == Color.Lime)
            {
                button156.BackColor = Color.Yellow;
            }
            else
            {
                button156.BackColor = Color.Red;
            }

        }

        private void button157_Click(object sender, EventArgs e)
        {
            if (button157.BackColor == Color.Lime)
            {
                button157.BackColor = Color.Yellow;
            }
            else
            {
                button157.BackColor = Color.Red;
            }
        }

        private void button158_Click(object sender, EventArgs e)
        {
            if (button158.BackColor == Color.Lime)
            {
                button158.BackColor = Color.Yellow;
            }
            else
            {
                button158.BackColor = Color.Red;
            }
        }

        private void button159_Click(object sender, EventArgs e)
        {
            if (button159.BackColor == Color.Lime)
            {
                button159.BackColor = Color.Yellow;
            }
            else
            {
                button159.BackColor = Color.Red;
            }
        }

        private void button160_Click(object sender, EventArgs e)
        {
            if (button160.BackColor == Color.Lime)
            {
                button160.BackColor = Color.Yellow;
            }
            else
            {
                button160.BackColor = Color.Red;
            }
        }

        private void button161_Click(object sender, EventArgs e)
        {
            if (button161.BackColor == Color.Lime)
            {
                button161.BackColor = Color.Yellow;
            }
            else
            {
                button161.BackColor = Color.Red;
            }
        }

        private void button162_Click(object sender, EventArgs e)
        {
            if (button162.BackColor == Color.Lime)
            {
                button162.BackColor = Color.Yellow;
            }
            else
            {
                button162.BackColor = Color.Red;
            }
        }

        private void button163_Click(object sender, EventArgs e)
        {
            if (button163.BackColor == Color.Lime)
            {
                button163.BackColor = Color.Yellow;
            }
            else
            {
                button163.BackColor = Color.Red;
            }
        }

        private void button164_Click(object sender, EventArgs e)
        {
            if (button164.BackColor == Color.Lime)
            {
                button164.BackColor = Color.Yellow;
            }
            else
            {
                button164.BackColor = Color.Red;
            }
        }

        private void button165_Click(object sender, EventArgs e)
        {
            if (button165.BackColor == Color.Lime)
            {
                button165.BackColor = Color.Yellow;
            }
            else
            {
                button165.BackColor = Color.Red;
            }
        }

        private void button166_Click(object sender, EventArgs e)
        {
            if (button166.BackColor == Color.Lime)
            {
                button166.BackColor = Color.Yellow;
            }
            else
            {
                button166.BackColor = Color.Red;
            }
        }

        private void button167_Click(object sender, EventArgs e)
        {
            if (button167.BackColor == Color.Lime)
            {
                button167.BackColor = Color.Yellow;
            }
            else
            {
                button167.BackColor = Color.Red;
            }
        }

        private void button168_Click(object sender, EventArgs e)
        {
            if (button168.BackColor == Color.Lime)
            {
                button168.BackColor = Color.Yellow;
            }
            else
            {
                button168.BackColor = Color.Red;
            }
        }

        private void button169_Click(object sender, EventArgs e)
        {
            if (button169.BackColor == Color.Lime)
            {
                button169.BackColor = Color.Yellow;
            }
            else
            {
                button169.BackColor = Color.Red;
            }
        }

        private void button170_Click(object sender, EventArgs e)
        {
            if (button170.BackColor == Color.Lime)
            {
                button170.BackColor = Color.Yellow;
            }
            else
            {
                button170.BackColor = Color.Red;
            }
        }

        private void button171_Click(object sender, EventArgs e)
        {
            if (button171.BackColor == Color.Lime)
            {
                button171.BackColor = Color.Yellow;
            }
            else
            {
                button171.BackColor = Color.Red;
            }
        }

        private void button172_Click(object sender, EventArgs e)
        {
            if (button172.BackColor == Color.Lime)
            {
                button172.BackColor = Color.Yellow;
            }
            else
            {
                button172.BackColor = Color.Red;
            }
        }

        private void button173_Click(object sender, EventArgs e)
        {
            if (button173.BackColor == Color.Lime)
            {
                button173.BackColor = Color.Yellow;
            }
            else
            {
                button173.BackColor = Color.Red;
            }
        }

        private void button174_Click(object sender, EventArgs e)
        {
            if (button174.BackColor == Color.Lime)
            {
                button174.BackColor = Color.Yellow;
            }
            else
            {
                button174.BackColor = Color.Red;
            }
        }

        private void button175_Click(object sender, EventArgs e)
        {
            if (button175.BackColor == Color.Lime)
            {
                button175.BackColor = Color.Yellow;
            }
            else
            {
                button175.BackColor = Color.Red;
            }
        }

        private void button176_Click(object sender, EventArgs e)
        {
            if (button176.BackColor == Color.Lime)
            {
                button176.BackColor = Color.Yellow;
            }
            else
            {
                button176.BackColor = Color.Red;
            }
        }

        private void button177_Click(object sender, EventArgs e)
        {
            if (button177.BackColor == Color.Lime)
            {
                button177.BackColor = Color.Yellow;
            }
            else
            {
                button177.BackColor = Color.Red;
            }
        }

        private void button178_Click(object sender, EventArgs e)
        {
            if (button178.BackColor == Color.Lime)
            {
                button178.BackColor = Color.Yellow;
            }
            else
            {
                button178.BackColor = Color.Red;
            }
        }

        private void button179_Click(object sender, EventArgs e)
        {
            if (button179.BackColor == Color.Lime)
            {
                button179.BackColor = Color.Yellow;
            }
            else
            {
                button179.BackColor = Color.Red;
            }
        }

        private void button180_Click(object sender, EventArgs e)
        {
            if (button180.BackColor == Color.Lime)
            {
                button180.BackColor = Color.Yellow;
            }
            else
            {
                button180.BackColor = Color.Red;
            }
        }

        private void button181_Click(object sender, EventArgs e)
        {
            if (button181.BackColor == Color.Lime)
            {
                button181.BackColor = Color.Yellow;
            }
            else
            {
                button181.BackColor = Color.Red;
            }
        }

        private void button182_Click(object sender, EventArgs e)
        {
            if (button182.BackColor == Color.Lime)
            {
                button182.BackColor = Color.Yellow;
            }
            else
            {
                button182.BackColor = Color.Red;
            }
        }

        private void button183_Click(object sender, EventArgs e)
        {
            if (button183.BackColor == Color.Lime)
            {
                button183.BackColor = Color.Yellow;
            }
            else
            {
                button183.BackColor = Color.Red;
            }
        }

        private void button184_Click(object sender, EventArgs e)
        {
            if (button184.BackColor == Color.Lime)
            {
                button184.BackColor = Color.Yellow;
            }
            else
            {
                button184.BackColor = Color.Red;
            }
        }

        private void button185_Click(object sender, EventArgs e)
        {
            if (button185.BackColor == Color.Lime)
            {
                button185.BackColor = Color.Yellow;
            }
            else
            {
                button185.BackColor = Color.Red;
            }
        }

        private void button186_Click(object sender, EventArgs e)
        {
            if (button186.BackColor == Color.Lime)
            {
                button186.BackColor = Color.Yellow;
            }
            else
            {
                button186.BackColor = Color.Red;
            }
        }

        private void button187_Click(object sender, EventArgs e)
        {
            if (button187.BackColor == Color.Lime)
            {
                button187.BackColor = Color.Yellow;
            }
            else
            {
                button187.BackColor = Color.Red;
            }

        }

        private void button739_Click(object sender, EventArgs e)
        {
            button127.BackColor = Color.Lime;
            button128.BackColor = Color.Lime;
            button129.BackColor = Color.Lime;
            button130.BackColor = Color.Lime;
            button131.BackColor = Color.Lime;
            button132.BackColor = Color.Lime;
            button133.BackColor = Color.Lime;
            button134.BackColor = Color.Lime;
            button135.BackColor = Color.Lime;
            button136.BackColor = Color.Lime;
            button137.BackColor = Color.Lime;
            button138.BackColor = Color.Lime;
            button139.BackColor = Color.Lime;
            button140.BackColor = Color.Lime;
            button141.BackColor = Color.Lime;
            button142.BackColor = Color.Lime;
            button143.BackColor = Color.Lime;
            button144.BackColor = Color.Lime;
            button145.BackColor = Color.Lime;
            button146.BackColor = Color.Lime;
            button147.BackColor = Color.Lime;
            button148.BackColor = Color.Lime;
            button149.BackColor = Color.Lime;
            button150.BackColor = Color.Lime;
            button151.BackColor = Color.Lime;
            button152.BackColor = Color.Lime;
            button153.BackColor = Color.Lime;
            button154.BackColor = Color.Lime;
            button155.BackColor = Color.Lime;
            button156.BackColor = Color.Lime;
            button157.BackColor = Color.Lime;
            button158.BackColor = Color.Lime;
            button159.BackColor = Color.Lime;
            button160.BackColor = Color.Lime;
            button161.BackColor = Color.Lime;
            button162.BackColor = Color.Lime;
            button163.BackColor = Color.Lime;
            button164.BackColor = Color.Lime;
            button165.BackColor = Color.Lime;
            button166.BackColor = Color.Lime;
            button167.BackColor = Color.Lime;
            button168.BackColor = Color.Lime;
            button169.BackColor = Color.Lime;
            button170.BackColor = Color.Lime;
            button171.BackColor = Color.Lime;
            button172.BackColor = Color.Lime;
            button173.BackColor = Color.Lime;
            button174.BackColor = Color.Lime;
            button175.BackColor = Color.Lime;
            button176.BackColor = Color.Lime;
            button177.BackColor = Color.Lime;
            button178.BackColor = Color.Lime;
            button179.BackColor = Color.Lime;
            button180.BackColor = Color.Lime;
            button181.BackColor = Color.Lime;
            button182.BackColor = Color.Lime;
            button183.BackColor = Color.Lime;
            button184.BackColor = Color.Lime;
            button185.BackColor = Color.Lime;
            button186.BackColor = Color.Lime;
            button187.BackColor = Color.Lime;


        }
        //-------------------------------------------------------------------------

        private void button188_Click(object sender, EventArgs e)
        {
            if (button188.BackColor == Color.Lime)
            {
                button188.BackColor = Color.Yellow;
            }
            else
            {
                button188.BackColor = Color.Red;
            }
        }

        private void button189_Click(object sender, EventArgs e)
        {
            if (button189.BackColor == Color.Lime)
            {
                button189.BackColor = Color.Yellow;
            }
            else
            {
                button189.BackColor = Color.Red;
            }
        }

        private void button190_Click(object sender, EventArgs e)
        {
            if (button190.BackColor == Color.Lime)
            {
                button190.BackColor = Color.Yellow;
            }
            else
            {
                button190.BackColor = Color.Red;
            }
        }

        private void button191_Click(object sender, EventArgs e)
        {
            if (button191.BackColor == Color.Lime)
            {
                button191.BackColor = Color.Yellow;
            }
            else
            {
                button191.BackColor = Color.Red;
            }
        }

        private void button192_Click(object sender, EventArgs e)
        {
            if (button192.BackColor == Color.Lime)
            {
                button192.BackColor = Color.Yellow;
            }
            else
            {
                button192.BackColor = Color.Red;
            }
        }

        private void button193_Click(object sender, EventArgs e)
        {
            if (button193.BackColor == Color.Lime)
            {
                button193.BackColor = Color.Yellow;
            }
            else
            {
                button193.BackColor = Color.Red;
            }
        }

        private void button194_Click(object sender, EventArgs e)
        {
            if (button194.BackColor == Color.Lime)
            {
                button194.BackColor = Color.Yellow;
            }
            else
            {
                button194.BackColor = Color.Red;
            }
        }

        private void button195_Click(object sender, EventArgs e)
        {
            if (button195.BackColor == Color.Lime)
            {
                button195.BackColor = Color.Yellow;
            }
            else
            {
                button195.BackColor = Color.Red;
            }
        }

        private void button196_Click(object sender, EventArgs e)
        {
            if (button196.BackColor == Color.Lime)
            {
                button196.BackColor = Color.Yellow;
            }
            else
            {
                button196.BackColor = Color.Red;
            }
        }

        private void button197_Click(object sender, EventArgs e)
        {
            if (button197.BackColor == Color.Lime)
            {
                button197.BackColor = Color.Yellow;
            }
            else
            {
                button197.BackColor = Color.Red;
            }
        }

        private void button198_Click(object sender, EventArgs e)
        {
            if (button198.BackColor == Color.Lime)
            {
                button198.BackColor = Color.Yellow;
            }
            else
            {
                button198.BackColor = Color.Red;
            }
        }

        private void button199_Click(object sender, EventArgs e)
        {
            if (button199.BackColor == Color.Lime)
            {
                button199.BackColor = Color.Yellow;
            }
            else
            {
                button199.BackColor = Color.Red;
            }
        }

        private void button200_Click(object sender, EventArgs e)
        {
            if (button200.BackColor == Color.Lime)
            {
                button200.BackColor = Color.Yellow;
            }
            else
            {
                button200.BackColor = Color.Red;
            }

        }

        private void button201_Click(object sender, EventArgs e)
        {
            if (button201.BackColor == Color.Lime)
            {
                button201.BackColor = Color.Yellow;
            }
            else
            {
                button201.BackColor = Color.Red;
            }

        }

        private void button202_Click(object sender, EventArgs e)
        {
            if (button202.BackColor == Color.Lime)
            {
                button202.BackColor = Color.Yellow;
            }
            else
            {
                button202.BackColor = Color.Red;
            }
        }

        private void button203_Click(object sender, EventArgs e)
        {
            if (button203.BackColor == Color.Lime)
            {
                button203.BackColor = Color.Yellow;
            }
            else
            {
                button203.BackColor = Color.Red;
            }
        }

        private void button204_Click(object sender, EventArgs e)
        {
            if (button204.BackColor == Color.Lime)
            {
                button204.BackColor = Color.Yellow;
            }
            else
            {
                button204.BackColor = Color.Red;
            }
        }

        private void button205_Click(object sender, EventArgs e)
        {
            if (button205.BackColor == Color.Lime)
            {
                button205.BackColor = Color.Yellow;
            }
            else
            {
                button205.BackColor = Color.Red;
            }
        }

        private void button206_Click(object sender, EventArgs e)
        {
            if (button206.BackColor == Color.Lime)
            {
                button206.BackColor = Color.Yellow;
            }
            else
            {
                button206.BackColor = Color.Red;
            }
        }

        private void button207_Click(object sender, EventArgs e)
        {
            if (button207.BackColor == Color.Lime)
            {
                button207.BackColor = Color.Yellow;
            }
            else
            {
                button207.BackColor = Color.Red;
            }
        }

        private void button208_Click(object sender, EventArgs e)
        {
            if (button208.BackColor == Color.Lime)
            {
                button208.BackColor = Color.Yellow;
            }
            else
            {
                button208.BackColor = Color.Red;
            }
        }

        private void button209_Click(object sender, EventArgs e)
        {
            if (button209.BackColor == Color.Lime)
            {
                button209.BackColor = Color.Yellow;
            }
            else
            {
                button209.BackColor = Color.Red;
            }
        }

        private void button210_Click(object sender, EventArgs e)
        {
            if (button210.BackColor == Color.Lime)
            {
                button210.BackColor = Color.Yellow;
            }
            else
            {
                button210.BackColor = Color.Red;
            }
        }

        private void button211_Click(object sender, EventArgs e)
        {
            if (button211.BackColor == Color.Lime)
            {
                button211.BackColor = Color.Yellow;
            }
            else
            {
                button211.BackColor = Color.Red;
            }
        }

        private void button212_Click(object sender, EventArgs e)
        {
            if (button212.BackColor == Color.Lime)
            {
                button212.BackColor = Color.Yellow;
            }
            else
            {
                button212.BackColor = Color.Red;
            }
        }

        private void button213_Click(object sender, EventArgs e)
        {
            if (button213.BackColor == Color.Lime)
            {
                button213.BackColor = Color.Yellow;
            }
            else
            {
                button213.BackColor = Color.Red;
            }
        }

        private void button214_Click(object sender, EventArgs e)
        {
            if (button214.BackColor == Color.Lime)
            {
                button214.BackColor = Color.Yellow;
            }
            else
            {
                button214.BackColor = Color.Red;
            }
        }

        private void button215_Click(object sender, EventArgs e)
        {
            if (button215.BackColor == Color.Lime)
            {
                button215.BackColor = Color.Yellow;
            }
            else
            {
                button215.BackColor = Color.Red;
            }
        }

        private void button216_Click(object sender, EventArgs e)
        {
            if (button216.BackColor == Color.Lime)
            {
                button216.BackColor = Color.Yellow;
            }
            else
            {
                button216.BackColor = Color.Red;
            }
        }

        private void button217_Click(object sender, EventArgs e)
        {
            if (button217.BackColor == Color.Lime)
            {
                button217.BackColor = Color.Yellow;
            }
            else
            {
                button217.BackColor = Color.Red;
            }
        }

        private void button218_Click(object sender, EventArgs e)
        {
            if (button218.BackColor == Color.Lime)
            {
                button218.BackColor = Color.Yellow;
            }
            else
            {
                button218.BackColor = Color.Red;
            }
        }

        private void button219_Click(object sender, EventArgs e)
        {
            if (button219.BackColor == Color.Lime)
            {
                button219.BackColor = Color.Yellow;
            }
            else
            {
                button219.BackColor = Color.Red;
            }
        }

        private void button220_Click(object sender, EventArgs e)
        {
            if (button220.BackColor == Color.Lime)
            {
                button220.BackColor = Color.Yellow;
            }
            else
            {
                button220.BackColor = Color.Red;
            }
        }

        private void button221_Click(object sender, EventArgs e)
        {
            if (button221.BackColor == Color.Lime)
            {
                button221.BackColor = Color.Yellow;
            }
            else
            {
                button221.BackColor = Color.Red;
            }
        }

        private void button222_Click(object sender, EventArgs e)
        {
            if (button222.BackColor == Color.Lime)
            {
                button222.BackColor = Color.Yellow;
            }
            else
            {
                button222.BackColor = Color.Red;
            }
        }

        private void button223_Click(object sender, EventArgs e)
        {
            if (button223.BackColor == Color.Lime)
            {
                button223.BackColor = Color.Yellow;
            }
            else
            {
                button223.BackColor = Color.Red;
            }
        }

        private void button224_Click(object sender, EventArgs e)
        {
            if (button224.BackColor == Color.Lime)
            {
                button224.BackColor = Color.Yellow;
            }
            else
            {
                button224.BackColor = Color.Red;
            }
        }

        private void button225_Click(object sender, EventArgs e)
        {
            if (button225.BackColor == Color.Lime)
            {
                button225.BackColor = Color.Yellow;
            }
            else
            {
                button225.BackColor = Color.Red;
            }
        }

        private void button226_Click(object sender, EventArgs e)
        {
            if (button226.BackColor == Color.Lime)
            {
                button226.BackColor = Color.Yellow;
            }
            else
            {
                button226.BackColor = Color.Red;
            }
        }

        private void button227_Click(object sender, EventArgs e)
        {
            if (button227.BackColor == Color.Lime)
            {
                button227.BackColor = Color.Yellow;
            }
            else
            {
                button227.BackColor = Color.Red;
            }
        }

        private void button228_Click(object sender, EventArgs e)
        {
            if (button228.BackColor == Color.Lime)
            {
                button228.BackColor = Color.Yellow;
            }
            else
            {
                button228.BackColor = Color.Red;
            }
        }

        private void button229_Click(object sender, EventArgs e)
        {
            if (button229.BackColor == Color.Lime)
            {
                button229.BackColor = Color.Yellow;
            }
            else
            {
                button229.BackColor = Color.Red;
            }
        }

        private void button230_Click(object sender, EventArgs e)
        {
            if (button230.BackColor == Color.Lime)
            {
                button230.BackColor = Color.Yellow;
            }
            else
            {
                button230.BackColor = Color.Red;
            }
        }

        private void button231_Click(object sender, EventArgs e)
        {
            if (button231.BackColor == Color.Lime)
            {
                button231.BackColor = Color.Yellow;
            }
            else
            {
                button231.BackColor = Color.Red;
            }
        }

        private void button232_Click(object sender, EventArgs e)
        {
            if (button232.BackColor == Color.Lime)
            {
                button232.BackColor = Color.Yellow;
            }
            else
            {
                button232.BackColor = Color.Red;
            }
        }

        private void button233_Click(object sender, EventArgs e)
        {
            if (button233.BackColor == Color.Lime)
            {
                button233.BackColor = Color.Yellow;
            }
            else
            {
                button233.BackColor = Color.Red;
            }
        }

        private void button234_Click(object sender, EventArgs e)
        {
            if (button234.BackColor == Color.Lime)
            {
                button234.BackColor = Color.Yellow;
            }
            else
            {
                button234.BackColor = Color.Red;
            }
        }

        private void button235_Click(object sender, EventArgs e)
        {
            if (button235.BackColor == Color.Lime)
            {
                button235.BackColor = Color.Yellow;
            }
            else
            {
                button235.BackColor = Color.Red;
            }
        }

        private void button236_Click(object sender, EventArgs e)
        {
            if (button236.BackColor == Color.Lime)
            {
                button236.BackColor = Color.Yellow;
            }
            else
            {
                button236.BackColor = Color.Red;
            }
        }

        private void button237_Click(object sender, EventArgs e)
        {
            if (button237.BackColor == Color.Lime)
            {
                button237.BackColor = Color.Yellow;
            }
            else
            {
                button237.BackColor = Color.Red;
            }
        }

        private void button238_Click(object sender, EventArgs e)
        {
            if (button238.BackColor == Color.Lime)
            {
                button238.BackColor = Color.Yellow;
            }
            else
            {
                button238.BackColor = Color.Red;
            }
        }

        private void button239_Click(object sender, EventArgs e)
        {
            if (button239.BackColor == Color.Lime)
            {
                button239.BackColor = Color.Yellow;
            }
            else
            {
                button239.BackColor = Color.Red;
            }
        }

        private void button240_Click(object sender, EventArgs e)
        {
            if (button240.BackColor == Color.Lime)
            {
                button240.BackColor = Color.Yellow;
            }
            else
            {
                button240.BackColor = Color.Red;
            }
        }

        private void button241_Click(object sender, EventArgs e)
        {
            if (button241.BackColor == Color.Lime)
            {
                button241.BackColor = Color.Yellow;
            }
            else
            {
                button241.BackColor = Color.Red;
            }
        }

        private void button242_Click(object sender, EventArgs e)
        {
            if (button242.BackColor == Color.Lime)
            {
                button242.BackColor = Color.Yellow;
            }
            else
            {
                button242.BackColor = Color.Red;
            }
        }

        private void button243_Click(object sender, EventArgs e)
        {
            if (button243.BackColor == Color.Lime)
            {
                button243.BackColor = Color.Yellow;
            }
            else
            {
                button243.BackColor = Color.Red;
            }
        }

        private void button244_Click(object sender, EventArgs e)
        {
            if (button244.BackColor == Color.Lime)
            {
                button244.BackColor = Color.Yellow;
            }
            else
            {
                button244.BackColor = Color.Red;
            }
        }

        private void button245_Click(object sender, EventArgs e)
        {
            if (button245.BackColor == Color.Lime)
            {
                button245.BackColor = Color.Yellow;
            }
            else
            {
                button245.BackColor = Color.Red;
            }
        }

        private void button246_Click(object sender, EventArgs e)
        {
            if (button246.BackColor == Color.Lime)
            {
                button246.BackColor = Color.Yellow;
            }
            else
            {
                button246.BackColor = Color.Red;
            }
        }

        private void button247_Click(object sender, EventArgs e)
        {
            if (button247.BackColor == Color.Lime)
            {
                button247.BackColor = Color.Yellow;
            }
            else
            {
                button247.BackColor = Color.Red;
            }
        }

        private void button248_Click(object sender, EventArgs e)
        {
            if (button248.BackColor == Color.Lime)
            {
                button248.BackColor = Color.Yellow;
            }
            else
            {
                button248.BackColor = Color.Red;
            }

        }

        private void button740_Click(object sender, EventArgs e)
        {
            button188.BackColor = Color.Lime;
            button189.BackColor = Color.Lime;
            button190.BackColor = Color.Lime;
            button191.BackColor = Color.Lime;
            button192.BackColor = Color.Lime;
            button193.BackColor = Color.Lime;
            button194.BackColor = Color.Lime;
            button195.BackColor = Color.Lime;
            button196.BackColor = Color.Lime;
            button197.BackColor = Color.Lime;
            button198.BackColor = Color.Lime;
            button199.BackColor = Color.Lime;
            button200.BackColor = Color.Lime;
            button201.BackColor = Color.Lime;
            button202.BackColor = Color.Lime;
            button203.BackColor = Color.Lime;
            button204.BackColor = Color.Lime;
            button205.BackColor = Color.Lime;
            button206.BackColor = Color.Lime;
            button207.BackColor = Color.Lime;
            button208.BackColor = Color.Lime;
            button209.BackColor = Color.Lime;
            button210.BackColor = Color.Lime;
            button211.BackColor = Color.Lime;
            button212.BackColor = Color.Lime;
            button213.BackColor = Color.Lime;
            button214.BackColor = Color.Lime;
            button215.BackColor = Color.Lime;
            button216.BackColor = Color.Lime;
            button217.BackColor = Color.Lime;
            button218.BackColor = Color.Lime;
            button219.BackColor = Color.Lime;
            button220.BackColor = Color.Lime;
            button221.BackColor = Color.Lime;
            button222.BackColor = Color.Lime;
            button223.BackColor = Color.Lime;
            button224.BackColor = Color.Lime;
            button225.BackColor = Color.Lime;
            button226.BackColor = Color.Lime;
            button227.BackColor = Color.Lime;
            button228.BackColor = Color.Lime;
            button229.BackColor = Color.Lime;
            button230.BackColor = Color.Lime;
            button231.BackColor = Color.Lime;
            button232.BackColor = Color.Lime;
            button233.BackColor = Color.Lime;
            button234.BackColor = Color.Lime;
            button235.BackColor = Color.Lime;
            button236.BackColor = Color.Lime;
            button237.BackColor = Color.Lime;
            button238.BackColor = Color.Lime;
            button239.BackColor = Color.Lime;
            button240.BackColor = Color.Lime;
            button241.BackColor = Color.Lime;
            button242.BackColor = Color.Lime;
            button243.BackColor = Color.Lime;
            button244.BackColor = Color.Lime;
            button245.BackColor = Color.Lime;
            button246.BackColor = Color.Lime;
            button247.BackColor = Color.Lime;
            button248.BackColor = Color.Lime;

        }
        //-------------------------------------------------------------------------------------------------

        private void button250_Click(object sender, EventArgs e)
        {
            if (button250.BackColor == Color.Lime)
            {
                button250.BackColor = Color.Yellow;
            }
            else
            {
                button250.BackColor = Color.Red;
            }
        }

        private void button251_Click(object sender, EventArgs e)
        {
            if (button251.BackColor == Color.Lime)
            {
                button251.BackColor = Color.Yellow;
            }
            else
            {
                button251.BackColor = Color.Red;
            }

        }

        private void button252_Click(object sender, EventArgs e)
        {
            if (button252.BackColor == Color.Lime)
            {
                button252.BackColor = Color.Yellow;
            }
            else
            {
                button252.BackColor = Color.Red;
            }
        }

        private void button253_Click(object sender, EventArgs e)
        {
            if (button253.BackColor == Color.Lime)
            {
                button253.BackColor = Color.Yellow;
            }
            else
            {
                button253.BackColor = Color.Red;
            }
        }

        private void button254_Click(object sender, EventArgs e)
        {
            if (button254.BackColor == Color.Lime)
            {
                button254.BackColor = Color.Yellow;
            }
            else
            {
                button254.BackColor = Color.Red;
            }
        }

        private void button255_Click(object sender, EventArgs e)
        {
            if (button255.BackColor == Color.Lime)
            {
                button255.BackColor = Color.Yellow;
            }
            else
            {
                button255.BackColor = Color.Red;
            }
        }

        private void button256_Click(object sender, EventArgs e)
        {
            if (button256.BackColor == Color.Lime)
            {
                button256.BackColor = Color.Yellow;
            }
            else
            {
                button256.BackColor = Color.Red;
            }
        }

        private void button257_Click(object sender, EventArgs e)
        {
            if (button257.BackColor == Color.Lime)
            {
                button257.BackColor = Color.Yellow;
            }
            else
            {
                button257.BackColor = Color.Red;
            }
        }

        private void button258_Click(object sender, EventArgs e)
        {
            if (button258.BackColor == Color.Lime)
            {
                button258.BackColor = Color.Yellow;
            }
            else
            {
                button258.BackColor = Color.Red;
            }
        }

        private void button259_Click(object sender, EventArgs e)
        {
            if (button259.BackColor == Color.Lime)
            {
                button259.BackColor = Color.Yellow;
            }
            else
            {
                button259.BackColor = Color.Red;
            }
        }

        private void button260_Click(object sender, EventArgs e)
        {
            if (button260.BackColor == Color.Lime)
            {
                button260.BackColor = Color.Yellow;
            }
            else
            {
                button260.BackColor = Color.Red;
            }
        }

        private void button261_Click(object sender, EventArgs e)
        {
            if (button261.BackColor == Color.Lime)
            {
                button261.BackColor = Color.Yellow;
            }
            else
            {
                button261.BackColor = Color.Red;
            }
        }

        private void button262_Click(object sender, EventArgs e)
        {
            if (button262.BackColor == Color.Lime)
            {
                button262.BackColor = Color.Yellow;
            }
            else
            {
                button262.BackColor = Color.Red;
            }
        }

        private void button263_Click(object sender, EventArgs e)
        {
            if (button263.BackColor == Color.Lime)
            {
                button263.BackColor = Color.Yellow;
            }
            else
            {
                button263.BackColor = Color.Red;
            }
        }

        private void button264_Click(object sender, EventArgs e)
        {
            if (button264.BackColor == Color.Lime)
            {
                button264.BackColor = Color.Yellow;
            }
            else
            {
                button264.BackColor = Color.Red;
            }
        }

        private void button265_Click(object sender, EventArgs e)
        {
            if (button265.BackColor == Color.Lime)
            {
                button265.BackColor = Color.Yellow;
            }
            else
            {
                button265.BackColor = Color.Red;
            }
        }

        private void button266_Click(object sender, EventArgs e)
        {
            if (button266.BackColor == Color.Lime)
            {
                button266.BackColor = Color.Yellow;
            }
            else
            {
                button266.BackColor = Color.Red;
            }
        }

        private void button267_Click(object sender, EventArgs e)
        {
            if (button267.BackColor == Color.Lime)
            {
                button267.BackColor = Color.Yellow;
            }
            else
            {
                button267.BackColor = Color.Red;
            }
        }

        private void button268_Click(object sender, EventArgs e)
        {
            if (button268.BackColor == Color.Lime)
            {
                button268.BackColor = Color.Yellow;
            }
            else
            {
                button268.BackColor = Color.Red;
            }
        }

        private void button269_Click(object sender, EventArgs e)
        {
            if (button269.BackColor == Color.Lime)
            {
                button269.BackColor = Color.Yellow;
            }
            else
            {
                button269.BackColor = Color.Red;
            }
        }

        private void button270_Click(object sender, EventArgs e)
        {
            if (button270.BackColor == Color.Lime)
            {
                button270.BackColor = Color.Yellow;
            }
            else
            {
                button270.BackColor = Color.Red;
            }
        }

        private void button271_Click(object sender, EventArgs e)
        {
            if (button271.BackColor == Color.Lime)
            {
                button271.BackColor = Color.Yellow;
            }
            else
            {
                button271.BackColor = Color.Red;
            }
        }

        private void button272_Click(object sender, EventArgs e)
        {
            if (button272.BackColor == Color.Lime)
            {
                button272.BackColor = Color.Yellow;
            }
            else
            {
                button272.BackColor = Color.Red;
            }
        }

        private void button273_Click(object sender, EventArgs e)
        {
            if (button273.BackColor == Color.Lime)
            {
                button273.BackColor = Color.Yellow;
            }
            else
            {
                button273.BackColor = Color.Red;
            }
        }

        private void button274_Click(object sender, EventArgs e)
        {
            if (button274.BackColor == Color.Lime)
            {
                button274.BackColor = Color.Yellow;
            }
            else
            {
                button274.BackColor = Color.Red;
            }
        }

        private void button275_Click(object sender, EventArgs e)
        {
            if (button275.BackColor == Color.Lime)
            {
                button275.BackColor = Color.Yellow;
            }
            else
            {
                button275.BackColor = Color.Red;
            }
        }

        private void button276_Click(object sender, EventArgs e)
        {
            if (button276.BackColor == Color.Lime)
            {
                button276.BackColor = Color.Yellow;
            }
            else
            {
                button276.BackColor = Color.Red;
            }
        }

        private void button277_Click(object sender, EventArgs e)
        {
            if (button277.BackColor == Color.Lime)
            {
                button277.BackColor = Color.Yellow;
            }
            else
            {
                button277.BackColor = Color.Red;
            }
        }

        private void button278_Click(object sender, EventArgs e)
        {
            if (button278.BackColor == Color.Lime)
            {
                button278.BackColor = Color.Yellow;
            }
            else
            {
                button278.BackColor = Color.Red;
            }
        }

        private void button279_Click(object sender, EventArgs e)
        {
            if (button279.BackColor == Color.Lime)
            {
                button279.BackColor = Color.Yellow;
            }
            else
            {
                button279.BackColor = Color.Red;
            }
        }

        private void button280_Click(object sender, EventArgs e)
        {
            if (button280.BackColor == Color.Lime)
            {
                button280.BackColor = Color.Yellow;
            }
            else
            {
                button280.BackColor = Color.Red;
            }
        }

        private void button281_Click(object sender, EventArgs e)
        {
            if (button281.BackColor == Color.Lime)
            {
                button281.BackColor = Color.Yellow;
            }
            else
            {
                button281.BackColor = Color.Red;
            }
        }

        private void button282_Click(object sender, EventArgs e)
        {
            if (button282.BackColor == Color.Lime)
            {
                button282.BackColor = Color.Yellow;
            }
            else
            {
                button282.BackColor = Color.Red;
            }
        }

        private void button283_Click(object sender, EventArgs e)
        {
            if (button283.BackColor == Color.Lime)
            {
                button283.BackColor = Color.Yellow;
            }
            else
            {
                button283.BackColor = Color.Red;
            }
        }

        private void button284_Click(object sender, EventArgs e)
        {
            if (button284.BackColor == Color.Lime)
            {
                button284.BackColor = Color.Yellow;
            }
            else
            {
                button284.BackColor = Color.Red;
            }
        }

        private void button285_Click(object sender, EventArgs e)
        {
            if (button285.BackColor == Color.Lime)
            {
                button285.BackColor = Color.Yellow;
            }
            else
            {
                button285.BackColor = Color.Red;
            }
        }

        private void button286_Click(object sender, EventArgs e)
        {
            if (button286.BackColor == Color.Lime)
            {
                button286.BackColor = Color.Yellow;
            }
            else
            {
                button286.BackColor = Color.Red;
            }
        }

        private void button287_Click(object sender, EventArgs e)
        {
            if (button287.BackColor == Color.Lime)
            {
                button287.BackColor = Color.Yellow;
            }
            else
            {
                button287.BackColor = Color.Red;
            }
        }

        private void button288_Click(object sender, EventArgs e)
        {
            if (button288.BackColor == Color.Lime)
            {
                button288.BackColor = Color.Yellow;
            }
            else
            {
                button288.BackColor = Color.Red;
            }
        }

        private void button289_Click(object sender, EventArgs e)
        {
            if (button289.BackColor == Color.Lime)
            {
                button289.BackColor = Color.Yellow;
            }
            else
            {
                button289.BackColor = Color.Red;
            }
        }

        private void button290_Click(object sender, EventArgs e)
        {
            if (button290.BackColor == Color.Lime)
            {
                button290.BackColor = Color.Yellow;
            }
            else
            {
                button290.BackColor = Color.Red;
            }
        }

        private void button291_Click(object sender, EventArgs e)
        {
            if (button291.BackColor == Color.Lime)
            {
                button291.BackColor = Color.Yellow;
            }
            else
            {
                button291.BackColor = Color.Red;
            }
        }

        private void button292_Click(object sender, EventArgs e)
        {
            if (button292.BackColor == Color.Lime)
            {
                button292.BackColor = Color.Yellow;
            }
            else
            {
                button292.BackColor = Color.Red;
            }
        }

        private void button293_Click(object sender, EventArgs e)
        {
            if (button293.BackColor == Color.Lime)
            {
                button293.BackColor = Color.Yellow;
            }
            else
            {
                button293.BackColor = Color.Red;
            }
        }

        private void button294_Click(object sender, EventArgs e)
        {
            if (button294.BackColor == Color.Lime)
            {
                button294.BackColor = Color.Yellow;
            }
            else
            {
                button294.BackColor = Color.Red;
            }
        }

        private void button295_Click(object sender, EventArgs e)
        {
            if (button295.BackColor == Color.Lime)
            {
                button295.BackColor = Color.Yellow;
            }
            else
            {
                button295.BackColor = Color.Red;
            }
        }

        private void button296_Click(object sender, EventArgs e)
        {
            if (button296.BackColor == Color.Lime)
            {
                button296.BackColor = Color.Yellow;
            }
            else
            {
                button296.BackColor = Color.Red;
            }
        }

        private void button297_Click(object sender, EventArgs e)
        {
            if (button297.BackColor == Color.Lime)
            {
                button297.BackColor = Color.Yellow;
            }
            else
            {
                button297.BackColor = Color.Red;
            }
        }

        private void button298_Click(object sender, EventArgs e)
        {
            if (button298.BackColor == Color.Lime)
            {
                button298.BackColor = Color.Yellow;
            }
            else
            {
                button298.BackColor = Color.Red;
            }
        }

        private void button299_Click(object sender, EventArgs e)
        {
            if (button299.BackColor == Color.Lime)
            {
                button299.BackColor = Color.Yellow;
            }
            else
            {
                button299.BackColor = Color.Red;
            }
        }

        private void button300_Click(object sender, EventArgs e)
        {
            if (button300.BackColor == Color.Lime)
            {
                button300.BackColor = Color.Yellow;
            }
            else
            {
                button300.BackColor = Color.Red;
            }
        }

        private void button301_Click(object sender, EventArgs e)
        {
            if (button301.BackColor == Color.Lime)
            {
                button301.BackColor = Color.Yellow;
            }
            else
            {
                button301.BackColor = Color.Red;
            }
        }

        private void button302_Click(object sender, EventArgs e)
        {
            if (button302.BackColor == Color.Lime)
            {
                button302.BackColor = Color.Yellow;
            }
            else
            {
                button302.BackColor = Color.Red;
            }
        }

        private void button303_Click(object sender, EventArgs e)
        {
            if (button303.BackColor == Color.Lime)
            {
                button303.BackColor = Color.Yellow;
            }
            else
            {
                button303.BackColor = Color.Red;
            }
        }

        private void button304_Click(object sender, EventArgs e)
        {
            if (button304.BackColor == Color.Lime)
            {
                button304.BackColor = Color.Yellow;
            }
            else
            {
                button304.BackColor = Color.Red;
            }
        }

        private void button305_Click(object sender, EventArgs e)
        {
            if (button305.BackColor == Color.Lime)
            {
                button305.BackColor = Color.Yellow;
            }
            else
            {
                button305.BackColor = Color.Red;
            }
        }

        private void button306_Click(object sender, EventArgs e)
        {
            if (button306.BackColor == Color.Lime)
            {
                button306.BackColor = Color.Yellow;
            }
            else
            {
                button306.BackColor = Color.Red;
            }
        }

        private void button307_Click(object sender, EventArgs e)
        {
            if (button307.BackColor == Color.Lime)
            {
                button307.BackColor = Color.Yellow;
            }
            else
            {
                button307.BackColor = Color.Red;
            }
        }

        private void button308_Click(object sender, EventArgs e)
        {
            if (button308.BackColor == Color.Lime)
            {
                button308.BackColor = Color.Yellow;
            }
            else
            {
                button308.BackColor = Color.Red;
            }
        }

        private void button309_Click(object sender, EventArgs e)
        {
            if (button309.BackColor == Color.Lime)
            {
                button309.BackColor = Color.Yellow;
            }
            else
            {
                button309.BackColor = Color.Red;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.BackColor == Color.Lime)
            {
                button5.BackColor = Color.Yellow;
            }
            else
            {
                button5.BackColor = Color.Red;
            }
        }

        private void button741_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.Lime;
            button250.BackColor = Color.Lime;
            button251.BackColor = Color.Lime;
            button252.BackColor = Color.Lime;
            button253.BackColor = Color.Lime;
            button254.BackColor = Color.Lime;
            button255.BackColor = Color.Lime;
            button256.BackColor = Color.Lime;
            button257.BackColor = Color.Lime;
            button258.BackColor = Color.Lime;
            button259.BackColor = Color.Lime;
            button260.BackColor = Color.Lime;
            button261.BackColor = Color.Lime;
            button262.BackColor = Color.Lime;
            button263.BackColor = Color.Lime;
            button264.BackColor = Color.Lime;
            button265.BackColor = Color.Lime;
            button266.BackColor = Color.Lime;
            button267.BackColor = Color.Lime;
            button268.BackColor = Color.Lime;
            button269.BackColor = Color.Lime;
            button270.BackColor = Color.Lime;
            button271.BackColor = Color.Lime;
            button272.BackColor = Color.Lime;
            button273.BackColor = Color.Lime;
            button274.BackColor = Color.Lime;
            button275.BackColor = Color.Lime;
            button276.BackColor = Color.Lime;
            button277.BackColor = Color.Lime;
            button278.BackColor = Color.Lime;
            button279.BackColor = Color.Lime;
            button280.BackColor = Color.Lime;
            button281.BackColor = Color.Lime;
            button282.BackColor = Color.Lime;
            button283.BackColor = Color.Lime;
            button284.BackColor = Color.Lime;
            button285.BackColor = Color.Lime;
            button286.BackColor = Color.Lime;
            button287.BackColor = Color.Lime;
            button288.BackColor = Color.Lime;
            button289.BackColor = Color.Lime;
            button290.BackColor = Color.Lime;
            button291.BackColor = Color.Lime;
            button292.BackColor = Color.Lime;
            button293.BackColor = Color.Lime;
            button294.BackColor = Color.Lime;
            button295.BackColor = Color.Lime;
            button296.BackColor = Color.Lime;
            button297.BackColor = Color.Lime;
            button298.BackColor = Color.Lime;
            button299.BackColor = Color.Lime;
            button300.BackColor = Color.Lime;
            button301.BackColor = Color.Lime;
            button302.BackColor = Color.Lime;
            button303.BackColor = Color.Lime;
            button304.BackColor = Color.Lime;
            button305.BackColor = Color.Lime;
            button306.BackColor = Color.Lime;
            button307.BackColor = Color.Lime;
            button308.BackColor = Color.Lime;
            button309.BackColor = Color.Lime;
        }
        //-----------------------------------------------------------------------------

        private void button310_Click(object sender, EventArgs e)
        {
            if (button310.BackColor == Color.Lime)
            {
                button310.BackColor = Color.Yellow;
            }
            else
            {
                button310.BackColor = Color.Red;
            }

        }

        private void button311_Click(object sender, EventArgs e)
        {
            if (button311.BackColor == Color.Lime)
            {
                button311.BackColor = Color.Yellow;
            }
            else
            {
                button311.BackColor = Color.Red;
            }
        }

        private void button312_Click(object sender, EventArgs e)
        {
            if (button312.BackColor == Color.Lime)
            {
                button312.BackColor = Color.Yellow;
            }
            else
            {
                button312.BackColor = Color.Red;
            }
        }

        private void button313_Click(object sender, EventArgs e)
        {
            if (button313.BackColor == Color.Lime)
            {
                button313.BackColor = Color.Yellow;
            }
            else
            {
                button313.BackColor = Color.Red;
            }
        }

        private void button314_Click(object sender, EventArgs e)
        {
            if (button314.BackColor == Color.Lime)
            {
                button314.BackColor = Color.Yellow;
            }
            else
            {
                button314.BackColor = Color.Red;
            }
        }

        private void button315_Click(object sender, EventArgs e)
        {
            if (button315.BackColor == Color.Lime)
            {
                button315.BackColor = Color.Yellow;
            }
            else
            {
                button315.BackColor = Color.Red;
            }
        }

        private void button316_Click(object sender, EventArgs e)
        {
            if (button316.BackColor == Color.Lime)
            {
                button316.BackColor = Color.Yellow;
            }
            else
            {
                button316.BackColor = Color.Red;
            }
        }

        private void button317_Click(object sender, EventArgs e)
        {
            if (button317.BackColor == Color.Lime)
            {
                button317.BackColor = Color.Yellow;
            }
            else
            {
                button317.BackColor = Color.Red;
            }
        }

        private void button318_Click(object sender, EventArgs e)
        {
            if (button318.BackColor == Color.Lime)
            {
                button318.BackColor = Color.Yellow;
            }
            else
            {
                button318.BackColor = Color.Red;
            }
        }

        private void button319_Click(object sender, EventArgs e)
        {
            if (button319.BackColor == Color.Lime)
            {
                button319.BackColor = Color.Yellow;
            }
            else
            {
                button319.BackColor = Color.Red;
            }
        }

        private void button320_Click(object sender, EventArgs e)
        {
            if (button320.BackColor == Color.Lime)
            {
                button320.BackColor = Color.Yellow;
            }
            else
            {
                button320.BackColor = Color.Red;
            }
        }

        private void button321_Click(object sender, EventArgs e)
        {
            if (button321.BackColor == Color.Lime)
            {
                button321.BackColor = Color.Yellow;
            }
            else
            {
                button321.BackColor = Color.Red;
            }
        }

        private void button322_Click(object sender, EventArgs e)
        {
            if (button322.BackColor == Color.Lime)
            {
                button322.BackColor = Color.Yellow;
            }
            else
            {
                button322.BackColor = Color.Red;
            }
        }

        private void button323_Click(object sender, EventArgs e)
        {
            if (button323.BackColor == Color.Lime)
            {
                button323.BackColor = Color.Yellow;
            }
            else
            {
                button323.BackColor = Color.Red;
            }
        }

        private void button324_Click(object sender, EventArgs e)
        {
            if (button324.BackColor == Color.Lime)
            {
                button324.BackColor = Color.Yellow;
            }
            else
            {
                button324.BackColor = Color.Red;
            }
        }

        private void button325_Click(object sender, EventArgs e)
        {
            if (button325.BackColor == Color.Lime)
            {
                button325.BackColor = Color.Yellow;
            }
            else
            {
                button325.BackColor = Color.Red;
            }
        }

        private void button326_Click(object sender, EventArgs e)
        {
            if (button326.BackColor == Color.Lime)
            {
                button326.BackColor = Color.Yellow;
            }
            else
            {
                button326.BackColor = Color.Red;
            }
        }

        private void button327_Click(object sender, EventArgs e)
        {
            if (button327.BackColor == Color.Lime)
            {
                button327.BackColor = Color.Yellow;
            }
            else
            {
                button327.BackColor = Color.Red;
            }
        }

        private void button328_Click(object sender, EventArgs e)
        {
            if (button328.BackColor == Color.Lime)
            {
                button328.BackColor = Color.Yellow;
            }
            else
            {
                button328.BackColor = Color.Red;
            }
        }

        private void button329_Click(object sender, EventArgs e)
        {
            if (button329.BackColor == Color.Lime)
            {
                button329.BackColor = Color.Yellow;
            }
            else
            {
                button329.BackColor = Color.Red;
            }
        }

        private void button330_Click(object sender, EventArgs e)
        {
            if (button330.BackColor == Color.Lime)
            {
                button330.BackColor = Color.Yellow;
            }
            else
            {
                button330.BackColor = Color.Red;
            }

        }

        private void button331_Click(object sender, EventArgs e)
        {
            if (button331.BackColor == Color.Lime)
            {
                button331.BackColor = Color.Yellow;
            }
            else
            {
                button331.BackColor = Color.Red;
            }
        }

        private void button332_Click(object sender, EventArgs e)
        {
            if (button332.BackColor == Color.Lime)
            {
                button332.BackColor = Color.Yellow;
            }
            else
            {
                button332.BackColor = Color.Red;
            }
        }

        private void button333_Click(object sender, EventArgs e)
        {
            if (button333.BackColor == Color.Lime)
            {
                button333.BackColor = Color.Yellow;
            }
            else
            {
                button333.BackColor = Color.Red;
            }

        }

        private void button334_Click(object sender, EventArgs e)
        {
            if (button334.BackColor == Color.Lime)
            {
                button334.BackColor = Color.Yellow;
            }
            else
            {
                button334.BackColor = Color.Red;
            }
        }

        private void button335_Click(object sender, EventArgs e)
        {
            if (button335.BackColor == Color.Lime)
            {
                button335.BackColor = Color.Yellow;
            }
            else
            {
                button335.BackColor = Color.Red;
            }
        }

        private void button336_Click(object sender, EventArgs e)
        {
            if (button336.BackColor == Color.Lime)
            {
                button336.BackColor = Color.Yellow;
            }
            else
            {
                button336.BackColor = Color.Red;
            }
        }

        private void button337_Click(object sender, EventArgs e)
        {
            if (button337.BackColor == Color.Lime)
            {
                button337.BackColor = Color.Yellow;
            }
            else
            {
                button337.BackColor = Color.Red;
            }
        }

        private void button338_Click(object sender, EventArgs e)
        {
            if (button338.BackColor == Color.Lime)
            {
                button338.BackColor = Color.Yellow;
            }
            else
            {
                button338.BackColor = Color.Red;
            }
        }

        private void button339_Click(object sender, EventArgs e)
        {
            if (button339.BackColor == Color.Lime)
            {
                button339.BackColor = Color.Yellow;
            }
            else
            {
                button339.BackColor = Color.Red;
            }
        }

        private void button340_Click(object sender, EventArgs e)
        {
            if (button340.BackColor == Color.Lime)
            {
                button340.BackColor = Color.Yellow;
            }
            else
            {
                button340.BackColor = Color.Red;
            }
        }

        private void button341_Click(object sender, EventArgs e)
        {
            if (button341.BackColor == Color.Lime)
            {
                button341.BackColor = Color.Yellow;
            }
            else
            {
                button341.BackColor = Color.Red;
            }
        }

        private void button342_Click(object sender, EventArgs e)
        {
            if (button342.BackColor == Color.Lime)
            {
                button342.BackColor = Color.Yellow;
            }
            else
            {
                button342.BackColor = Color.Red;
            }
        }

        private void button343_Click(object sender, EventArgs e)
        {
            if (button343.BackColor == Color.Lime)
            {
                button343.BackColor = Color.Yellow;
            }
            else
            {
                button343.BackColor = Color.Red;
            }
        }

        private void button344_Click(object sender, EventArgs e)
        {
            if (button344.BackColor == Color.Lime)
            {
                button344.BackColor = Color.Yellow;
            }
            else
            {
                button344.BackColor = Color.Red;
            }
        }

        private void button345_Click(object sender, EventArgs e)
        {
            if (button345.BackColor == Color.Lime)
            {
                button345.BackColor = Color.Yellow;
            }
            else
            {
                button345.BackColor = Color.Red;
            }
        }

        private void button346_Click(object sender, EventArgs e)
        {
            if (button346.BackColor == Color.Lime)
            {
                button346.BackColor = Color.Yellow;
            }
            else
            {
                button346.BackColor = Color.Red;
            }
        }

        private void button347_Click(object sender, EventArgs e)
        {
            if (button347.BackColor == Color.Lime)
            {
                button347.BackColor = Color.Yellow;
            }
            else
            {
                button347.BackColor = Color.Red;
            }
        }

        private void button348_Click(object sender, EventArgs e)
        {
            if (button348.BackColor == Color.Lime)
            {
                button348.BackColor = Color.Yellow;
            }
            else
            {
                button348.BackColor = Color.Red;
            }


        }

        private void button349_Click(object sender, EventArgs e)
        {
            if (button349.BackColor == Color.Lime)
            {
                button349.BackColor = Color.Yellow;
            }
            else
            {
                button349.BackColor = Color.Red;
            }
        }

        private void button350_Click(object sender, EventArgs e)
        {
            if (button350.BackColor == Color.Lime)
            {
                button350.BackColor = Color.Yellow;
            }
            else
            {
                button350.BackColor = Color.Red;
            }
        }

        private void button351_Click(object sender, EventArgs e)
        {
            if (button351.BackColor == Color.Lime)
            {
                button351.BackColor = Color.Yellow;
            }
            else
            {
                button351.BackColor = Color.Red;
            }
        }

        private void button352_Click(object sender, EventArgs e)
        {
            if (button352.BackColor == Color.Lime)
            {
                button352.BackColor = Color.Yellow;
            }
            else
            {
                button352.BackColor = Color.Red;
            }
        }

        private void button353_Click(object sender, EventArgs e)
        {
            if (button353.BackColor == Color.Lime)
            {
                button353.BackColor = Color.Yellow;
            }
            else
            {
                button353.BackColor = Color.Red;
            }
        }

        private void button354_Click(object sender, EventArgs e)
        {
            if (button354.BackColor == Color.Lime)
            {
                button354.BackColor = Color.Yellow;
            }
            else
            {
                button354.BackColor = Color.Red;
            }
        }

        private void button355_Click(object sender, EventArgs e)
        {
            if (button355.BackColor == Color.Lime)
            {
                button355.BackColor = Color.Yellow;
            }
            else
            {
                button355.BackColor = Color.Red;
            }
        }

        private void button356_Click(object sender, EventArgs e)
        {
            if (button356.BackColor == Color.Lime)
            {
                button356.BackColor = Color.Yellow;
            }
            else
            {
                button356.BackColor = Color.Red;
            }
        }

        private void button357_Click(object sender, EventArgs e)
        {
            if (button357.BackColor == Color.Lime)
            {
                button357.BackColor = Color.Yellow;
            }
            else
            {
                button357.BackColor = Color.Red;
            }
        }

        private void button358_Click(object sender, EventArgs e)
        {
            if (button358.BackColor == Color.Lime)
            {
                button358.BackColor = Color.Yellow;
            }
            else
            {
                button358.BackColor = Color.Red;
            }
        }

        private void button359_Click(object sender, EventArgs e)
        {
            if (button359.BackColor == Color.Lime)
            {
                button359.BackColor = Color.Yellow;
            }
            else
            {
                button359.BackColor = Color.Red;
            }
        }

        private void button360_Click(object sender, EventArgs e)
        {
            if (button360.BackColor == Color.Lime)
            {
                button360.BackColor = Color.Yellow;
            }
            else
            {
                button360.BackColor = Color.Red;
            }
        }

        private void button361_Click(object sender, EventArgs e)
        {
            if (button361.BackColor == Color.Lime)
            {
                button361.BackColor = Color.Yellow;
            }
            else
            {
                button361.BackColor = Color.Red;
            }
        }

        private void button362_Click(object sender, EventArgs e)
        {
            if (button362.BackColor == Color.Lime)
            {
                button362.BackColor = Color.Yellow;
            }
            else
            {
                button362.BackColor = Color.Red;
            }
        }

        private void button363_Click(object sender, EventArgs e)
        {
            if (button363.BackColor == Color.Lime)
            {
                button363.BackColor = Color.Yellow;
            }
            else
            {
                button363.BackColor = Color.Red;
            }
        }

        private void button364_Click(object sender, EventArgs e)
        {
            if (button364.BackColor == Color.Lime)
            {
                button364.BackColor = Color.Yellow;
            }
            else
            {
                button364.BackColor = Color.Red;
            }
        }

        private void button365_Click(object sender, EventArgs e)
        {
            if (button365.BackColor == Color.Lime)
            {
                button365.BackColor = Color.Yellow;
            }
            else
            {
                button365.BackColor = Color.Red;
            }
        }

        private void button366_Click(object sender, EventArgs e)
        {
            if (button366.BackColor == Color.Lime)
            {
                button366.BackColor = Color.Yellow;
            }
            else
            {
                button366.BackColor = Color.Red;
            }
        }

        private void button367_Click(object sender, EventArgs e)
        {
            if (button367.BackColor == Color.Lime)
            {
                button367.BackColor = Color.Yellow;
            }
            else
            {
                button367.BackColor = Color.Red;
            }
        }

        private void button368_Click(object sender, EventArgs e)
        {
            if (button368.BackColor == Color.Lime)
            {
                button368.BackColor = Color.Yellow;
            }
            else
            {
                button368.BackColor = Color.Red;
            }
        }

        private void button369_Click(object sender, EventArgs e)
        {
            if (button369.BackColor == Color.Lime)
            {
                button369.BackColor = Color.Yellow;
            }
            else
            {
                button369.BackColor = Color.Red;
            }
        }

        private void button370_Click(object sender, EventArgs e)
        {
            if (button370.BackColor == Color.Lime)
            {
                button370.BackColor = Color.Yellow;
            }
            else
            {
                button370.BackColor = Color.Red;
            }
        }

        private void button742_Click(object sender, EventArgs e)
        {
            button310.BackColor = Color.Lime;
            button311.BackColor = Color.Lime;
            button312.BackColor = Color.Lime;
            button313.BackColor = Color.Lime;
            button314.BackColor = Color.Lime;
            button315.BackColor = Color.Lime;
            button316.BackColor = Color.Lime;
            button317.BackColor = Color.Lime;
            button318.BackColor = Color.Lime;
            button319.BackColor = Color.Lime;
            button320.BackColor = Color.Lime;
            button321.BackColor = Color.Lime;
            button322.BackColor = Color.Lime;
            button323.BackColor = Color.Lime;
            button324.BackColor = Color.Lime;
            button325.BackColor = Color.Lime;
            button326.BackColor = Color.Lime;
            button327.BackColor = Color.Lime;
            button328.BackColor = Color.Lime;
            button329.BackColor = Color.Lime;
            button330.BackColor = Color.Lime;
            button331.BackColor = Color.Lime;
            button332.BackColor = Color.Lime;
            button333.BackColor = Color.Lime;
            button334.BackColor = Color.Lime;
            button335.BackColor = Color.Lime;
            button336.BackColor = Color.Lime;
            button337.BackColor = Color.Lime;
            button338.BackColor = Color.Lime;
            button339.BackColor = Color.Lime;
            button340.BackColor = Color.Lime;
            button341.BackColor = Color.Lime;
            button342.BackColor = Color.Lime;
            button343.BackColor = Color.Lime;
            button344.BackColor = Color.Lime;
            button345.BackColor = Color.Lime;
            button346.BackColor = Color.Lime;
            button347.BackColor = Color.Lime;
            button348.BackColor = Color.Lime;
            button349.BackColor = Color.Lime;
            button350.BackColor = Color.Lime;
            button351.BackColor = Color.Lime;
            button352.BackColor = Color.Lime;
            button353.BackColor = Color.Lime;
            button354.BackColor = Color.Lime;
            button355.BackColor = Color.Lime;
            button356.BackColor = Color.Lime;
            button357.BackColor = Color.Lime;
            button358.BackColor = Color.Lime;
            button359.BackColor = Color.Lime;
            button360.BackColor = Color.Lime;
            button361.BackColor = Color.Lime;
            button362.BackColor = Color.Lime;
            button363.BackColor = Color.Lime;
            button364.BackColor = Color.Lime;
            button365.BackColor = Color.Lime;
            button366.BackColor = Color.Lime;
            button367.BackColor = Color.Lime;
            button368.BackColor = Color.Lime;
            button369.BackColor = Color.Lime;
            button370.BackColor = Color.Lime;

        }



        private void button371_Click(object sender, EventArgs e)
        {
            if (button371.BackColor == Color.Lime)
            {
                button371.BackColor = Color.Yellow;
            }
            else
            {
                button371.BackColor = Color.Red;
            }
        }

        private void button372_Click(object sender, EventArgs e)
        {
            if (button372.BackColor == Color.Lime)
            {
                button372.BackColor = Color.Yellow;
            }
            else
            {
                button372.BackColor = Color.Red;
            }
        }

        private void button373_Click(object sender, EventArgs e)
        {
            if (button373.BackColor == Color.Lime)
            {
                button373.BackColor = Color.Yellow;
            }
            else
            {
                button373.BackColor = Color.Red;
            }
        }

        private void button374_Click(object sender, EventArgs e)
        {
            if (button374.BackColor == Color.Lime)
            {
                button374.BackColor = Color.Yellow;
            }
            else
            {
                button374.BackColor = Color.Red;
            }
        }

        private void button375_Click(object sender, EventArgs e)
        {
            if (button375.BackColor == Color.Lime)
            {
                button375.BackColor = Color.Yellow;
            }
            else
            {
                button375.BackColor = Color.Red;
            }
        }

        private void button376_Click(object sender, EventArgs e)
        {
            if (button376.BackColor == Color.Lime)
            {
                button376.BackColor = Color.Yellow;
            }
            else
            {
                button376.BackColor = Color.Red;
            }
        }

        private void button377_Click(object sender, EventArgs e)
        {
            if (button377.BackColor == Color.Lime)
            {
                button377.BackColor = Color.Yellow;
            }
            else
            {
                button377.BackColor = Color.Red;
            }
        }

        private void button378_Click(object sender, EventArgs e)
        {
            if (button378.BackColor == Color.Lime)
            {
                button378.BackColor = Color.Yellow;
            }
            else
            {
                button378.BackColor = Color.Red;
            }
        }

        private void button379_Click(object sender, EventArgs e)
        {
            if (button379.BackColor == Color.Lime)
            {
                button379.BackColor = Color.Yellow;
            }
            else
            {
                button379.BackColor = Color.Red;
            }
        }

        private void button380_Click(object sender, EventArgs e)
        {
            if (button380.BackColor == Color.Lime)
            {
                button380.BackColor = Color.Yellow;
            }
            else
            {
                button380.BackColor = Color.Red;
            }
        }

        private void button381_Click(object sender, EventArgs e)
        {
            if (button381.BackColor == Color.Lime)
            {
                button381.BackColor = Color.Yellow;
            }
            else
            {
                button381.BackColor = Color.Red;
            }
        }

        private void button382_Click(object sender, EventArgs e)
        {
            if (button382.BackColor == Color.Lime)
            {
                button382.BackColor = Color.Yellow;
            }
            else
            {
                button382.BackColor = Color.Red;
            }
        }

        private void button383_Click(object sender, EventArgs e)
        {
            if (button383.BackColor == Color.Lime)
            {
                button383.BackColor = Color.Yellow;
            }
            else
            {
                button383.BackColor = Color.Red;
            }
        }

        private void button384_Click(object sender, EventArgs e)
        {
            if (button384.BackColor == Color.Lime)
            {
                button384.BackColor = Color.Yellow;
            }
            else
            {
                button384.BackColor = Color.Red;
            }
        }

        private void button385_Click(object sender, EventArgs e)
        {
            if (button385.BackColor == Color.Lime)
            {
                button385.BackColor = Color.Yellow;
            }
            else
            {
                button385.BackColor = Color.Red;
            }
        }

        private void button386_Click(object sender, EventArgs e)
        {
            if (button386.BackColor == Color.Lime)
            {
                button386.BackColor = Color.Yellow;
            }
            else
            {
                button386.BackColor = Color.Red;
            }
        }

        private void button387_Click(object sender, EventArgs e)
        {
            if (button387.BackColor == Color.Lime)
            {
                button387.BackColor = Color.Yellow;
            }
            else
            {
                button387.BackColor = Color.Red;
            }
        }

        private void button388_Click(object sender, EventArgs e)
        {
            if (button388.BackColor == Color.Lime)
            {
                button388.BackColor = Color.Yellow;
            }
            else
            {
                button388.BackColor = Color.Red;
            }
        }

        private void button389_Click(object sender, EventArgs e)
        {
            if (button389.BackColor == Color.Lime)
            {
                button389.BackColor = Color.Yellow;
            }
            else
            {
                button389.BackColor = Color.Red;
            }
        }

        private void button390_Click(object sender, EventArgs e)
        {
            if (button390.BackColor == Color.Lime)
            {
                button390.BackColor = Color.Yellow;
            }
            else
            {
                button390.BackColor = Color.Red;
            }
        }

        private void button391_Click(object sender, EventArgs e)
        {
            if (button391.BackColor == Color.Lime)
            {
                button391.BackColor = Color.Yellow;
            }
            else
            {
                button391.BackColor = Color.Red;
            }
        }

        private void button392_Click(object sender, EventArgs e)
        {
            if (button392.BackColor == Color.Lime)
            {
                button392.BackColor = Color.Yellow;
            }
            else
            {
                button392.BackColor = Color.Red;
            }
        }

        private void button393_Click(object sender, EventArgs e)
        {
            if (button393.BackColor == Color.Lime)
            {
                button393.BackColor = Color.Yellow;
            }
            else
            {
                button393.BackColor = Color.Red;
            }
        }

        private void button394_Click(object sender, EventArgs e)
        {
            if (button394.BackColor == Color.Lime)
            {
                button394.BackColor = Color.Yellow;
            }
            else
            {
                button394.BackColor = Color.Red;
            }
        }

        private void button395_Click(object sender, EventArgs e)
        {
            if (button395.BackColor == Color.Lime)
            {
                button395.BackColor = Color.Yellow;
            }
            else
            {
                button395.BackColor = Color.Red;
            }
        }

        private void button396_Click(object sender, EventArgs e)
        {

            if (button396.BackColor == Color.Lime)
            {
                button396.BackColor = Color.Yellow;
            }
            else
            {
                button396.BackColor = Color.Red;
            }
        }
        private void button397_Click(object sender, EventArgs e)
        {
            if (button397.BackColor == Color.Lime)
            {
                button397.BackColor = Color.Yellow;
            }
            else
            {
                button397.BackColor = Color.Red;
            }
        }

        private void button398_Click(object sender, EventArgs e)
        {
            if (button398.BackColor == Color.Lime)
            {
                button398.BackColor = Color.Yellow;
            }
            else
            {
                button398.BackColor = Color.Red;
            }
        }

        private void button399_Click(object sender, EventArgs e)
        {
            if (button399.BackColor == Color.Lime)
            {
                button399.BackColor = Color.Yellow;
            }
            else
            {
                button399.BackColor = Color.Red;
            }
        }

        private void button400_Click(object sender, EventArgs e)
        {
            if (button400.BackColor == Color.Lime)
            {
                button400.BackColor = Color.Yellow;
            }
            else
            {
                button400.BackColor = Color.Red;
            }
        }

        private void button401_Click(object sender, EventArgs e)
        {
            if (button401.BackColor == Color.Lime)
            {
                button401.BackColor = Color.Yellow;
            }
            else
            {
                button401.BackColor = Color.Red;
            }
        }

        private void button402_Click(object sender, EventArgs e)
        {
            if (button402.BackColor == Color.Lime)
            {
                button402.BackColor = Color.Yellow;
            }
            else
            {
                button402.BackColor = Color.Red;
            }
        }

        private void button403_Click(object sender, EventArgs e)
        {
            if (button403.BackColor == Color.Lime)
            {
                button403.BackColor = Color.Yellow;
            }
            else
            {
                button403.BackColor = Color.Red;
            }
        }

        private void button404_Click(object sender, EventArgs e)
        {
            if (button404.BackColor == Color.Lime)
            {
                button404.BackColor = Color.Yellow;
            }
            else
            {
                button404.BackColor = Color.Red;
            }
        }

        private void button405_Click(object sender, EventArgs e)
        {
            if (button405.BackColor == Color.Lime)
            {
                button405.BackColor = Color.Yellow;
            }
            else
            {
                button405.BackColor = Color.Red;
            }
        }

        private void button406_Click(object sender, EventArgs e)
        {
            if (button406.BackColor == Color.Lime)
            {
                button406.BackColor = Color.Yellow;
            }
            else
            {
                button406.BackColor = Color.Red;
            }
        }

        private void button407_Click(object sender, EventArgs e)
        {
            if (button407.BackColor == Color.Lime)
            {
                button407.BackColor = Color.Yellow;
            }
            else
            {
                button407.BackColor = Color.Red;
            }
        }

        private void button408_Click(object sender, EventArgs e)
        {
            if (button408.BackColor == Color.Lime)
            {
                button408.BackColor = Color.Yellow;
            }
            else
            {
                button408.BackColor = Color.Red;
            }
        }

        private void button409_Click(object sender, EventArgs e)
        {
            if (button409.BackColor == Color.Lime)
            {
                button409.BackColor = Color.Yellow;
            }
            else
            {
                button409.BackColor = Color.Red;
            }
        }

        private void button410_Click(object sender, EventArgs e)
        {
            if (button410.BackColor == Color.Lime)
            {
                button410.BackColor = Color.Yellow;
            }
            else
            {
                button410.BackColor = Color.Red;
            }
        }

        private void button411_Click(object sender, EventArgs e)
        {
            if (button411.BackColor == Color.Lime)
            {
                button411.BackColor = Color.Yellow;
            }
            else
            {
                button411.BackColor = Color.Red;
            }
        }

        private void button412_Click(object sender, EventArgs e)
        {
            if (button412.BackColor == Color.Lime)
            {
                button412.BackColor = Color.Yellow;
            }
            else
            {
                button412.BackColor = Color.Red;
            }
        }

        private void button413_Click(object sender, EventArgs e)
        {
            if (button413.BackColor == Color.Lime)
            {
                button413.BackColor = Color.Yellow;
            }
            else
            {
                button413.BackColor = Color.Red;
            }
        }

        private void button414_Click(object sender, EventArgs e)
        {
            if (button414.BackColor == Color.Lime)
            {
                button414.BackColor = Color.Yellow;
            }
            else
            {
                button414.BackColor = Color.Red;
            }
        }

        private void button415_Click(object sender, EventArgs e)
        {
            if (button415.BackColor == Color.Lime)
            {
                button415.BackColor = Color.Yellow;
            }
            else
            {
                button415.BackColor = Color.Red;
            }
        }

        private void button416_Click(object sender, EventArgs e)
        {
            if (button416.BackColor == Color.Lime)
            {
                button416.BackColor = Color.Yellow;
            }
            else
            {
                button416.BackColor = Color.Red;
            }
        }

        private void button417_Click(object sender, EventArgs e)
        {
            if (button417.BackColor == Color.Lime)
            {
                button417.BackColor = Color.Yellow;
            }
            else
            {
                button417.BackColor = Color.Red;
            }
        }

        private void button418_Click(object sender, EventArgs e)
        {
            if (button418.BackColor == Color.Lime)
            {
                button418.BackColor = Color.Yellow;
            }
            else
            {
                button418.BackColor = Color.Red;
            }
        }

        private void button419_Click(object sender, EventArgs e)
        {
            if (button419.BackColor == Color.Lime)
            {
                button419.BackColor = Color.Yellow;
            }
            else
            {
                button419.BackColor = Color.Red;
            }

        }

        private void button420_Click(object sender, EventArgs e)
        {
            if (button420.BackColor == Color.Lime)
            {
                button420.BackColor = Color.Yellow;
            }
            else
            {
                button420.BackColor = Color.Red;
            }
        }

        private void button421_Click(object sender, EventArgs e)
        {
            if (button421.BackColor == Color.Lime)
            {
                button421.BackColor = Color.Yellow;
            }
            else
            {
                button421.BackColor = Color.Red;
            }
        }

        private void button422_Click(object sender, EventArgs e)
        {
            if (button422.BackColor == Color.Lime)
            {
                button422.BackColor = Color.Yellow;
            }
            else
            {
                button422.BackColor = Color.Red;
            }
        }

        private void button423_Click(object sender, EventArgs e)
        {
            if (button423.BackColor == Color.Lime)
            {
                button423.BackColor = Color.Yellow;
            }
            else
            {
                button423.BackColor = Color.Red;
            }
        }

        private void button424_Click(object sender, EventArgs e)
        {
            if (button424.BackColor == Color.Lime)
            {
                button424.BackColor = Color.Yellow;
            }
            else
            {
                button424.BackColor = Color.Red;
            }
        }

        private void button425_Click(object sender, EventArgs e)
        {
            if (button425.BackColor == Color.Lime)
            {
                button425.BackColor = Color.Yellow;
            }
            else
            {
                button425.BackColor = Color.Red;
            }
        }

        private void button426_Click(object sender, EventArgs e)
        {
            if (button426.BackColor == Color.Lime)
            {
                button426.BackColor = Color.Yellow;
            }
            else
            {
                button426.BackColor = Color.Red;
            }
        }

        private void button427_Click(object sender, EventArgs e)
        {
            if (button427.BackColor == Color.Lime)
            {
                button427.BackColor = Color.Yellow;
            }
            else
            {
                button427.BackColor = Color.Red;
            }
        }

        private void button428_Click(object sender, EventArgs e)
        {
            if (button428.BackColor == Color.Lime)
            {
                button428.BackColor = Color.Yellow;
            }
            else
            {
                button428.BackColor = Color.Red;
            }
        }

        private void button429_Click(object sender, EventArgs e)
        {
            if (button429.BackColor == Color.Lime)
            {
                button429.BackColor = Color.Yellow;
            }
            else
            {
                button429.BackColor = Color.Red;
            }
        }

        private void button430_Click(object sender, EventArgs e)
        {
            if (button430.BackColor == Color.Lime)
            {
                button430.BackColor = Color.Yellow;
            }
            else
            {
                button430.BackColor = Color.Red;
            }
        }

        private void button431_Click(object sender, EventArgs e)
        {
            if (button431.BackColor == Color.Lime)
            {
                button431.BackColor = Color.Yellow;
            }
            else
            {
                button431.BackColor = Color.Red;
            }
        }

        private void button743_Click(object sender, EventArgs e)
        {
            button371.BackColor = Color.Lime;
            button372.BackColor = Color.Lime;
            button373.BackColor = Color.Lime;
            button374.BackColor = Color.Lime;
            button375.BackColor = Color.Lime;
            button376.BackColor = Color.Lime;
            button377.BackColor = Color.Lime;
            button378.BackColor = Color.Lime;
            button379.BackColor = Color.Lime;
            button380.BackColor = Color.Lime;
            button381.BackColor = Color.Lime;
            button382.BackColor = Color.Lime;
            button383.BackColor = Color.Lime;
            button384.BackColor = Color.Lime;
            button385.BackColor = Color.Lime;
            button386.BackColor = Color.Lime;
            button387.BackColor = Color.Lime;
            button388.BackColor = Color.Lime;
            button389.BackColor = Color.Lime;
            button390.BackColor = Color.Lime;
            button391.BackColor = Color.Lime;
            button392.BackColor = Color.Lime;
            button393.BackColor = Color.Lime;
            button394.BackColor = Color.Lime;
            button395.BackColor = Color.Lime;
            button396.BackColor = Color.Lime;
            button397.BackColor = Color.Lime;
            button398.BackColor = Color.Lime;
            button399.BackColor = Color.Lime;
            button400.BackColor = Color.Lime;
            button401.BackColor = Color.Lime;
            button402.BackColor = Color.Lime;
            button403.BackColor = Color.Lime;
            button404.BackColor = Color.Lime;
            button405.BackColor = Color.Lime;
            button406.BackColor = Color.Lime;
            button407.BackColor = Color.Lime;
            button408.BackColor = Color.Lime;
            button409.BackColor = Color.Lime;
            button410.BackColor = Color.Lime;
            button411.BackColor = Color.Lime;
            button412.BackColor = Color.Lime;
            button413.BackColor = Color.Lime;
            button414.BackColor = Color.Lime;
            button415.BackColor = Color.Lime;
            button416.BackColor = Color.Lime;
            button417.BackColor = Color.Lime;
            button418.BackColor = Color.Lime;
            button419.BackColor = Color.Lime;
            button420.BackColor = Color.Lime;
            button421.BackColor = Color.Lime;
            button422.BackColor = Color.Lime;
            button423.BackColor = Color.Lime;
            button424.BackColor = Color.Lime;
            button425.BackColor = Color.Lime;
            button426.BackColor = Color.Lime;
            button427.BackColor = Color.Lime;
            button428.BackColor = Color.Lime;
            button429.BackColor = Color.Lime;
            button430.BackColor = Color.Lime;
            button431.BackColor = Color.Lime;

        }

        private void button432_Click(object sender, EventArgs e)
        {
            if (button432.BackColor == Color.Lime)
            {
                button432.BackColor = Color.Yellow;
            }
            else
            {
                button432.BackColor = Color.Red;
            }

        }

        private void button433_Click(object sender, EventArgs e)
        {
            if (button433.BackColor == Color.Lime)
            {
                button433.BackColor = Color.Yellow;
            }
            else
            {
                button433.BackColor = Color.Red;
            }

        }

        private void button434_Click(object sender, EventArgs e)
        {
            if (button434.BackColor == Color.Lime)
            {
                button434.BackColor = Color.Yellow;
            }
            else
            {
                button434.BackColor = Color.Red;
            }

        }

        private void button435_Click(object sender, EventArgs e)
        {
            if (button435.BackColor == Color.Lime)
            {
                button435.BackColor = Color.Yellow;
            }
            else
            {
                button435.BackColor = Color.Red;
            }

        }

        private void button436_Click(object sender, EventArgs e)
        {
            if (button436.BackColor == Color.Lime)
            {
                button436.BackColor = Color.Yellow;
            }
            else
            {
                button436.BackColor = Color.Red;
            }


        }

        private void button437_Click(object sender, EventArgs e)
        {
            if (button438.BackColor == Color.Lime)
            {
                button438.BackColor = Color.Yellow;
            }
            else
            {
                button438.BackColor = Color.Red;
            }

        }

        private void button438_Click(object sender, EventArgs e)
        {
            if (button438.BackColor == Color.Lime)
            {
                button438.BackColor = Color.Yellow;
            }
            else
            {
                button438.BackColor = Color.Red;
            }

        }

        private void button439_Click(object sender, EventArgs e)
        {
            if (button439.BackColor == Color.Lime)
            {
                button439.BackColor = Color.Yellow;
            }
            else
            {
                button439.BackColor = Color.Red;
            }
        }
        private void button440_Click(object sender, EventArgs e)
        {
            if (button440.BackColor == Color.Lime)
            {
                button440.BackColor = Color.Yellow;
            }
            else
            {
                button440.BackColor = Color.Red;
            }
        }
        private void button441_Click(object sender, EventArgs e)
        {
            if (button441.BackColor == Color.Lime)
            {
                button441.BackColor = Color.Yellow;
            }
            else
            {
                button441.BackColor = Color.Red;
            }
        }
        private void button442_Click(object sender, EventArgs e)
        {
            if (button442.BackColor == Color.Lime)
            {
                button442.BackColor = Color.Yellow;
            }
            else
            {
                button442.BackColor = Color.Red;
            }
        }
        private void button443_Click(object sender, EventArgs e)
        {
            if (button443.BackColor == Color.Lime)
            {
                button443.BackColor = Color.Yellow;
            }
            else
            {
                button443.BackColor = Color.Red;
            }
        }
        private void button444_Click(object sender, EventArgs e)
        {
            if (button444.BackColor == Color.Lime)
            {
                button444.BackColor = Color.Yellow;
            }
            else
            {
                button444.BackColor = Color.Red;
            }
        }
        private void button445_Click(object sender, EventArgs e)
        {
            if (button445.BackColor == Color.Lime)
            {
                button445.BackColor = Color.Yellow;
            }
            else
            {
                button445.BackColor = Color.Red;
            }
        }
        private void button446_Click(object sender, EventArgs e)
        {
            if (button446.BackColor == Color.Lime)
            {
                button446.BackColor = Color.Yellow;
            }
            else
            {
                button446.BackColor = Color.Red;
            }
        }
        private void button447_Click(object sender, EventArgs e)
        {
            if (button447.BackColor == Color.Lime)
            {
                button447.BackColor = Color.Yellow;
            }
            else
            {
                button447.BackColor = Color.Red;
            }
        }
        private void button448_Click(object sender, EventArgs e)
        {
            if (button448.BackColor == Color.Lime)
            {
                button448.BackColor = Color.Yellow;
            }
            else
            {
                button448.BackColor = Color.Red;
            }
        }
        private void button449_Click(object sender, EventArgs e)
        {
            if (button449.BackColor == Color.Lime)
            {
                button449.BackColor = Color.Yellow;
            }
            else
            {
                button449.BackColor = Color.Red;
            }
        }
        private void button450_Click(object sender, EventArgs e)
        {
            if (button450.BackColor == Color.Lime)
            {
                button450.BackColor = Color.Yellow;
            }
            else
            {
                button450.BackColor = Color.Red;
            }
        }
        private void button451_Click(object sender, EventArgs e)
        {
            if (button451.BackColor == Color.Lime)
            {
                button451.BackColor = Color.Yellow;
            }
            else
            {
                button451.BackColor = Color.Red;
            }
        }
        private void button452_Click(object sender, EventArgs e)
        {
            if (button452.BackColor == Color.Lime)
            {
                button452.BackColor = Color.Yellow;
            }
            else
            {
                button452.BackColor = Color.Red;
            }
        }
        private void button453_Click(object sender, EventArgs e)
        {
            if (button453.BackColor == Color.Lime)
            {
                button453.BackColor = Color.Yellow;
            }
            else
            {
                button453.BackColor = Color.Red;
            }
        }
        private void button454_Click(object sender, EventArgs e)
        {
            if (button454.BackColor == Color.Lime)
            {
                button454.BackColor = Color.Yellow;
            }
            else
            {
                button454.BackColor = Color.Red;
            }
        }
        private void button455_Click(object sender, EventArgs e)
        {
            if (button455.BackColor == Color.Lime)
            {
                button455.BackColor = Color.Yellow;
            }
            else
            {
                button455.BackColor = Color.Red;
            }
        }
        private void button456_Click(object sender, EventArgs e)
        {
            if (button456.BackColor == Color.Lime)
            {
                button456.BackColor = Color.Yellow;
            }
            else
            {
                button456.BackColor = Color.Red;
            }
        }
        private void button457_Click(object sender, EventArgs e)
        {
            if (button457.BackColor == Color.Lime)
            {
                button457.BackColor = Color.Yellow;
            }
            else
            {
                button457.BackColor = Color.Red;
            }
        }
        private void button458_Click(object sender, EventArgs e)
        {
            if (button458.BackColor == Color.Lime)
            {
                button458.BackColor = Color.Yellow;
            }
            else
            {
                button458.BackColor = Color.Red;
            }
        }
        private void button459_Click(object sender, EventArgs e)
        {
            if (button459.BackColor == Color.Lime)
            {
                button459.BackColor = Color.Yellow;
            }
            else
            {
                button459.BackColor = Color.Red;
            }
        }
        private void button460_Click(object sender, EventArgs e)
        {
            if (button460.BackColor == Color.Lime)
            {
                button460.BackColor = Color.Yellow;
            }
            else
            {
                button460.BackColor = Color.Red;
            }
        }
        private void button461_Click(object sender, EventArgs e)
        {
            if (button461.BackColor == Color.Lime)
            {
                button461.BackColor = Color.Yellow;
            }
            else
            {
                button461.BackColor = Color.Red;
            }
        }
        private void button462_Click(object sender, EventArgs e)
        {
            if (button462.BackColor == Color.Lime)
            {
                button462.BackColor = Color.Yellow;
            }
            else
            {
                button462.BackColor = Color.Red;
            }
        }
        private void button463_Click(object sender, EventArgs e)
        {
            if (button463.BackColor == Color.Lime)
            {
                button463.BackColor = Color.Yellow;
            }
            else
            {
                button463.BackColor = Color.Red;
            }
        }
        private void button464_Click(object sender, EventArgs e)
        {
            if (button464.BackColor == Color.Lime)
            {
                button464.BackColor = Color.Yellow;
            }
            else
            {
                button464.BackColor = Color.Red;
            }
        }
        private void button465_Click(object sender, EventArgs e)
        {
            if (button465.BackColor == Color.Lime)
            {
                button465.BackColor = Color.Yellow;
            }
            else
            {
                button465.BackColor = Color.Red;
            }
        }
        private void button466_Click(object sender, EventArgs e)
        {
            if (button466.BackColor == Color.Lime)
            {
                button466.BackColor = Color.Yellow;
            }
            else
            {
                button466.BackColor = Color.Red;
            }
        }
        private void button467_Click(object sender, EventArgs e)
        {
            if (button467.BackColor == Color.Lime)
            {
                button467.BackColor = Color.Yellow;
            }
            else
            {
                button467.BackColor = Color.Red;
            }
        }
        private void button468_Click(object sender, EventArgs e)
        {
            if (button468.BackColor == Color.Lime)
            {
                button468.BackColor = Color.Yellow;
            }
            else
            {
                button468.BackColor = Color.Red;
            }
        }
        private void button469_Click(object sender, EventArgs e)
        {
            if (button469.BackColor == Color.Lime)
            {
                button469.BackColor = Color.Yellow;
            }
            else
            {
                button469.BackColor = Color.Red;
            }
        }
        private void button470_Click(object sender, EventArgs e)
        {
            if (button470.BackColor == Color.Lime)
            {
                button470.BackColor = Color.Yellow;
            }
            else
            {
                button470.BackColor = Color.Red;
            }
        }
        private void button471_Click(object sender, EventArgs e)
        {
            if (button471.BackColor == Color.Lime)
            {
                button471.BackColor = Color.Yellow;
            }
            else
            {
                button471.BackColor = Color.Red;
            }
        }
        private void button472_Click(object sender, EventArgs e)
        {
            if (button472.BackColor == Color.Lime)
            {
                button472.BackColor = Color.Yellow;
            }
            else
            {
                button472.BackColor = Color.Red;
            }
        }
        private void button473_Click(object sender, EventArgs e)
        {
            if (button473.BackColor == Color.Lime)
            {
                button473.BackColor = Color.Yellow;
            }
            else
            {
                button473.BackColor = Color.Red;
            }
        }
        private void button474_Click(object sender, EventArgs e)
        {
            if (button474.BackColor == Color.Lime)
            {
                button474.BackColor = Color.Yellow;
            }
            else
            {
                button474.BackColor = Color.Red;
            }
        }
        private void button475_Click(object sender, EventArgs e)
        {
            if (button475.BackColor == Color.Lime)
            {
                button475.BackColor = Color.Yellow;
            }
            else
            {
                button475.BackColor = Color.Red;
            }
        }
        private void button476_Click(object sender, EventArgs e)
        {
            if (button476.BackColor == Color.Lime)
            {
                button476.BackColor = Color.Yellow;
            }
            else
            {
                button476.BackColor = Color.Red;
            }
        }
        private void button477_Click(object sender, EventArgs e)
        {
            if (button477.BackColor == Color.Lime)
            {
                button477.BackColor = Color.Yellow;
            }
            else
            {
                button477.BackColor = Color.Red;
            }
        }
        private void button478_Click(object sender, EventArgs e)
        {
            if (button478.BackColor == Color.Lime)
            {
                button478.BackColor = Color.Yellow;
            }
            else
            {
                button478.BackColor = Color.Red;
            }
        }
        private void button479_Click(object sender, EventArgs e)
        {
            if (button479.BackColor == Color.Lime)
            {
                button479.BackColor = Color.Yellow;
            }
            else
            {
                button479.BackColor = Color.Red;
            }
        }
        private void button480_Click(object sender, EventArgs e)
        {
            if (button480.BackColor == Color.Lime)
            {
                button480.BackColor = Color.Yellow;
            }
            else
            {
                button480.BackColor = Color.Red;
            }
        }
        private void button481_Click(object sender, EventArgs e)
        {
            if (button481.BackColor == Color.Lime)
            {
                button481.BackColor = Color.Yellow;
            }
            else
            {
                button481.BackColor = Color.Red;
            }
        }
        private void button482_Click(object sender, EventArgs e)
        {
            if (button482.BackColor == Color.Lime)
            {
                button482.BackColor = Color.Yellow;
            }
            else
            {
                button482.BackColor = Color.Red;
            }
        }
        private void button483_Click(object sender, EventArgs e)
        {
            if (button483.BackColor == Color.Lime)
            {
                button483.BackColor = Color.Yellow;
            }
            else
            {
                button483.BackColor = Color.Red;
            }
        }
        private void button484_Click(object sender, EventArgs e)
        {
            if (button484.BackColor == Color.Lime)
            {
                button484.BackColor = Color.Yellow;
            }
            else
            {
                button484.BackColor = Color.Red;
            }
        }
        private void button485_Click(object sender, EventArgs e)
        {
            if (button485.BackColor == Color.Lime)
            {
                button485.BackColor = Color.Yellow;
            }
            else
            {
                button485.BackColor = Color.Red;
            }
        }
        private void button486_Click(object sender, EventArgs e)
        {
            if (button486.BackColor == Color.Lime)
            {
                button486.BackColor = Color.Yellow;
            }
            else
            {
                button486.BackColor = Color.Red;
            }
        }
        private void button487_Click(object sender, EventArgs e)
        {
            if (button487.BackColor == Color.Lime)
            {
                button487.BackColor = Color.Yellow;
            }
            else
            {
                button487.BackColor = Color.Red;
            }
        }
        private void button488_Click(object sender, EventArgs e)
        {
            if (button488.BackColor == Color.Lime)
            {
                button488.BackColor = Color.Yellow;
            }
            else
            {
                button488.BackColor = Color.Red;
            }
        }
        private void button489_Click(object sender, EventArgs e)
        {
            if (button489.BackColor == Color.Lime)
            {
                button489.BackColor = Color.Yellow;
            }
            else
            {
                button489.BackColor = Color.Red;
            }
        }
        private void button490_Click(object sender, EventArgs e)
        {
            if (button490.BackColor == Color.Lime)
            {
                button490.BackColor = Color.Yellow;
            }
            else
            {
                button490.BackColor = Color.Red;
            }
        }
        private void button491_Click(object sender, EventArgs e)
        {
            if (button491.BackColor == Color.Lime)
            {
                button491.BackColor = Color.Yellow;
            }
            else
            {
                button491.BackColor = Color.Red;
            }
        }
        private void button492_Click(object sender, EventArgs e)
        {
            if (button492.BackColor == Color.Lime)
            {
                button492.BackColor = Color.Yellow;
            }
            else
            {
                button492.BackColor = Color.Red;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //---------------------------------------------------------------


        private void button493_Click(object sender, EventArgs e)
        {
            if (button493.BackColor == Color.Lime)
            {
                button493.BackColor = Color.Yellow;
            }
            else
            {
                button493.BackColor = Color.Red;
            }
        }
        private void button494_Click(object sender, EventArgs e)
        {
            if (button494.BackColor == Color.Lime)
            {
                button494.BackColor = Color.Yellow;
            }
            else
            {
                button494.BackColor = Color.Red;
            }
        }
        private void button495_Click(object sender, EventArgs e)
        {
            if (button495.BackColor == Color.Lime)
            {
                button495.BackColor = Color.Yellow;
            }
            else
            {
                button495.BackColor = Color.Red;
            }
        }
        private void button496_Click(object sender, EventArgs e)
        {
            if (button496.BackColor == Color.Lime)
            {
                button496.BackColor = Color.Yellow;
            }
            else
            {
                button496.BackColor = Color.Red;
            }
        }
        private void button497_Click(object sender, EventArgs e)
        {
            if (button497.BackColor == Color.Lime)
            {
                button497.BackColor = Color.Yellow;
            }
            else
            {
                button497.BackColor = Color.Red;
            }
        }
        private void button498_Click(object sender, EventArgs e)
        {
            if (button498.BackColor == Color.Lime)
            {
                button498.BackColor = Color.Yellow;
            }
            else
            {
                button498.BackColor = Color.Red;
            }
        }
        private void button499_Click(object sender, EventArgs e)
        {
            if (button499.BackColor == Color.Lime)
            {
                button499.BackColor = Color.Yellow;
            }
            else
            {
                button499.BackColor = Color.Red;
            }
        }
        private void button500_Click(object sender, EventArgs e)
        {
            if (button500.BackColor == Color.Lime)
            {
                button500.BackColor = Color.Yellow;
            }
            else
            {
                button500.BackColor = Color.Red;
            }
        }
        private void button501_Click(object sender, EventArgs e)
        {
            if (button501.BackColor == Color.Lime)
            {
                button501.BackColor = Color.Yellow;
            }
            else
            {
                button501.BackColor = Color.Red;
            }
        }
        private void button502_Click(object sender, EventArgs e)
        {
            if (button502.BackColor == Color.Lime)
            {
                button502.BackColor = Color.Yellow;
            }
            else
            {
                button502.BackColor = Color.Red;
            }
        }
        private void button503_Click(object sender, EventArgs e)
        {
            if (button503.BackColor == Color.Lime)
            {
                button503.BackColor = Color.Yellow;
            }
            else
            {
                button503.BackColor = Color.Red;
            }
        }
        private void button504_Click(object sender, EventArgs e)
        {
            if (button504.BackColor == Color.Lime)
            {
                button504.BackColor = Color.Yellow;
            }
            else
            {
                button504.BackColor = Color.Red;
            }
        }
        private void button505_Click(object sender, EventArgs e)
        {
            if (button505.BackColor == Color.Lime)
            {
                button505.BackColor = Color.Yellow;
            }
            else
            {
                button505.BackColor = Color.Red;
            }
        }
        private void button506_Click(object sender, EventArgs e)
        {
            if (button506.BackColor == Color.Lime)
            {
                button506.BackColor = Color.Yellow;
            }
            else
            {
                button506.BackColor = Color.Red;
            }
        }
        private void button507_Click(object sender, EventArgs e)
        {
            if (button507.BackColor == Color.Lime)
            {
                button507.BackColor = Color.Yellow;
            }
            else
            {
                button507.BackColor = Color.Red;
            }
        }
        private void button508_Click(object sender, EventArgs e)
        {
            if (button508.BackColor == Color.Lime)
            {
                button508.BackColor = Color.Yellow;
            }
            else
            {
                button508.BackColor = Color.Red;
            }
        }
        private void button509_Click(object sender, EventArgs e)
        {
            if (button509.BackColor == Color.Lime)
            {
                button509.BackColor = Color.Yellow;
            }
            else
            {
                button509.BackColor = Color.Red;
            }
        }
        private void button510_Click(object sender, EventArgs e)
        {
            if (button510.BackColor == Color.Lime)
            {
                button510.BackColor = Color.Yellow;
            }
            else
            {
                button510.BackColor = Color.Red;
            }
        }
        private void button511_Click(object sender, EventArgs e)
        {
            if (button511.BackColor == Color.Lime)
            {
                button511.BackColor = Color.Yellow;
            }
            else
            {
                button511.BackColor = Color.Red;
            }
        }
        private void button512_Click(object sender, EventArgs e)
        {
            if (button512.BackColor == Color.Lime)
            {
                button512.BackColor = Color.Yellow;
            }
            else
            {
                button512.BackColor = Color.Red;
            }
        }
        private void button513_Click(object sender, EventArgs e)
        {
            if (button513.BackColor == Color.Lime)
            {
                button513.BackColor = Color.Yellow;
            }
            else
            {
                button513.BackColor = Color.Red;
            }
        }
        private void button514_Click(object sender, EventArgs e)
        {
            if (button514.BackColor == Color.Lime)
            {
                button514.BackColor = Color.Yellow;
            }
            else
            {
                button514.BackColor = Color.Red;
            }
        }
        private void button515_Click(object sender, EventArgs e)
        {
            if (button515.BackColor == Color.Lime)
            {
                button515.BackColor = Color.Yellow;
            }
            else
            {
                button515.BackColor = Color.Red;
            }
        }
        private void button516_Click(object sender, EventArgs e)
        {
            if (button516.BackColor == Color.Lime)
            {
                button516.BackColor = Color.Yellow;
            }
            else
            {
                button516.BackColor = Color.Red;
            }
        }
        private void button517_Click(object sender, EventArgs e)
        {
            if (button517.BackColor == Color.Lime)
            {
                button517.BackColor = Color.Yellow;
            }
            else
            {
                button517.BackColor = Color.Red;
            }
        }
        private void button518_Click(object sender, EventArgs e)
        {
            if (button518.BackColor == Color.Lime)
            {
                button518.BackColor = Color.Yellow;
            }
            else
            {
                button518.BackColor = Color.Red;
            }
        }
        private void button519_Click(object sender, EventArgs e)
        {
            if (button519.BackColor == Color.Lime)
            {
                button519.BackColor = Color.Yellow;
            }
            else
            {
                button519.BackColor = Color.Red;
            }
        }
        private void button520_Click(object sender, EventArgs e)
        {
            if (button520.BackColor == Color.Lime)
            {
                button520.BackColor = Color.Yellow;
            }
            else
            {
                button520.BackColor = Color.Red;
            }
        }
        private void button521_Click(object sender, EventArgs e)
        {
            if (button521.BackColor == Color.Lime)
            {
                button521.BackColor = Color.Yellow;
            }
            else
            {
                button521.BackColor = Color.Red;
            }
        }
        private void button522_Click(object sender, EventArgs e)
        {
            if (button522.BackColor == Color.Lime)
            {
                button522.BackColor = Color.Yellow;
            }
            else
            {
                button522.BackColor = Color.Red;
            }
        }
        private void button523_Click(object sender, EventArgs e)
        {
            if (button523.BackColor == Color.Lime)
            {
                button523.BackColor = Color.Yellow;
            }
            else
            {
                button523.BackColor = Color.Red;
            }
        }
        private void button524_Click(object sender, EventArgs e)
        {
            if (button524.BackColor == Color.Lime)
            {
                button524.BackColor = Color.Yellow;
            }
            else
            {
                button524.BackColor = Color.Red;
            }
        }
        private void button525_Click(object sender, EventArgs e)
        {
            if (button525.BackColor == Color.Lime)
            {
                button525.BackColor = Color.Yellow;
            }
            else
            {
                button525.BackColor = Color.Red;
            }
        }
        private void button526_Click(object sender, EventArgs e)
        {
            if (button526.BackColor == Color.Lime)
            {
                button526.BackColor = Color.Yellow;
            }
            else
            {
                button526.BackColor = Color.Red;
            }
        }
        private void button527_Click(object sender, EventArgs e)
        {
            if (button527.BackColor == Color.Lime)
            {
                button527.BackColor = Color.Yellow;
            }
            else
            {
                button527.BackColor = Color.Red;
            }
        }
        private void button528_Click(object sender, EventArgs e)
        {
            if (button528.BackColor == Color.Lime)
            {
                button528.BackColor = Color.Yellow;
            }
            else
            {
                button528.BackColor = Color.Red;
            }
        }
        private void button529_Click(object sender, EventArgs e)
        {
            if (button529.BackColor == Color.Lime)
            {
                button529.BackColor = Color.Yellow;
            }
            else
            {
                button529.BackColor = Color.Red;
            }
        }
        private void button530_Click(object sender, EventArgs e)
        {
            if (button530.BackColor == Color.Lime)
            {
                button530.BackColor = Color.Yellow;
            }
            else
            {
                button530.BackColor = Color.Red;
            }
        }
        private void button531_Click(object sender, EventArgs e)
        {
            if (button531.BackColor == Color.Lime)
            {
                button531.BackColor = Color.Yellow;
            }
            else
            {
                button531.BackColor = Color.Red;
            }
        }
        private void button532_Click(object sender, EventArgs e)
        {
            if (button532.BackColor == Color.Lime)
            {
                button532.BackColor = Color.Yellow;
            }
            else
            {
                button532.BackColor = Color.Red;
            }
        }
        private void button533_Click(object sender, EventArgs e)
        {
            if (button533.BackColor == Color.Lime)
            {
                button533.BackColor = Color.Yellow;
            }
            else
            {
                button533.BackColor = Color.Red;
            }
        }
        private void button534_Click(object sender, EventArgs e)
        {
            if (button534.BackColor == Color.Lime)
            {
                button534.BackColor = Color.Yellow;
            }
            else
            {
                button534.BackColor = Color.Red;
            }
        }
        private void button535_Click(object sender, EventArgs e)
        {
            if (button535.BackColor == Color.Lime)
            {
                button535.BackColor = Color.Yellow;
            }
            else
            {
                button535.BackColor = Color.Red;
            }
        }
        private void button536_Click(object sender, EventArgs e)
        {
            if (button536.BackColor == Color.Lime)
            {
                button536.BackColor = Color.Yellow;
            }
            else
            {
                button536.BackColor = Color.Red;
            }
        }
        private void button537_Click(object sender, EventArgs e)
        {
            if (button537.BackColor == Color.Lime)
            {
                button537.BackColor = Color.Yellow;
            }
            else
            {
                button537.BackColor = Color.Red;
            }
        }
        private void button538_Click(object sender, EventArgs e)
        {
            if (button538.BackColor == Color.Lime)
            {
                button538.BackColor = Color.Yellow;
            }
            else
            {
                button538.BackColor = Color.Red;
            }
        }
        private void button539_Click(object sender, EventArgs e)
        {
            if (button539.BackColor == Color.Lime)
            {
                button539.BackColor = Color.Yellow;
            }
            else
            {
                button539.BackColor = Color.Red;
            }
        }
        private void button540_Click(object sender, EventArgs e)
        {
            if (button540.BackColor == Color.Lime)
            {
                button540.BackColor = Color.Yellow;
            }
            else
            {
                button540.BackColor = Color.Red;
            }
        }
        private void button541_Click(object sender, EventArgs e)
        {
            if (button541.BackColor == Color.Lime)
            {
                button541.BackColor = Color.Yellow;
            }
            else
            {
                button541.BackColor = Color.Red;
            }
        }
        private void button542_Click(object sender, EventArgs e)
        {
            if (button542.BackColor == Color.Lime)
            {
                button542.BackColor = Color.Yellow;
            }
            else
            {
                button542.BackColor = Color.Red;
            }
        }
        private void button543_Click(object sender, EventArgs e)
        {
            if (button543.BackColor == Color.Lime)
            {
                button543.BackColor = Color.Yellow;
            }
            else
            {
                button543.BackColor = Color.Red;
            }
        }
        private void button544_Click(object sender, EventArgs e)
        {
            if (button544.BackColor == Color.Lime)
            {
                button544.BackColor = Color.Yellow;
            }
            else
            {
                button544.BackColor = Color.Red;
            }
        }
        private void button545_Click(object sender, EventArgs e)
        {
            if (button545.BackColor == Color.Lime)
            {
                button545.BackColor = Color.Yellow;
            }
            else
            {
                button545.BackColor = Color.Red;
            }
        }
        private void button546_Click(object sender, EventArgs e)
        {
            if (button546.BackColor == Color.Lime)
            {
                button546.BackColor = Color.Yellow;
            }
            else
            {
                button546.BackColor = Color.Red;
            }
        }
        private void button547_Click(object sender, EventArgs e)
        {
            if (button547.BackColor == Color.Lime)
            {
                button547.BackColor = Color.Yellow;
            }
            else
            {
                button547.BackColor = Color.Red;
            }
        }
        private void button548_Click(object sender, EventArgs e)
        {
            if (button548.BackColor == Color.Lime)
            {
                button548.BackColor = Color.Yellow;
            }
            else
            {
                button548.BackColor = Color.Red;
            }
        }
        private void button549_Click(object sender, EventArgs e)
        {
            if (button549.BackColor == Color.Lime)
            {
                button549.BackColor = Color.Yellow;
            }
            else
            {
                button549.BackColor = Color.Red;
            }
        }
        private void button550_Click(object sender, EventArgs e)
        {
            if (button550.BackColor == Color.Lime)
            {
                button550.BackColor = Color.Yellow;
            }
            else
            {
                button550.BackColor = Color.Red;
            }
        }
        private void button551_Click(object sender, EventArgs e)
        {
            if (button551.BackColor == Color.Lime)
            {
                button551.BackColor = Color.Yellow;
            }
            else
            {
                button551.BackColor = Color.Red;
            }
        }
        private void button552_Click(object sender, EventArgs e)
        {
            if (button552.BackColor == Color.Lime)
            {
                button552.BackColor = Color.Yellow;
            }
            else
            {
                button552.BackColor = Color.Red;
            }
        }
        private void button553_Click(object sender, EventArgs e)
        {
            if (button553.BackColor == Color.Lime)
            {
                button553.BackColor = Color.Yellow;
            }
            else
            {
                button553.BackColor = Color.Red;
            }
        }
        private void button554_Click(object sender, EventArgs e)
        {
            if (button554.BackColor == Color.Lime)
            {
                button554.BackColor = Color.Yellow;
            }
            else
            {
                button554.BackColor = Color.Red;
            }
        }
        private void button555_Click(object sender, EventArgs e)
        {
            if (button555.BackColor == Color.Lime)
            {
                button555.BackColor = Color.Yellow;
            }
            else
            {
                button555.BackColor = Color.Red;
            }
        }
        private void button556_Click(object sender, EventArgs e)
        {
            if (button556.BackColor == Color.Lime)
            {
                button556.BackColor = Color.Yellow;
            }
            else
            {
                button556.BackColor = Color.Red;
            }
        }
        private void button557_Click(object sender, EventArgs e)
        {
            if (button557.BackColor == Color.Lime)
            {
                button557.BackColor = Color.Yellow;
            }
            else
            {
                button557.BackColor = Color.Red;
            }
        }
        private void button558_Click(object sender, EventArgs e)
        {
            if (button558.BackColor == Color.Lime)
            {
                button558.BackColor = Color.Yellow;
            }
            else
            {
                button558.BackColor = Color.Red;
            }
        }
        private void button559_Click(object sender, EventArgs e)
        {
            if (button559.BackColor == Color.Lime)
            {
                button559.BackColor = Color.Yellow;
            }
            else
            {
                button559.BackColor = Color.Red;
            }
        }
        private void button560_Click(object sender, EventArgs e)
        {
            if (button560.BackColor == Color.Lime)
            {
                button560.BackColor = Color.Yellow;
            }
            else
            {
                button560.BackColor = Color.Red;
            }
        }
        private void button561_Click(object sender, EventArgs e)
        {
            if (button561.BackColor == Color.Lime)
            {
                button561.BackColor = Color.Yellow;
            }
            else
            {
                button561.BackColor = Color.Red;
            }
        }
        private void button562_Click(object sender, EventArgs e)
        {
            if (button562.BackColor == Color.Lime)
            {
                button562.BackColor = Color.Yellow;
            }
            else
            {
                button562.BackColor = Color.Red;
            }
        }
        private void button563_Click(object sender, EventArgs e)
        {
            if (button563.BackColor == Color.Lime)
            {
                button563.BackColor = Color.Yellow;
            }
            else
            {
                button563.BackColor = Color.Red;
            }
        }
        private void button564_Click(object sender, EventArgs e)
        {
            if (button564.BackColor == Color.Lime)
            {
                button564.BackColor = Color.Yellow;
            }
            else
            {
                button564.BackColor = Color.Red;
            }
        }
        private void button565_Click(object sender, EventArgs e)
        {
            if (button565.BackColor == Color.Lime)
            {
                button565.BackColor = Color.Yellow;
            }
            else
            {
                button565.BackColor = Color.Red;
            }
        }
        private void button566_Click(object sender, EventArgs e)
        {
            if (button566.BackColor == Color.Lime)
            {
                button566.BackColor = Color.Yellow;
            }
            else
            {
                button566.BackColor = Color.Red;
            }
        }
        private void button567_Click(object sender, EventArgs e)
        {
            if (button567.BackColor == Color.Lime)
            {
                button567.BackColor = Color.Yellow;
            }
            else
            {
                button567.BackColor = Color.Red;
            }
        }
        private void button568_Click(object sender, EventArgs e)
        {
            if (button568.BackColor == Color.Lime)
            {
                button568.BackColor = Color.Yellow;
            }
            else
            {
                button568.BackColor = Color.Red;
            }
        }
        private void button569_Click(object sender, EventArgs e)
        {
            if (button569.BackColor == Color.Lime)
            {
                button569.BackColor = Color.Yellow;
            }
            else
            {
                button569.BackColor = Color.Red;
            }
        }
        private void button570_Click(object sender, EventArgs e)
        {
            if (button570.BackColor == Color.Lime)
            {
                button570.BackColor = Color.Yellow;
            }
            else
            {
                button570.BackColor = Color.Red;
            }
        }
        private void button571_Click(object sender, EventArgs e)
        {
            if (button571.BackColor == Color.Lime)
            {
                button571.BackColor = Color.Yellow;
            }
            else
            {
                button571.BackColor = Color.Red;
            }
        }
        private void button572_Click(object sender, EventArgs e)
        {
            if (button572.BackColor == Color.Lime)
            {
                button572.BackColor = Color.Yellow;
            }
            else
            {
                button572.BackColor = Color.Red;
            }
        }
        private void button573_Click(object sender, EventArgs e)
        {
            if (button573.BackColor == Color.Lime)
            {
                button573.BackColor = Color.Yellow;
            }
            else
            {
                button573.BackColor = Color.Red;
            }
        }
        private void button574_Click(object sender, EventArgs e)
        {
            if (button574.BackColor == Color.Lime)
            {
                button574.BackColor = Color.Yellow;
            }
            else
            {
                button574.BackColor = Color.Red;
            }
        }
        private void button575_Click(object sender, EventArgs e)
        {
            if (button575.BackColor == Color.Lime)
            {
                button575.BackColor = Color.Yellow;
            }
            else
            {
                button575.BackColor = Color.Red;
            }
        }
        private void button576_Click(object sender, EventArgs e)
        {
            if (button576.BackColor == Color.Lime)
            {
                button576.BackColor = Color.Yellow;
            }
            else
            {
                button576.BackColor = Color.Red;
            }
        }
        private void button577_Click(object sender, EventArgs e)
        {
            if (button577.BackColor == Color.Lime)
            {
                button577.BackColor = Color.Yellow;
            }
            else
            {
                button577.BackColor = Color.Red;
            }
        }
        private void button578_Click(object sender, EventArgs e)
        {
            if (button578.BackColor == Color.Lime)
            {
                button578.BackColor = Color.Yellow;
            }
            else
            {
                button578.BackColor = Color.Red;
            }
        }
        private void button579_Click(object sender, EventArgs e)
        {
            if (button579.BackColor == Color.Lime)
            {
                button579.BackColor = Color.Yellow;
            }
            else
            {
                button579.BackColor = Color.Red;
            }
        }
        private void button580_Click(object sender, EventArgs e)
        {
            if (button580.BackColor == Color.Lime)
            {
                button580.BackColor = Color.Yellow;
            }
            else
            {
                button580.BackColor = Color.Red;
            }
        }
        private void button581_Click(object sender, EventArgs e)
        {
            if (button581.BackColor == Color.Lime)
            {
                button581.BackColor = Color.Yellow;
            }
            else
            {
                button581.BackColor = Color.Red;
            }
        }
        private void button582_Click(object sender, EventArgs e)
        {
            if (button582.BackColor == Color.Lime)
            {
                button582.BackColor = Color.Yellow;
            }
            else
            {
                button582.BackColor = Color.Red;
            }
        }
        private void button583_Click(object sender, EventArgs e)
        {
            if (button583.BackColor == Color.Lime)
            {
                button583.BackColor = Color.Yellow;
            }
            else
            {
                button583.BackColor = Color.Red;
            }
        }
        private void button584_Click(object sender, EventArgs e)
        {
            if (button584.BackColor == Color.Lime)
            {
                button584.BackColor = Color.Yellow;
            }
            else
            {
                button584.BackColor = Color.Red;
            }
        }
        private void button585_Click(object sender, EventArgs e)
        {
            if (button585.BackColor == Color.Lime)
            {
                button585.BackColor = Color.Yellow;
            }
            else
            {
                button585.BackColor = Color.Red;
            }
        }
        private void button586_Click(object sender, EventArgs e)
        {
            if (button586.BackColor == Color.Lime)
            {
                button586.BackColor = Color.Yellow;
            }
            else
            {
                button586.BackColor = Color.Red;
            }
        }
        private void button587_Click(object sender, EventArgs e)
        {
            if (button587.BackColor == Color.Lime)
            {
                button587.BackColor = Color.Yellow;
            }
            else
            {
                button587.BackColor = Color.Red;
            }
        }
        private void button588_Click(object sender, EventArgs e)
        {
            if (button588.BackColor == Color.Lime)
            {
                button588.BackColor = Color.Yellow;
            }
            else
            {
                button588.BackColor = Color.Red;
            }
        }
        private void button589_Click(object sender, EventArgs e)
        {
            if (button589.BackColor == Color.Lime)
            {
                button589.BackColor = Color.Yellow;
            }
            else
            {
                button589.BackColor = Color.Red;
            }
        }
        private void button590_Click(object sender, EventArgs e)
        {
            if (button590.BackColor == Color.Lime)
            {
                button590.BackColor = Color.Yellow;
            }
            else
            {
                button590.BackColor = Color.Red;
            }
        }
        private void button591_Click(object sender, EventArgs e)
        {
            if (button591.BackColor == Color.Lime)
            {
                button591.BackColor = Color.Yellow;
            }
            else
            {
                button591.BackColor = Color.Red;
            }
        }
        private void button592_Click(object sender, EventArgs e)
        {
            if (button592.BackColor == Color.Lime)
            {
                button592.BackColor = Color.Yellow;
            }
            else
            {
                button592.BackColor = Color.Red;
            }
        }
        private void button593_Click(object sender, EventArgs e)
        {
            if (button593.BackColor == Color.Lime)
            {
                button593.BackColor = Color.Yellow;
            }
            else
            {
                button593.BackColor = Color.Red;
            }
        }
        private void button594_Click(object sender, EventArgs e)
        {
            if (button594.BackColor == Color.Lime)
            {
                button594.BackColor = Color.Yellow;
            }
            else
            {
                button594.BackColor = Color.Red;
            }
        }
        private void button595_Click(object sender, EventArgs e)
        {
            if (button595.BackColor == Color.Lime)
            {
                button595.BackColor = Color.Yellow;
            }
            else
            {
                button595.BackColor = Color.Red;
            }
        }
        private void button596_Click(object sender, EventArgs e)
        {
            if (button596.BackColor == Color.Lime)
            {
                button596.BackColor = Color.Yellow;
            }
            else
            {
                button596.BackColor = Color.Red;
            }
        }
        private void button597_Click(object sender, EventArgs e)
        {
            if (button597.BackColor == Color.Lime)
            {
                button597.BackColor = Color.Yellow;
            }
            else
            {
                button597.BackColor = Color.Red;
            }
        }
        private void button598_Click(object sender, EventArgs e)
        {
            if (button598.BackColor == Color.Lime)
            {
                button598.BackColor = Color.Yellow;
            }
            else
            {
                button598.BackColor = Color.Red;
            }
        }
        private void button599_Click(object sender, EventArgs e)
        {
            if (button599.BackColor == Color.Lime)
            {
                button599.BackColor = Color.Yellow;
            }
            else
            {
                button599.BackColor = Color.Red;
            }
        }
        private void button600_Click(object sender, EventArgs e)
        {
            if (button600.BackColor == Color.Lime)
            {
                button600.BackColor = Color.Yellow;
            }
            else
            {
                button600.BackColor = Color.Red;
            }
        }
        private void button601_Click(object sender, EventArgs e)
        {
            if (button601.BackColor == Color.Lime)
            {
                button601.BackColor = Color.Yellow;
            }
            else
            {
                button601.BackColor = Color.Red;
            }
        }
        private void button602_Click(object sender, EventArgs e)
        {
            if (button602.BackColor == Color.Lime)
            {
                button602.BackColor = Color.Yellow;
            }
            else
            {
                button602.BackColor = Color.Red;
            }
        }
        private void button603_Click(object sender, EventArgs e)
        {
            if (button603.BackColor == Color.Lime)
            {
                button603.BackColor = Color.Yellow;
            }
            else
            {
                button603.BackColor = Color.Red;
            }
        }
        private void button604_Click(object sender, EventArgs e)
        {
            if (button604.BackColor == Color.Lime)
            {
                button604.BackColor = Color.Yellow;
            }
            else
            {
                button604.BackColor = Color.Red;
            }
        }
        private void button605_Click(object sender, EventArgs e)
        {
            if (button605.BackColor == Color.Lime)
            {
                button605.BackColor = Color.Yellow;
            }
            else
            {
                button605.BackColor = Color.Red;
            }
        }
        private void button606_Click(object sender, EventArgs e)
        {
            if (button606.BackColor == Color.Lime)
            {
                button606.BackColor = Color.Yellow;
            }
            else
            {
                button606.BackColor = Color.Red;
            }
        }
        private void button607_Click(object sender, EventArgs e)
        {
            if (button607.BackColor == Color.Lime)
            {
                button607.BackColor = Color.Yellow;
            }
            else
            {
                button607.BackColor = Color.Red;
            }
        }
        private void button608_Click(object sender, EventArgs e)
        {
            if (button608.BackColor == Color.Lime)
            {
                button608.BackColor = Color.Yellow;
            }
            else
            {
                button608.BackColor = Color.Red;
            }
        }
        private void button609_Click(object sender, EventArgs e)
        {
            if (button609.BackColor == Color.Lime)
            {
                button609.BackColor = Color.Yellow;
            }
            else
            {
                button609.BackColor = Color.Red;
            }
        }
        private void button610_Click(object sender, EventArgs e)
        {
            if (button610.BackColor == Color.Lime)
            {
                button610.BackColor = Color.Yellow;
            }
            else
            {
                button610.BackColor = Color.Red;
            }
        }
        private void button611_Click(object sender, EventArgs e)
        {
            if (button611.BackColor == Color.Lime)
            {
                button611.BackColor = Color.Yellow;
            }
            else
            {
                button611.BackColor = Color.Red;
            }
        }
        private void button612_Click(object sender, EventArgs e)
        {
            if (button612.BackColor == Color.Lime)
            {
                button612.BackColor = Color.Yellow;
            }
            else
            {
                button612.BackColor = Color.Red;
            }
        }
        private void button613_Click(object sender, EventArgs e)
        {
            if (button613.BackColor == Color.Lime)
            {
                button613.BackColor = Color.Yellow;
            }
            else
            {
                button613.BackColor = Color.Red;
            }
        }
        private void button614_Click(object sender, EventArgs e)
        {
            if (button614.BackColor == Color.Lime)
            {
                button614.BackColor = Color.Yellow;
            }
            else
            {
                button614.BackColor = Color.Red;
            }
        }
        private void button615_Click(object sender, EventArgs e)
        {
            if (button615.BackColor == Color.Lime)
            {
                button615.BackColor = Color.Yellow;
            }
            else
            {
                button615.BackColor = Color.Red;
            }
        }
        private void button616_Click(object sender, EventArgs e)
        {
            if (button616.BackColor == Color.Lime)
            {
                button616.BackColor = Color.Yellow;
            }
            else
            {
                button616.BackColor = Color.Red;
            }
        }
        private void button617_Click(object sender, EventArgs e)
        {
            if (button617.BackColor == Color.Lime)
            {
                button617.BackColor = Color.Yellow;
            }
            else
            {
                button617.BackColor = Color.Red;
            }
        }
        private void button618_Click(object sender, EventArgs e)
        {
            if (button618.BackColor == Color.Lime)
            {
                button618.BackColor = Color.Yellow;
            }
            else
            {
                button618.BackColor = Color.Red;
            }
        }
        private void button619_Click(object sender, EventArgs e)
        {
            if (button619.BackColor == Color.Lime)
            {
                button619.BackColor = Color.Yellow;
            }
            else
            {
                button619.BackColor = Color.Red;
            }
        }
        private void button620_Click(object sender, EventArgs e)
        {
            if (button620.BackColor == Color.Lime)
            {
                button620.BackColor = Color.Yellow;
            }
            else
            {
                button620.BackColor = Color.Red;
            }
        }
        private void button621_Click(object sender, EventArgs e)
        {
            if (button621.BackColor == Color.Lime)
            {
                button621.BackColor = Color.Yellow;
            }
            else
            {
                button621.BackColor = Color.Red;
            }
        }
        private void button622_Click(object sender, EventArgs e)
        {
            if (button622.BackColor == Color.Lime)
            {
                button622.BackColor = Color.Yellow;
            }
            else
            {
                button622.BackColor = Color.Red;
            }
        }
        private void button623_Click(object sender, EventArgs e)
        {
            if (button623.BackColor == Color.Lime)
            {
                button623.BackColor = Color.Yellow;
            }
            else
            {
                button623.BackColor = Color.Red;
            }
        }
        private void button624_Click(object sender, EventArgs e)
        {
            if (button624.BackColor == Color.Lime)
            {
                button624.BackColor = Color.Yellow;
            }
            else
            {
                button624.BackColor = Color.Red;
            }
        }
        private void button625_Click(object sender, EventArgs e)
        {
            if (button625.BackColor == Color.Lime)
            {
                button625.BackColor = Color.Yellow;
            }
            else
            {
                button625.BackColor = Color.Red;
            }
        }
        private void button626_Click(object sender, EventArgs e)
        {
            if (button626.BackColor == Color.Lime)
            {
                button626.BackColor = Color.Yellow;
            }
            else
            {
                button626.BackColor = Color.Red;
            }
        }
        private void button627_Click(object sender, EventArgs e)
        {
            if (button627.BackColor == Color.Lime)
            {
                button627.BackColor = Color.Yellow;
            }
            else
            {
                button627.BackColor = Color.Red;
            }
        }
        private void button628_Click(object sender, EventArgs e)
        {
            if (button628.BackColor == Color.Lime)
            {
                button628.BackColor = Color.Yellow;
            }
            else
            {
                button628.BackColor = Color.Red;
            }
        }
        private void button629_Click(object sender, EventArgs e)
        {
            if (button629.BackColor == Color.Lime)
            {
                button629.BackColor = Color.Yellow;
            }
            else
            {
                button629.BackColor = Color.Red;
            }
        }
        private void button630_Click(object sender, EventArgs e)
        {
            if (button630.BackColor == Color.Lime)
            {
                button630.BackColor = Color.Yellow;
            }
            else
            {
                button630.BackColor = Color.Red;
            }
        }
        private void button631_Click(object sender, EventArgs e)
        {
            if (button631.BackColor == Color.Lime)
            {
                button631.BackColor = Color.Yellow;
            }
            else
            {
                button631.BackColor = Color.Red;
            }
        }
        private void button632_Click(object sender, EventArgs e)
        {
            if (button632.BackColor == Color.Lime)
            {
                button632.BackColor = Color.Yellow;
            }
            else
            {
                button632.BackColor = Color.Red;
            }
        }
        private void button633_Click(object sender, EventArgs e)
        {
            if (button633.BackColor == Color.Lime)
            {
                button633.BackColor = Color.Yellow;
            }
            else
            {
                button633.BackColor = Color.Red;
            }
        }
        private void button634_Click(object sender, EventArgs e)
        {
            if (button634.BackColor == Color.Lime)
            {
                button634.BackColor = Color.Yellow;
            }
            else
            {
                button634.BackColor = Color.Red;
            }
        }
        private void button635_Click(object sender, EventArgs e)
        {
            if (button635.BackColor == Color.Lime)
            {
                button635.BackColor = Color.Yellow;
            }
            else
            {
                button635.BackColor = Color.Red;
            }
        }
        private void button636_Click(object sender, EventArgs e)
        {
            if (button636.BackColor == Color.Lime)
            {
                button636.BackColor = Color.Yellow;
            }
            else
            {
                button636.BackColor = Color.Red;
            }
        }
        private void button637_Click(object sender, EventArgs e)
        {
            if (button637.BackColor == Color.Lime)
            {
                button637.BackColor = Color.Yellow;
            }
            else
            {
                button637.BackColor = Color.Red;
            }
        }
        private void button638_Click(object sender, EventArgs e)
        {
            if (button638.BackColor == Color.Lime)
            {
                button638.BackColor = Color.Yellow;
            }
            else
            {
                button638.BackColor = Color.Red;
            }
        }
        private void button639_Click(object sender, EventArgs e)
        {
            if (button639.BackColor == Color.Lime)
            {
                button639.BackColor = Color.Yellow;
            }
            else
            {
                button639.BackColor = Color.Red;
            }
        }
        private void button640_Click(object sender, EventArgs e)
        {
            if (button640.BackColor == Color.Lime)
            {
                button640.BackColor = Color.Yellow;
            }
            else
            {
                button640.BackColor = Color.Red;
            }
        }
        private void button641_Click(object sender, EventArgs e)
        {
            if (button641.BackColor == Color.Lime)
            {
                button641.BackColor = Color.Yellow;
            }
            else
            {
                button641.BackColor = Color.Red;
            }
        }
        private void button642_Click(object sender, EventArgs e)
        {
            if (button642.BackColor == Color.Lime)
            {
                button642.BackColor = Color.Yellow;
            }
            else
            {
                button642.BackColor = Color.Red;
            }
        }
        private void button643_Click(object sender, EventArgs e)
        {
            if (button643.BackColor == Color.Lime)
            {
                button643.BackColor = Color.Yellow;
            }
            else
            {
                button643.BackColor = Color.Red;
            }
        }
        private void button644_Click(object sender, EventArgs e)
        {
            if (button644.BackColor == Color.Lime)
            {
                button644.BackColor = Color.Yellow;
            }
            else
            {
                button644.BackColor = Color.Red;
            }
        }
        private void button645_Click(object sender, EventArgs e)
        {
            if (button645.BackColor == Color.Lime)
            {
                button645.BackColor = Color.Yellow;
            }
            else
            {
                button645.BackColor = Color.Red;
            }
        }
        private void button646_Click(object sender, EventArgs e)
        {
            if (button646.BackColor == Color.Lime)
            {
                button646.BackColor = Color.Yellow;
            }
            else
            {
                button646.BackColor = Color.Red;
            }
        }
        private void button647_Click(object sender, EventArgs e)
        {
            if (button647.BackColor == Color.Lime)
            {
                button647.BackColor = Color.Yellow;
            }
            else
            {
                button647.BackColor = Color.Red;
            }
        }
        private void button648_Click(object sender, EventArgs e)
        {
            if (button648.BackColor == Color.Lime)
            {
                button648.BackColor = Color.Yellow;
            }
            else
            {
                button648.BackColor = Color.Red;
            }
        }
        private void button649_Click(object sender, EventArgs e)
        {
            if (button649.BackColor == Color.Lime)
            {
                button649.BackColor = Color.Yellow;
            }
            else
            {
                button649.BackColor = Color.Red;
            }
        }
        private void button650_Click(object sender, EventArgs e)
        {
            if (button650.BackColor == Color.Lime)
            {
                button650.BackColor = Color.Yellow;
            }
            else
            {
                button650.BackColor = Color.Red;
            }
        }
        private void button651_Click(object sender, EventArgs e)
        {
            if (button651.BackColor == Color.Lime)
            {
                button651.BackColor = Color.Yellow;
            }
            else
            {
                button651.BackColor = Color.Red;
            }
        }
        private void button652_Click(object sender, EventArgs e)
        {
            if (button652.BackColor == Color.Lime)
            {
                button652.BackColor = Color.Yellow;
            }
            else
            {
                button652.BackColor = Color.Red;
            }
        }
        private void button653_Click(object sender, EventArgs e)
        {
            if (button653.BackColor == Color.Lime)
            {
                button653.BackColor = Color.Yellow;
            }
            else
            {
                button653.BackColor = Color.Red;
            }
        }
        private void button654_Click(object sender, EventArgs e)
        {
            if (button654.BackColor == Color.Lime)
            {
                button654.BackColor = Color.Yellow;
            }
            else
            {
                button654.BackColor = Color.Red;
            }
        }
        private void button655_Click(object sender, EventArgs e)
        {
            if (button655.BackColor == Color.Lime)
            {
                button655.BackColor = Color.Yellow;
            }
            else
            {
                button655.BackColor = Color.Red;
            }
        }
        private void button656_Click(object sender, EventArgs e)
        {
            if (button656.BackColor == Color.Lime)
            {
                button656.BackColor = Color.Yellow;
            }
            else
            {
                button656.BackColor = Color.Red;
            }
        }
        private void button657_Click(object sender, EventArgs e)
        {
            if (button657.BackColor == Color.Lime)
            {
                button657.BackColor = Color.Yellow;
            }
            else
            {
                button657.BackColor = Color.Red;
            }
        }
        private void button658_Click(object sender, EventArgs e)
        {
            if (button658.BackColor == Color.Lime)
            {
                button658.BackColor = Color.Yellow;
            }
            else
            {
                button658.BackColor = Color.Red;
            }
        }
        private void button659_Click(object sender, EventArgs e)
        {
            if (button659.BackColor == Color.Lime)
            {
                button659.BackColor = Color.Yellow;
            }
            else
            {
                button659.BackColor = Color.Red;
            }
        }
        private void button660_Click(object sender, EventArgs e)
        {
            if (button660.BackColor == Color.Lime)
            {
                button660.BackColor = Color.Yellow;
            }
            else
            {
                button660.BackColor = Color.Red;
            }
        }
        private void button661_Click(object sender, EventArgs e)
        {
            if (button661.BackColor == Color.Lime)
            {
                button661.BackColor = Color.Yellow;
            }
            else
            {
                button661.BackColor = Color.Red;
            }
        }
        private void button662_Click(object sender, EventArgs e)
        {
            if (button662.BackColor == Color.Lime)
            {
                button662.BackColor = Color.Yellow;
            }
            else
            {
                button662.BackColor = Color.Red;
            }
        }
        private void button663_Click(object sender, EventArgs e)
        {
            if (button663.BackColor == Color.Lime)
            {
                button663.BackColor = Color.Yellow;
            }
            else
            {
                button663.BackColor = Color.Red;
            }
        }
        private void button664_Click(object sender, EventArgs e)
        {
            if (button664.BackColor == Color.Lime)
            {
                button664.BackColor = Color.Yellow;
            }
            else
            {
                button664.BackColor = Color.Red;
            }
        }
        private void button665_Click(object sender, EventArgs e)
        {
            if (button665.BackColor == Color.Lime)
            {
                button665.BackColor = Color.Yellow;
            }
            else
            {
                button665.BackColor = Color.Red;
            }
        }
        private void button666_Click(object sender, EventArgs e)
        {
            if (button666.BackColor == Color.Lime)
            {
                button666.BackColor = Color.Yellow;
            }
            else
            {
                button666.BackColor = Color.Red;
            }
        }
        private void button667_Click(object sender, EventArgs e)
        {
            if (button667.BackColor == Color.Lime)
            {
                button667.BackColor = Color.Yellow;
            }
            else
            {
                button667.BackColor = Color.Red;
            }
        }
        private void button668_Click(object sender, EventArgs e)
        {
            if (button668.BackColor == Color.Lime)
            {
                button668.BackColor = Color.Yellow;
            }
            else
            {
                button668.BackColor = Color.Red;
            }
        }
        private void button669_Click(object sender, EventArgs e)
        {
            if (button669.BackColor == Color.Lime)
            {
                button669.BackColor = Color.Yellow;
            }
            else
            {
                button669.BackColor = Color.Red;
            }
        }
        private void button670_Click(object sender, EventArgs e)
        {
            if (button670.BackColor == Color.Lime)
            {
                button670.BackColor = Color.Yellow;
            }
            else
            {
                button670.BackColor = Color.Red;
            }
        }
        private void button671_Click(object sender, EventArgs e)
        {
            if (button671.BackColor == Color.Lime)
            {
                button671.BackColor = Color.Yellow;
            }
            else
            {
                button671.BackColor = Color.Red;
            }
        }
        private void button672_Click(object sender, EventArgs e)
        {
            if (button672.BackColor == Color.Lime)
            {
                button672.BackColor = Color.Yellow;
            }
            else
            {
                button672.BackColor = Color.Red;
            }
        }
        private void button673_Click(object sender, EventArgs e)
        {
            if (button673.BackColor == Color.Lime)
            {
                button673.BackColor = Color.Yellow;
            }
            else
            {
                button673.BackColor = Color.Red;
            }
        }
        private void button674_Click(object sender, EventArgs e)
        {
            if (button674.BackColor == Color.Lime)
            {
                button674.BackColor = Color.Yellow;
            }
            else
            {
                button674.BackColor = Color.Red;
            }
        }
        private void button675_Click(object sender, EventArgs e)
        {
            if (button675.BackColor == Color.Lime)
            {
                button675.BackColor = Color.Yellow;
            }
            else
            {
                button675.BackColor = Color.Red;
            }
        }
        private void button676_Click(object sender, EventArgs e)
        {
            if (button676.BackColor == Color.Lime)
            {
                button676.BackColor = Color.Yellow;
            }
            else
            {
                button676.BackColor = Color.Red;
            }
        }
        private void button677_Click(object sender, EventArgs e)
        {
            if (button677.BackColor == Color.Lime)
            {
                button677.BackColor = Color.Yellow;
            }
            else
            {
                button677.BackColor = Color.Red;
            }
        }
        private void button678_Click(object sender, EventArgs e)
        {
            if (button678.BackColor == Color.Lime)
            {
                button678.BackColor = Color.Yellow;
            }
            else
            {
                button678.BackColor = Color.Red;
            }
        }
        private void button679_Click(object sender, EventArgs e)
        {
            if (button679.BackColor == Color.Lime)
            {
                button679.BackColor = Color.Yellow;
            }
            else
            {
                button679.BackColor = Color.Red;
            }
        }
        private void button680_Click(object sender, EventArgs e)
        {
            if (button680.BackColor == Color.Lime)
            {
                button680.BackColor = Color.Yellow;
            }
            else
            {
                button680.BackColor = Color.Red;
            }
        }
        private void button681_Click(object sender, EventArgs e)
        {
            if (button681.BackColor == Color.Lime)
            {
                button681.BackColor = Color.Yellow;
            }
            else
            {
                button681.BackColor = Color.Red;
            }
        }
        private void button682_Click(object sender, EventArgs e)
        {
            if (button682.BackColor == Color.Lime)
            {
                button682.BackColor = Color.Yellow;
            }
            else
            {
                button682.BackColor = Color.Red;
            }
        }
        private void button683_Click(object sender, EventArgs e)
        {
            if (button683.BackColor == Color.Lime)
            {
                button683.BackColor = Color.Yellow;
            }
            else
            {
                button683.BackColor = Color.Red;
            }
        }
        private void button684_Click(object sender, EventArgs e)
        {
            if (button684.BackColor == Color.Lime)
            {
                button684.BackColor = Color.Yellow;
            }
            else
            {
                button684.BackColor = Color.Red;
            }
        }
        private void button685_Click(object sender, EventArgs e)
        {
            if (button685.BackColor == Color.Lime)
            {
                button685.BackColor = Color.Yellow;
            }
            else
            {
                button685.BackColor = Color.Red;
            }
        }
        private void button686_Click(object sender, EventArgs e)
        {
            if (button686.BackColor == Color.Lime)
            {
                button686.BackColor = Color.Yellow;
            }
            else
            {
                button686.BackColor = Color.Red;
            }
        }
        private void button687_Click(object sender, EventArgs e)
        {
            if (button687.BackColor == Color.Lime)
            {
                button687.BackColor = Color.Yellow;
            }
            else
            {
                button687.BackColor = Color.Red;
            }
        }
        private void button688_Click(object sender, EventArgs e)
        {
            if (button688.BackColor == Color.Lime)
            {
                button688.BackColor = Color.Yellow;
            }
            else
            {
                button688.BackColor = Color.Red;
            }
        }
        private void button689_Click(object sender, EventArgs e)
        {
            if (button689.BackColor == Color.Lime)
            {
                button689.BackColor = Color.Yellow;
            }
            else
            {
                button689.BackColor = Color.Red;
            }
        }
        private void button690_Click(object sender, EventArgs e)
        {
            if (button690.BackColor == Color.Lime)
            {
                button690.BackColor = Color.Yellow;
            }
            else
            {
                button690.BackColor = Color.Red;
            }
        }
        private void button691_Click(object sender, EventArgs e)
        {
            if (button691.BackColor == Color.Lime)
            {
                button691.BackColor = Color.Yellow;
            }
            else
            {
                button691.BackColor = Color.Red;
            }
        }
        private void button692_Click(object sender, EventArgs e)
        {
            if (button692.BackColor == Color.Lime)
            {
                button692.BackColor = Color.Yellow;
            }
            else
            {
                button692.BackColor = Color.Red;
            }
        }
        private void button693_Click(object sender, EventArgs e)
        {
            if (button693.BackColor == Color.Lime)
            {
                button693.BackColor = Color.Yellow;
            }
            else
            {
                button693.BackColor = Color.Red;
            }
        }
        private void button694_Click(object sender, EventArgs e)
        {
            if (button694.BackColor == Color.Lime)
            {
                button694.BackColor = Color.Yellow;
            }
            else
            {
                button694.BackColor = Color.Red;
            }
        }
        private void button695_Click(object sender, EventArgs e)
        {
            if (button695.BackColor == Color.Lime)
            {
                button695.BackColor = Color.Yellow;
            }
            else
            {
                button695.BackColor = Color.Red;
            }
        }
        private void button696_Click(object sender, EventArgs e)
        {
            if (button696.BackColor == Color.Lime)
            {
                button696.BackColor = Color.Yellow;
            }
            else
            {
                button696.BackColor = Color.Red;
            }
        }
        private void button697_Click(object sender, EventArgs e)
        {
            if (button697.BackColor == Color.Lime)
            {
                button697.BackColor = Color.Yellow;
            }
            else
            {
                button697.BackColor = Color.Red;
            }
        }
        private void button698_Click(object sender, EventArgs e)
        {
            if (button698.BackColor == Color.Lime)
            {
                button698.BackColor = Color.Yellow;
            }
            else
            {
                button698.BackColor = Color.Red;
            }
        }
        private void button699_Click(object sender, EventArgs e)
        {
            if (button699.BackColor == Color.Lime)
            {
                button699.BackColor = Color.Yellow;
            }
            else
            {
                button699.BackColor = Color.Red;
            }
        }
        private void button700_Click(object sender, EventArgs e)
        {
            if (button700.BackColor == Color.Lime)
            {
                button700.BackColor = Color.Yellow;
            }
            else
            {
                button700.BackColor = Color.Red;
            }
        }
        private void button701_Click(object sender, EventArgs e)
        {
            if (button701.BackColor == Color.Lime)
            {
                button701.BackColor = Color.Yellow;
            }
            else
            {
                button701.BackColor = Color.Red;
            }
        }
        private void button702_Click(object sender, EventArgs e)
        {
            if (button702.BackColor == Color.Lime)
            {
                button702.BackColor = Color.Yellow;
            }
            else
            {
                button702.BackColor = Color.Red;
            }
        }
        private void button703_Click(object sender, EventArgs e)
        {
            if (button703.BackColor == Color.Lime)
            {
                button703.BackColor = Color.Yellow;
            }
            else
            {
                button703.BackColor = Color.Red;
            }
        }
        private void button704_Click(object sender, EventArgs e)
        {
            if (button704.BackColor == Color.Lime)
            {
                button704.BackColor = Color.Yellow;
            }
            else
            {
                button704.BackColor = Color.Red;
            }
        }
        private void button705_Click(object sender, EventArgs e)
        {
            if (button705.BackColor == Color.Lime)
            {
                button705.BackColor = Color.Yellow;
            }
            else
            {
                button705.BackColor = Color.Red;
            }
        }
        private void button706_Click(object sender, EventArgs e)
        {
            if (button706.BackColor == Color.Lime)
            {
                button706.BackColor = Color.Yellow;
            }
            else
            {
                button706.BackColor = Color.Red;
            }
        }
        private void button707_Click(object sender, EventArgs e)
        {
            if (button707.BackColor == Color.Lime)
            {
                button707.BackColor = Color.Yellow;
            }
            else
            {
                button707.BackColor = Color.Red;
            }
        }
        private void button708_Click(object sender, EventArgs e)
        {
            if (button708.BackColor == Color.Lime)
            {
                button708.BackColor = Color.Yellow;
            }
            else
            {
                button708.BackColor = Color.Red;
            }
        }
        private void button709_Click(object sender, EventArgs e)
        {
            if (button709.BackColor == Color.Lime)
            {
                button709.BackColor = Color.Yellow;
            }
            else
            {
                button709.BackColor = Color.Red;
            }
        }
        private void button710_Click(object sender, EventArgs e)
        {
            if (button710.BackColor == Color.Lime)
            {
                button710.BackColor = Color.Yellow;
            }
            else
            {
                button710.BackColor = Color.Red;
            }
        }
        private void button711_Click(object sender, EventArgs e)
        {
            if (button711.BackColor == Color.Lime)
            {
                button711.BackColor = Color.Yellow;
            }
            else
            {
                button711.BackColor = Color.Red;
            }
        }
        private void button712_Click(object sender, EventArgs e)
        {
            if (button712.BackColor == Color.Lime)
            {
                button712.BackColor = Color.Yellow;
            }
            else
            {
                button712.BackColor = Color.Red;
            }
        }
        private void button713_Click(object sender, EventArgs e)
        {
            if (button713.BackColor == Color.Lime)
            {
                button713.BackColor = Color.Yellow;
            }
            else
            {
                button713.BackColor = Color.Red;
            }
        }
        private void button714_Click(object sender, EventArgs e)
        {
            if (button714.BackColor == Color.Lime)
            {
                button714.BackColor = Color.Yellow;
            }
            else
            {
                button714.BackColor = Color.Red;
            }
        }
        private void button715_Click(object sender, EventArgs e)
        {
            if (button715.BackColor == Color.Lime)
            {
                button715.BackColor = Color.Yellow;
            }
            else
            {
                button715.BackColor = Color.Red;
            }
        }
        private void button716_Click(object sender, EventArgs e)
        {
            if (button716.BackColor == Color.Lime)
            {
                button716.BackColor = Color.Yellow;
            }
            else
            {
                button716.BackColor = Color.Red;
            }
        }
        private void button717_Click(object sender, EventArgs e)
        {
            if (button717.BackColor == Color.Lime)
            {
                button717.BackColor = Color.Yellow;
            }
            else
            {
                button717.BackColor = Color.Red;
            }
        }
        private void button718_Click(object sender, EventArgs e)
        {
            if (button718.BackColor == Color.Lime)
            {
                button718.BackColor = Color.Yellow;
            }
            else
            {
                button718.BackColor = Color.Red;
            }
        }
        private void button719_Click(object sender, EventArgs e)
        {
            if (button719.BackColor == Color.Lime)
            {
                button719.BackColor = Color.Yellow;
            }
            else
            {
                button719.BackColor = Color.Red;
            }
        }
        private void button720_Click(object sender, EventArgs e)
        {
            if (button720.BackColor == Color.Lime)
            {
                button720.BackColor = Color.Yellow;
            }
            else
            {
                button720.BackColor = Color.Red;
            }
        }
        private void button721_Click(object sender, EventArgs e)
        {
            if (button721.BackColor == Color.Lime)
            {
                button721.BackColor = Color.Yellow;
            }
            else
            {
                button721.BackColor = Color.Red;
            }
        }
        private void button722_Click(object sender, EventArgs e)
        {
            if (button722.BackColor == Color.Lime)
            {
                button722.BackColor = Color.Yellow;
            }
            else
            {
                button722.BackColor = Color.Red;
            }
        }
        private void button723_Click(object sender, EventArgs e)
        {
            if (button723.BackColor == Color.Lime)
            {
                button723.BackColor = Color.Yellow;
            }
            else
            {
                button723.BackColor = Color.Red;
            }
        }
        private void button724_Click(object sender, EventArgs e)
        {
            if (button724.BackColor == Color.Lime)
            {
                button724.BackColor = Color.Yellow;
            }
            else
            {
                button724.BackColor = Color.Red;
            }
        }
        private void button725_Click(object sender, EventArgs e)
        {
            if (button725.BackColor == Color.Lime)
            {
                button725.BackColor = Color.Yellow;
            }
            else
            {
                button725.BackColor = Color.Red;
            }
        }
        private void button726_Click(object sender, EventArgs e)
        {
            if (button726.BackColor == Color.Lime)
            {
                button726.BackColor = Color.Yellow;
            }
            else
            {
                button726.BackColor = Color.Red;
            }
        }
        private void button727_Click(object sender, EventArgs e)
        {
            if (button727.BackColor == Color.Lime)
            {
                button727.BackColor = Color.Yellow;
            }
            else
            {
                button727.BackColor = Color.Red;
            }
        }
        private void button728_Click(object sender, EventArgs e)
        {
            if (button728.BackColor == Color.Lime)
            {
                button728.BackColor = Color.Yellow;
            }
            else
            {
                button728.BackColor = Color.Red;
            }
        }
        private void button729_Click(object sender, EventArgs e)
        {
            if (button729.BackColor == Color.Lime)
            {
                button729.BackColor = Color.Yellow;
            }
            else
            {
                button729.BackColor = Color.Red;
            }
        }
        private void button730_Click(object sender, EventArgs e)
        {
            if (button730.BackColor == Color.Lime)
            {
                button730.BackColor = Color.Yellow;
            }
            else
            {
                button730.BackColor = Color.Red;
            }
        }
        private void button731_Click(object sender, EventArgs e)
        {
            if (button731.BackColor == Color.Lime)
            {
                button731.BackColor = Color.Yellow;
            }
            else
            {
                button731.BackColor = Color.Red;
            }
        }
        private void button732_Click(object sender, EventArgs e)
        {
            if (button732.BackColor == Color.Lime)
            {
                button732.BackColor = Color.Yellow;
            }
            else
            {
                button732.BackColor = Color.Red;
            }
        }
        private void button733_Click(object sender, EventArgs e)
        {
            if (button733.BackColor == Color.Lime)
            {
                button733.BackColor = Color.Yellow;
            }
            else
            {
                button733.BackColor = Color.Red;
            }
        }
        private void button734_Click(object sender, EventArgs e)
        {
            if (button734.BackColor == Color.Lime)
            {
                button734.BackColor = Color.Yellow;
            }
            else
            {
                button734.BackColor = Color.Red;
            }
        }
        private void button735_Click(object sender, EventArgs e)
        {
            if (button735.BackColor == Color.Lime)
            {
                button735.BackColor = Color.Yellow;
            }
            else
            {
                button735.BackColor = Color.Red;
            }
        }
        private void button736_Click(object sender, EventArgs e)
        {
            if (button736.BackColor == Color.Lime)
            {
                button736.BackColor = Color.Yellow;
            }
            else
            {
                button736.BackColor = Color.Red;
            }
        }
        private void button744_Click(object sender, EventArgs e)
        {
            if (button744.BackColor == Color.Lime)
            {
                button744.BackColor = Color.Yellow;
            }
            else
            {
                button744.BackColor = Color.Red;
            }
        }
        private void button745_Click(object sender, EventArgs e)
        {
            if (button745.BackColor == Color.Lime)
            {
                button745.BackColor = Color.Yellow;
            }
            else
            {
                button745.BackColor = Color.Red;
            }
        }
        private void button746_Click(object sender, EventArgs e)
        {
            if (button746.BackColor == Color.Lime)
            {
                button746.BackColor = Color.Yellow;
            }
            else
            {
                button746.BackColor = Color.Red;
            }
        }
        private void button747_Click(object sender, EventArgs e)
        {
            if (button747.BackColor == Color.Lime)
            {
                button747.BackColor = Color.Yellow;
            }
            else
            {
                button747.BackColor = Color.Red;
            }
        }
        private void button748_Click(object sender, EventArgs e)
        {
            if (button748.BackColor == Color.Lime)
            {
                button748.BackColor = Color.Yellow;
            }
            else
            {
                button748.BackColor = Color.Red;
            }
        }
        //---------------------------------------
        private void Button494_Click(object sender, EventArgs e)
        {
            if (button494.BackColor == Color.Lime)
            {
                button494.BackColor = Color.Yellow;
            }
            else
            {
                button494.BackColor = Color.Red;
            }
        }

        private void button744_Click_1(object sender, EventArgs e)
        {
            button432.BackColor = Color.Lime;
            button433.BackColor = Color.Lime;
            button434.BackColor = Color.Lime;
            button435.BackColor = Color.Lime;
            button436.BackColor = Color.Lime;
            button437.BackColor = Color.Lime;
            button438.BackColor = Color.Lime;
            button439.BackColor = Color.Lime;
            button440.BackColor = Color.Lime;
            button441.BackColor = Color.Lime;
            button442.BackColor = Color.Lime;
            button443.BackColor = Color.Lime;
            button444.BackColor = Color.Lime;
            button445.BackColor = Color.Lime;
            button446.BackColor = Color.Lime;
            button447.BackColor = Color.Lime;
            button448.BackColor = Color.Lime;
            button449.BackColor = Color.Lime;
            button450.BackColor = Color.Lime;
            button451.BackColor = Color.Lime;
            button452.BackColor = Color.Lime;
            button453.BackColor = Color.Lime;
            button454.BackColor = Color.Lime;
            button455.BackColor = Color.Lime;
            button456.BackColor = Color.Lime;
            button457.BackColor = Color.Lime;
            button458.BackColor = Color.Lime;
            button459.BackColor = Color.Lime;
            button460.BackColor = Color.Lime;
            button461.BackColor = Color.Lime;
            button462.BackColor = Color.Lime;
            button463.BackColor = Color.Lime;
            button464.BackColor = Color.Lime;
            button465.BackColor = Color.Lime;
            button466.BackColor = Color.Lime;
            button467.BackColor = Color.Lime;
            button468.BackColor = Color.Lime;
            button469.BackColor = Color.Lime;
            button470.BackColor = Color.Lime;
            button471.BackColor = Color.Lime;
            button472.BackColor = Color.Lime;
            button473.BackColor = Color.Lime;
            button474.BackColor = Color.Lime;
            button475.BackColor = Color.Lime;
            button476.BackColor = Color.Lime;
            button477.BackColor = Color.Lime;
            button478.BackColor = Color.Lime;
            button479.BackColor = Color.Lime;
            button480.BackColor = Color.Lime;
            button481.BackColor = Color.Lime;
            button482.BackColor = Color.Lime;
            button483.BackColor = Color.Lime;
            button484.BackColor = Color.Lime;
            button485.BackColor = Color.Lime;
            button486.BackColor = Color.Lime;
            button487.BackColor = Color.Lime;
            button488.BackColor = Color.Lime;
            button489.BackColor = Color.Lime;
            button490.BackColor = Color.Lime;
            button491.BackColor = Color.Lime;
            button492.BackColor = Color.Lime;

        }

        private void button521_Click_1(object sender, EventArgs e)
        {
            if (button521.BackColor == Color.Lime)
            {
                button521.BackColor = Color.Yellow;
            }
            else
            {
                button521.BackColor = Color.Red;
            }

        }

        private void button493_Click_1(object sender, EventArgs e)
        {
            if (button493.BackColor == Color.Lime)
            {
                button493.BackColor = Color.Yellow;
            }
            else
            {
                button493.BackColor = Color.Red;
            }
        }

        private void button494_Click_1(object sender, EventArgs e)
        {
            if (button494.BackColor == Color.Lime)
            {
                button494.BackColor = Color.Yellow;
            }
            else
            {
                button494.BackColor = Color.Red;
            }
        }

        private void button495_Click_1(object sender, EventArgs e)
        {
            if (button495.BackColor == Color.Lime)
            {
                button495.BackColor = Color.Yellow;
            }
            else
            {
                button495.BackColor = Color.Red;
            }

        }

        private void button496_Click_1(object sender, EventArgs e)
        {
            if (button496.BackColor == Color.Lime)
            {
                button496.BackColor = Color.Yellow;
            }
            else
            {
                button496.BackColor = Color.Red;
            }

        }

        private void button497_Click_1(object sender, EventArgs e)
        {
            if (button497.BackColor == Color.Lime)
            {
                button497.BackColor = Color.Yellow;
            }
            else
            {
                button497.BackColor = Color.Red;
            }

        }

        private void button498_Click_1(object sender, EventArgs e)
        {
            if (button498.BackColor == Color.Lime)
            {
                button498.BackColor = Color.Yellow;
            }
            else
            {
                button498.BackColor = Color.Red;
            }

        }

        private void button499_Click_1(object sender, EventArgs e)
        {
            if (button499.BackColor == Color.Lime)
            {
                button499.BackColor = Color.Yellow;
            }
            else
            {
                button499.BackColor = Color.Red;
            }

        }

        private void button500_Click_1(object sender, EventArgs e)
        {
            if (button500.BackColor == Color.Lime)
            {
                button500.BackColor = Color.Yellow;
            }
            else
            {
                button500.BackColor = Color.Red;
            }

        }

        private void button501_Click_1(object sender, EventArgs e)
        {
            if (button501.BackColor == Color.Lime)
            {
                button501.BackColor = Color.Yellow;
            }
            else
            {
                button501.BackColor = Color.Red;
            }

        }

        private void button502_Click_1(object sender, EventArgs e)
        {
            if (button502.BackColor == Color.Lime)
            {
                button502.BackColor = Color.Yellow;
            }
            else
            {
                button502.BackColor = Color.Red;
            }

        }

        private void button503_Click_1(object sender, EventArgs e)
        {
            if (button503.BackColor == Color.Lime)
            {
                button503.BackColor = Color.Yellow;
            }
            else
            {
                button503.BackColor = Color.Red;
            }

        }

        private void button504_Click_1(object sender, EventArgs e)
        {
            if (button504.BackColor == Color.Lime)
            {
                button504.BackColor = Color.Yellow;
            }
            else
            {
                button504.BackColor = Color.Red;
            }

        }

        private void button505_Click_1(object sender, EventArgs e)
        {
            if (button505.BackColor == Color.Lime)
            {
                button505.BackColor = Color.Yellow;
            }
            else
            {
                button505.BackColor = Color.Red;
            }

        }

        private void button506_Click_1(object sender, EventArgs e)
        {
            if (button506.BackColor == Color.Lime)
            {
                button506.BackColor = Color.Yellow;
            }
            else
            {
                button506.BackColor = Color.Red;
            }

        }

        private void button507_Click_1(object sender, EventArgs e)
        {
            if (button507.BackColor == Color.Lime)
            {
                button507.BackColor = Color.Yellow;
            }
            else
            {
                button507.BackColor = Color.Red;
            }


        }

        private void button508_Click_1(object sender, EventArgs e)
        {
            if (button508.BackColor == Color.Lime)
            {
                button508.BackColor = Color.Yellow;
            }
            else
            {
                button508.BackColor = Color.Red;
            }

        }

        private void button509_Click_1(object sender, EventArgs e)
        {
            if (button509.BackColor == Color.Lime)
            {
                button509.BackColor = Color.Yellow;
            }
            else
            {
                button509.BackColor = Color.Red;
            }
        }

        private void button510_Click_1(object sender, EventArgs e)

        {
            if (button510.BackColor == Color.Lime)
            {
                button510.BackColor = Color.Yellow;
            }
            else
            {
                button510.BackColor = Color.Red;
            }

        }

        private void button511_Click_1(object sender, EventArgs e)
        {
            if (button511.BackColor == Color.Lime)
            {
                button511.BackColor = Color.Yellow;
            }
            else
            {
                button511.BackColor = Color.Red;
            }

        }

        private void button512_Click_1(object sender, EventArgs e)
        {
            if (button512.BackColor == Color.Lime)
            {
                button512.BackColor = Color.Yellow;
            }
            else
            {
                button512.BackColor = Color.Red;
            }

        }

        private void button513_Click_1(object sender, EventArgs e)
        {
            if (button513.BackColor == Color.Lime)
            {
                button513.BackColor = Color.Yellow;
            }
            else
            {
                button513.BackColor = Color.Red;
            }
        }

        private void button514_Click_1(object sender, EventArgs e)
        {
            if (button514.BackColor == Color.Lime)
            {
                button514.BackColor = Color.Yellow;
            }
            else
            {
                button514.BackColor = Color.Red;
            }


        }

        private void button515_Click_1(object sender, EventArgs e)
        {
            if (button515.BackColor == Color.Lime)
            {
                button515.BackColor = Color.Yellow;
            }
            else
            {
                button515.BackColor = Color.Red;
            }

        }

        private void button516_Click_1(object sender, EventArgs e)
        {
            if (button516.BackColor == Color.Lime)
            {
                button516.BackColor = Color.Yellow;
            }
            else
            {
                button516.BackColor = Color.Red;
            }

        }

        private void button517_Click_1(object sender, EventArgs e)
        {
            if (button517.BackColor == Color.Lime)
            {
                button517.BackColor = Color.Yellow;
            }
            else
            {
                button517.BackColor = Color.Red;
            }

        }

        private void button518_Click_1(object sender, EventArgs e)
        {
            if (button518.BackColor == Color.Lime)
            {
                button518.BackColor = Color.Yellow;
            }
            else
            {
                button518.BackColor = Color.Red;
            }
        }

        private void button519_Click_1(object sender, EventArgs e)
        {
            if (button519.BackColor == Color.Lime)
            {
                button519.BackColor = Color.Yellow;
            }
            else
            {
                button519.BackColor = Color.Red;
            }


        }

        private void button520_Click_1(object sender, EventArgs e)
        {
            if (button520.BackColor == Color.Lime)
            {
                button520.BackColor = Color.Yellow;
            }
            else
            {
                button520.BackColor = Color.Red;
            }

        }

        private void button522_Click_1(object sender, EventArgs e)
        {
            if (button522.BackColor == Color.Lime)
            {
                button522.BackColor = Color.Yellow;
            }
            else
            {
                button522.BackColor = Color.Red;
            }

        }

        private void button523_Click_1(object sender, EventArgs e)
        {
            if (button523.BackColor == Color.Lime)
            {
                button523.BackColor = Color.Yellow;
            }
            else
            {
                button523.BackColor = Color.Red;
            }

        }

        private void button524_Click_1(object sender, EventArgs e)
        {
            if (button524.BackColor == Color.Lime)
            {
                button524.BackColor = Color.Yellow;
            }
            else
            {
                button524.BackColor = Color.Red;
            }

        }

        private void button525_Click_1(object sender, EventArgs e)
        {
            if (button525.BackColor == Color.Lime)
            {
                button525.BackColor = Color.Yellow;
            }
            else
            {
                button525.BackColor = Color.Red;
            }

        }

        private void button526_Click_1(object sender, EventArgs e)
        {
            if (button526.BackColor == Color.Lime)
            {
                button526.BackColor = Color.Yellow;
            }
            else
            {
                button526.BackColor = Color.Red;
            }

        }

        private void button527_Click_1(object sender, EventArgs e)
        {
            if (button527.BackColor == Color.Lime)
            {
                button527.BackColor = Color.Yellow;
            }
            else
            {
                button527.BackColor = Color.Red;
            }

        }

        private void button528_Click_1(object sender, EventArgs e)
        {
            if (button528.BackColor == Color.Lime)
            {
                button528.BackColor = Color.Yellow;
            }
            else
            {
                button528.BackColor = Color.Red;
            }

        }

        private void button529_Click_1(object sender, EventArgs e)
        {
            if (button529.BackColor == Color.Lime)
            {
                button529.BackColor = Color.Yellow;
            }
            else
            {
                button529.BackColor = Color.Red;
            }

        }

        private void button530_Click_1(object sender, EventArgs e)
        {
            if (button530.BackColor == Color.Lime)
            {
                button530.BackColor = Color.Yellow;
            }
            else
            {
                button530.BackColor = Color.Red;
            }

        }

        private void button531_Click_1(object sender, EventArgs e)
        {
            if (button531.BackColor == Color.Lime)
            {
                button531.BackColor = Color.Yellow;
            }
            else
            {
                button531.BackColor = Color.Red;
            }

        }

        private void button532_Click_1(object sender, EventArgs e)
        {
            if (button532.BackColor == Color.Lime)
            {
                button532.BackColor = Color.Yellow;
            }
            else
            {
                button532.BackColor = Color.Red;
            }

        }

        private void button533_Click_1(object sender, EventArgs e)
        {
            if (button533.BackColor == Color.Lime)
            {
                button533.BackColor = Color.Yellow;
            }
            else
            {
                button533.BackColor = Color.Red;
            }

        }

        private void button534_Click_1(object sender, EventArgs e)
        {
            if (button534.BackColor == Color.Lime)
            {
                button534.BackColor = Color.Yellow;
            }
            else
            {
                button534.BackColor = Color.Red;
            }

        }

        private void button535_Click_1(object sender, EventArgs e)
        {
            if (button535.BackColor == Color.Lime)
            {
                button535.BackColor = Color.Yellow;
            }
            else
            {
                button535.BackColor = Color.Red;
            }

        }

        private void button536_Click_1(object sender, EventArgs e)
        {
            if (button536.BackColor == Color.Lime)
            {
                button536.BackColor = Color.Yellow;
            }
            else
            {
                button536.BackColor = Color.Red;
            }

        }

        private void button537_Click_1(object sender, EventArgs e)
        {
            if (button537.BackColor == Color.Lime)
            {
                button537.BackColor = Color.Yellow;
            }
            else
            {
                button537.BackColor = Color.Red;
            }

        }

        private void button538_Click_1(object sender, EventArgs e)
        {
            if (button538.BackColor == Color.Lime)
            {
                button538.BackColor = Color.Yellow;
            }
            else
            {
                button538.BackColor = Color.Red;
            }

        }

        private void button539_Click_1(object sender, EventArgs e)
        {
            if (button539.BackColor == Color.Lime)
            {
                button539.BackColor = Color.Yellow;
            }
            else
            {
                button539.BackColor = Color.Red;
            }

        }

        private void button540_Click_1(object sender, EventArgs e)
        {
            if (button540.BackColor == Color.Lime)
            {
                button540.BackColor = Color.Yellow;
            }
            else
            {
                button540.BackColor = Color.Red;
            }

        }

        private void button541_Click_1(object sender, EventArgs e)
        {
            if (button541.BackColor == Color.Lime)
            {
                button541.BackColor = Color.Yellow;
            }
            else
            {
                button541.BackColor = Color.Red;
            }

        }

        private void button542_Click_1(object sender, EventArgs e)
        {
            if (button542.BackColor == Color.Lime)
            {
                button542.BackColor = Color.Yellow;
            }
            else
            {
                button542.BackColor = Color.Red;
            }


        }

        private void button543_Click_1(object sender, EventArgs e)
        {
            if (button543.BackColor == Color.Lime)
            {
                button543.BackColor = Color.Yellow;
            }
            else
            {
                button543.BackColor = Color.Red;
            }

        }

        private void button544_Click_1(object sender, EventArgs e)
        {
            if (button544.BackColor == Color.Lime)
            {
                button544.BackColor = Color.Yellow;
            }
            else
            {
                button544.BackColor = Color.Red;
            }

        }

        private void button545_Click_1(object sender, EventArgs e)
        {
            if (button545.BackColor == Color.Lime)
            {
                button545.BackColor = Color.Yellow;
            }
            else
            {
                button545.BackColor = Color.Red;
            }

        }

        private void button546_Click_1(object sender, EventArgs e)
        {
            if (button546.BackColor == Color.Lime)
            {
                button546.BackColor = Color.Yellow;
            }
            else
            {
                button546.BackColor = Color.Red;
            }

        }

        private void button547_Click_1(object sender, EventArgs e)
        {
            if (button547.BackColor == Color.Lime)
            {
                button547.BackColor = Color.Yellow;
            }
            else
            {
                button547.BackColor = Color.Red;
            }

        }

        private void button548_Click_1(object sender, EventArgs e)
        {

            if (button548.BackColor == Color.Lime)
            {
                button548.BackColor = Color.Yellow;
            }
            else
            {
                button548.BackColor = Color.Red;
            }


        }

        private void button549_Click_1(object sender, EventArgs e)
        {
            {
                if (button549.BackColor == Color.Lime)
                {
                    button549.BackColor = Color.Yellow;
                }
                else
                {
                    button549.BackColor = Color.Red;
                }

            }


        }

        private void button745_Click_1(object sender, EventArgs e)
        {
            button550.BackColor = Color.Lime;
            button551.BackColor = Color.Lime;
            button552.BackColor = Color.Lime;
            button553.BackColor = Color.Lime;
            button454.BackColor = Color.Lime;
            button455.BackColor = Color.Lime;
            button456.BackColor = Color.Lime;
            button457.BackColor = Color.Lime;
            button458.BackColor = Color.Lime;
            button459.BackColor = Color.Lime;
            button460.BackColor = Color.Lime;
            button461.BackColor = Color.Lime;
            button462.BackColor = Color.Lime;
            button463.BackColor = Color.Lime;
            button464.BackColor = Color.Lime;
            button465.BackColor = Color.Lime;
            button466.BackColor = Color.Lime;
            button467.BackColor = Color.Lime;
            button468.BackColor = Color.Lime;
            button469.BackColor = Color.Lime;
            button470.BackColor = Color.Lime;
            button471.BackColor = Color.Lime;
            button472.BackColor = Color.Lime;
            button473.BackColor = Color.Lime;
            button474.BackColor = Color.Lime;
            button475.BackColor = Color.Lime;
            button476.BackColor = Color.Lime;
            button477.BackColor = Color.Lime;
            button478.BackColor = Color.Lime;
            button479.BackColor = Color.Lime;
            button480.BackColor = Color.Lime;
            button481.BackColor = Color.Lime;
            button482.BackColor = Color.Lime;
            button483.BackColor = Color.Lime;
            button484.BackColor = Color.Lime;
            button485.BackColor = Color.Lime;
            button486.BackColor = Color.Lime;
            button487.BackColor = Color.Lime;
            button488.BackColor = Color.Lime;
            button489.BackColor = Color.Lime;
            button490.BackColor = Color.Lime;
            button491.BackColor = Color.Lime;
            button492.BackColor = Color.Lime;
            button493.BackColor = Color.Lime;
            button494.BackColor = Color.Lime;
            button495.BackColor = Color.Lime;
            button496.BackColor = Color.Lime;
            button497.BackColor = Color.Lime;
            button498.BackColor = Color.Lime;
            button499.BackColor = Color.Lime;
            button500.BackColor = Color.Lime;
            button501.BackColor = Color.Lime;
            button502.BackColor = Color.Lime;
            button503.BackColor = Color.Lime;
            button504.BackColor = Color.Lime;
            button505.BackColor = Color.Lime;
            button506.BackColor = Color.Lime;
            button507.BackColor = Color.Lime;
            button508.BackColor = Color.Lime;
            button509.BackColor = Color.Lime;
            button510.BackColor = Color.Lime;
            button511.BackColor = Color.Lime;
            button512.BackColor = Color.Lime;
            button513.BackColor = Color.Lime;
            button514.BackColor = Color.Lime;
            button515.BackColor = Color.Lime;
            button516.BackColor = Color.Lime;
            button517.BackColor = Color.Lime;
            button518.BackColor = Color.Lime;
            button519.BackColor = Color.Lime;
            button520.BackColor = Color.Lime;
            button521.BackColor = Color.Lime;
            button522.BackColor = Color.Lime;
            button523.BackColor = Color.Lime;
            button524.BackColor = Color.Lime;
            button525.BackColor = Color.Lime;
            button526.BackColor = Color.Lime;
            button527.BackColor = Color.Lime;
            button528.BackColor = Color.Lime;
            button529.BackColor = Color.Lime;
            button530.BackColor = Color.Lime;
            button531.BackColor = Color.Lime;
            button532.BackColor = Color.Lime;
            button533.BackColor = Color.Lime;
            button534.BackColor = Color.Lime;
            button535.BackColor = Color.Lime;
            button536.BackColor = Color.Lime;
            button537.BackColor = Color.Lime;
            button538.BackColor = Color.Lime;
            button539.BackColor = Color.Lime;
            button540.BackColor = Color.Lime;
            button541.BackColor = Color.Lime;
            button542.BackColor = Color.Lime;
            button543.BackColor = Color.Lime;
            button544.BackColor = Color.Lime;
            button545.BackColor = Color.Lime;
            button546.BackColor = Color.Lime;
            button547.BackColor = Color.Lime;
            button548.BackColor = Color.Lime;
            button549.BackColor = Color.Lime;
        }

        private void button555_Click_1(object sender, EventArgs e)
        {
            if (button555.BackColor == Color.Lime)
            {
                button555.BackColor = Color.Yellow;
            }
            else
            {
                button555.BackColor = Color.Red;
            }
        }
        private void button556_Click_1(object sender, EventArgs e)
        {
            if (button556.BackColor == Color.Lime)
            {
                button556.BackColor = Color.Yellow;
            }
            else
            {
                button556.BackColor = Color.Red;
            }
        }
        private void button557_Click_1(object sender, EventArgs e)
        {
            if (button557.BackColor == Color.Lime)
            {
                button557.BackColor = Color.Yellow;
            }
            else
            {
                button557.BackColor = Color.Red;
            }
        }
        private void button558_Click_1(object sender, EventArgs e)
        {
            if (button558.BackColor == Color.Lime)
            {
                button558.BackColor = Color.Yellow;
            }
            else
            {
                button558.BackColor = Color.Red;
            }
        }
        private void button559_Click_1(object sender, EventArgs e)
        {
            if (button559.BackColor == Color.Lime)
            {
                button559.BackColor = Color.Yellow;
            }
            else
            {
                button559.BackColor = Color.Red;
            }
        }
        private void button560_Click_1(object sender, EventArgs e)
        {
            if (button560.BackColor == Color.Lime)
            {
                button560.BackColor = Color.Yellow;
            }
            else
            {
                button560.BackColor = Color.Red;
            }
        }
        private void button561_Click_1(object sender, EventArgs e)
        {
            if (button561.BackColor == Color.Lime)
            {
                button561.BackColor = Color.Yellow;
            }
            else
            {
                button561.BackColor = Color.Red;
            }
        }
        private void button562_Click_1(object sender, EventArgs e)
        {
            if (button562.BackColor == Color.Lime)
            {
                button562.BackColor = Color.Yellow;
            }
            else
            {
                button562.BackColor = Color.Red;
            }
        }
        private void button563_Click_1(object sender, EventArgs e)
        {
            if (button563.BackColor == Color.Lime)
            {
                button563.BackColor = Color.Yellow;
            }
            else
            {
                button563.BackColor = Color.Red;
            }
        }
        private void button564_Click_1(object sender, EventArgs e)
        {
            if (button564.BackColor == Color.Lime)
            {
                button564.BackColor = Color.Yellow;
            }
            else
            {
                button564.BackColor = Color.Red;
            }
        }
        private void button565_Click_1(object sender, EventArgs e)
        {
            if (button565.BackColor == Color.Lime)
            {
                button565.BackColor = Color.Yellow;
            }
            else
            {
                button565.BackColor = Color.Red;
            }
        }
        private void button566_Click_1(object sender, EventArgs e)
        {
            if (button566.BackColor == Color.Lime)
            {
                button566.BackColor = Color.Yellow;
            }
            else
            {
                button566.BackColor = Color.Red;
            }
        }
        private void button567_Click_1(object sender, EventArgs e)
        {
            if (button567.BackColor == Color.Lime)
            {
                button567.BackColor = Color.Yellow;
            }
            else
            {
                button567.BackColor = Color.Red;
            }
        }
        private void button568_Click_1(object sender, EventArgs e)
        {
            if (button568.BackColor == Color.Lime)
            {
                button568.BackColor = Color.Yellow;
            }
            else
            {
                button568.BackColor = Color.Red;
            }
        }
        private void button569_Click_1(object sender, EventArgs e)
        {
            if (button569.BackColor == Color.Lime)
            {
                button569.BackColor = Color.Yellow;
            }
            else
            {
                button569.BackColor = Color.Red;
            }
        }
        private void button570_Click_1(object sender, EventArgs e)
        {
            if (button570.BackColor == Color.Lime)
            {
                button570.BackColor = Color.Yellow;
            }
            else
            {
                button570.BackColor = Color.Red;
            }
        }
        private void button571_Click_1(object sender, EventArgs e)
        {
            if (button571.BackColor == Color.Lime)
            {
                button571.BackColor = Color.Yellow;
            }
            else
            {
                button571.BackColor = Color.Red;
            }
        }
        private void button572_Click_1(object sender, EventArgs e)
        {
            if (button572.BackColor == Color.Lime)
            {
                button572.BackColor = Color.Yellow;
            }
            else
            {
                button572.BackColor = Color.Red;
            }
        }
        private void button573_Click_1(object sender, EventArgs e)
        {
            if (button573.BackColor == Color.Lime)
            {
                button573.BackColor = Color.Yellow;
            }
            else
            {
                button573.BackColor = Color.Red;
            }
        }
        private void button574_Click_1(object sender, EventArgs e)
        {
            if (button574.BackColor == Color.Lime)
            {
                button574.BackColor = Color.Yellow;
            }
            else
            {
                button574.BackColor = Color.Red;
            }
        }
        private void button575_Click_1(object sender, EventArgs e)
        {
            if (button575.BackColor == Color.Lime)
            {
                button575.BackColor = Color.Yellow;
            }
            else
            {
                button575.BackColor = Color.Red;
            }
        }
        private void button576_Click_1(object sender, EventArgs e)
        {
            if (button576.BackColor == Color.Lime)
            {
                button576.BackColor = Color.Yellow;
            }
            else
            {
                button576.BackColor = Color.Red;
            }
        }
        private void button577_Click_1(object sender, EventArgs e)
        {
            if (button577.BackColor == Color.Lime)
            {
                button577.BackColor = Color.Yellow;
            }
            else
            {
                button577.BackColor = Color.Red;
            }
        }
        private void button578_Click_1(object sender, EventArgs e)
        {
            if (button578.BackColor == Color.Lime)
            {
                button578.BackColor = Color.Yellow;
            }
            else
            {
                button578.BackColor = Color.Red;
            }
        }
        private void button579_Click_1(object sender, EventArgs e)
        {
            if (button579.BackColor == Color.Lime)
            {
                button579.BackColor = Color.Yellow;
            }
            else
            {
                button579.BackColor = Color.Red;
            }
        }
        private void button580_Click_1(object sender, EventArgs e)
        {
            if (button580.BackColor == Color.Lime)
            {
                button580.BackColor = Color.Yellow;
            }
            else
            {
                button580.BackColor = Color.Red;
            }
        }
        private void button581_Click_1(object sender, EventArgs e)
        {
            if (button581.BackColor == Color.Lime)
            {
                button581.BackColor = Color.Yellow;
            }
            else
            {
                button581.BackColor = Color.Red;
            }
        }
        private void button582_Click_1(object sender, EventArgs e)
        {
            if (button582.BackColor == Color.Lime)
            {
                button582.BackColor = Color.Yellow;
            }
            else
            {
                button582.BackColor = Color.Red;
            }
        }
        private void button583_Click_1(object sender, EventArgs e)
        {
            if (button583.BackColor == Color.Lime)
            {
                button583.BackColor = Color.Yellow;
            }
            else
            {
                button583.BackColor = Color.Red;
            }
        }
        private void button584_Click_1(object sender, EventArgs e)
        {
            if (button584.BackColor == Color.Lime)
            {
                button584.BackColor = Color.Yellow;
            }
            else
            {
                button584.BackColor = Color.Red;
            }
        }
        private void button585_Click_1(object sender, EventArgs e)
        {
            if (button585.BackColor == Color.Lime)
            {
                button585.BackColor = Color.Yellow;
            }
            else
            {
                button585.BackColor = Color.Red;
            }
        }
        private void button586_Click_1(object sender, EventArgs e)
        {
            if (button586.BackColor == Color.Lime)
            {
                button586.BackColor = Color.Yellow;
            }
            else
            {
                button586.BackColor = Color.Red;
            }
        }
        private void button587_Click_1(object sender, EventArgs e)
        {
            if (button587.BackColor == Color.Lime)
            {
                button587.BackColor = Color.Yellow;
            }
            else
            {
                button587.BackColor = Color.Red;
            }
        }
        private void button588_Click_1(object sender, EventArgs e)
        {
            if (button588.BackColor == Color.Lime)
            {
                button588.BackColor = Color.Yellow;
            }
            else
            {
                button588.BackColor = Color.Red;
            }
        }
        private void button589_Click_1(object sender, EventArgs e)
        {
            if (button589.BackColor == Color.Lime)
            {
                button589.BackColor = Color.Yellow;
            }
            else
            {
                button589.BackColor = Color.Red;
            }
        }
        private void button590_Click_1(object sender, EventArgs e)
        {
            if (button590.BackColor == Color.Lime)
            {
                button590.BackColor = Color.Yellow;
            }
            else
            {
                button590.BackColor = Color.Red;
            }
        }
        private void button591_Click_1(object sender, EventArgs e)
        {
            if (button591.BackColor == Color.Lime)
            {
                button591.BackColor = Color.Yellow;
            }
            else
            {
                button591.BackColor = Color.Red;
            }
        }
        private void button592_Click_1(object sender, EventArgs e)
        {
            if (button592.BackColor == Color.Lime)
            {
                button592.BackColor = Color.Yellow;
            }
            else
            {
                button592.BackColor = Color.Red;
            }
        }
        private void button593_Click_1(object sender, EventArgs e)
        {
            if (button593.BackColor == Color.Lime)
            {
                button593.BackColor = Color.Yellow;
            }
            else
            {
                button593.BackColor = Color.Red;
            }
        }
        private void button594_Click_1(object sender, EventArgs e)
        {
            if (button594.BackColor == Color.Lime)
            {
                button594.BackColor = Color.Yellow;
            }
            else
            {
                button594.BackColor = Color.Red;
            }
        }
        private void button595_Click_1(object sender, EventArgs e)
        {
            if (button595.BackColor == Color.Lime)
            {
                button595.BackColor = Color.Yellow;
            }
            else
            {
                button595.BackColor = Color.Red;
            }
        }
        private void button596_Click_1(object sender, EventArgs e)
        {
            if (button596.BackColor == Color.Lime)
            {
                button596.BackColor = Color.Yellow;
            }
            else
            {
                button596.BackColor = Color.Red;
            }
        }
        private void button597_Click_1(object sender, EventArgs e)
        {
            if (button597.BackColor == Color.Lime)
            {
                button597.BackColor = Color.Yellow;
            }
            else
            {
                button597.BackColor = Color.Red;
            }
        }
        private void button598_Click_1(object sender, EventArgs e)
        {
            if (button598.BackColor == Color.Lime)
            {
                button598.BackColor = Color.Yellow;
            }
            else
            {
                button598.BackColor = Color.Red;
            }
        }
        private void button599_Click_1(object sender, EventArgs e)
        {
            if (button599.BackColor == Color.Lime)
            {
                button599.BackColor = Color.Yellow;
            }
            else
            {
                button599.BackColor = Color.Red;
            }
        }
        private void button600_Click_1(object sender, EventArgs e)
        {
            if (button600.BackColor == Color.Lime)
            {
                button600.BackColor = Color.Yellow;
            }
            else
            {
                button600.BackColor = Color.Red;
            }
        }
        private void button601_Click_1(object sender, EventArgs e)
        {
            if (button601.BackColor == Color.Lime)
            {
                button601.BackColor = Color.Yellow;
            }
            else
            {
                button601.BackColor = Color.Red;
            }
        }
        private void button602_Click_1(object sender, EventArgs e)
        {
            if (button602.BackColor == Color.Lime)
            {
                button602.BackColor = Color.Yellow;
            }
            else
            {
                button602.BackColor = Color.Red;
            }
        }
        private void button603_Click_1(object sender, EventArgs e)
        {
            if (button603.BackColor == Color.Lime)
            {
                button603.BackColor = Color.Yellow;
            }
            else
            {
                button603.BackColor = Color.Red;
            }
        }
        private void button604_Click_1(object sender, EventArgs e)
        {
            if (button604.BackColor == Color.Lime)
            {
                button604.BackColor = Color.Yellow;
            }
            else
            {
                button604.BackColor = Color.Red;
            }
        }
        private void button605_Click_1(object sender, EventArgs e)
        {
            if (button605.BackColor == Color.Lime)
            {
                button605.BackColor = Color.Yellow;
            }
            else
            {
                button605.BackColor = Color.Red;
            }
        }
        private void button606_Click_1(object sender, EventArgs e)
        {
            if (button606.BackColor == Color.Lime)
            {
                button606.BackColor = Color.Yellow;
            }
            else
            {
                button606.BackColor = Color.Red;
            }
        }
        private void button607_Click_1(object sender, EventArgs e)
        {
            if (button607.BackColor == Color.Lime)
            {
                button607.BackColor = Color.Yellow;
            }
            else
            {
                button607.BackColor = Color.Red;
            }
        }
        private void button608_Click_1(object sender, EventArgs e)
        {
            if (button608.BackColor == Color.Lime)
            {
                button608.BackColor = Color.Yellow;
            }
            else
            {
                button608.BackColor = Color.Red;
            }
        }
        private void button609_Click_1(object sender, EventArgs e)
        {
            if (button609.BackColor == Color.Lime)
            {
                button609.BackColor = Color.Yellow;
            }
            else
            {
                button609.BackColor = Color.Red;
            }
        }
        private void button610_Click_1(object sender, EventArgs e)
        {
            if (button610.BackColor == Color.Lime)
            {
                button610.BackColor = Color.Yellow;
            }
            else
            {
                button610.BackColor = Color.Red;
            }
        }
        private void button611_Click_1(object sender, EventArgs e)
        {
            if (button611.BackColor == Color.Lime)
            {
                button611.BackColor = Color.Yellow;
            }
            else
            {
                button611.BackColor = Color.Red;
            }
        }
        private void button612_Click_1(object sender, EventArgs e)
        {
            if (button612.BackColor == Color.Lime)
            {
                button612.BackColor = Color.Yellow;
            }
            else
            {
                button612.BackColor = Color.Red;
            }
        }
        private void button613_Click_1(object sender, EventArgs e)
        {
            if (button613.BackColor == Color.Lime)
            {
                button613.BackColor = Color.Yellow;
            }
            else
            {
                button613.BackColor = Color.Red;
            }
        }
        private void button614_Click_1(object sender, EventArgs e)
        {
            if (button614.BackColor == Color.Lime)
            {
                button614.BackColor = Color.Yellow;
            }
            else
            {
                button614.BackColor = Color.Red;
            }
        }

        private void button746_Click_1(object sender, EventArgs e)
        {
            button555.BackColor = Color.Lime;
            button556.BackColor = Color.Lime;
            button557.BackColor = Color.Lime;
            button558.BackColor = Color.Lime;
            button559.BackColor = Color.Lime;
            button560.BackColor = Color.Lime;
            button561.BackColor = Color.Lime;
            button562.BackColor = Color.Lime;
            button563.BackColor = Color.Lime;
            button564.BackColor = Color.Lime;
            button565.BackColor = Color.Lime;
            button566.BackColor = Color.Lime;
            button567.BackColor = Color.Lime;
            button568.BackColor = Color.Lime;
            button569.BackColor = Color.Lime;
            button570.BackColor = Color.Lime;
            button571.BackColor = Color.Lime;
            button572.BackColor = Color.Lime;
            button573.BackColor = Color.Lime;
            button574.BackColor = Color.Lime;
            button575.BackColor = Color.Lime;
            button576.BackColor = Color.Lime;
            button577.BackColor = Color.Lime;
            button578.BackColor = Color.Lime;
            button579.BackColor = Color.Lime;
            button580.BackColor = Color.Lime;
            button581.BackColor = Color.Lime;
            button582.BackColor = Color.Lime;
            button583.BackColor = Color.Lime;
            button584.BackColor = Color.Lime;
            button585.BackColor = Color.Lime;
            button586.BackColor = Color.Lime;
            button587.BackColor = Color.Lime;
            button588.BackColor = Color.Lime;
            button589.BackColor = Color.Lime;
            button590.BackColor = Color.Lime;
            button591.BackColor = Color.Lime;
            button592.BackColor = Color.Lime;
            button593.BackColor = Color.Lime;
            button594.BackColor = Color.Lime;
            button595.BackColor = Color.Lime;
            button596.BackColor = Color.Lime;
            button597.BackColor = Color.Lime;
            button598.BackColor = Color.Lime;
            button599.BackColor = Color.Lime;
            button600.BackColor = Color.Lime;
            button601.BackColor = Color.Lime;
            button602.BackColor = Color.Lime;
            button603.BackColor = Color.Lime;
            button604.BackColor = Color.Lime;
            button605.BackColor = Color.Lime;
            button606.BackColor = Color.Lime;
            button607.BackColor = Color.Lime;
            button608.BackColor = Color.Lime;
            button609.BackColor = Color.Lime;
            button610.BackColor = Color.Lime;
            button611.BackColor = Color.Lime;
            button612.BackColor = Color.Lime;
            button613.BackColor = Color.Lime;
            button614.BackColor = Color.Lime;

        }

        private void button551_Click_1(object sender, EventArgs e)
        {
            if (button551.BackColor == Color.Lime)
            {
                button551.BackColor = Color.Yellow;
            }
            else
            {
                button551.BackColor = Color.Red;
            }
        }
        private void button552_Click_1(object sender, EventArgs e)
        {
            if (button552.BackColor == Color.Lime)
            {
                button552.BackColor = Color.Yellow;
            }
            else
            {
                button552.BackColor = Color.Red;
            }
        }
        private void button553_Click_1(object sender, EventArgs e)
        {
            if (button553.BackColor == Color.Lime)
            {
                button553.BackColor = Color.Yellow;
            }
            else
            {
                button553.BackColor = Color.Red;
            }
        }
        private void button550_Click_1(object sender, EventArgs e)
        {
            if (button550.BackColor == Color.Lime)
            {
                button550.BackColor = Color.Yellow;
            }
            else
            {
                button550.BackColor = Color.Red;
            }
        }

        //-------------------------------------------------------------------
        private void button616_Click_1(object sender, EventArgs e)
        {
            if (button616.BackColor == Color.Lime)
            {
                button616.BackColor = Color.Yellow;
            }
            else
            {
                button616.BackColor = Color.Red;
            }
        }
        private void button617_Click_1(object sender, EventArgs e)
        {
            if (button617.BackColor == Color.Lime)
            {
                button617.BackColor = Color.Yellow;
            }
            else
            {
                button617.BackColor = Color.Red;
            }
        }
        private void button618_Click_1(object sender, EventArgs e)
        {
            if (button618.BackColor == Color.Lime)
            {
                button618.BackColor = Color.Yellow;
            }
            else
            {
                button618.BackColor = Color.Red;
            }
        }
        private void button619_Click_1(object sender, EventArgs e)
        {
            if (button619.BackColor == Color.Lime)
            {
                button619.BackColor = Color.Yellow;
            }
            else
            {
                button619.BackColor = Color.Red;
            }
        }
        private void button620_Click_1(object sender, EventArgs e)
        {
            if (button620.BackColor == Color.Lime)
            {
                button620.BackColor = Color.Yellow;
            }
            else
            {
                button620.BackColor = Color.Red;
            }
        }
        private void button621_Click_1(object sender, EventArgs e)
        {
            if (button621.BackColor == Color.Lime)
            {
                button621.BackColor = Color.Yellow;
            }
            else
            {
                button621.BackColor = Color.Red;
            }
        }
        private void button622_Click_1(object sender, EventArgs e)
        {
            if (button622.BackColor == Color.Lime)
            {
                button622.BackColor = Color.Yellow;
            }
            else
            {
                button622.BackColor = Color.Red;
            }
        }
        private void button623_Click_1(object sender, EventArgs e)
        {
            if (button623.BackColor == Color.Lime)
            {
                button623.BackColor = Color.Yellow;
            }
            else
            {
                button623.BackColor = Color.Red;
            }
        }
        private void button624_Click_1(object sender, EventArgs e)
        {
            if (button624.BackColor == Color.Lime)
            {
                button624.BackColor = Color.Yellow;
            }
            else
            {
                button624.BackColor = Color.Red;
            }
        }
        private void button625_Click_1(object sender, EventArgs e)
        {
            if (button625.BackColor == Color.Lime)
            {
                button625.BackColor = Color.Yellow;
            }
            else
            {
                button625.BackColor = Color.Red;
            }
        }
        private void button626_Click_1(object sender, EventArgs e)
        {
            if (button626.BackColor == Color.Lime)
            {
                button626.BackColor = Color.Yellow;
            }
            else
            {
                button626.BackColor = Color.Red;
            }
        }
        private void button627_Click_1(object sender, EventArgs e)
        {
            if (button627.BackColor == Color.Lime)
            {
                button627.BackColor = Color.Yellow;
            }
            else
            {
                button627.BackColor = Color.Red;
            }
        }
        private void button628_Click_1(object sender, EventArgs e)
        {
            if (button628.BackColor == Color.Lime)
            {
                button628.BackColor = Color.Yellow;
            }
            else
            {
                button628.BackColor = Color.Red;
            }
        }
        private void button629_Click_1(object sender, EventArgs e)
        {
            if (button629.BackColor == Color.Lime)
            {
                button629.BackColor = Color.Yellow;
            }
            else
            {
                button629.BackColor = Color.Red;
            }
        }
        private void button630_Click_1(object sender, EventArgs e)
        {
            if (button630.BackColor == Color.Lime)
            {
                button630.BackColor = Color.Yellow;
            }
            else
            {
                button630.BackColor = Color.Red;
            }
        }
        private void button631_Click_1(object sender, EventArgs e)
        {
            if (button631.BackColor == Color.Lime)
            {
                button631.BackColor = Color.Yellow;
            }
            else
            {
                button631.BackColor = Color.Red;
            }
        }
        private void button632_Click_1(object sender, EventArgs e)
        {
            if (button632.BackColor == Color.Lime)
            {
                button632.BackColor = Color.Yellow;
            }
            else
            {
                button632.BackColor = Color.Red;
            }
        }
        private void button633_Click_1(object sender, EventArgs e)
        {
            if (button633.BackColor == Color.Lime)
            {
                button633.BackColor = Color.Yellow;
            }
            else
            {
                button633.BackColor = Color.Red;
            }
        }
        private void button634_Click_1(object sender, EventArgs e)
        {
            if (button634.BackColor == Color.Lime)
            {
                button634.BackColor = Color.Yellow;
            }
            else
            {
                button634.BackColor = Color.Red;
            }
        }
        private void button635_Click_1(object sender, EventArgs e)
        {
            if (button635.BackColor == Color.Lime)
            {
                button635.BackColor = Color.Yellow;
            }
            else
            {
                button635.BackColor = Color.Red;
            }
        }
        private void button636_Click_1(object sender, EventArgs e)
        {
            if (button636.BackColor == Color.Lime)
            {
                button636.BackColor = Color.Yellow;
            }
            else
            {
                button636.BackColor = Color.Red;
            }
        }
        private void button637_Click_1(object sender, EventArgs e)
        {
            if (button637.BackColor == Color.Lime)
            {
                button637.BackColor = Color.Yellow;
            }
            else
            {
                button637.BackColor = Color.Red;
            }
        }
        private void button638_Click_1(object sender, EventArgs e)
        {
            if (button638.BackColor == Color.Lime)
            {
                button638.BackColor = Color.Yellow;
            }
            else
            {
                button638.BackColor = Color.Red;
            }
        }
        private void button639_Click_1(object sender, EventArgs e)
        {
            if (button639.BackColor == Color.Lime)
            {
                button639.BackColor = Color.Yellow;
            }
            else
            {
                button639.BackColor = Color.Red;
            }
        }
        private void button640_Click_1(object sender, EventArgs e)
        {
            if (button640.BackColor == Color.Lime)
            {
                button640.BackColor = Color.Yellow;
            }
            else
            {
                button640.BackColor = Color.Red;
            }
        }
        private void button641_Click_1(object sender, EventArgs e)
        {
            if (button641.BackColor == Color.Lime)
            {
                button641.BackColor = Color.Yellow;
            }
            else
            {
                button641.BackColor = Color.Red;
            }
        }
        private void button642_Click_1(object sender, EventArgs e)
        {
            if (button642.BackColor == Color.Lime)
            {
                button642.BackColor = Color.Yellow;
            }
            else
            {
                button642.BackColor = Color.Red;
            }
        }
        private void button643_Click_1(object sender, EventArgs e)
        {
            if (button643.BackColor == Color.Lime)
            {
                button643.BackColor = Color.Yellow;
            }
            else
            {
                button643.BackColor = Color.Red;
            }
        }
        private void button644_Click_1(object sender, EventArgs e)
        {
            if (button644.BackColor == Color.Lime)
            {
                button644.BackColor = Color.Yellow;
            }
            else
            {
                button644.BackColor = Color.Red;
            }
        }
        private void button645_Click_1(object sender, EventArgs e)
        {
            if (button645.BackColor == Color.Lime)
            {
                button645.BackColor = Color.Yellow;
            }
            else
            {
                button645.BackColor = Color.Red;
            }
        }
        private void button646_Click_1(object sender, EventArgs e)
        {
            if (button646.BackColor == Color.Lime)
            {
                button646.BackColor = Color.Yellow;
            }
            else
            {
                button646.BackColor = Color.Red;
            }
        }
        private void button647_Click_1(object sender, EventArgs e)
        {
            if (button647.BackColor == Color.Lime)
            {
                button647.BackColor = Color.Yellow;
            }
            else
            {
                button647.BackColor = Color.Red;
            }
        }
        private void button648_Click_1(object sender, EventArgs e)
        {
            if (button648.BackColor == Color.Lime)
            {
                button648.BackColor = Color.Yellow;
            }
            else
            {
                button648.BackColor = Color.Red;
            }
        }
        private void button649_Click_1(object sender, EventArgs e)
        {
            if (button649.BackColor == Color.Lime)
            {
                button649.BackColor = Color.Yellow;
            }
            else
            {
                button649.BackColor = Color.Red;
            }
        }
        private void button650_Click_1(object sender, EventArgs e)
        {
            if (button650.BackColor == Color.Lime)
            {
                button650.BackColor = Color.Yellow;
            }
            else
            {
                button650.BackColor = Color.Red;
            }
        }
        private void button651_Click_1(object sender, EventArgs e)
        {
            if (button651.BackColor == Color.Lime)
            {
                button651.BackColor = Color.Yellow;
            }
            else
            {
                button651.BackColor = Color.Red;
            }
        }
        private void button652_Click_1(object sender, EventArgs e)
        {
            if (button652.BackColor == Color.Lime)
            {
                button652.BackColor = Color.Yellow;
            }
            else
            {
                button652.BackColor = Color.Red;
            }
        }
        private void button653_Click_1(object sender, EventArgs e)
        {
            if (button653.BackColor == Color.Lime)
            {
                button653.BackColor = Color.Yellow;
            }
            else
            {
                button653.BackColor = Color.Red;
            }
        }
        private void button654_Click_1(object sender, EventArgs e)
        {
            if (button654.BackColor == Color.Lime)
            {
                button654.BackColor = Color.Yellow;
            }
            else
            {
                button654.BackColor = Color.Red;
            }
        }
        private void button655_Click_1(object sender, EventArgs e)
        {
            if (button655.BackColor == Color.Lime)
            {
                button655.BackColor = Color.Yellow;
            }
            else
            {
                button655.BackColor = Color.Red;
            }
        }
        private void button656_Click_1(object sender, EventArgs e)
        {
            if (button656.BackColor == Color.Lime)
            {
                button656.BackColor = Color.Yellow;
            }
            else
            {
                button656.BackColor = Color.Red;
            }
        }
        private void button657_Click_1(object sender, EventArgs e)
        {
            if (button657.BackColor == Color.Lime)
            {
                button657.BackColor = Color.Yellow;
            }
            else
            {
                button657.BackColor = Color.Red;
            }
        }
        private void button658_Click_1(object sender, EventArgs e)
        {
            if (button658.BackColor == Color.Lime)
            {
                button658.BackColor = Color.Yellow;
            }
            else
            {
                button658.BackColor = Color.Red;
            }
        }
        private void button659_Click_1(object sender, EventArgs e)
        {
            if (button659.BackColor == Color.Lime)
            {
                button659.BackColor = Color.Yellow;
            }
            else
            {
                button659.BackColor = Color.Red;
            }
        }
        private void button660_Click_1(object sender, EventArgs e)
        {
            if (button660.BackColor == Color.Lime)
            {
                button660.BackColor = Color.Yellow;
            }
            else
            {
                button660.BackColor = Color.Red;
            }
        }
        private void button661_Click_1(object sender, EventArgs e)
        {
            if (button661.BackColor == Color.Lime)
            {
                button661.BackColor = Color.Yellow;
            }
            else
            {
                button661.BackColor = Color.Red;
            }
        }
        private void button662_Click_1(object sender, EventArgs e)
        {
            if (button662.BackColor == Color.Lime)
            {
                button662.BackColor = Color.Yellow;
            }
            else
            {
                button662.BackColor = Color.Red;
            }
        }
        private void button663_Click_1(object sender, EventArgs e)
        {
            if (button663.BackColor == Color.Lime)
            {
                button663.BackColor = Color.Yellow;
            }
            else
            {
                button663.BackColor = Color.Red;
            }
        }
        private void button664_Click_1(object sender, EventArgs e)
        {
            if (button664.BackColor == Color.Lime)
            {
                button664.BackColor = Color.Yellow;
            }
            else
            {
                button664.BackColor = Color.Red;
            }
        }
        private void button665_Click_1(object sender, EventArgs e)
        {
            if (button665.BackColor == Color.Lime)
            {
                button665.BackColor = Color.Yellow;
            }
            else
            {
                button665.BackColor = Color.Red;
            }
        }
        private void button666_Click_1(object sender, EventArgs e)
        {
            if (button666.BackColor == Color.Lime)
            {
                button666.BackColor = Color.Yellow;
            }
            else
            {
                button666.BackColor = Color.Red;
            }
        }
        private void button667_Click_1(object sender, EventArgs e)
        {
            if (button667.BackColor == Color.Lime)
            {
                button667.BackColor = Color.Yellow;
            }
            else
            {
                button667.BackColor = Color.Red;
            }
        }
        private void button668_Click_1(object sender, EventArgs e)
        {
            if (button668.BackColor == Color.Lime)
            {
                button668.BackColor = Color.Yellow;
            }
            else
            {
                button668.BackColor = Color.Red;
            }
        }
        private void button669_Click_1(object sender, EventArgs e)
        {
            if (button669.BackColor == Color.Lime)
            {
                button669.BackColor = Color.Yellow;
            }
            else
            {
                button669.BackColor = Color.Red;
            }
        }
        private void button670_Click_1(object sender, EventArgs e)
        {
            if (button670.BackColor == Color.Lime)
            {
                button670.BackColor = Color.Yellow;
            }
            else
            {
                button670.BackColor = Color.Red;
            }
        }
        private void button671_Click_1(object sender, EventArgs e)
        {
            if (button671.BackColor == Color.Lime)
            {
                button671.BackColor = Color.Yellow;
            }
            else
            {
                button671.BackColor = Color.Red;
            }
        }
        private void button672_Click_1(object sender, EventArgs e)
        {
            if (button672.BackColor == Color.Lime)
            {
                button672.BackColor = Color.Yellow;
            }
            else
            {
                button672.BackColor = Color.Red;
            }
        }
        private void button673_Click_1(object sender, EventArgs e)
        {
            if (button673.BackColor == Color.Lime)
            {
                button673.BackColor = Color.Yellow;
            }
            else
            {
                button673.BackColor = Color.Red;
            }
        }
        private void button674_Click_1(object sender, EventArgs e)
        {
            if (button674.BackColor == Color.Lime)
            {
                button674.BackColor = Color.Yellow;
            }
            else
            {
                button674.BackColor = Color.Red;
            }
        }
        private void button675_Click_1(object sender, EventArgs e)
        {
            if (button675.BackColor == Color.Lime)
            {
                button675.BackColor = Color.Yellow;
            }
            else
            {
                button675.BackColor = Color.Red;
            }
        }

        private void button747_Click_1(object sender, EventArgs e)
        {
            button616.BackColor = Color.Lime;
            button617.BackColor = Color.Lime;
            button618.BackColor = Color.Lime;
            button619.BackColor = Color.Lime;
            button620.BackColor = Color.Lime;
            button621.BackColor = Color.Lime;
            button622.BackColor = Color.Lime;
            button623.BackColor = Color.Lime;
            button624.BackColor = Color.Lime;
            button625.BackColor = Color.Lime;
            button626.BackColor = Color.Lime;
            button627.BackColor = Color.Lime;
            button628.BackColor = Color.Lime;
            button629.BackColor = Color.Lime;
            button630.BackColor = Color.Lime;
            button631.BackColor = Color.Lime;
            button632.BackColor = Color.Lime;
            button633.BackColor = Color.Lime;
            button634.BackColor = Color.Lime;
            button635.BackColor = Color.Lime;
            button636.BackColor = Color.Lime;
            button637.BackColor = Color.Lime;
            button638.BackColor = Color.Lime;
            button639.BackColor = Color.Lime;
            button640.BackColor = Color.Lime;
            button641.BackColor = Color.Lime;
            button642.BackColor = Color.Lime;
            button643.BackColor = Color.Lime;
            button644.BackColor = Color.Lime;
            button645.BackColor = Color.Lime;
            button646.BackColor = Color.Lime;
            button647.BackColor = Color.Lime;
            button648.BackColor = Color.Lime;
            button649.BackColor = Color.Lime;
            button650.BackColor = Color.Lime;
            button651.BackColor = Color.Lime;
            button652.BackColor = Color.Lime;
            button653.BackColor = Color.Lime;
            button654.BackColor = Color.Lime;
            button655.BackColor = Color.Lime;
            button656.BackColor = Color.Lime;
            button657.BackColor = Color.Lime;
            button658.BackColor = Color.Lime;
            button659.BackColor = Color.Lime;
            button660.BackColor = Color.Lime;
            button661.BackColor = Color.Lime;
            button662.BackColor = Color.Lime;
            button663.BackColor = Color.Lime;
            button664.BackColor = Color.Lime;
            button665.BackColor = Color.Lime;
            button666.BackColor = Color.Lime;
            button667.BackColor = Color.Lime;
            button668.BackColor = Color.Lime;
            button669.BackColor = Color.Lime;
            button670.BackColor = Color.Lime;
            button671.BackColor = Color.Lime;
            button672.BackColor = Color.Lime;
            button673.BackColor = Color.Lime;
            button674.BackColor = Color.Lime;
            button675.BackColor = Color.Lime;
        }

        private void button676_Click_1(object sender, EventArgs e)
        {
            if (button676.BackColor == Color.Lime)
            {
                button676.BackColor = Color.Yellow;
            }
            else
            {
                button676.BackColor = Color.Red;
            }
        }
        private void button677_Click_1(object sender, EventArgs e)
        {
            if (button677.BackColor == Color.Lime)
            {
                button677.BackColor = Color.Yellow;
            }
            else
            {
                button677.BackColor = Color.Red;
            }
        }
        private void button678_Click_1(object sender, EventArgs e)
        {
            if (button678.BackColor == Color.Lime)
            {
                button678.BackColor = Color.Yellow;
            }
            else
            {
                button678.BackColor = Color.Red;
            }
        }
        private void button679_Click_1(object sender, EventArgs e)
        {
            if (button679.BackColor == Color.Lime)
            {
                button679.BackColor = Color.Yellow;
            }
            else
            {
                button679.BackColor = Color.Red;
            }
        }
        private void button680_Click_1(object sender, EventArgs e)
        {
            if (button680.BackColor == Color.Lime)
            {
                button680.BackColor = Color.Yellow;
            }
            else
            {
                button680.BackColor = Color.Red;
            }
        }
        private void button681_Click_1(object sender, EventArgs e)
        {
            if (button681.BackColor == Color.Lime)
            {
                button681.BackColor = Color.Yellow;
            }
            else
            {
                button681.BackColor = Color.Red;
            }
        }
        private void button682_Click_1(object sender, EventArgs e)
        {
            if (button682.BackColor == Color.Lime)
            {
                button682.BackColor = Color.Yellow;
            }
            else
            {
                button682.BackColor = Color.Red;
            }
        }
        private void button683_Click_1(object sender, EventArgs e)
        {
            if (button683.BackColor == Color.Lime)
            {
                button683.BackColor = Color.Yellow;
            }
            else
            {
                button683.BackColor = Color.Red;
            }
        }
        private void button684_Click_1(object sender, EventArgs e)
        {
            if (button684.BackColor == Color.Lime)
            {
                button684.BackColor = Color.Yellow;
            }
            else
            {
                button684.BackColor = Color.Red;
            }
        }
        private void button685_Click_1(object sender, EventArgs e)
        {
            if (button685.BackColor == Color.Lime)
            {
                button685.BackColor = Color.Yellow;
            }
            else
            {
                button685.BackColor = Color.Red;
            }
        }
        private void button686_Click_1(object sender, EventArgs e)
        {
            if (button686.BackColor == Color.Lime)
            {
                button686.BackColor = Color.Yellow;
            }
            else
            {
                button686.BackColor = Color.Red;
            }
        }
        private void button687_Click_1(object sender, EventArgs e)
        {
            if (button687.BackColor == Color.Lime)
            {
                button687.BackColor = Color.Yellow;
            }
            else
            {
                button687.BackColor = Color.Red;
            }
        }
        private void button688_Click_1(object sender, EventArgs e)
        {
            if (button688.BackColor == Color.Lime)
            {
                button688.BackColor = Color.Yellow;
            }
            else
            {
                button688.BackColor = Color.Red;
            }
        }
        private void button689_Click_1(object sender, EventArgs e)
        {
            if (button689.BackColor == Color.Lime)
            {
                button689.BackColor = Color.Yellow;
            }
            else
            {
                button689.BackColor = Color.Red;
            }
        }
        private void button690_Click_1(object sender, EventArgs e)
        {
            if (button690.BackColor == Color.Lime)
            {
                button690.BackColor = Color.Yellow;
            }
            else
            {
                button690.BackColor = Color.Red;
            }
        }
        private void button691_Click_1(object sender, EventArgs e)
        {
            if (button691.BackColor == Color.Lime)
            {
                button691.BackColor = Color.Yellow;
            }
            else
            {
                button691.BackColor = Color.Red;
            }
        }
        private void button692_Click_1(object sender, EventArgs e)
        {
            if (button692.BackColor == Color.Lime)
            {
                button692.BackColor = Color.Yellow;
            }
            else
            {
                button692.BackColor = Color.Red;
            }
        }
        private void button693_Click_1(object sender, EventArgs e)
        {
            if (button693.BackColor == Color.Lime)
            {
                button693.BackColor = Color.Yellow;
            }
            else
            {
                button693.BackColor = Color.Red;
            }
        }
        private void button694_Click_1(object sender, EventArgs e)
        {
            if (button694.BackColor == Color.Lime)
            {
                button694.BackColor = Color.Yellow;
            }
            else
            {
                button694.BackColor = Color.Red;
            }
        }
        private void button695_Click_1(object sender, EventArgs e)
        {
            if (button695.BackColor == Color.Lime)
            {
                button695.BackColor = Color.Yellow;
            }
            else
            {
                button695.BackColor = Color.Red;
            }
        }
        private void button696_Click_1(object sender, EventArgs e)
        {
            if (button696.BackColor == Color.Lime)
            {
                button696.BackColor = Color.Yellow;
            }
            else
            {
                button696.BackColor = Color.Red;
            }
        }
        private void button697_Click_1(object sender, EventArgs e)
        {
            if (button697.BackColor == Color.Lime)
            {
                button697.BackColor = Color.Yellow;
            }
            else
            {
                button697.BackColor = Color.Red;
            }
        }
        private void button698_Click_1(object sender, EventArgs e)
        {
            if (button698.BackColor == Color.Lime)
            {
                button698.BackColor = Color.Yellow;
            }
            else
            {
                button698.BackColor = Color.Red;
            }
        }
        private void button699_Click_1(object sender, EventArgs e)
        {
            if (button699.BackColor == Color.Lime)
            {
                button699.BackColor = Color.Yellow;
            }
            else
            {
                button699.BackColor = Color.Red;
            }
        }
        private void button700_Click_1(object sender, EventArgs e)
        {
            if (button700.BackColor == Color.Lime)
            {
                button700.BackColor = Color.Yellow;
            }
            else
            {
                button700.BackColor = Color.Red;
            }
        }
        private void button701_Click_1(object sender, EventArgs e)
        {
            if (button701.BackColor == Color.Lime)
            {
                button701.BackColor = Color.Yellow;
            }
            else
            {
                button701.BackColor = Color.Red;
            }
        }
        private void button702_Click_1(object sender, EventArgs e)
        {
            if (button702.BackColor == Color.Lime)
            {
                button702.BackColor = Color.Yellow;
            }
            else
            {
                button702.BackColor = Color.Red;
            }
        }
        private void button703_Click_1(object sender, EventArgs e)
        {
            if (button703.BackColor == Color.Lime)
            {
                button703.BackColor = Color.Yellow;
            }
            else
            {
                button703.BackColor = Color.Red;
            }
        }
        private void button704_Click_1(object sender, EventArgs e)
        {
            if (button704.BackColor == Color.Lime)
            {
                button704.BackColor = Color.Yellow;
            }
            else
            {
                button704.BackColor = Color.Red;
            }
        }
        private void button705_Click_1(object sender, EventArgs e)
        {
            if (button705.BackColor == Color.Lime)
            {
                button705.BackColor = Color.Yellow;
            }
            else
            {
                button705.BackColor = Color.Red;
            }
        }
        private void button706_Click_1(object sender, EventArgs e)
        {
            if (button706.BackColor == Color.Lime)
            {
                button706.BackColor = Color.Yellow;
            }
            else
            {
                button706.BackColor = Color.Red;
            }
        }
        private void button707_Click_1(object sender, EventArgs e)
        {
            if (button707.BackColor == Color.Lime)
            {
                button707.BackColor = Color.Yellow;
            }
            else
            {
                button707.BackColor = Color.Red;
            }
        }
        private void button708_Click_1(object sender, EventArgs e)
        {
            if (button708.BackColor == Color.Lime)
            {
                button708.BackColor = Color.Yellow;
            }
            else
            {
                button708.BackColor = Color.Red;
            }
        }
        private void button709_Click_1(object sender, EventArgs e)
        {
            if (button709.BackColor == Color.Lime)
            {
                button709.BackColor = Color.Yellow;
            }
            else
            {
                button709.BackColor = Color.Red;
            }
        }
        private void button710_Click_1(object sender, EventArgs e)
        {
            if (button710.BackColor == Color.Lime)
            {
                button710.BackColor = Color.Yellow;
            }
            else
            {
                button710.BackColor = Color.Red;
            }
        }
        private void button711_Click_1(object sender, EventArgs e)
        {
            if (button711.BackColor == Color.Lime)
            {
                button711.BackColor = Color.Yellow;
            }
            else
            {
                button711.BackColor = Color.Red;
            }
        }
        private void button712_Click_1(object sender, EventArgs e)
        {
            if (button712.BackColor == Color.Lime)
            {
                button712.BackColor = Color.Yellow;
            }
            else
            {
                button712.BackColor = Color.Red;
            }
        }
        private void button713_Click_1(object sender, EventArgs e)
        {
            if (button713.BackColor == Color.Lime)
            {
                button713.BackColor = Color.Yellow;
            }
            else
            {
                button713.BackColor = Color.Red;
            }
        }
        private void button714_Click_1(object sender, EventArgs e)
        {
            if (button714.BackColor == Color.Lime)
            {
                button714.BackColor = Color.Yellow;
            }
            else
            {
                button714.BackColor = Color.Red;
            }
        }
        private void button715_Click_1(object sender, EventArgs e)
        {
            if (button715.BackColor == Color.Lime)
            {
                button715.BackColor = Color.Yellow;
            }
            else
            {
                button715.BackColor = Color.Red;
            }
        }
        private void button716_Click_1(object sender, EventArgs e)
        {
            if (button716.BackColor == Color.Lime)
            {
                button716.BackColor = Color.Yellow;
            }
            else
            {
                button716.BackColor = Color.Red;
            }
        }
        private void button717_Click_1(object sender, EventArgs e)
        {
            if (button717.BackColor == Color.Lime)
            {
                button717.BackColor = Color.Yellow;
            }
            else
            {
                button717.BackColor = Color.Red;
            }
        }
        private void button718_Click_1(object sender, EventArgs e)
        {
            if (button718.BackColor == Color.Lime)
            {
                button718.BackColor = Color.Yellow;
            }
            else
            {
                button718.BackColor = Color.Red;
            }
        }
        private void button719_Click_1(object sender, EventArgs e)
        {
            if (button719.BackColor == Color.Lime)
            {
                button719.BackColor = Color.Yellow;
            }
            else
            {
                button719.BackColor = Color.Red;
            }
        }
        private void button720_Click_1(object sender, EventArgs e)
        {
            if (button720.BackColor == Color.Lime)
            {
                button720.BackColor = Color.Yellow;
            }
            else
            {
                button720.BackColor = Color.Red;
            }
        }
        private void button721_Click_1(object sender, EventArgs e)
        {
            if (button721.BackColor == Color.Lime)
            {
                button721.BackColor = Color.Yellow;
            }
            else
            {
                button721.BackColor = Color.Red;
            }
        }
        private void button722_Click_1(object sender, EventArgs e)
        {
            if (button722.BackColor == Color.Lime)
            {
                button722.BackColor = Color.Yellow;
            }
            else
            {
                button722.BackColor = Color.Red;
            }
        }
        private void button723_Click_1(object sender, EventArgs e)
        {
            if (button723.BackColor == Color.Lime)
            {
                button723.BackColor = Color.Yellow;
            }
            else
            {
                button723.BackColor = Color.Red;
            }
        }
        private void button724_Click_1(object sender, EventArgs e)
        {
            if (button724.BackColor == Color.Lime)
            {
                button724.BackColor = Color.Yellow;
            }
            else
            {
                button724.BackColor = Color.Red;
            }
        }
        private void button725_Click_1(object sender, EventArgs e)
        {
            if (button725.BackColor == Color.Lime)
            {
                button725.BackColor = Color.Yellow;
            }
            else
            {
                button725.BackColor = Color.Red;
            }
        }
        private void button726_Click_1(object sender, EventArgs e)
        {
            if (button726.BackColor == Color.Lime)
            {
                button726.BackColor = Color.Yellow;
            }
            else
            {
                button726.BackColor = Color.Red;
            }
        }
        private void button727_Click_1(object sender, EventArgs e)
        {
            if (button727.BackColor == Color.Lime)
            {
                button727.BackColor = Color.Yellow;
            }
            else
            {
                button727.BackColor = Color.Red;
            }
        }
        private void button728_Click_1(object sender, EventArgs e)
        {
            if (button728.BackColor == Color.Lime)
            {
                button728.BackColor = Color.Yellow;
            }
            else
            {
                button728.BackColor = Color.Red;
            }
        }
        private void button729_Click_1(object sender, EventArgs e)
        {
            if (button729.BackColor == Color.Lime)
            {
                button729.BackColor = Color.Yellow;
            }
            else
            {
                button729.BackColor = Color.Red;
            }
        }
        private void button730_Click_1(object sender, EventArgs e)
        {
            if (button730.BackColor == Color.Lime)
            {
                button730.BackColor = Color.Yellow;
            }
            else
            {
                button730.BackColor = Color.Red;
            }
        }
        private void button731_Click_1(object sender, EventArgs e)
        {
            if (button731.BackColor == Color.Lime)
            {
                button731.BackColor = Color.Yellow;
            }
            else
            {
                button731.BackColor = Color.Red;
            }
        }
        private void button732_Click_1(object sender, EventArgs e)
        {
            if (button732.BackColor == Color.Lime)
            {
                button732.BackColor = Color.Yellow;
            }
            else
            {
                button732.BackColor = Color.Red;
            }
        }
        private void button733_Click_1(object sender, EventArgs e)
        {
            if (button733.BackColor == Color.Lime)
            {
                button733.BackColor = Color.Yellow;
            }
            else
            {
                button733.BackColor = Color.Red;
            }
        }
        private void button734_Click_1(object sender, EventArgs e)
        {
            if (button734.BackColor == Color.Lime)
            {
                button734.BackColor = Color.Yellow;
            }
            else
            {
                button734.BackColor = Color.Red;
            }
        }
        private void button735_Click_1(object sender, EventArgs e)
        {
            if (button735.BackColor == Color.Lime)
            {
                button735.BackColor = Color.Yellow;
            }
            else
            {
                button735.BackColor = Color.Red;
            }
        }
        private void button736_Click_1(object sender, EventArgs e)
        {
            if (button736.BackColor == Color.Lime)
            {
                button736.BackColor = Color.Yellow;
            }
            else
            {
                button736.BackColor = Color.Red;
            }
        }

        private void button748_Click_1(object sender, EventArgs e)
        {

            button676.BackColor = Color.Lime;
            button677.BackColor = Color.Lime;
            button678.BackColor = Color.Lime;
            button679.BackColor = Color.Lime;
            button680.BackColor = Color.Lime;
            button681.BackColor = Color.Lime;
            button682.BackColor = Color.Lime;
            button683.BackColor = Color.Lime;
            button684.BackColor = Color.Lime;
            button685.BackColor = Color.Lime;
            button686.BackColor = Color.Lime;
            button687.BackColor = Color.Lime;
            button688.BackColor = Color.Lime;
            button689.BackColor = Color.Lime;
            button690.BackColor = Color.Lime;
            button691.BackColor = Color.Lime;
            button692.BackColor = Color.Lime;
            button693.BackColor = Color.Lime;
            button694.BackColor = Color.Lime;
            button695.BackColor = Color.Lime;
            button696.BackColor = Color.Lime;
            button697.BackColor = Color.Lime;
            button698.BackColor = Color.Lime;
            button699.BackColor = Color.Lime;
            button700.BackColor = Color.Lime;
            button701.BackColor = Color.Lime;
            button702.BackColor = Color.Lime;
            button703.BackColor = Color.Lime;
            button704.BackColor = Color.Lime;
            button705.BackColor = Color.Lime;
            button706.BackColor = Color.Lime;
            button707.BackColor = Color.Lime;
            button708.BackColor = Color.Lime;
            button709.BackColor = Color.Lime;
            button710.BackColor = Color.Lime;
            button711.BackColor = Color.Lime;
            button712.BackColor = Color.Lime;
            button713.BackColor = Color.Lime;
            button714.BackColor = Color.Lime;
            button715.BackColor = Color.Lime;
            button716.BackColor = Color.Lime;
            button717.BackColor = Color.Lime;
            button718.BackColor = Color.Lime;
            button719.BackColor = Color.Lime;
            button720.BackColor = Color.Lime;
            button721.BackColor = Color.Lime;
            button722.BackColor = Color.Lime;
            button723.BackColor = Color.Lime;
            button724.BackColor = Color.Lime;
            button725.BackColor = Color.Lime;
            button726.BackColor = Color.Lime;
            button727.BackColor = Color.Lime;
            button728.BackColor = Color.Lime;
            button729.BackColor = Color.Lime;
            button730.BackColor = Color.Lime;
            button731.BackColor = Color.Lime;
            button732.BackColor = Color.Lime;
            button733.BackColor = Color.Lime;
            button734.BackColor = Color.Lime;
            button735.BackColor = Color.Lime;
            button736.BackColor = Color.Lime;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (StreamWriter sr = File.AppendText(@"C:\Users\GOMEZ\Documents\Visual Studio 2017\Projects\WindowsFormsApp2\WindowsFormsApp2\Persona.txt"))
            {
                sr.WriteLine("\nNombre: " + txtNombre.Text);
                sr.WriteLine("\nTeléfono: " + txtNumero.Text);
                sr.WriteLine("\nAsiento Reservado: " + txtAsiento.Text);
                sr.WriteLine("\nRuta: " + txtRuta.Text);
                sr.WriteLine("\nHora: " + txtHora.Text);


                sr.Close();

                Console.WriteLine(File.ReadAllText(@"C:\Users\GOMEZ\Documents\Visual Studio 2017\Projects\WindowsFormsApp2\WindowsFormsApp2\Persona.txt"));
            }


            //----------------------------------------------------------------

        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(@"C:\Users\GOMEZ\Documents\Visual Studio 2017\Projects\WindowsFormsApp2\WindowsFormsApp2\Persona.txt");
            string linea;

            try
            {
                linea = reader.ReadLine();
                while (linea != null)
                {
                    richTxt.AppendText(linea + "\n");
                    linea = reader.ReadLine();

                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtNumero.Text = "";
            txtAsiento.Text = "";
            txtRuta.Text = "";
            txtHora.Text = "";
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            richTxt.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
