namespace Cookbook
{
    partial class modificar_libros
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
            this.volver = new System.Windows.Forms.Button();
            this.modificar = new System.Windows.Forms.Button();
            this.buscador = new System.Windows.Forms.TextBox();
            this.titulo = new System.Windows.Forms.TextBox();
            this.categoria = new System.Windows.Forms.TextBox();
            this.cant_hojas = new System.Windows.Forms.TextBox();
            this.editorial = new System.Windows.Forms.TextBox();
            this.precio = new System.Windows.Forms.TextBox();
            this.año = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.indice = new System.Windows.Forms.TextBox();
            this.stock = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modificar Libros";
            // 
            // volver
            // 
            this.volver.Location = new System.Drawing.Point(109, 326);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(75, 23);
            this.volver.TabIndex = 1;
            this.volver.Text = "volver";
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // modificar
            // 
            this.modificar.Location = new System.Drawing.Point(322, 326);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(75, 23);
            this.modificar.TabIndex = 2;
            this.modificar.Text = "modificar";
            this.modificar.UseVisualStyleBackColor = true;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // buscador
            // 
            this.buscador.Location = new System.Drawing.Point(84, 69);
            this.buscador.Name = "buscador";
            this.buscador.Size = new System.Drawing.Size(100, 20);
            this.buscador.TabIndex = 3;
            this.buscador.TextChanged += new System.EventHandler(this.buscador_TextChanged);
            // 
            // titulo
            // 
            this.titulo.Location = new System.Drawing.Point(385, 117);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(152, 20);
            this.titulo.TabIndex = 4;
            // 
            // categoria
            // 
            this.categoria.Location = new System.Drawing.Point(385, 143);
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(152, 20);
            this.categoria.TabIndex = 5;
            // 
            // cant_hojas
            // 
            this.cant_hojas.Location = new System.Drawing.Point(385, 169);
            this.cant_hojas.Name = "cant_hojas";
            this.cant_hojas.Size = new System.Drawing.Size(152, 20);
            this.cant_hojas.TabIndex = 6;
            // 
            // editorial
            // 
            this.editorial.Location = new System.Drawing.Point(385, 195);
            this.editorial.Name = "editorial";
            this.editorial.Size = new System.Drawing.Size(152, 20);
            this.editorial.TabIndex = 7;
            // 
            // precio
            // 
            this.precio.Location = new System.Drawing.Point(385, 221);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(152, 20);
            this.precio.TabIndex = 8;
            // 
            // año
            // 
            this.año.Location = new System.Drawing.Point(385, 247);
            this.año.Name = "año";
            this.año.Size = new System.Drawing.Size(152, 20);
            this.año.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(84, 117);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // indice
            // 
            this.indice.Location = new System.Drawing.Point(385, 273);
            this.indice.Name = "indice";
            this.indice.Size = new System.Drawing.Size(152, 20);
            this.indice.TabIndex = 12;
            // 
            // stock
            // 
            this.stock.Location = new System.Drawing.Point(385, 299);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(152, 20);
            this.stock.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "titulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "cantidad de hojas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "precio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "año";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(286, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "indice";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(289, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "stock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "editorial";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Nombre";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(84, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Libro:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(84, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Autor:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(87, 167);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 27;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // modificar_libros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 371);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.indice);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.año);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.editorial);
            this.Controls.Add(this.cant_hojas);
            this.Controls.Add(this.categoria);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.buscador);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.label1);
            this.Name = "modificar_libros";
            this.Text = "modificar_libros";
            this.Load += new System.EventHandler(this.modificar_libros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button volver;
        private System.Windows.Forms.Button modificar;
        private System.Windows.Forms.TextBox buscador;
        private System.Windows.Forms.TextBox titulo;
        private System.Windows.Forms.TextBox categoria;
        private System.Windows.Forms.TextBox cant_hojas;
        private System.Windows.Forms.TextBox editorial;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.TextBox año;
       // private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox indice;
        private System.Windows.Forms.TextBox stock;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}