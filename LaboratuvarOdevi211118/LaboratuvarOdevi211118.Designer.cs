namespace LaboratuvarOdevi211118
{
    partial class LaboratuvarOdevi211118
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnFibNormSirala = new System.Windows.Forms.Button();
            this.txtFibNormSirala = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFibTersSirala = new System.Windows.Forms.Button();
            this.txtFibTersSirala = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnFibIndisBul = new System.Windows.Forms.Button();
            this.txtFibIndisBul = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(262, 14);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(945, 619);
            this.listBox1.TabIndex = 0;
            // 
            // btnFibNormSirala
            // 
            this.btnFibNormSirala.Location = new System.Drawing.Point(178, 20);
            this.btnFibNormSirala.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFibNormSirala.Name = "btnFibNormSirala";
            this.btnFibNormSirala.Size = new System.Drawing.Size(48, 27);
            this.btnFibNormSirala.TabIndex = 1;
            this.btnFibNormSirala.Text = ">>";
            this.btnFibNormSirala.UseVisualStyleBackColor = true;
            this.btnFibNormSirala.Click += new System.EventHandler(this.btnFibNormSirala_Click);
            // 
            // txtFibNormSirala
            // 
            this.txtFibNormSirala.Location = new System.Drawing.Point(6, 22);
            this.txtFibNormSirala.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFibNormSirala.Name = "txtFibNormSirala";
            this.txtFibNormSirala.Size = new System.Drawing.Size(165, 23);
            this.txtFibNormSirala.TabIndex = 2;
            this.txtFibNormSirala.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._sadeceRakam);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFibNormSirala);
            this.groupBox1.Controls.Add(this.txtFibNormSirala);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(234, 60);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fibbonaci Sayıları (Normal Sıra)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFibTersSirala);
            this.groupBox2.Controls.Add(this.txtFibTersSirala);
            this.groupBox2.Location = new System.Drawing.Point(14, 81);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(234, 60);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fibbonaci Sayıları (Ters Sıra)";
            // 
            // btnFibTersSirala
            // 
            this.btnFibTersSirala.Location = new System.Drawing.Point(178, 20);
            this.btnFibTersSirala.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFibTersSirala.Name = "btnFibTersSirala";
            this.btnFibTersSirala.Size = new System.Drawing.Size(48, 27);
            this.btnFibTersSirala.TabIndex = 1;
            this.btnFibTersSirala.Text = ">>";
            this.btnFibTersSirala.UseVisualStyleBackColor = true;
            this.btnFibTersSirala.Click += new System.EventHandler(this.btnFibTersSirala_Click);
            // 
            // txtFibTersSirala
            // 
            this.txtFibTersSirala.Location = new System.Drawing.Point(6, 22);
            this.txtFibTersSirala.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFibTersSirala.Name = "txtFibTersSirala";
            this.txtFibTersSirala.Size = new System.Drawing.Size(165, 23);
            this.txtFibTersSirala.TabIndex = 2;
            this.txtFibTersSirala.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._sadeceRakam);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnFibIndisBul);
            this.groupBox3.Controls.Add(this.txtFibIndisBul);
            this.groupBox3.Location = new System.Drawing.Point(14, 148);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(234, 60);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İndis No";
            // 
            // btnFibIndisBul
            // 
            this.btnFibIndisBul.Enabled = false;
            this.btnFibIndisBul.Location = new System.Drawing.Point(178, 20);
            this.btnFibIndisBul.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFibIndisBul.Name = "btnFibIndisBul";
            this.btnFibIndisBul.Size = new System.Drawing.Size(48, 27);
            this.btnFibIndisBul.TabIndex = 1;
            this.btnFibIndisBul.Text = ">>";
            this.btnFibIndisBul.UseVisualStyleBackColor = true;
            this.btnFibIndisBul.Click += new System.EventHandler(this.btnFibIndisBul_Click);
            // 
            // txtFibIndisBul
            // 
            this.txtFibIndisBul.Location = new System.Drawing.Point(6, 22);
            this.txtFibIndisBul.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFibIndisBul.Name = "txtFibIndisBul";
            this.txtFibIndisBul.Size = new System.Drawing.Size(165, 23);
            this.txtFibIndisBul.TabIndex = 2;
            this.txtFibIndisBul.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._sadeceRakam);
            // 
            // LaboratuvarOdevi211118
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 644);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "LaboratuvarOdevi211118";
            this.Text = "LaboratuvarOdevi211118";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnFibNormSirala;
        private System.Windows.Forms.TextBox txtFibNormSirala;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFibTersSirala;
        private System.Windows.Forms.TextBox txtFibTersSirala;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnFibIndisBul;
        private System.Windows.Forms.TextBox txtFibIndisBul;
    }
}