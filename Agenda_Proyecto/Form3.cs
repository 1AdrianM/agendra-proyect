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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Server =DESKTOP-47O6KGN\\SQLEXPRESS  ;  database= HWitla; integrated security = true");
            conexion.Open();
            string ID_Txtbuscar = textBox1.Text;
            try {     
            string cadena = " select  nombre, apellido, direccion, movil,estado_civil from dato_agenda3 where ID ="+ID_Txtbuscar;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();
           
            if (registro.Read())
                     
            {

                textBox2_name.AppendText(registro["nombre"].ToString());
                textBox3_sur.AppendText(registro["apellido"].ToString());
                textBox4_dir.AppendText(registro["direccion"].ToString());
                textBox_ecv.AppendText(registro["estado_civil"].ToString());
                numero_txtboc.AppendText(registro["movil"].ToString());









            }
            else
                MessageBox.Show("No se han encontrado registros");
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Ha ocurrido un error al momento de buscar los registros   " + ex);
            }
            MessageBox.Show("Registros encontrados exitosamente");

            conexion.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Server =DESKTOP-47O6KGN\\SQLEXPRESS  ;  database= HWitla; integrated security = true");
            conexion.Open();
            string ID_TXTBOX = textBox1.Text;
            string cadena = " delete from dato_agenda3 where ID= " + ID_TXTBOX;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cnt;
            cnt = comando.ExecuteNonQuery();
            if (cnt == 1)
            {
                 foreach(Control ctrl in this.Controls)
                {
                     if (ctrl is TextBox)
                    {

                        ctrl.Text = "";
                    }




                }
                MessageBox.Show("Registros eliminados exitosamente");



            }
            else
                MessageBox.Show("los registros que intenta eliminar no existen");

            conexion.Close();
            button1.Enabled = false;
        }
    }
}
