namespace ExercicioLista2WFA
{
    partial class Exercicio01
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
            this.btZeigen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInformeUmNumero
            // 
            this.labelInformeUmNumero.AutoSize = true;
            this.labelInformeUmNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformeUmNumero.Location = new System.Drawing.Point(12, 9);
            this.labelInformeUmNumero.Name = "labelInformeUmNumero";
            this.labelInformeUmNumero.Size = new System.Drawing.Size(148, 20);
            this.labelInformeUmNumero.TabIndex = 0;
            this.labelInformeUmNumero.Text = "Informe um número";
            // 
            // txtInformeUmNumero
            // 
            this.txtInformeUmNumero.Location = new System.Drawing.Point(166, 11);
            this.txtInformeUmNumero.Name = "txtInformeUmNumero";
            this.txtInformeUmNumero.Size = new System.Drawing.Size(57, 20);
            this.txtInformeUmNumero.TabIndex = 1;
            // 
            // btZeigen
            // 
            this.btZeigen.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btZeigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btZeigen.Location = new System.Drawing.Point(217, 106);
            this.btZeigen.Name = "btZeigen";
            this.btZeigen.Size = new System.Drawing.Size(89, 29);
            this.btZeigen.TabIndex = 2;
            this.btZeigen.Text = "Zeigen";
            this.btZeigen.UseVisualStyleBackColor = false;
            this.btZeigen.Click += new System.EventHandler(this.btZeigen_Click);
            // 
            // Exercicio01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(318, 147);
            this.Controls.Add(this.btZeigen);
            this.Controls.Add(this.txtInformeUmNumero);
            this.Controls.Add(this.labelInformeUmNumero);
            this.Name = "Exercicio01";
            this.Text = "Exercicio01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInformeUmNumero;
        private System.Windows.Forms.TextBox txtInformeUmNumero;
        private System.Windows.Forms.Button btZeigen;
    }
}