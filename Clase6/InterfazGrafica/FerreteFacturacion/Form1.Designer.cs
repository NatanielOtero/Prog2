namespace FerreteFacturacion
{
    partial class Form1
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
            this.lvlNumero1 = new System.Windows.Forms.Label();
            this.lvlNumero2 = new System.Windows.Forms.Label();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.btnSumar = new System.Windows.Forms.Button();
            this.lvlNumero3 = new System.Windows.Forms.Label();
            this.txtBox3 = new System.Windows.Forms.TextBox();
            this.btnPromedio = new System.Windows.Forms.Button();
            this.btnIva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvlNumero1
            // 
            this.lvlNumero1.AutoSize = true;
            this.lvlNumero1.ForeColor = System.Drawing.SystemColors.Control;
            this.lvlNumero1.Location = new System.Drawing.Point(192, 9);
            this.lvlNumero1.Name = "lvlNumero1";
            this.lvlNumero1.Size = new System.Drawing.Size(53, 13);
            this.lvlNumero1.TabIndex = 0;
            this.lvlNumero1.Text = "Numero 1";
            this.lvlNumero1.Click += new System.EventHandler(this.lvlNumero1_Click);
            // 
            // lvlNumero2
            // 
            this.lvlNumero2.AutoSize = true;
            this.lvlNumero2.ForeColor = System.Drawing.SystemColors.Control;
            this.lvlNumero2.Location = new System.Drawing.Point(192, 48);
            this.lvlNumero2.Name = "lvlNumero2";
            this.lvlNumero2.Size = new System.Drawing.Size(53, 13);
            this.lvlNumero2.TabIndex = 1;
            this.lvlNumero2.Text = "Numero 2";
            this.lvlNumero2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(172, 25);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(100, 20);
            this.txtBox1.TabIndex = 3;
            this.txtBox1.TextChanged += new System.EventHandler(this.txtBox1_TextChanged);
            // 
            // txtBox2
            // 
            this.txtBox2.Location = new System.Drawing.Point(172, 64);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(100, 20);
            this.txtBox2.TabIndex = 4;
            this.txtBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnSumar
            // 
            this.btnSumar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSumar.Location = new System.Drawing.Point(96, 148);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(267, 36);
            this.btnSumar.TabIndex = 5;
            this.btnSumar.Text = "Mostrar Suma";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lvlNumero3
            // 
            this.lvlNumero3.AutoSize = true;
            this.lvlNumero3.ForeColor = System.Drawing.SystemColors.Control;
            this.lvlNumero3.Location = new System.Drawing.Point(192, 96);
            this.lvlNumero3.Name = "lvlNumero3";
            this.lvlNumero3.Size = new System.Drawing.Size(53, 13);
            this.lvlNumero3.TabIndex = 6;
            this.lvlNumero3.Text = "Numero 3";
            this.lvlNumero3.Click += new System.EventHandler(this.lvlNumero3_Click);
            // 
            // txtBox3
            // 
            this.txtBox3.Location = new System.Drawing.Point(172, 112);
            this.txtBox3.Name = "txtBox3";
            this.txtBox3.Size = new System.Drawing.Size(100, 20);
            this.txtBox3.TabIndex = 7;
            this.txtBox3.TextChanged += new System.EventHandler(this.txtBox3_TextChanged);
            // 
            // btnPromedio
            // 
            this.btnPromedio.ForeColor = System.Drawing.Color.DarkRed;
            this.btnPromedio.Location = new System.Drawing.Point(96, 190);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(267, 38);
            this.btnPromedio.TabIndex = 8;
            this.btnPromedio.Text = "Mostrar Promedio";
            this.btnPromedio.UseVisualStyleBackColor = true;
            this.btnPromedio.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIva
            // 
            this.btnIva.ForeColor = System.Drawing.Color.DarkRed;
            this.btnIva.Location = new System.Drawing.Point(96, 245);
            this.btnIva.Name = "btnIva";
            this.btnIva.Size = new System.Drawing.Size(267, 46);
            this.btnIva.TabIndex = 9;
            this.btnIva.Text = "Mostrar Precio final";
            this.btnIva.UseVisualStyleBackColor = true;
            this.btnIva.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(425, 303);
            this.Controls.Add(this.btnIva);
            this.Controls.Add(this.btnPromedio);
            this.Controls.Add(this.txtBox3);
            this.Controls.Add(this.lvlNumero3);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.lvlNumero2);
            this.Controls.Add(this.lvlNumero1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lvlNumero1;
        private System.Windows.Forms.Label lvlNumero2;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Label lvlNumero3;
        private System.Windows.Forms.TextBox txtBox3;
        private System.Windows.Forms.Button btnPromedio;
        private System.Windows.Forms.Button btnIva;
    }
}

