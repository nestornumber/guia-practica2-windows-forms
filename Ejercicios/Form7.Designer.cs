
namespace Ejercicios
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.resultado_numero = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.Button();
            this.ejerciciodescripcion = new System.Windows.Forms.TextBox();
            this.ejerciciotitulo = new System.Windows.Forms.Label();
            this.sucesion = new System.Windows.Forms.PictureBox();
            this.numero = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sucesion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numero)).BeginInit();
            this.SuspendLayout();
            // 
            // resultado_numero
            // 
            this.resultado_numero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resultado_numero.AutoSize = true;
            this.resultado_numero.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado_numero.Location = new System.Drawing.Point(161, 398);
            this.resultado_numero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultado_numero.Name = "resultado_numero";
            this.resultado_numero.Size = new System.Drawing.Size(21, 20);
            this.resultado_numero.TabIndex = 43;
            this.resultado_numero.Text = "...";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(161, 365);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "Resultado:";
            // 
            // resultado
            // 
            this.resultado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resultado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resultado.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.Location = new System.Drawing.Point(483, 313);
            this.resultado.Margin = new System.Windows.Forms.Padding(4);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(160, 35);
            this.resultado.TabIndex = 41;
            this.resultado.Text = "Mostrar resultado";
            this.resultado.UseVisualStyleBackColor = true;
            this.resultado.Click += new System.EventHandler(this.resultado_Click);
            // 
            // ejerciciodescripcion
            // 
            this.ejerciciodescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ejerciciodescripcion.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ejerciciodescripcion.Location = new System.Drawing.Point(165, 73);
            this.ejerciciodescripcion.Multiline = true;
            this.ejerciciodescripcion.Name = "ejerciciodescripcion";
            this.ejerciciodescripcion.ReadOnly = true;
            this.ejerciciodescripcion.Size = new System.Drawing.Size(478, 71);
            this.ejerciciodescripcion.TabIndex = 38;
            this.ejerciciodescripcion.Text = "Calcule el valor de π a partir de la serie, el usuario ingresa el grado de precis" +
    "ión:\r\n";
            // 
            // ejerciciotitulo
            // 
            this.ejerciciotitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ejerciciotitulo.AutoSize = true;
            this.ejerciciotitulo.Font = new System.Drawing.Font("Google Sans Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ejerciciotitulo.Location = new System.Drawing.Point(158, 22);
            this.ejerciciotitulo.Name = "ejerciciotitulo";
            this.ejerciciotitulo.Size = new System.Drawing.Size(146, 39);
            this.ejerciciotitulo.TabIndex = 37;
            this.ejerciciotitulo.Text = "Ejercicio 6";
            this.ejerciciotitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sucesion
            // 
            this.sucesion.Image = ((System.Drawing.Image)(resources.GetObject("sucesion.Image")));
            this.sucesion.Location = new System.Drawing.Point(165, 160);
            this.sucesion.Name = "sucesion";
            this.sucesion.Size = new System.Drawing.Size(478, 86);
            this.sucesion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sucesion.TabIndex = 44;
            this.sucesion.TabStop = false;
            this.sucesion.Click += new System.EventHandler(this.sucesion_Click);
            // 
            // numero
            // 
            this.numero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numero.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero.Location = new System.Drawing.Point(483, 267);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(160, 28);
            this.numero.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Nivel de precisión:";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sucesion);
            this.Controls.Add(this.resultado_numero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.ejerciciodescripcion);
            this.Controls.Add(this.ejerciciotitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form7";
            this.Text = "Ejercicio 6";
            ((System.ComponentModel.ISupportInitialize)(this.sucesion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label resultado_numero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button resultado;
        private System.Windows.Forms.TextBox ejerciciodescripcion;
        private System.Windows.Forms.Label ejerciciotitulo;
        private System.Windows.Forms.PictureBox sucesion;
        private System.Windows.Forms.NumericUpDown numero;
        private System.Windows.Forms.Label label2;
    }
}