
namespace Ejercicios
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.ejerciciodescripcion = new System.Windows.Forms.TextBox();
            this.ejerciciotitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numero = new System.Windows.Forms.NumericUpDown();
            this.resultado = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.resultado_parimpar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numero)).BeginInit();
            this.SuspendLayout();
            // 
            // ejerciciodescripcion
            // 
            this.ejerciciodescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ejerciciodescripcion.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ejerciciodescripcion.Location = new System.Drawing.Point(108, 90);
            this.ejerciciodescripcion.Multiline = true;
            this.ejerciciodescripcion.Name = "ejerciciodescripcion";
            this.ejerciciodescripcion.ReadOnly = true;
            this.ejerciciodescripcion.Size = new System.Drawing.Size(478, 71);
            this.ejerciciodescripcion.TabIndex = 18;
            this.ejerciciodescripcion.Text = "Desarrollar un programa que solicite al usuario un número entero y mostrar en pan" +
    "talla un mensaje que indique al usuario si se trata de un número par o de un núm" +
    "ero impar.";
            // 
            // ejerciciotitulo
            // 
            this.ejerciciotitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ejerciciotitulo.AutoSize = true;
            this.ejerciciotitulo.Font = new System.Drawing.Font("Google Sans Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ejerciciotitulo.Location = new System.Drawing.Point(101, 39);
            this.ejerciciotitulo.Name = "ejerciciotitulo";
            this.ejerciciotitulo.Size = new System.Drawing.Size(145, 39);
            this.ejerciciotitulo.TabIndex = 17;
            this.ejerciciotitulo.Text = "Ejercicio 3";
            this.ejerciciotitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Número entero:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // numero
            // 
            this.numero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numero.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero.Location = new System.Drawing.Point(426, 213);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(160, 28);
            this.numero.TabIndex = 22;
            // 
            // resultado
            // 
            this.resultado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resultado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resultado.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.Location = new System.Drawing.Point(426, 261);
            this.resultado.Margin = new System.Windows.Forms.Padding(4);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(160, 35);
            this.resultado.TabIndex = 23;
            this.resultado.Text = "Mostrar resultado";
            this.resultado.UseVisualStyleBackColor = true;
            this.resultado.Click += new System.EventHandler(this.resultado_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(104, 328);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Resultado:";
            // 
            // resultado_parimpar
            // 
            this.resultado_parimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resultado_parimpar.AutoSize = true;
            this.resultado_parimpar.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado_parimpar.Location = new System.Drawing.Point(565, 328);
            this.resultado_parimpar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultado_parimpar.Name = "resultado_parimpar";
            this.resultado_parimpar.Size = new System.Drawing.Size(21, 20);
            this.resultado_parimpar.TabIndex = 25;
            this.resultado_parimpar.Text = "...";
            this.resultado_parimpar.Click += new System.EventHandler(this.resultado_parimpar_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultado_parimpar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ejerciciodescripcion);
            this.Controls.Add(this.ejerciciotitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Ejercicio 3";
            ((System.ComponentModel.ISupportInitialize)(this.numero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ejerciciodescripcion;
        private System.Windows.Forms.Label ejerciciotitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numero;
        private System.Windows.Forms.Button resultado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label resultado_parimpar;
    }
}