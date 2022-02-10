using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Agenda_Proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void lbl_nomb_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            // el error no es la base de datos
            SqlConnection conexion = new SqlConnection("Server =DESKTOP-47O6KGN\\SQLEXPRESS  ;  database= HWitla; integrated security = true");
            conexion.Open();
            string ID_txt = textBox5_ID.Text;
            string txt_nombre = textBox1.Text;
            string txt_apellido = textBox2.Text;
            string dt_datetime = textBox3.Text;
            string txt_direccion = textBox4.Text;
              string cb_genero = comboBox2.Text;
            string cb_civil_state = comboBox1.Text;                        
            string txt_movil = textBox7.Text;  
            // error encontrado (','.) segun excepciones
            string txt_telefono = textBox8.Text;
            string txt_email = textBox9.Text;
            
            try { 
            string cadena = "insert into dato_agenda3 (ID, nombre, apellido,fecha_nacimiento , direccion, genero , estado_civil , movil, telefono,correo_electronica ) values(" + ID_txt + ",'" + txt_nombre + "' , '" + txt_apellido + "','"+ dt_datetime +" ' , '" + txt_direccion + "', '"+ cb_genero+ "','"+cb_civil_state+"' , " + txt_movil + "," + txt_telefono + ", '" + txt_email + "')";
            SqlCommand comando = new SqlCommand(cadena, conexion);      
            comando.CommandType = System.Data.CommandType.Text;
             comando.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Se ha Producido un error al momento de ingresar los registros " + ex);
            }
             
            MessageBox.Show("Los datos se guardaron exitosamente");
            textBox1.Text = "";
            textBox5_ID.Text = "";

             textBox2.Text = "";
             textBox3.Text = "";
             textBox4.Text = ""; 
            comboBox2.Text = "";
            comboBox1.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            conexion.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
