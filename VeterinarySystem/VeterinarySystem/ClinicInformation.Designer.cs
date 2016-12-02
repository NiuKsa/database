﻿namespace VeterinarySystem
{
    partial class ClinicInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClinicInformation));
            this.label1 = new System.Windows.Forms.Label();
            this.choose = new System.Windows.Forms.ComboBox();
            this.pCodeTextBox = new System.Windows.Forms.TextBox();
            this.pCode = new System.Windows.Forms.Label();
            this.fName = new System.Windows.Forms.Label();
            this.sName = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.startedAt = new System.Windows.Forms.Label();
            this.animals = new System.Windows.Forms.Label();
            this.fNameText = new System.Windows.Forms.Label();
            this.sNameText = new System.Windows.Forms.Label();
            this.phoneText = new System.Windows.Forms.Label();
            this.startedAtText = new System.Windows.Forms.Label();
            this.animalText = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.seeAllAnimals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(105, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 55);
            this.label1.TabIndex = 0;
            // 
            // choose
            // 
            this.choose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choose.FormattingEnabled = true;
            this.choose.Items.AddRange(new object[] {
            "Vet",
            "All vets",
            "Owner",
            "All owners"});
            this.choose.Location = new System.Drawing.Point(70, 67);
            this.choose.Name = "choose";
            this.choose.Size = new System.Drawing.Size(217, 28);
            this.choose.TabIndex = 1;
            this.choose.Text = "Choose information type";
            // 
            // pCodeTextBox
            // 
            this.pCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pCodeTextBox.Location = new System.Drawing.Point(70, 117);
            this.pCodeTextBox.Name = "pCodeTextBox";
            this.pCodeTextBox.Size = new System.Drawing.Size(217, 26);
            this.pCodeTextBox.TabIndex = 3;
            // 
            // pCode
            // 
            this.pCode.AutoSize = true;
            this.pCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pCode.Location = new System.Drawing.Point(67, 98);
            this.pCode.Name = "pCode";
            this.pCode.Size = new System.Drawing.Size(147, 16);
            this.pCode.TabIndex = 4;
            this.pCode.Text = "Eneter \'Personal code\':";
            // 
            // fName
            // 
            this.fName.AutoSize = true;
            this.fName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fName.Location = new System.Drawing.Point(67, 159);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(73, 16);
            this.fName.TabIndex = 5;
            this.fName.Text = "First name:";
            this.fName.Click += new System.EventHandler(this.label2_Click);
            // 
            // sName
            // 
            this.sName.AutoSize = true;
            this.sName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sName.Location = new System.Drawing.Point(67, 185);
            this.sName.Name = "sName";
            this.sName.Size = new System.Drawing.Size(95, 16);
            this.sName.TabIndex = 6;
            this.sName.Text = "Second name:";
            this.sName.Click += new System.EventHandler(this.label4_Click);
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(67, 210);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(74, 16);
            this.phone.TabIndex = 11;
            this.phone.Text = "Phone No.:";
            this.phone.Click += new System.EventHandler(this.label5_Click);
            // 
            // startedAt
            // 
            this.startedAt.AutoSize = true;
            this.startedAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startedAt.Location = new System.Drawing.Point(67, 235);
            this.startedAt.Name = "startedAt";
            this.startedAt.Size = new System.Drawing.Size(99, 16);
            this.startedAt.TabIndex = 12;
            this.startedAt.Text = "Started work at:";
            // 
            // animals
            // 
            this.animals.AutoSize = true;
            this.animals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animals.Location = new System.Drawing.Point(67, 261);
            this.animals.Name = "animals";
            this.animals.Size = new System.Drawing.Size(111, 16);
            this.animals.TabIndex = 13;
            this.animals.Text = "Treating animals:";
            this.animals.Click += new System.EventHandler(this.label7_Click);
            // 
            // fNameText
            // 
            this.fNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameText.Location = new System.Drawing.Point(182, 156);
            this.fNameText.Name = "fNameText";
            this.fNameText.Size = new System.Drawing.Size(101, 19);
            this.fNameText.TabIndex = 15;
            this.fNameText.Text = "text";
            this.fNameText.Click += new System.EventHandler(this.label9_Click);
            // 
            // sNameText
            // 
            this.sNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sNameText.Location = new System.Drawing.Point(182, 182);
            this.sNameText.Name = "sNameText";
            this.sNameText.Size = new System.Drawing.Size(105, 19);
            this.sNameText.TabIndex = 16;
            this.sNameText.Text = "text";
            this.sNameText.Click += new System.EventHandler(this.label10_Click);
            // 
            // phoneText
            // 
            this.phoneText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneText.Location = new System.Drawing.Point(182, 207);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(105, 19);
            this.phoneText.TabIndex = 17;
            this.phoneText.Text = "text";
            // 
            // startedAtText
            // 
            this.startedAtText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startedAtText.Location = new System.Drawing.Point(182, 232);
            this.startedAtText.Name = "startedAtText";
            this.startedAtText.Size = new System.Drawing.Size(105, 19);
            this.startedAtText.TabIndex = 18;
            this.startedAtText.Text = "text";
            // 
            // animalText
            // 
            this.animalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animalText.Location = new System.Drawing.Point(182, 258);
            this.animalText.Name = "animalText";
            this.animalText.Size = new System.Drawing.Size(105, 19);
            this.animalText.TabIndex = 19;
            this.animalText.Text = "text";
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.SystemColors.Control;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Image = ((System.Drawing.Image)(resources.GetObject("cancel.Image")));
            this.cancel.Location = new System.Drawing.Point(134, 361);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(80, 30);
            this.cancel.TabIndex = 21;
            this.cancel.UseVisualStyleBackColor = false;
            // 
            // seeAllAnimals
            // 
            this.seeAllAnimals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seeAllAnimals.Location = new System.Drawing.Point(70, 296);
            this.seeAllAnimals.Name = "seeAllAnimals";
            this.seeAllAnimals.Size = new System.Drawing.Size(217, 30);
            this.seeAllAnimals.TabIndex = 22;
            this.seeAllAnimals.Text = "See all treating animals info";
            this.seeAllAnimals.UseVisualStyleBackColor = true;
            // 
            // ClinicInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(353, 418);
            this.Controls.Add(this.seeAllAnimals);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.animalText);
            this.Controls.Add(this.startedAtText);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.sNameText);
            this.Controls.Add(this.fNameText);
            this.Controls.Add(this.animals);
            this.Controls.Add(this.startedAt);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.sName);
            this.Controls.Add(this.fName);
            this.Controls.Add(this.pCode);
            this.Controls.Add(this.pCodeTextBox);
            this.Controls.Add(this.choose);
            this.Controls.Add(this.label1);
            this.Name = "ClinicInformation";
            this.Text = "ClinicInformation";
            this.Load += new System.EventHandler(this.ClinicInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox choose;
        private System.Windows.Forms.TextBox pCodeTextBox;
        private System.Windows.Forms.Label pCode;
        private System.Windows.Forms.Label fName;
        private System.Windows.Forms.Label sName;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label startedAt;
        private System.Windows.Forms.Label animals;
        private System.Windows.Forms.Label fNameText;
        private System.Windows.Forms.Label sNameText;
        private System.Windows.Forms.Label phoneText;
        private System.Windows.Forms.Label startedAtText;
        private System.Windows.Forms.Label animalText;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button seeAllAnimals;
    }
}