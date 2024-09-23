namespace WindowsFormsApp1
{
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblPrimeitaInformacao = new System.Windows.Forms.Label();
            this.txtValorInserido = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.HotPink;
            this.btnCalcular.Location = new System.Drawing.Point(127, 196);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(140, 51);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblPrimeitaInformacao
            // 
            this.lblPrimeitaInformacao.AutoSize = true;
            this.lblPrimeitaInformacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimeitaInformacao.ForeColor = System.Drawing.Color.HotPink;
            this.lblPrimeitaInformacao.Location = new System.Drawing.Point(12, 51);
            this.lblPrimeitaInformacao.Name = "lblPrimeitaInformacao";
            this.lblPrimeitaInformacao.Size = new System.Drawing.Size(378, 40);
            this.lblPrimeitaInformacao.TabIndex = 1;
            this.lblPrimeitaInformacao.Text = "Digite a baixo o  quanto você ama sua namorada:\r\n\r\n";
            // 
            // txtValorInserido
            // 
            this.txtValorInserido.ForeColor = System.Drawing.Color.HotPink;
            this.txtValorInserido.Location = new System.Drawing.Point(58, 126);
            this.txtValorInserido.MaxLength = 4;
            this.txtValorInserido.Name = "txtValorInserido";
            this.txtValorInserido.Size = new System.Drawing.Size(286, 22);
            this.txtValorInserido.TabIndex = 2;
            this.txtValorInserido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorInserido_KeyPress);
            // 
            // TelaPrincipal
            // 
            this.AcceptButton = this.btnCalcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(452, 345);
            this.Controls.Add(this.txtValorInserido);
            this.Controls.Add(this.lblPrimeitaInformacao);
            this.Controls.Add(this.btnCalcular);
            this.ForeColor = System.Drawing.Color.HotPink;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaPrincipal";
            this.Text = "Tela Principal";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblPrimeitaInformacao;
        private System.Windows.Forms.TextBox txtValorInserido;
    }
}

