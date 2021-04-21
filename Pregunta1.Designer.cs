namespace ER
{
    partial class Pregunta1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.txtCond1 = new System.Windows.Forms.TextBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVar1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pregunta 1";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Sweet Creamy", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(45, 43);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(289, 25);
            this.lb1.TabIndex = 3;
            this.lb1.Text = "Declaración de variables";
            this.lb1.Click += new System.EventHandler(this.lb1_Click);
            // 
            // txtCond1
            // 
            this.txtCond1.Location = new System.Drawing.Point(49, 221);
            this.txtCond1.Name = "txtCond1";
            this.txtCond1.Size = new System.Drawing.Size(285, 20);
            this.txtCond1.TabIndex = 5;
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(297, 294);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(80, 26);
            this.btnValidar.TabIndex = 6;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "escribe declaración de variables";
            // 
            // txtVar1
            // 
            this.txtVar1.Location = new System.Drawing.Point(49, 106);
            this.txtVar1.Name = "txtVar1";
            this.txtVar1.Size = new System.Drawing.Size(285, 20);
            this.txtVar1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "escribe declaración de condición";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sweet Creamy", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(117, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Condición If";
            // 
            // Pregunta1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 332);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.txtCond1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pregunta1";
            this.Text = "Pregunta1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TextBox txtCond1;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}