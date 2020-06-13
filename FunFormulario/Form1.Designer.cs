namespace FunFormulario
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.btnAceptar2 = new System.Windows.Forms.Button();
            this.bt = new System.Windows.Forms.Button();
            this.txtR1 = new System.Windows.Forms.TextBox();
            this.txtR2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Por favor ingre un numero del 1 al 12   :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Por favor ingrese un numero entero      :";
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(209, 113);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(43, 20);
            this.txtNumero2.TabIndex = 12;
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(209, 20);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(43, 20);
            this.txtNumero1.TabIndex = 11;
            this.txtNumero1.TextChanged += new System.EventHandler(this.txtNum_TextChanged);
            // 
            // btnAceptar2
            // 
            this.btnAceptar2.Location = new System.Drawing.Point(12, 151);
            this.btnAceptar2.Name = "btnAceptar2";
            this.btnAceptar2.Size = new System.Drawing.Size(112, 27);
            this.btnAceptar2.TabIndex = 10;
            this.btnAceptar2.Text = "Aceptar";
            this.btnAceptar2.UseVisualStyleBackColor = true;
            this.btnAceptar2.Click += new System.EventHandler(this.btnAceptar2_Click);
            // 
            // bt
            // 
            this.bt.Location = new System.Drawing.Point(15, 59);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(109, 29);
            this.bt.TabIndex = 9;
            this.bt.Text = "Aceptar";
            this.bt.UseVisualStyleBackColor = true;
            this.bt.Click += new System.EventHandler(this.bt_Click);
            // 
            // txtR1
            // 
            this.txtR1.Location = new System.Drawing.Point(165, 64);
            this.txtR1.Name = "txtR1";
            this.txtR1.Size = new System.Drawing.Size(87, 20);
            this.txtR1.TabIndex = 17;
            // 
            // txtR2
            // 
            this.txtR2.Location = new System.Drawing.Point(165, 155);
            this.txtR2.Name = "txtR2";
            this.txtR2.Size = new System.Drawing.Size(87, 20);
            this.txtR2.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 185);
            this.Controls.Add(this.txtR2);
            this.Controls.Add(this.txtR1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.btnAceptar2);
            this.Controls.Add(this.bt);
            this.Name = "Form1";
            this.Text = "FUNCIONES DESDE UNA CLASE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.Button btnAceptar2;
        private System.Windows.Forms.Button bt;
        private System.Windows.Forms.TextBox txtR1;
        private System.Windows.Forms.TextBox txtR2;
    }
}

