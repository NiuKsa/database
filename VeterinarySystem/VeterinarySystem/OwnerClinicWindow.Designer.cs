﻿namespace VeterinarySystem
{
    partial class OwnerClinicWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OwnerClinicWindow));
            this.label = new System.Windows.Forms.Label();
            this.tableDataGridView = new System.Windows.Forms.DataGridView();
            this.cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(192, 18);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(39, 24);
            this.label.TabIndex = 1;
            this.label.Text = "text";
            // 
            // tableDataGridView
            // 
            this.tableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDataGridView.Location = new System.Drawing.Point(22, 59);
            this.tableDataGridView.Name = "tableDataGridView";
            this.tableDataGridView.Size = new System.Drawing.Size(552, 299);
            this.tableDataGridView.TabIndex = 25;
            this.tableDataGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tableDataGridView_RowHeaderMouseDoubleClick);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.SystemColors.Control;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Image = ((System.Drawing.Image)(resources.GetObject("cancel.Image")));
            this.cancel.Location = new System.Drawing.Point(232, 382);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(80, 30);
            this.cancel.TabIndex = 26;
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // OwnerClinicWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(597, 424);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.tableDataGridView);
            this.Controls.Add(this.label);
            this.Name = "OwnerClinicWindow";
            this.Text = "OwnerClinicWindow";
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DataGridView tableDataGridView;
        private System.Windows.Forms.Button cancel;
    }
}