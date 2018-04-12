namespace AramaAlgoritma
{
    partial class AnimasyonAyar
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
            this.txtRich_sure = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRich_MetinLimit = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRich_AramaMetinLimit = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRich_sure
            // 
            this.txtRich_sure.Location = new System.Drawing.Point(149, 41);
            this.txtRich_sure.Name = "txtRich_sure";
            this.txtRich_sure.Size = new System.Drawing.Size(165, 28);
            this.txtRich_sure.TabIndex = 1;
            this.txtRich_sure.Text = "";
            this.txtRich_sure.Enter += new System.EventHandler(this.txtRich_Enter_SelectAll);
            this.txtRich_sure.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRich_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sure (1000 = 1ms)";
            // 
            // txtRich_MetinLimit
            // 
            this.txtRich_MetinLimit.Location = new System.Drawing.Point(149, 75);
            this.txtRich_MetinLimit.Name = "txtRich_MetinLimit";
            this.txtRich_MetinLimit.Size = new System.Drawing.Size(165, 28);
            this.txtRich_MetinLimit.TabIndex = 2;
            this.txtRich_MetinLimit.Text = "";
            this.txtRich_MetinLimit.Enter += new System.EventHandler(this.txtRich_Enter_SelectAll);
            this.txtRich_MetinLimit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRich_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Metin Limit";
            // 
            // txtRich_AramaMetinLimit
            // 
            this.txtRich_AramaMetinLimit.Location = new System.Drawing.Point(149, 109);
            this.txtRich_AramaMetinLimit.Name = "txtRich_AramaMetinLimit";
            this.txtRich_AramaMetinLimit.Size = new System.Drawing.Size(165, 28);
            this.txtRich_AramaMetinLimit.TabIndex = 3;
            this.txtRich_AramaMetinLimit.Text = "";
            this.txtRich_AramaMetinLimit.Enter += new System.EventHandler(this.txtRich_Enter_SelectAll);
            this.txtRich_AramaMetinLimit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRich_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Arama Metin Limit";
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(25, 144);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(289, 42);
            this.btn_Kaydet.TabIndex = 4;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // AnimasyonAyar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(343, 215);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRich_AramaMetinLimit);
            this.Controls.Add(this.txtRich_MetinLimit);
            this.Controls.Add(this.txtRich_sure);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AnimasyonAyar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnimasyonAyar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtRich_sure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtRich_MetinLimit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtRich_AramaMetinLimit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Kaydet;
    }
}