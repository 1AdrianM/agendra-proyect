using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Agenda_Proyecto
{
    public partial class Form4 : Form
    {
       private SqlConnection conexion = new SqlConnection("Server =DESKTOP-47O6KGN\\SQLEXPRESS  ;  database= HWitla; integrated security = true");

        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                conexion.Open();
                string ID_textbo2 = textBox1.Text;
            try
            {
                string cadena = " select ID, nombre, apellido, fecha_nacimiento, direccion, genero, estado_civil, movil, telefono, correo_electronica  from dato_agenda3 where ID =" + ID_textbo2;

                SqlCommand comando = new SqlCommand(cadena, conexion);
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read())
                {
                    textBox5_ID2.AppendText(registro["ID"].ToString());

                    textBox5_nombre.AppendText(registro["nombre"].ToString());
                    textBox2_apellido.AppendText(registro["apellido"].ToString());
                    textBox3_datetime.AppendText(registro["fecha_nacimiento"].ToString());

                    textBox4_direc.AppendText(registro["direccion"].ToString());
                    textBox6_genre.AppendText(registro["genero"].ToString());

                    textBox10_civilE.AppendText(registro["estado_civil"].ToString());
                    textBox7_moviltel.AppendText(registro["movil"].ToString());
                    textBox8_tel.AppendText(registro["telefono"].ToString());
                    textBox9_emailCE.AppendText(registro["correo_electronica"].ToString()); ;


                }
                else
                    MessageBox.Show("No existe registro");
            } catch(Exception ex)
            {

                MessageBox.Show("se ha producido error al intentar modificar su registros"+ ex);
            }
                conexion.Close();

            



        }

        private void button2_Click(object sender, EventArgs e)
        {
                conexion.Open();
                string ID_textbo2 = textBox5_ID2.Text;
                string nombre = textBox5_nombre.Text;
                string apellido = textBox2_apellido.Text;
            string datetime = textBox3_datetime.Text;
            string direccion = textBox4_direc.Text;
            string genero = textBox6_genre.Text;
            string civil_E = textBox10_civilE.Text;
            string movil = textBox7_moviltel.Text;
            string telefono = textBox8_tel.Text;
            string email = textBox9_emailCE.Text;

               string cadena = "update dato_agenda3 set nombre ='" +nombre +"', apellido = '" + apellido + "',fecha_nacimiento='" + datetime + "',direccion = '" + direccion + "', genero='" + genero + "', estado_civil = '" + civil_E + "', movil=" + movil + ", telefono = " + telefono + ", correo_electronica ='" + email + "' where ID =" + ID_textbo2;
                SqlCommand comando = new SqlCommand(cadena, conexion);
                int cant;
                cant = comando.ExecuteNonQuery();
                if (cant == 1)
                {
                     textBox5_ID2.Text = "";

                    textBox5_nombre.Text = "";

                    textBox2_apellido.Text = "";

                    textBox3_datetime.Text = "";

                   textBox4_direc.Text = "";

                textBox6_genre.Text = "";

                textBox10_civilE.Text = "";

                textBox7_moviltel.Text = "";

                textBox8_tel.Text = "";

                textBox9_emailCE.Text = "";


                MessageBox.Show("Registro modificado");
                }
                else
                    MessageBox.Show("No existe registro");
                conexion.Close();
                button2.Enabled = false;
            }
        }
    }

