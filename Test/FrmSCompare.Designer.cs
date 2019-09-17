namespace Test
{
    partial class FrmSCompare
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblStr1 = new System.Windows.Forms.Label();
            this.txtStr1 = new System.Windows.Forms.TextBox();
            this.lblStr2 = new System.Windows.Forms.Label();
            this.txtStr2 = new System.Windows.Forms.TextBox();
            this.btnCompare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStr1
            // 
            this.lblStr1.AutoSize = true;
            this.lblStr1.Location = new System.Drawing.Point(47, 9);
            this.lblStr1.Name = "lblStr1";
            this.lblStr1.Size = new System.Drawing.Size(94, 13);
            this.lblStr1.TabIndex = 0;
            this.lblStr1.Text = "Ingrese un string1:";
            // 
            // txtStr1
            // 
            this.txtStr1.Location = new System.Drawing.Point(50, 26);
            this.txtStr1.MaxLength = 20;
            this.txtStr1.Name = "txtStr1";
            this.txtStr1.Size = new System.Drawing.Size(100, 20);
            this.txtStr1.TabIndex = 1;
            // 
            // lblStr2
            // 
            this.lblStr2.AutoSize = true;
            this.lblStr2.Location = new System.Drawing.Point(47, 67);
            this.lblStr2.Name = "lblStr2";
            this.lblStr2.Size = new System.Drawing.Size(94, 13);
            this.lblStr2.TabIndex = 2;
            this.lblStr2.Text = "Ingrese un string2:";
            // 
            // txtStr2
            // 
            this.txtStr2.Location = new System.Drawing.Point(50, 83);
            this.txtStr2.MaxLength = 20;
            this.txtStr2.Name = "txtStr2";
            this.txtStr2.Size = new System.Drawing.Size(100, 20);
            this.txtStr2.TabIndex = 3;
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(66, 124);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(75, 23);
            this.btnCompare.TabIndex = 4;
            this.btnCompare.Text = "Comparar";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // FrmSCompare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 159);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.txtStr2);
            this.Controls.Add(this.lblStr2);
            this.Controls.Add(this.txtStr1);
            this.Controls.Add(this.lblStr1);
            this.Name = "FrmSCompare";
            this.Text = "SCompare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStr1;
        private System.Windows.Forms.TextBox txtStr1;
        private System.Windows.Forms.Label lblStr2;
        private System.Windows.Forms.TextBox txtStr2;
        private System.Windows.Forms.Button btnCompare;
    }
}
