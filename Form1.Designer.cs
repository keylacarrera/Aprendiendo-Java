namespace ER
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
            this.lb1 = new System.Windows.Forms.Label();
            this.btnJugar = new System.Windows.Forms.Button();
            this.btnResul = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Sweet Creamy", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(58, 24);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(157, 25);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "!Bienvenido a";
            // 
            // btnJugar
            // 
            this.btnJugar.Font = new System.Drawing.Font("Sweet Creamy", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugar.Location = new System.Drawing.Point(76, 106);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(116, 47);
            this.btnJugar.TabIndex = 1;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // btnResul
            // 
            this.btnResul.Font = new System.Drawing.Font("Sweet Creamy", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResul.Location = new System.Drawing.Point(76, 169);
            this.btnResul.Name = "btnResul";
            this.btnResul.Size = new System.Drawing.Size(116, 47);
            this.btnResul.TabIndex = 2;
            this.btnResul.Text = "Resultados";
            this.btnResul.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(185, 251);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 31);
            this.button4.TabIndex = 4;
            this.button4.Text = "Salir";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sweet Creamy", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Aprendamos Java¡";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 307);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnResul);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.lb1);
            this.Name = "Form1";
            this.Text = "Aprendamos JAVA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Button btnResul;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
    }
}

