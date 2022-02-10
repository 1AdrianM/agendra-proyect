
namespace Agenda_Proyecto
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buton_buscar = new System.Windows.Forms.Button();
            this.label3_nombre = new System.Windows.Forms.Label();
            this.label4_apellido = new System.Windows.Forms.Label();
            this.label5_direccion = new System.Windows.Forms.Label();
            this.label6_telefono = new System.Windows.Forms.Label();
            this.label7_estadocv = new System.Windows.Forms.Label();
            this.textBox2_name = new System.Windows.Forms.TextBox();
            this.textBox3_sur = new System.Windows.Forms.TextBox();
            this.textBox4_dir = new System.Windows.Forms.TextBox();
            this.numero_txtboc = new System.Windows.Forms.TextBox();
            this.textBox_ecv = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar registros";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresar Datos a Consultar\r\n";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(312, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 20);
            this.textBox1.TabIndex = 2;
            // 
            // buton_buscar
            // 
            this.buton_buscar.Location = new System.Drawing.Point(556, 83);
            this.buton_buscar.Name = "buton_buscar";
            this.buton_buscar.Size = new System.Drawing.Size(75, 20);
            this.buton_buscar.TabIndex = 3;
            this.buton_buscar.Text = "Buscar";
            this.buton_buscar.UseVisualStyleBackColor = true;
            this.buton_buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3_nombre
            // 
            this.label3_nombre.AutoSize = true;
            this.label3_nombre.Location = new System.Drawing.Point(151, 209);
            this.label3_nombre.Name = "label3_nombre";
            this.label3_nombre.Size = new System.Drawing.Size(44, 13);
            this.label3_nombre.TabIndex = 4;
            this.label3_nombre.Text = "Nombre";
            this.label3_nombre.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4_apellido
            // 
            this.label4_apellido.AutoSize = true;
            this.label4_apellido.Location = new System.Drawing.Point(151, 261);
            this.label4_apellido.Name = "label4_apellido";
            this.label4_apellido.Size = new System.Drawing.Size(44, 13);
            this.label4_apellido.TabIndex = 5;
            this.label4_apellido.Text = "Apellido";
            this.label4_apellido.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5_direccion
            // 
            this.label5_direccion.AutoSize = true;
            this.label5_direccion.Location = new System.Drawing.Point(151, 312);
            this.label5_direccion.Name = "label5_direccion";
            this.label5_direccion.Size = new System.Drawing.Size(52, 13);
            this.label5_direccion.TabIndex = 6;
            this.label5_direccion.Text = "Direccion";
            this.label5_direccion.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6_telefono
            // 
            this.label6_telefono.AutoSize = true;
            this.label6_telefono.Location = new System.Drawing.Point(151, 354);
            this.label6_telefono.Name = "label6_telefono";
            this.label6_telefono.Size = new System.Drawing.Size(77, 13);
            this.label6_telefono.TabIndex = 7;
            this.label6_telefono.Text = "Telefono Movil";
            // 
            // label7_estadocv
            // 
            this.label7_estadocv.AutoSize = true;
            this.label7_estadocv.Location = new System.Drawing.Point(151, 401);
            this.label7_estadocv.Name = "label7_estadocv";
            this.label7_estadocv.Size = new System.Drawing.Size(61, 13);
            this.label7_estadocv.TabIndex = 8;
            this.label7_estadocv.Text = "Estado civil";
            this.label7_estadocv.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBox2_name
            // 
            this.textBox2_name.Location = new System.Drawing.Point(262, 209);
            this.textBox2_name.Name = "textBox2_name";
            this.textBox2_name.Size = new System.Drawing.Size(253, 20);
            this.textBox2_name.TabIndex = 9;
            // 
            // textBox3_sur
            // 
            this.textBox3_sur.Location = new System.Drawing.Point(262, 261);
            this.textBox3_sur.Name = "textBox3_sur";
            this.textBox3_sur.Size = new System.Drawing.Size(253, 20);
            this.textBox3_sur.TabIndex = 10;
            // 
            // textBox4_dir
            // 
            this.textBox4_dir.Location = new System.Drawing.Point(262, 312);
            this.textBox4_dir.Name = "textBox4_dir";
            this.textBox4_dir.Size = new System.Drawing.Size(253, 20);
            this.textBox4_dir.TabIndex = 11;
            // 
            // numero_txtboc
            // 
            this.numero_txtboc.Location = new System.Drawing.Point(262, 354);
            this.numero_txtboc.Name = "numero_txtboc";
            this.numero_txtboc.Size = new System.Drawing.Size(253, 20);
            this.numero_txtboc.TabIndex = 12;
            // 
            // textBox_ecv
            // 
            this.textBox_ecv.Location = new System.Drawing.Point(262, 401);
            this.textBox_ecv.Name = "textBox_ecv";
            this.textBox_ecv.Size = new System.Drawing.Size(253, 20);
            this.textBox_ecv.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 497);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_ecv);
            this.Controls.Add(this.numero_txtboc);
            this.Controls.Add(this.textBox4_dir);
            this.Controls.Add(this.textBox3_sur);
            this.Controls.Add(this.textBox2_name);
            this.Controls.Add(this.label7_estadocv);
            this.Controls.Add(this.label6_telefono);
            this.Controls.Add(this.label5_direccion);
            this.Controls.Add(this.label4_apellido);
            this.Controls.Add(this.label3_nombre);
            this.Controls.Add(this.buton_buscar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buton_buscar;
        private System.Windows.Forms.Label label3_nombre;
        private System.Windows.Forms.Label label4_apellido;
        private System.Windows.Forms.Label label5_direccion;
        private System.Windows.Forms.Label label6_telefono;
        private System.Windows.Forms.Label label7_estadocv;
        private System.Windows.Forms.TextBox textBox2_name;
        private System.Windows.Forms.TextBox textBox3_sur;
        private System.Windows.Forms.TextBox textBox4_dir;
        private System.Windows.Forms.TextBox numero_txtboc;
        private System.Windows.Forms.TextBox textBox_ecv;
        private System.Windows.Forms.Button button1;
    }
}