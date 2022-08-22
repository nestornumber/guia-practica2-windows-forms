
namespace Ejercicios
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.resultado_mayormenor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.Button();
            this.numero1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ejerciciodescripcion = new System.Windows.Forms.TextBox();
            this.ejerciciotitulo = new System.Windows.Forms.Label();
            this.numero3 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numero2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numero1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numero3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numero2)).BeginInit();
            this.SuspendLayout();
            // 
            // resultado_mayormenor
            // 
            this.resultado_mayormenor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resultado_mayormenor.AutoSize = true;
            this.resultado_mayormenor.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado_mayormenor.Location = new System.Drawing.Point(160, 379);
            this.resultado_mayormenor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultado_mayormenor.Name = "resultado_mayormenor";
            this.resultado_mayormenor.Size = new System.Drawing.Size(21, 20);
            this.resultado_mayormenor.TabIndex = 32;
            this.resultado_mayormenor.Text = "...";
            this.resultado_mayormenor.Click += new System.EventHandler(this.resultado_mayormenor_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(160, 349);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Resultado:";
            // 
            // resultado
            // 
            this.resultado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resultado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resultado.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.Location = new System.Drawing.Point(482, 293);
            this.resultado.Margin = new System.Windows.Forms.Padding(4);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(160, 35);
            this.resultado.TabIndex = 30;
            this.resultado.Text = "Mostrar resultado";
            this.resultado.UseVisualStyleBackColor = true;
            this.resultado.Click += new System.EventHandler(this.resultado_Click);
            // 
            // numero1
            // 
            this.numero1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numero1.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero1.Location = new System.Drawing.Point(482, 179);
            this.numero1.Name = "numero1";
            this.numero1.Size = new System.Drawing.Size(160, 28);
            this.numero1.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Primer número:";
            // 
            // ejerciciodescripcion
            // 
            this.ejerciciodescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ejerciciodescripcion.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ejerciciodescripcion.Location = new System.Drawing.Point(164, 84);
            this.ejerciciodescripcion.Multiline = true;
            this.ejerciciodescripcion.Name = "ejerciciodescripcion";
            this.ejerciciodescripcion.ReadOnly = true;
            this.ejerciciodescripcion.Size = new System.Drawing.Size(478, 71);
            this.ejerciciodescripcion.TabIndex = 27;
            this.ejerciciodescripcion.Text = "Desarrollar un programa que indique cual de tres números ingresados por el usuari" +
    "o es el mayor y cuál es el menor.";
            this.ejerciciodescripcion.TextChanged += new System.EventHandler(this.ejerciciodescripcion_TextChanged);
            // 
            // ejerciciotitulo
            // 
            this.ejerciciotitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ejerciciotitulo.AutoSize = true;
            this.ejerciciotitulo.Font = new System.Drawing.Font("Google Sans Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ejerciciotitulo.Location = new System.Drawing.Point(157, 33);
            this.ejerciciotitulo.Name = "ejerciciotitulo";
            this.ejerciciotitulo.Size = new System.Drawing.Size(146, 39);
            this.ejerciciotitulo.TabIndex = 26;
            this.ejerciciotitulo.Text = "Ejercicio 4";
            this.ejerciciotitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numero3
            // 
            this.numero3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numero3.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero3.Location = new System.Drawing.Point(482, 247);
            this.numero3.Name = "numero3";
            this.numero3.Size = new System.Drawing.Size(160, 28);
            this.numero3.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Tercer número:";
            // 
            // numero2
            // 
            this.numero2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numero2.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero2.Location = new System.Drawing.Point(482, 213);
            this.numero2.Name = "numero2";
            this.numero2.Size = new System.Drawing.Size(160, 28);
            this.numero2.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(160, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Segundo número:";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numero2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numero3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultado_mayormenor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.numero1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ejerciciodescripcion);
            this.Controls.Add(this.ejerciciotitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.Text = "Ejercicio 4";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numero1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numero3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numero2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resultado_mayormenor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button resultado;
        private System.Windows.Forms.NumericUpDown numero1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ejerciciodescripcion;
        private System.Windows.Forms.Label ejerciciotitulo;
        private System.Windows.Forms.NumericUpDown numero3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numero2;
        private System.Windows.Forms.Label label3;
    }
}