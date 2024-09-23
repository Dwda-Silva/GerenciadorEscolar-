namespace WindowsFormsApp1
{
    partial class QuinentosMil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuinentosMil));
            this.lblMensagemMenorQueZero2 = new System.Windows.Forms.Label();
            this.lblMensagemMenorQueZero = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMensagemMenorQueZero2
            // 
            this.lblMensagemMenorQueZero2.AutoSize = true;
            this.lblMensagemMenorQueZero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMensagemMenorQueZero2.Location = new System.Drawing.Point(101, 44);
            this.lblMensagemMenorQueZero2.Name = "lblMensagemMenorQueZero2";
            this.lblMensagemMenorQueZero2.Size = new System.Drawing.Size(174, 20);
            this.lblMensagemMenorQueZero2.TabIndex = 8;
            this.lblMensagemMenorQueZero2.Text = "talves você chegue lá.";
            // 
            // lblMensagemMenorQueZero
            // 
            this.lblMensagemMenorQueZero.AutoSize = true;
            this.lblMensagemMenorQueZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMensagemMenorQueZero.Location = new System.Drawing.Point(101, 24);
            this.lblMensagemMenorQueZero.Name = "lblMensagemMenorQueZero";
            this.lblMensagemMenorQueZero.Size = new System.Drawing.Size(252, 20);
            this.lblMensagemMenorQueZero.TabIndex = 7;
            this.lblMensagemMenorQueZero.Text = "Se continuar subindo os valores,";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(172, 111);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(101, 40);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // QuinentosMil
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 173);
            this.Controls.Add(this.lblMensagemMenorQueZero2);
            this.Controls.Add(this.lblMensagemMenorQueZero);
            this.Controls.Add(this.btnOk);
            this.ForeColor = System.Drawing.Color.HotPink;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuinentosMil";
            this.Text = "A criatividade faltou ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensagemMenorQueZero2;
        private System.Windows.Forms.Label lblMensagemMenorQueZero;
        private System.Windows.Forms.Button btnOk;
    }
}