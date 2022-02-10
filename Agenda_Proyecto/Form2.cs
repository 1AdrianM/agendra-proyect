using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_Proyecto
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Server =DESKTOP-47O6KGN\\SQLEXPRESS  ;  database= HWitla; integrated security = true");
            conexion.Open();
             string cadena = "select ID, nombre, apellido,fecha_nacimiento , direccion, genero , estado_civil , movil, telefono,correo_electronica from HWitla.dbo.dato_agenda3";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registros = comando.ExecuteReader();
            while(registros.Read())
            {
                textBox1.AppendText(registros["ID"].ToString());
                textBox1.AppendText("/ ");

                textBox1.AppendText(registros["nombre"].ToString());
                textBox1.AppendText("/ ");

                textBox1.AppendText(registros["apellido"].ToString());
                textBox1.AppendText("/ ");

                textBox1.AppendText(registros["fecha_nacimiento"].ToString());
                textBox1.AppendText(" /");

                textBox1.AppendText(registros["direccion"].ToString());
                textBox1.AppendText("/ ");

                textBox1.AppendText(registros["genero"].ToString());
                textBox1.AppendText("/ ");

                textBox1.AppendText(registros["estado_civil"].ToString());
                textBox1.AppendText("/ ");

                textBox1.AppendText(registros["movil"].ToString());
                textBox1.AppendText(" /");

                textBox1.AppendText(registros["telefono"].ToString());
                textBox1.AppendText("/ ");

                textBox1.AppendText(registros["correo_electronica"].ToString());
                textBox1.AppendText(Environment.NewLine);












            }
            conexion.Close();
        }

    }
}
