﻿
namespace Examen_Empresa.Vista
{
    partial class DetalleView
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
            this.DetallesDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DetallesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DetallesDataGridView
            // 
            this.DetallesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetallesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetallesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.DetallesDataGridView.Name = "DetallesDataGridView";
            this.DetallesDataGridView.RowHeadersWidth = 62;
            this.DetallesDataGridView.RowTemplate.Height = 28;
            this.DetallesDataGridView.Size = new System.Drawing.Size(800, 450);
            this.DetallesDataGridView.TabIndex = 0;
            // 
            // DetalleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DetallesDataGridView);
            this.Name = "DetalleView";
            this.Text = "Detalles";
            ((System.ComponentModel.ISupportInitialize)(this.DetallesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DetallesDataGridView;
    }
}