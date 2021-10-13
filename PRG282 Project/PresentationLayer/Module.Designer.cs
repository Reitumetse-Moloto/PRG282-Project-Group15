
namespace PRG282_Project
{
    partial class frmModule
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteMod = new System.Windows.Forms.Button();
            this.btnUpdateMod = new System.Windows.Forms.Button();
            this.btnAddModule = new System.Windows.Forms.Button();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtModName = new System.Windows.Forms.TextBox();
            this.txtModuleCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.btnSearchMod = new System.Windows.Forms.Button();
            this.txtSearchModule = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(319, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Module";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(767, 226);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnDeleteMod);
            this.panel1.Controls.Add(this.btnUpdateMod);
            this.panel1.Controls.Add(this.btnAddModule);
            this.panel1.Controls.Add(this.txtLink);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.txtModName);
            this.panel1.Controls.Add(this.txtModuleCode);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(25, 293);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 227);
            this.panel1.TabIndex = 2;
            // 
            // btnDeleteMod
            // 
            this.btnDeleteMod.Location = new System.Drawing.Point(261, 156);
            this.btnDeleteMod.Name = "btnDeleteMod";
            this.btnDeleteMod.Size = new System.Drawing.Size(79, 36);
            this.btnDeleteMod.TabIndex = 10;
            this.btnDeleteMod.Text = "Delete Module";
            this.btnDeleteMod.UseVisualStyleBackColor = true;
            this.btnDeleteMod.Click += new System.EventHandler(this.btnDeleteMod_Click);
            // 
            // btnUpdateMod
            // 
            this.btnUpdateMod.Location = new System.Drawing.Point(138, 156);
            this.btnUpdateMod.Name = "btnUpdateMod";
            this.btnUpdateMod.Size = new System.Drawing.Size(91, 36);
            this.btnUpdateMod.TabIndex = 9;
            this.btnUpdateMod.Text = "Update Module";
            this.btnUpdateMod.UseVisualStyleBackColor = true;
            this.btnUpdateMod.Click += new System.EventHandler(this.btnUpdateMod_Click);
            // 
            // btnAddModule
            // 
            this.btnAddModule.Location = new System.Drawing.Point(11, 156);
            this.btnAddModule.Name = "btnAddModule";
            this.btnAddModule.Size = new System.Drawing.Size(87, 36);
            this.btnAddModule.TabIndex = 8;
            this.btnAddModule.Text = "Add Module";
            this.btnAddModule.UseVisualStyleBackColor = true;
            this.btnAddModule.Click += new System.EventHandler(this.btnAddModule_Click);
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(94, 121);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(188, 20);
            this.txtLink.TabIndex = 7;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(94, 89);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(188, 20);
            this.txtDescription.TabIndex = 6;
            // 
            // txtModName
            // 
            this.txtModName.Location = new System.Drawing.Point(94, 53);
            this.txtModName.Name = "txtModName";
            this.txtModName.Size = new System.Drawing.Size(188, 20);
            this.txtModName.TabIndex = 5;
            // 
            // txtModuleCode
            // 
            this.txtModuleCode.Location = new System.Drawing.Point(94, 21);
            this.txtModuleCode.Name = "txtModuleCode";
            this.txtModuleCode.Size = new System.Drawing.Size(188, 20);
            this.txtModuleCode.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Link:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Module Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Module Code:";
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.btnSearchMod);
            this.grpSearch.Controls.Add(this.txtSearchModule);
            this.grpSearch.Controls.Add(this.label2);
            this.grpSearch.Location = new System.Drawing.Point(402, 293);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(390, 152);
            this.grpSearch.TabIndex = 0;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search Module";
            // 
            // btnSearchMod
            // 
            this.btnSearchMod.Location = new System.Drawing.Point(261, 46);
            this.btnSearchMod.Name = "btnSearchMod";
            this.btnSearchMod.Size = new System.Drawing.Size(85, 39);
            this.btnSearchMod.TabIndex = 2;
            this.btnSearchMod.Text = "Search Module";
            this.btnSearchMod.UseVisualStyleBackColor = true;
            this.btnSearchMod.Click += new System.EventHandler(this.btnSearchMod_Click);
            // 
            // txtSearchModule
            // 
            this.txtSearchModule.Location = new System.Drawing.Point(130, 56);
            this.txtSearchModule.Name = "txtSearchModule";
            this.txtSearchModule.Size = new System.Drawing.Size(100, 20);
            this.txtSearchModule.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter Module Code:";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(717, 464);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // frmModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 532);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "frmModule";
            this.Text = "Module";
            this.Load += new System.EventHandler(this.Module_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtModName;
        private System.Windows.Forms.TextBox txtModuleCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Button btnSearchMod;
        private System.Windows.Forms.TextBox txtSearchModule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnDeleteMod;
        private System.Windows.Forms.Button btnUpdateMod;
        private System.Windows.Forms.Button btnAddModule;
    }
}