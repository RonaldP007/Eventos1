using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Negocio;

namespace Presentacion
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

        private void tabPage2_Click(object sender, EventArgs e)
        {
       
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            Metodos md = new Metodos();
            List<int> lista = new List<int>();
            lista = md.ComboBox();
            for (int i = 0; i < lista.Count; i++)
            {
                comboBox1.Items.Add(lista[i]);
            }
        }

        private void ComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Metodos md = new Metodos();
            List<object> lista = new List<object>();
            lista = md.Informacion(Convert.ToInt32(comboBox1.SelectedItem));
            Txt_Ced.Text = Convert.ToString(lista[0]);
            Txt_Nombre.Text = Convert.ToString(lista[1]);
            dateTime.Text = Convert.ToString(lista[2]);
            Txt_Res.Text = Convert.ToString(lista[3]);
        }
    }
}
