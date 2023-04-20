namespace ControleCofre
{
    partial class frmAbrirCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbrirCaixa));
            this.txtAbrirCaixa = new System.Windows.Forms.TextBox();
            this.lblDatAbertura = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDataAbertura = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.btnAbrirCaixa = new System.Windows.Forms.Button();
            this.txtTrocoDiaAnterior = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtAbrirCaixa
            // 
            this.txtAbrirCaixa.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtAbrirCaixa.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbrirCaixa.ForeColor = System.Drawing.Color.White;
            this.txtAbrirCaixa.Location = new System.Drawing.Point(-5, -2);
            this.txtAbrirCaixa.Name = "txtAbrirCaixa";
            this.txtAbrirCaixa.Size = new System.Drawing.Size(242, 33);
            this.txtAbrirCaixa.TabIndex = 29;
            this.txtAbrirCaixa.Text = "Abrir Caixa";
            this.txtAbrirCaixa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDatAbertura
            // 
            this.lblDatAbertura.AutoSize = true;
            this.lblDatAbertura.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatAbertura.ForeColor = System.Drawing.Color.White;
            this.lblDatAbertura.Location = new System.Drawing.Point(5, 41);
            this.lblDatAbertura.Name = "lblDatAbertura";
            this.lblDatAbertura.Size = new System.Drawing.Size(98, 18);
            this.lblDatAbertura.TabIndex = 31;
            this.lblDatAbertura.Text = "Data Abertura:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 18);
            this.label2.TabIndex = 32;
            this.label2.Text = "Troco dia Anterior:";
            // 
            // dtpDataAbertura
            // 
            this.dtpDataAbertura.Enabled = false;
            this.dtpDataAbertura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataAbertura.Location = new System.Drawing.Point(127, 41);
            this.dtpDataAbertura.Name = "dtpDataAbertura";
            this.dtpDataAbertura.Size = new System.Drawing.Size(100, 20);
            this.dtpDataAbertura.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 38;
            this.label1.Text = "Troco dia Anterior:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 37;
            this.label3.Text = "Data Abertura:";
            // 
            // btn
            // 
            this.btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn.BackgroundImage")));
            this.btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.ForeColor = System.Drawing.SystemColors.Window;
            this.btn.Location = new System.Drawing.Point(-5, 105);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(242, 57);
            this.btn.TabIndex = 35;
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAbrirCaixa
            // 
            this.btnAbrirCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbrirCaixa.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAbrirCaixa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAbrirCaixa.BackgroundImage")));
            this.btnAbrirCaixa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAbrirCaixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrirCaixa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnAbrirCaixa.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAbrirCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirCaixa.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAbrirCaixa.Location = new System.Drawing.Point(1, 104);
            this.btnAbrirCaixa.Name = "btnAbrirCaixa";
            this.btnAbrirCaixa.Size = new System.Drawing.Size(229, 57);
            this.btnAbrirCaixa.TabIndex = 28;
            this.btnAbrirCaixa.UseVisualStyleBackColor = false;
            // 
            // txtTrocoDiaAnterior
            // 
            this.txtTrocoDiaAnterior.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrocoDiaAnterior.Location = new System.Drawing.Point(127, 71);
            this.txtTrocoDiaAnterior.Name = "txtTrocoDiaAnterior";
            this.txtTrocoDiaAnterior.Size = new System.Drawing.Size(100, 23);
            this.txtTrocoDiaAnterior.TabIndex = 39;
            // 
            // frmAbrirCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(232, 162);
            this.Controls.Add(this.dtpDataAbertura);
            this.Controls.Add(this.txtTrocoDiaAnterior);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDatAbertura);
            this.Controls.Add(this.txtAbrirCaixa);
            this.Controls.Add(this.btnAbrirCaixa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAbrirCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abrindo Caixa";
            this.Load += new System.EventHandler(this.frmAbrirCaixa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAbrirCaixa;
        private System.Windows.Forms.TextBox txtAbrirCaixa;
        private System.Windows.Forms.Label lblDatAbertura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDataAbertura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TextBox txtTrocoDiaAnterior;
    }
}