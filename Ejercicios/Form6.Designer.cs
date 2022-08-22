
namespace Ejercicios
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.label5 = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.Button();
            this.ejerciciodescripcion = new System.Windows.Forms.TextBox();
            this.ejerciciotitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.resultado_numerosperfectos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(161, 308);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Resultado:";
            // 
            // resultado
            // 
            this.resultado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resultado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resultado.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.Location = new System.Drawing.Point(483, 252);
            this.resultado.Margin = new System.Windows.Forms.Padding(4);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(160, 35);
            this.resultado.TabIndex = 35;
            this.resultado.Text = "Mostrar resultado";
            this.resultado.UseVisualStyleBackColor = true;
            this.resultado.Click += new System.EventHandler(this.resultado_Click);
            // 
            // ejerciciodescripcion
            // 
            this.ejerciciodescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ejerciciodescripcion.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ejerciciodescripcion.Location = new System.Drawing.Point(165, 78);
            this.ejerciciodescripcion.Multiline = true;
            this.ejerciciodescripcion.Name = "ejerciciodescripcion";
            this.ejerciciodescripcion.ReadOnly = true;
            this.ejerciciodescripcion.Size = new System.Drawing.Size(478, 152);
            this.ejerciciodescripcion.TabIndex = 34;
            this.ejerciciodescripcion.Text = resources.GetString("ejerciciodescripcion.Text");
            // 
            // ejerciciotitulo
            // 
            this.ejerciciotitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ejerciciotitulo.AutoSize = true;
            this.ejerciciotitulo.Font = new System.Drawing.Font("Google Sans Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ejerciciotitulo.Location = new System.Drawing.Point(158, 27);
            this.ejerciciotitulo.Name = "ejerciciotitulo";
            this.ejerciciotitulo.Size = new System.Drawing.Size(146, 39);
            this.ejerciciotitulo.TabIndex = 33;
            this.ejerciciotitulo.Text = "Ejercicio 5";
            this.ejerciciotitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 18);
            this.label1.TabIndex = 38;
            this.label1.Text = "DEL 1 AL 1,000";
            // 
            // resultado_numerosperfectos
            // 
            this.resultado_numerosperfectos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resultado_numerosperfectos.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado_numerosperfectos.Location = new System.Drawing.Point(165, 348);
            this.resultado_numerosperfectos.Multiline = true;
            this.resultado_numerosperfectos.Name = "resultado_numerosperfectos";
            this.resultado_numerosperfectos.ReadOnly = true;
            this.resultado_numerosperfectos.Size = new System.Drawing.Size(478, 68);
            this.resultado_numerosperfectos.TabIndex = 39;
            this.resultado_numerosperfectos.Text = "...";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultado_numerosperfectos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.ejerciciodescripcion);
            this.Controls.Add(this.ejerciciotitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6";
            this.Text = "Ejercicio 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button resultado;
        private System.Windows.Forms.TextBox ejerciciodescripcion;
        private System.Windows.Forms.Label ejerciciotitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox resultado_numerosperfectos;
    }
}