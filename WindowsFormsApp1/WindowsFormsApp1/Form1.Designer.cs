namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCen = new System.Windows.Forms.TextBox();
            this.txtFar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grados Centigrados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grados Farenheit";
            // 
            // txtCen
            // 
            this.txtCen.Location = new System.Drawing.Point(292, 109);
            this.txtCen.Name = "txtCen";
            this.txtCen.Size = new System.Drawing.Size(172, 20);
            this.txtCen.TabIndex = 2;
            this.txtCen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCen_KeyPress);
            // 
            // txtFar
            // 
            this.txtFar.Location = new System.Drawing.Point(292, 195);
            this.txtFar.Name = "txtFar";
            this.txtFar.Size = new System.Drawing.Size(172, 20);
            this.txtFar.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 65);
            this.button1.TabIndex = 4;
            this.button1.Text = "Convertir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 378);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtFar);
            this.Controls.Add(this.txtCen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCen;
        private System.Windows.Forms.TextBox txtFar;
        private System.Windows.Forms.Button button1;
    }
}

