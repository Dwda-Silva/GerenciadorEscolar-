namespace WindowsFormsApp1
{
    partial class FopapMenorQueCem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FopapMenorQueCem));
            this.btnOk = new System.Windows.Forms.Button();
            this.lblMensagemMenorQueZero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(181, 106);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(91, 33);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblMensagemMenorQueZero
            // 
            this.lblMensagemMenorQueZero.AutoSize = true;
            this.lblMensagemMenorQueZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMensagemMenorQueZero.Location = new System.Drawing.Point(60, 27);
            this.lblMensagemMenorQueZero.Name = "lblMensagemMenorQueZero";
            this.lblMensagemMenorQueZero.Size = new System.Drawing.Size(335, 20);
            this.lblMensagemMenorQueZero.TabIndex = 1;
            this.lblMensagemMenorQueZero.Text = "Só isso ? Por favor insira um valor decente.";
            // 
            // FopapMenorQueCem
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 173);
            this.Controls.Add(this.lblMensagemMenorQueZero);
            this.Controls.Add(this.btnOk);
            this.ForeColor = System.Drawing.Color.HotPink;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FopapMenorQueCem";
            this.Text = "Sem ideia para titulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblMensagemMenorQueZero;
    }
}