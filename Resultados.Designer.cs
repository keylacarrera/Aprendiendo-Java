namespace ER
{
    partial class Resultados
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCorrec = new System.Windows.Forms.Label();
            this.lbPunt = new System.Windows.Forms.Label();
            this.lbIncorrec = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Correctos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Puntaje:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Incorrectos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(164, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "RESULTADOS";
            // 
            // lbCorrec
            // 
            this.lbCorrec.AutoSize = true;
            this.lbCorrec.Location = new System.Drawing.Point(121, 326);
            this.lbCorrec.Name = "lbCorrec";
            this.lbCorrec.Size = new System.Drawing.Size(24, 13);
            this.lbCorrec.TabIndex = 15;
            this.lbCorrec.Text = "0/0";
            // 
            // lbPunt
            // 
            this.lbPunt.AutoSize = true;
            this.lbPunt.Location = new System.Drawing.Point(379, 327);
            this.lbPunt.Name = "lbPunt";
            this.lbPunt.Size = new System.Drawing.Size(24, 13);
            this.lbPunt.TabIndex = 16;
            this.lbPunt.Text = "0/0";
            // 
            // lbIncorrec
            // 
            this.lbIncorrec.AutoSize = true;
            this.lbIncorrec.Location = new System.Drawing.Point(265, 326);
            this.lbIncorrec.Name = "lbIncorrec";
            this.lbIncorrec.Size = new System.Drawing.Size(24, 13);
            this.lbIncorrec.TabIndex = 17;
            this.lbIncorrec.Text = "0/0";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(186, 365);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 18;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Font = new System.Drawing.Font("Century Schoolbook", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(32, 60);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(378, 246);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // Resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 400);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.lbIncorrec);
            this.Controls.Add(this.lbPunt);
            this.Controls.Add(this.lbCorrec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "Resultados";
            this.Text = "Resultados";
            this.Load += new System.EventHandler(this.Preguntas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCorrec;
        private System.Windows.Forms.Label lbPunt;
        private System.Windows.Forms.Label lbIncorrec;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.ListView listView1;
    }
}