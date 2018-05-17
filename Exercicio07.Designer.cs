namespace ExercicioLista2WFA
{
    partial class Exercicio07
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btZeigen = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.labelResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInformeUmNumero
            // 
            this.labelInformeUmNumero.AutoSize = true;
            this.labelInformeUmNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformeUmNumero.Location = new System.Drawing.Point(12, 9);
            this.labelInformeUmNumero.Name = "labelInformeUmNumero";
            this.labelInformeUmNumero.Size = new System.Drawing.Size(121, 16);
            this.labelInformeUmNumero.TabIndex = 0;
            this.labelInformeUmNumero.Text = "Informe um número";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(139, 8);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(78, 20);
            this.txtNumero.TabIndex = 1;
            // 
            // btZeigen
            // 
            this.btZeigen.Location = new System.Drawing.Point(139, 209);
            this.btZeigen.Name = "btZeigen";
            this.btZeigen.Size = new System.Drawing.Size(81, 23);
            this.btZeigen.TabIndex = 3;
            this.btZeigen.Text = "Zeigen";
            this.btZeigen.UseVisualStyleBackColor = true;
            this.btZeigen.Click += new System.EventHandler(this.btZeigen_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtResultado.Location = new System.Drawing.Point(18, 74);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(202, 113);
            this.txtResultado.TabIndex = 4;
            this.txtResultado.TextChanged += new System.EventHandler(this.txtResultado_TextChanged);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(15, 58);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(55, 13);
            this.labelResultado.TabIndex = 5;
            this.labelResultado.Text = "Resultado";
            this.labelResultado.Click += new System.EventHandler(this.labelResultado_Click);
            // 
            // Exercicio07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(232, 244);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btZeigen);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.labelInformeUmNumero);
            this.Name = "Exercicio07";
            this.Text = "Exercicio07";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInformeUmNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btZeigen;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label labelResultado;
    }
}