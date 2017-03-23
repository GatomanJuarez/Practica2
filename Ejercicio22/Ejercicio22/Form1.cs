using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nombre, am, ap;
            nombre = textnom.Text;
            am = textam.Text;

            ap = textap.Text;
            String nombresao = nombre + " " + am + " " + ap;
            MessageBox.Show("Hola" + " " + nombre + " " + am + " " + ap + " Que tal tu dia!",
                "HOA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String nom = textnom.Text;
            int result;
            int edad = int.Parse(textBox1.Text);
            result = 2016 - edad;
            label5.Text = nom+" "+"naciste el año de:"+" "+result;

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String nom = textnom.Text;
            int result;
            int AÑO = int.Parse(textBox2.Text);
           
            result = 2016 - AÑO;
            label6.Text = nom + " " + "tu edad es:" + " " + result+" "+"años";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int edad = int.Parse(textBox1.Text);
            if (edad >= 18)
            {
                label8.Text = "Eres Mayor de edad";
            }
            else
            {
                label8.Text = "Eres Menor de edad";
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }