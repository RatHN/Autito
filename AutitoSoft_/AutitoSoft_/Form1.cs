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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void updateDatastreamsButton_Click(object sender, EventArgs e)
        {
            picStreams.BackColor = Color.Red;
            List<string> lista;
            lista = XivelyApi.GetDatastreams();
            DatastreamListBox.Items.Clear();
            foreach (var item in lista)
            {
                DatastreamListBox.Items.Add(item);
            }
            picStreams.BackColor = Color.Green;
        }

        private void setValue_Click(object sender, EventArgs e)
        {
            picSet.BackColor = Color.Red;
            XivelyApi.SetData(DatastreamListBox.SelectedItem.ToString(), textBoxSet.Text);
            picSet.BackColor = Color.Green;

        }

        private void getValue_Click(object sender, EventArgs e)
        {
            
        }

        private void DatastreamListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            picSet.BackColor = Color.Red;
            textBoxSet.Text = XivelyApi.GetData(DatastreamListBox.SelectedItem.ToString());
            picSet.BackColor = Color.Green;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            XivelyApi.SetData("Sensor1", "Azul");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            XivelyApi.SetData("Sensor1", "Verde");
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            XivelyApi.SetData("Sensor2", "Azul");
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            XivelyApi.SetData("Sensor2", "Azul");
        }

        private void estadoButton_Click(object sender, EventArgs e)
        {
            if (estadoButton.Text == "Comenzar")
            {
                XivelyApi.SetData("EstadoCmd", "ON");
                estadoButton.Text = "Parar";
            }
            else
            {
                XivelyApi.SetData("EstadoCmd", "OFF");
                estadoButton.Text = "Comenzar";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 forma=new Form2();
            forma.ShowDialog();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    pictureBox1.BackColor = Color.Red;
        //    textBox1.Text = XivelyApi.GetData(DatastreamListBox.SelectedItem.ToString());
        //    pictureBox1.BackColor = Color.Green;
        //}
    }
}
