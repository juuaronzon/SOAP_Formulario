namespace FORMSOAP
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
            this.components = new System.ComponentModel.Container();
            this.txt_1 = new System.Windows.Forms.TextBox();
            this.txt_2 = new System.Windows.Forms.TextBox();
            this.timer_1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txt_1
            // 
            this.txt_1.Location = new System.Drawing.Point(104, 95);
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(168, 20);
            this.txt_1.TabIndex = 0;
            // 
            // txt_2
            // 
            this.txt_2.Location = new System.Drawing.Point(104, 121);
            this.txt_2.Name = "txt_2";
            this.txt_2.Size = new System.Drawing.Size(168, 20);
            this.txt_2.TabIndex = 1;
            // 
            // timer_1
            // 
            this.timer_1.Enabled = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 263);
            this.Controls.Add(this.txt_2);
            this.Controls.Add(this.txt_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_1;
        private System.Windows.Forms.TextBox txt_2;
        private System.Windows.Forms.Timer timer_1;
    }
}

