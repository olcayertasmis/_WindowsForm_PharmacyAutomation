﻿
namespace Eczane_Otomasyonu
{
    partial class ReportingSystem
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnStokGoster = new System.Windows.Forms.Button();
            this.BtnStokRapor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnGunuRaporla = new System.Windows.Forms.Button();
            this.BtnGunuGoster = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(562, 185);
            this.dataGridView1.TabIndex = 0;
            // 
            // BtnStokGoster
            // 
            this.BtnStokGoster.Location = new System.Drawing.Point(225, 342);
            this.BtnStokGoster.Name = "BtnStokGoster";
            this.BtnStokGoster.Size = new System.Drawing.Size(134, 47);
            this.BtnStokGoster.TabIndex = 1;
            this.BtnStokGoster.Text = "GÖSTER";
            this.BtnStokGoster.UseVisualStyleBackColor = true;
            this.BtnStokGoster.Click += new System.EventHandler(this.BtnStokGoster_Click);
            // 
            // BtnStokRapor
            // 
            this.BtnStokRapor.Location = new System.Drawing.Point(415, 342);
            this.BtnStokRapor.Name = "BtnStokRapor";
            this.BtnStokRapor.Size = new System.Drawing.Size(134, 47);
            this.BtnStokRapor.TabIndex = 2;
            this.BtnStokRapor.Text = "İLAÇ RAPORLA";
            this.BtnStokRapor.UseVisualStyleBackColor = true;
            this.BtnStokRapor.Click += new System.EventHandler(this.BtnStokRapor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "STOĞU BİTEN İLAÇLAR :";
            // 
            // BtnGunuRaporla
            // 
            this.BtnGunuRaporla.Location = new System.Drawing.Point(415, 286);
            this.BtnGunuRaporla.Name = "BtnGunuRaporla";
            this.BtnGunuRaporla.Size = new System.Drawing.Size(134, 47);
            this.BtnGunuRaporla.TabIndex = 4;
            this.BtnGunuRaporla.Text = "GÜNÜ RAPORLA";
            this.BtnGunuRaporla.UseVisualStyleBackColor = true;
            this.BtnGunuRaporla.Click += new System.EventHandler(this.BtnGunuRaporla_Click);
            // 
            // BtnGunuGoster
            // 
            this.BtnGunuGoster.Location = new System.Drawing.Point(225, 286);
            this.BtnGunuGoster.Name = "BtnGunuGoster";
            this.BtnGunuGoster.Size = new System.Drawing.Size(134, 47);
            this.BtnGunuGoster.TabIndex = 5;
            this.BtnGunuGoster.Text = "GÖSTER";
            this.BtnGunuGoster.UseVisualStyleBackColor = true;
            this.BtnGunuGoster.Click += new System.EventHandler(this.BtnGunuGoster_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "BUGÜN YAPILAN SATIŞLAR :";
            // 
            // ReportingSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 401);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnGunuGoster);
            this.Controls.Add(this.BtnGunuRaporla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnStokRapor);
            this.Controls.Add(this.BtnStokGoster);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ReportingSystem";
            this.Text = "ReportingSystem";
            this.Load += new System.EventHandler(this.ReportingSystem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnStokGoster;
        private System.Windows.Forms.Button BtnStokRapor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnGunuRaporla;
        private System.Windows.Forms.Button BtnGunuGoster;
        private System.Windows.Forms.Label label2;
    }
}