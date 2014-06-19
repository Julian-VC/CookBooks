namespace Cookbook
{
    partial class agregar_Libro
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
            this.titulo = new System.Windows.Forms.TextBox();
            this.categoria = new System.Windows.Forms.TextBox();
            this.cant_hojas = new System.Windows.Forms.TextBox();
            this.editorial = new System.Windows.Forms.TextBox();
            this.precio = new System.Windows.Forms.TextBox();
            this.año = new System.Windows.Forms.TextBox();
            this.indice = new System.Windows.Forms.TextBox();
            this.stock = new System.Windows.Forms.TextBox();
            this.tapa = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.aceptar = new System.Windows.Forms.Button();
            this.volver = new System.Windows.Forms.Button();
            this.cargar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tapa)).BeginInit();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.Location = new System.Drawing.Point(335, 63);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(178, 20);
            this.titulo.TabIndex = 0;
            this.titulo.TextChanged += new System.EventHandler(this.titulo_TextChanged);
            // 
            // categoria
            // 
            this.categoria.Location = new System.Drawing.Point(335, 89);
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(178, 20);
            this.categoria.TabIndex = 1;
            // 
            // cant_hojas
            // 
            this.cant_hojas.Location = new System.Drawing.Point(335, 115);
            this.cant_hojas.Name = "cant_hojas";
            this.cant_hojas.Size = new System.Drawing.Size(178, 20);
            this.cant_hojas.TabIndex = 2;
            // 
            // editorial
            // 
            this.editorial.Location = new System.Drawing.Point(335, 204);
            this.editorial.Name = "editorial";
            this.editorial.Size = new System.Drawing.Size(178, 20);
            this.editorial.TabIndex = 3;
            // 
            // precio
            // 
            this.precio.Location = new System.Drawing.Point(335, 230);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(178, 20);
            this.precio.TabIndex = 4;
            // 
            // año
            // 
            this.año.Location = new System.Drawing.Point(335, 256);
            this.año.Name = "año";
            this.año.Size = new System.Drawing.Size(178, 20);
            this.año.TabIndex = 5;
            // 
            // indice
            // 
            this.indice.Location = new System.Drawing.Point(335, 282);
            this.indice.Name = "indice";
            this.indice.Size = new System.Drawing.Size(178, 20);
            this.indice.TabIndex = 6;
            // 
            // stock
            // 
            this.stock.Location = new System.Drawing.Point(335, 308);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(178, 20);
            this.stock.TabIndex = 7;
            // 
            // tapa
            // 
            this.tapa.Location = new System.Drawing.Point(335, 142);
            this.tapa.Name = "tapa";
            this.tapa.Size = new System.Drawing.Size(178, 50);
            this.tapa.TabIndex = 8;
            this.tapa.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Agregar Libro";
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(377, 353);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(75, 23);
            this.aceptar.TabIndex = 10;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // volver
            // 
            this.volver.Location = new System.Drawing.Point(181, 353);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(75, 23);
            this.volver.TabIndex = 11;
            this.volver.Text = "Volver";
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // cargar
            // 
            this.cargar.Location = new System.Drawing.Point(177, 142);
            this.cargar.Name = "cargar";
            this.cargar.Size = new System.Drawing.Size(75, 23);
            this.cargar.TabIndex = 12;
            this.cargar.Text = "agregar";
            this.cargar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "titulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "cantidad hojas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "editorial";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "precio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "año";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(189, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "indice";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(192, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "stock";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Autor:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(31, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // agregar_Libro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 390);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cargar);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tapa);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.indice);
            this.Controls.Add(this.año);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.editorial);
            this.Controls.Add(this.cant_hojas);
            this.Controls.Add(this.categoria);
            this.Controls.Add(this.titulo);
            this.Name = "agregar_Libro";
            this.Text = "agregar_Libro";
            this.Load += new System.EventHandler(this.agregar_Libro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tapa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titulo;
        private System.Windows.Forms.TextBox categoria;
        private System.Windows.Forms.TextBox cant_hojas;
        private System.Windows.Forms.TextBox editorial;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.TextBox año;
        private System.Windows.Forms.TextBox indice;
        private System.Windows.Forms.TextBox stock;
        private System.Windows.Forms.PictureBox tapa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Button volver;
        private System.Windows.Forms.Button cargar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}