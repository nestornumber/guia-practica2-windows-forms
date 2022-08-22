
namespace Ejercicios
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.ejerciciodescripcion = new System.Windows.Forms.TextBox();
            this.ejerciciotitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.Button();
            this.productoPrecio = new System.Windows.Forms.NumericUpDown();
            this.productoCantidad = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.productoPagar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.productoPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // ejerciciodescripcion
            // 
            this.ejerciciodescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ejerciciodescripcion.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ejerciciodescripcion.Location = new System.Drawing.Point(132, 88);
            this.ejerciciodescripcion.Multiline = true;
            this.ejerciciodescripcion.Name = "ejerciciodescripcion";
            this.ejerciciodescripcion.ReadOnly = true;
            this.ejerciciodescripcion.Size = new System.Drawing.Size(478, 71);
            this.ejerciciodescripcion.TabIndex = 16;
            this.ejerciciodescripcion.Text = "Se debe desarrollar un programa que pida el ingreso del precio de un artículo y l" +
    "a  cantidad que lleva el cliente. Mostrar lo que debe pagar el comprador.";
            // 
            // ejerciciotitulo
            // 
            this.ejerciciotitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ejerciciotitulo.AutoSize = true;
            this.ejerciciotitulo.Font = new System.Drawing.Font("Google Sans Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ejerciciotitulo.Location = new System.Drawing.Point(125, 37);
            this.ejerciciotitulo.Name = "ejerciciotitulo";
            this.ejerciciotitulo.Size = new System.Drawing.Size(145, 39);
            this.ejerciciotitulo.TabIndex = 15;
            this.ejerciciotitulo.Text = "Ejercicio 2";
            this.ejerciciotitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Precio por cada unidad:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(151, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Cantidad:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "ARTÍCULOS";
            // 
            // resultado
            // 
            this.resultado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resultado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resultado.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.Location = new System.Drawing.Point(450, 345);
            this.resultado.Margin = new System.Windows.Forms.Padding(4);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(160, 35);
            this.resultado.TabIndex = 20;
            this.resultado.Text = "Mostrar resultado";
            this.resultado.UseVisualStyleBackColor = true;
            this.resultado.Click += new System.EventHandler(this.resultado_Click);
            // 
            // productoPrecio
            // 
            this.productoPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productoPrecio.DecimalPlaces = 2;
            this.productoPrecio.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productoPrecio.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.productoPrecio.Location = new System.Drawing.Point(450, 240);
            this.productoPrecio.Name = "productoPrecio";
            this.productoPrecio.Size = new System.Drawing.Size(160, 28);
            this.productoPrecio.TabIndex = 21;
            // 
            // productoCantidad
            // 
            this.productoCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productoCantidad.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productoCantidad.Location = new System.Drawing.Point(450, 289);
            this.productoCantidad.Name = "productoCantidad";
            this.productoCantidad.Size = new System.Drawing.Size(160, 28);
            this.productoCantidad.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(151, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Pagar:";
            // 
            // productoPagar
            // 
            this.productoPagar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productoPagar.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productoPagar.Location = new System.Drawing.Point(450, 414);
            this.productoPagar.Name = "productoPagar";
            this.productoPagar.Size = new System.Drawing.Size(160, 28);
            this.productoPagar.TabIndex = 24;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.productoPagar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.productoCantidad);
            this.Controls.Add(this.productoPrecio);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ejerciciodescripcion);
            this.Controls.Add(this.ejerciciotitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Ejercicio 2";
            ((System.ComponentModel.ISupportInitialize)(this.productoPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ejerciciodescripcion;
        private System.Windows.Forms.Label ejerciciotitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button resultado;
        private System.Windows.Forms.NumericUpDown productoPrecio;
        private System.Windows.Forms.NumericUpDown productoCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox productoPagar;
    }
}