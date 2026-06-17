namespace App.Cafeteria
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            rdbCalientes = new RadioButton();
            txtNombre = new Label();
            txtMensaje = new TextBox();
            txtPrecio = new Label();
            textBox2 = new TextBox();
            txtTamano = new Label();
            textBox3 = new TextBox();
            lblVariable = new Label();
            txtExtra = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            lblRegistro = new Label();
            button1 = new Button();
            listBox1 = new ListBox();
            lbldescripcion = new Label();
            rdbEnergetica = new RadioButton();
            rdbFria = new RadioButton();
            lblconta = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 19);
            label1.Name = "label1";
            label1.Size = new Size(162, 20);
            label1.TabIndex = 0;
            label1.Text = "REGISTRO DE BEBIDAS";
            // 
            // rdbCalientes
            // 
            rdbCalientes.AutoSize = true;
            rdbCalientes.Location = new Point(31, 73);
            rdbCalientes.Name = "rdbCalientes";
            rdbCalientes.Size = new Size(135, 24);
            rdbCalientes.TabIndex = 1;
            rdbCalientes.TabStop = true;
            rdbCalientes.Text = "Bebida Caliente";
            rdbCalientes.UseVisualStyleBackColor = true;
            rdbCalientes.CheckedChanged += rbCalientes_CheckedChanged;
            // 
            // txtNombre
            // 
            txtNombre.AutoSize = true;
            txtNombre.Location = new Point(31, 122);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(64, 20);
            txtNombre.TabIndex = 2;
            txtNombre.Text = "Nombre";
            // 
            // txtMensaje
            // 
            txtMensaje.Location = new Point(31, 159);
            txtMensaje.Name = "txtMensaje";
            txtMensaje.Size = new Size(178, 27);
            txtMensaje.TabIndex = 3;
            txtMensaje.TextChanged += textBox1_TextChanged;
            // 
            // txtPrecio
            // 
            txtPrecio.AutoSize = true;
            txtPrecio.Location = new Point(31, 201);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(50, 20);
            txtPrecio.TabIndex = 4;
            txtPrecio.Text = "Precio";
            txtPrecio.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(31, 224);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(178, 27);
            textBox2.TabIndex = 5;
            // 
            // txtTamano
            // 
            txtTamano.AutoSize = true;
            txtTamano.Location = new Point(31, 264);
            txtTamano.Name = "txtTamano";
            txtTamano.Size = new Size(61, 20);
            txtTamano.TabIndex = 6;
            txtTamano.Text = "Tamaño";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(31, 287);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(178, 27);
            textBox3.TabIndex = 7;
            // 
            // lblVariable
            // 
            lblVariable.AutoSize = true;
            lblVariable.Location = new Point(31, 335);
            lblVariable.Name = "lblVariable";
            lblVariable.Size = new Size(93, 20);
            lblVariable.TabIndex = 8;
            lblVariable.Text = "Temperatura";
            // 
            // txtExtra
            // 
            txtExtra.Location = new Point(31, 368);
            txtExtra.Name = "txtExtra";
            txtExtra.Size = new Size(169, 27);
            txtExtra.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(589, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(309, 27);
            dateTimePicker1.TabIndex = 10;
            // 
            // lblRegistro
            // 
            lblRegistro.AutoSize = true;
            lblRegistro.Location = new Point(489, 131);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(147, 20);
            lblRegistro.TabIndex = 11;
            lblRegistro.Text = "Bebidas Registradas \r\n";
            // 
            // button1
            // 
            button1.Location = new Point(64, 445);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 12;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(361, 171);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(498, 184);
            listBox1.TabIndex = 13;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // lbldescripcion
            // 
            lbldescripcion.AutoSize = true;
            lbldescripcion.Location = new Point(396, 375);
            lbldescripcion.Name = "lbldescripcion";
            lbldescripcion.Size = new Size(87, 20);
            lbldescripcion.TabIndex = 14;
            lbldescripcion.Text = "Descripción";
            // 
            // rdbEnergetica
            // 
            rdbEnergetica.AutoSize = true;
            rdbEnergetica.Location = new Point(326, 73);
            rdbEnergetica.Name = "rdbEnergetica";
            rdbEnergetica.Size = new Size(151, 24);
            rdbEnergetica.TabIndex = 15;
            rdbEnergetica.TabStop = true;
            rdbEnergetica.Text = "Bebida Energetica";
            rdbEnergetica.UseVisualStyleBackColor = true;
            rdbEnergetica.CheckedChanged += rdbEnergetica_CheckedChanged;
            // 
            // rdbFria
            // 
            rdbFria.AutoSize = true;
            rdbFria.Location = new Point(187, 73);
            rdbFria.Name = "rdbFria";
            rdbFria.Size = new Size(105, 24);
            rdbFria.TabIndex = 16;
            rdbFria.TabStop = true;
            rdbFria.Text = "Bebida Fria";
            rdbFria.UseVisualStyleBackColor = true;
            rdbFria.CheckedChanged += rdbFria_CheckedChanged;
            // 
            // lblconta
            // 
            lblconta.AutoSize = true;
            lblconta.Location = new Point(461, 430);
            lblconta.Name = "lblconta";
            lblconta.Size = new Size(180, 20);
            lblconta.TabIndex = 17;
            lblconta.Text = "0 bebidas sean registrado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(910, 518);
            Controls.Add(lblconta);
            Controls.Add(rdbFria);
            Controls.Add(rdbEnergetica);
            Controls.Add(lbldescripcion);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(lblRegistro);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtExtra);
            Controls.Add(lblVariable);
            Controls.Add(textBox3);
            Controls.Add(txtTamano);
            Controls.Add(textBox2);
            Controls.Add(txtPrecio);
            Controls.Add(txtMensaje);
            Controls.Add(txtNombre);
            Controls.Add(rdbCalientes);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            TransparencyKey = Color.FromArgb(255, 192, 192);
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton rdbCalientes;
        private Label txtNombre;
        private TextBox txtMensaje;
        private Label txtPrecio;
        private TextBox textBox2;
        private Label txtTamano;
        private TextBox textBox3;
        private Label lblVariable;
        private TextBox txtExtra;
        private DateTimePicker dateTimePicker1;
        private Label lblRegistro;
        private Button button1;
        private ListBox listBox1;
        private Label lbldescripcion;
        private RadioButton rdbEnergetica;
        private RadioButton rdbFria;
        private Label lblconta;
    }
}
