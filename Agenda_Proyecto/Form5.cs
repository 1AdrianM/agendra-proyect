using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Agenda_Proyecto
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Server =DESKTOP-47O6KGN\\SQLEXPRESS  ;  database= HWitla; integrated security = true");
            conexion.Open();
            string ID_TXTBOX = textBox1.Text;
            string cadena = " delete from dato_agenda3 where ID= " +ID_TXTBOX;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cnt;
            cnt = comando.ExecuteNonQuery();
            if (cnt ==1)
            {

                textBox1.Text = "";
                MessageBox.Show("Registros eliminados exitosamente");


            }
            else
            MessageBox.Show("los registros que intenta eliminar no existen");
            conexion.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
