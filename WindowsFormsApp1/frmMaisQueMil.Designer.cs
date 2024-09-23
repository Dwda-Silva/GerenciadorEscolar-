namespace WindowsFormsApp1
{
    partial class MaisQueMil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaisQueMil));
            this.lblMensagemMenorQueZero = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMensagemMenorQueZero
            // 
            this.lblMensagemMenorQueZero.AutoSize = true;
            this.lblMensagemMenorQueZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMensagemMenorQueZero.Location = new System.Drawing.Point(73, 9);
            this.lblMensagemMenorQueZero.Name = "lblMensagemMenorQueZero";
            this.lblMensagemMenorQueZero.Size = new System.Drawing.Size(304, 60);
            this.lblMensagemMenorQueZero.TabIndex = 4;
            this.lblMensagemMenorQueZero.Text = "Não importa o valor que você coloque,\r\no amor da sua namorada que se iguala \r\nao " +
    "infinito, sempre vai ser maior.\r\n";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(180, 101);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(91, 33);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // MaisQueMil
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 173);
            this.Controls.Add(this.lblMensagemMenorQueZero);
            this.Controls.Add(this.btnOk);
            this.ForeColor = System.Drawing.Color.HotPink;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MaisQueMil";
            this.Text = "EU AMO MAIS^^";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMensagemMenorQueZero;
        private System.Windows.Forms.Button btnOk;
    }
}