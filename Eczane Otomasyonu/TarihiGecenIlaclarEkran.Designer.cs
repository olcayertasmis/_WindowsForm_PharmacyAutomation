﻿
namespace Eczane_Otomasyonu
{
    partial class TarihiGecenIlaclarEkran
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EczaneOtomasyonDBDataSet3 = new Eczane_Otomasyonu.EczaneOtomasyonDBDataSet3();
            this.TarihiGecenlerViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TarihiGecenlerViewTableAdapter = new Eczane_Otomasyonu.EczaneOtomasyonDBDataSet3TableAdapters.TarihiGecenlerViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.EczaneOtomasyonDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TarihiGecenlerViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TarihiGecenlerViewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Eczane_Otomasyonu.TarihiGecenilaclarWizard.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // EczaneOtomasyonDBDataSet3
            // 
            this.EczaneOtomasyonDBDataSet3.DataSetName = "EczaneOtomasyonDBDataSet3";
            this.EczaneOtomasyonDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TarihiGecenlerViewBindingSource
            // 
            this.TarihiGecenlerViewBindingSource.DataMember = "TarihiGecenlerView";
            this.TarihiGecenlerViewBindingSource.DataSource = this.EczaneOtomasyonDBDataSet3;
            // 
            // TarihiGecenlerViewTableAdapter
            // 
            this.TarihiGecenlerViewTableAdapter.ClearBeforeFill = true;
            // 
            // TarihiGecenIlaclarEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "TarihiGecenIlaclarEkran";
            this.Text = "TarihiGecenIlaclarEkran";
            this.Load += new System.EventHandler(this.TarihiGecenIlaclarEkran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EczaneOtomasyonDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TarihiGecenlerViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TarihiGecenlerViewBindingSource;
        private EczaneOtomasyonDBDataSet3 EczaneOtomasyonDBDataSet3;
        private EczaneOtomasyonDBDataSet3TableAdapters.TarihiGecenlerViewTableAdapter TarihiGecenlerViewTableAdapter;
    }
}