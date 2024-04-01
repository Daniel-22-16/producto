namespace producto
{
    partial class Form2
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
            label7 = new Label();
            label8 = new Label();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            textBox9 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            groupBox2 = new GroupBox();
            textBox8 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox2 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            comboBox2 = new ComboBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(378, 417);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(114, 373);
            label8.Name = "label8";
            label8.Size = new Size(76, 15);
            label8.TabIndex = 7;
            label8.Text = "Tipo de pago";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox9);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label10);
            groupBox1.Location = new Point(22, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(339, 268);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(41, 152);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(127, 23);
            comboBox1.TabIndex = 25;
            comboBox1.Text = "Seleccionar Empresa";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(41, 79);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(66, 23);
            textBox9.TabIndex = 14;
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(41, 131);
            label9.Name = "label9";
            label9.Size = new Size(58, 15);
            label9.TabIndex = 13;
            label9.Text = "EMPRESA";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(41, 44);
            label10.Name = "label10";
            label10.Size = new Size(18, 15);
            label10.TabIndex = 12;
            label10.Text = "ID";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox8);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(388, 38);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(571, 404);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(112, 300);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(224, 32);
            textBox8.TabIndex = 24;
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(45, 151);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(281, 34);
            textBox6.TabIndex = 23;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(117, 40);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(192, 23);
            textBox5.TabIndex = 22;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(49, 244);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 35);
            textBox2.TabIndex = 20;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 312);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 19;
            label6.Text = "Direccion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 214);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 18;
            label5.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 116);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 17;
            label4.Text = "CORREO( Usuario)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 43);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 16;
            label3.Text = "USUARIO";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(196, 370);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(118, 23);
            comboBox2.TabIndex = 25;
            comboBox2.Text = "Seleccionar Pago";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(363, 494);
            button1.Name = "button1";
            button1.Size = new Size(116, 41);
            button1.TabIndex = 26;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 569);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label7;
        private Label label8;
        private GroupBox groupBox1;
        private TextBox textBox9;
        private Label label9;
        private Label label10;
        private GroupBox groupBox2;
        private TextBox textBox8;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button1;
    }
}