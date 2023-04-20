namespace ControleCofre
{
    partial class frmFecharCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFecharCaixa));
            this.dtpDataFechamento = new System.Windows.Forms.DateTimePicker();
            this.txtTrocoFechamento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDatAbertura = new System.Windows.Forms.Label();
            this.txtAbrirCaixa = new System.Windows.Forms.TextBox();
            this.btnFecharCaixa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpDataFechamento
            // 
            this.dtpDataFechamento.Enabled = false;
            this.dtpDataFechamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFechamento.Location = new System.Drawing.Point(127, 41);
            this.dtpDataFechamento.Name = "dtpDataFechamento";
            this.dtpDataFechamento.Size = new System.Drawing.Size(100, 20);
            this.dtpDataFechamento.TabIndex = 46;
            // 
            // txtTrocoFechamento
            // 
            this.txtTrocoFechamento.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrocoFechamento.Location = new System.Drawing.Point(127, 72);
            this.txtTrocoFechamento.Name = "txtTrocoFechamento";
            this.txtTrocoFechamento.Size = new System.Drawing.Size(100, 23);
            this.txtTrocoFechamento.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(55, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 44;
            this.label2.Text = "Troco dia :";
            // 
            // lblDatAbertura
            // 
            this.lblDatAbertura.AutoSize = true;
            this.lblDatAbertura.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatAbertura.ForeColor = System.Drawing.Color.White;
            this.lblDatAbertura.Location = new System.Drawing.Point(6, 41);
            this.lblDatAbertura.Name = "lblDatAbertura";
            this.lblDatAbertura.Size = new System.Drawing.Size(120, 18);
            this.lblDatAbertura.TabIndex = 43;
            this.lblDatAbertura.Text = "Data Fechamento:";
            // 
            // txtAbrirCaixa
            // 
            this.txtAbrirCaixa.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtAbrirCaixa.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbrirCaixa.ForeColor = System.Drawing.Color.White;
            this.txtAbrirCaixa.Location = new System.Drawing.Point(-5, -2);
            this.txtAbrirCaixa.Name = "txtAbrirCaixa";
            this.txtAbrirCaixa.Size = new System.Drawing.Size(242, 33);
            this.txtAbrirCaixa.TabIndex = 42;
            this.txtAbrirCaixa.Text = "Fechar Caixa";
            this.txtAbrirCaixa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnFecharCaixa
            // 
            this.btnFecharCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFecharCaixa.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnFecharCaixa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFecharCaixa.BackgroundImage")));
            this.btnFecharCaixa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFecharCaixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFecharCaixa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnFecharCaixa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnFecharCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharCaixa.ForeColor = System.Drawing.SystemColors.Window;
            this.btnFecharCaixa.Location = new System.Drawing.Point(-5, 106);
            this.btnFecharCaixa.Name = "btnFecharCaixa";
            this.btnFecharCaixa.Size = new System.Drawing.Size(242, 57);
            this.btnFecharCaixa.TabIndex = 41;
            this.btnFecharCaixa.UseVisualStyleBackColor = false;
            this.btnFecharCaixa.Click += new System.EventHandler(this.btnFecharCaixa_Click);
            // 
            // frmFecharCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(232, 162);
            this.Controls.Add(this.dtpDataFechamento);
            this.Controls.Add(this.txtTrocoFechamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDatAbertura);
            this.Controls.Add(this.txtAbrirCaixa);
            this.Controls.Add(this.btnFecharCaixa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFecharCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fechar Caixa";
            this.Load += new System.EventHandler(this.frmFecharCaixa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDataFechamento;
        private System.Windows.Forms.TextBox txtTrocoFechamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDatAbertura;
        private System.Windows.Forms.TextBox txtAbrirCaixa;
        private System.Windows.Forms.Button btnFecharCaixa;
    }
}