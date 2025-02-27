namespace FORMS
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Ingresar = new Button();
            textnombre = new TextBox();
            textApellido = new TextBox();
            textDNI = new TextBox();
            textNota = new TextBox();
            button1 = new Button();
            buttoncalificacion = new Button();
            dataGridView1 = new DataGridView();
            Nombre = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            comboBox5 = new ComboBox();
            listView1 = new ListView();
            listView2 = new ListView();
            listView3 = new ListView();
            listView4 = new ListView();
            maskedTextBox1 = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 128, 255);
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(172, 51);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(172, 97);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(176, 131);
            label3.Name = "label3";
            label3.Size = new Size(44, 25);
            label3.TabIndex = 2;
            label3.Text = "DNI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(176, 171);
            label4.Name = "label4";
            label4.Size = new Size(53, 25);
            label4.TabIndex = 3;
            label4.Text = "Nota";
            // 
            // Ingresar
            // 
            Ingresar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Ingresar.Location = new Point(508, 114);
            Ingresar.Name = "Ingresar";
            Ingresar.Size = new Size(96, 42);
            Ingresar.TabIndex = 4;
            Ingresar.Text = "Ingresar";
            Ingresar.UseVisualStyleBackColor = true;
            // 
            // textnombre
            // 
            textnombre.Location = new Point(281, 51);
            textnombre.Name = "textnombre";
            textnombre.Size = new Size(146, 23);
            textnombre.TabIndex = 5;
            textnombre.TextChanged += textnombre_TextChanged;
            // 
            // textApellido
            // 
            textApellido.Location = new Point(281, 97);
            textApellido.Name = "textApellido";
            textApellido.Size = new Size(146, 23);
            textApellido.TabIndex = 6;
            // 
            // textDNI
            // 
            textDNI.Location = new Point(281, 136);
            textDNI.Name = "textDNI";
            textDNI.Size = new Size(146, 23);
            textDNI.TabIndex = 7;
            // 
            // textNota
            // 
            textNota.Location = new Point(278, 174);
            textNota.Name = "textNota";
            textNota.Size = new Size(149, 23);
            textNota.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(23, 404);
            button1.Name = "button1";
            button1.Size = new Size(121, 34);
            button1.TabIndex = 9;
            button1.Text = "Alumnos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttoncalificacion
            // 
            buttoncalificacion.Location = new Point(520, 404);
            buttoncalificacion.Name = "buttoncalificacion";
            buttoncalificacion.Size = new Size(129, 34);
            buttoncalificacion.TabIndex = 11;
            buttoncalificacion.Text = "Calificacion ";
            buttoncalificacion.UseVisualStyleBackColor = true;
            buttoncalificacion.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 216);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(554, 150);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Nombre
            // 
            Nombre.FormattingEnabled = true;
            Nombre.Location = new Point(23, 216);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(92, 23);
            Nombre.TabIndex = 13;
            Nombre.Text = "Fecha-Hora";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(113, 216);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(129, 23);
            comboBox2.TabIndex = 14;
            comboBox2.Text = "Nombre ";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(239, 216);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(130, 23);
            comboBox3.TabIndex = 15;
            comboBox3.Text = "Apellido";
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(368, 216);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(128, 23);
            comboBox4.TabIndex = 16;
            comboBox4.Text = "DNI";
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(492, 216);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(85, 23);
            comboBox5.TabIndex = 17;
            comboBox5.Text = "Nota";
            // 
            // listView1
            // 
            listView1.Location = new Point(113, 236);
            listView1.Name = "listView1";
            listView1.Size = new Size(129, 31);
            listView1.TabIndex = 19;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            listView2.Location = new Point(241, 236);
            listView2.Name = "listView2";
            listView2.Size = new Size(128, 31);
            listView2.TabIndex = 20;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // listView3
            // 
            listView3.Location = new Point(368, 236);
            listView3.Name = "listView3";
            listView3.Size = new Size(128, 31);
            listView3.TabIndex = 21;
            listView3.UseCompatibleStateImageBehavior = false;
            // 
            // listView4
            // 
            listView4.Location = new Point(492, 236);
            listView4.Name = "listView4";
            listView4.Size = new Size(85, 31);
            listView4.TabIndex = 22;
            listView4.UseCompatibleStateImageBehavior = false;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(24, 245);
            maskedTextBox1.Mask = "00/00/0000 00:00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(91, 23);
            maskedTextBox1.TabIndex = 23;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 255);
            ClientSize = new Size(661, 450);
            Controls.Add(maskedTextBox1);
            Controls.Add(listView4);
            Controls.Add(listView3);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Controls.Add(comboBox5);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(Nombre);
            Controls.Add(dataGridView1);
            Controls.Add(buttoncalificacion);
            Controls.Add(button1);
            Controls.Add(textNota);
            Controls.Add(textDNI);
            Controls.Add(textApellido);
            Controls.Add(textnombre);
            Controls.Add(Ingresar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form1";
            TransparencyKey = Color.FromArgb(192, 0, 192);
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button Ingresar;
        private TextBox textnombre;
        private TextBox textApellido;
        private TextBox textDNI;
        private TextBox textNota;
        private Button button1;
        private Button buttoncalificacion;
        private DataGridView dataGridView1;
        private ComboBox Nombre;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private ListView listView1;
        private ListView listView2;
        private ListView listView3;
        private ListView listView4;
        private MaskedTextBox maskedTextBox1;
    }
}
