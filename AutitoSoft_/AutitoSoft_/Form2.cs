using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutitoSoft_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        public void dibujar(PictureBox pb, int ox, int oy, int dx, int dy, float w, Color col)
        {
            //pb.Refresh();
            Graphics g = pb.CreateGraphics();
            g.DrawLine(
                new Pen(col, w),
                new Point(ox, oy),
                new Point(dx, dy));
        }

        int r;
        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
           r = 1;
        }

        byte keystate = 0;
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            

            if (keystate==0)
            {
                keystate = 1;
                if (e.KeyCode == Keys.Up)
                {
                    XivelyApi.SetData("Sensor1", "1");
                }
                else if (e.KeyCode == Keys.Down)
                {
                    XivelyApi.SetData("Sensor1", "2");
                }
                if (e.KeyCode == Keys.Right)
                {
                    XivelyApi.SetData("Sensor2", "1");
                }
                else if (e.KeyCode == Keys.Left)
                {
                    XivelyApi.SetData("Sensor2", "2");
                }
                keystate = 0;
            }
        }


        int SDistanFRENTE = 0;
        int SDistanDER = 0;
        int SDistanISQ = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            button1_Click(null, e);
        }


        List<Datastream> lista=new List<Datastream>();
        private void button1_Click(object sender, EventArgs e)
        {
            lista = XivelyApi.GetDatastreams("SDistanFRENTE", "SDistanISQ", "SDistanDER");
            pictureBox2.Refresh();
            dibujar(pictureBox2, 110 - Convert.ToInt16(lista[0].current_value), 0, 110 - Convert.ToInt16(lista[0].current_value), 100, 2f, Color.Black);
            pictureBox1.Refresh();
            dibujar(pictureBox1, 0, 110 - Convert.ToInt16(lista[1].current_value), 110, 110 - Convert.ToInt16(lista[1].current_value), 2f, Color.Black);
            pictureBox3.Refresh();
            dibujar(pictureBox3, Convert.ToInt16(lista[2].current_value), 0, Convert.ToInt16(lista[2].current_value), 110, 2f, Color.Black);
            //dibuj
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            Form2_KeyDown(null, e);
        }

        private void button1_Enter(object sender, EventArgs e)
        {
            this.Focus();
        }
    }
}
