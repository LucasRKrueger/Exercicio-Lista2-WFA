namespace ExercicioLista2WFA
{
    partial class Exercicio06
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
            this.labelInformeUmNumero = new System.Windows.Forms.Label();
            this.txtInformeUmNumero = new System.Windows.Forms.TextBox();
            this.btInformeUmNumero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInformeUmNumero
            // 
            this.labelInformeUmNumero.AutoSize = true;
            this.labelInformeUmNumero.Location = new System.Drawing.Point(12, 9);
            this.labelInformeUmNumero.Name = "labelInformeUmNumero";
            this.labelInformeUmNumero.Size = new System.Drawing.Size(97, 13);
            this.labelInformeUmNumero.TabIndex = 0;
            this.labelInformeUmNumero.Text = "Informe um número";
            // 
            // txtInformeUmNumero
            // 
            this.txtInformeUmNumero.Location = new System.Drawing.Point(115, 6);
            this.txtInformeUmNumero.Name = "txtInformeUmNumero";
            this.txtInformeUmNumero.Size = new System.Drawing.Size(100, 20);
            this.txtInformeUmNumero.TabIndex = 1;
            // 
            // btInformeUmNumero
            // 
            this.btInformeUmNumero.Location = new System.Drawing.Point(133, 93);
            this.btInformeUmNumero.Name = "btInformeUmNumero";
            this.btInformeUmNumero.Size = new System.Drawing.Size(82, 27);
            this.btInformeUmNumero.TabIndex = 2;
            this.btInformeUmNumero.Text = "Zeigen";
            this.btInformeUmNumero.UseVisualStyleBackColor = true;
            this.btInformeUmNumero.Click += new System.EventHandler(this.btInformeUmNumero_Click);
            // 
            // Exercicio06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(225, 135);
            this.Controls.Add(this.btInformeUmNumero);
            this.Controls.Add(this.txtInformeUmNumero);
            this.Controls.Add(this.labelInformeUmNumero);
            this.Name = "Exercicio06";
            this.Text = "Exercicio06";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInformeUmNumero;
        private System.Windows.Forms.TextBox txtInformeUmNumero;
        private System.Windows.Forms.Button btInformeUmNumero;
    }
}