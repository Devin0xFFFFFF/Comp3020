﻿namespace Comp3020A3
{
    partial class ListForm
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listDataGrid = new System.Windows.Forms.DataGridView();
            this.listTitleLabel = new System.Windows.Forms.Label();
            this.newListButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 51);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(784, 510);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listTitleLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 96);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.newListButton);
            this.panel2.Controls.Add(this.listDataGrid);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(778, 402);
            this.panel2.TabIndex = 1;
            // 
            // listDataGrid
            // 
            this.listDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listDataGrid.Location = new System.Drawing.Point(18, 12);
            this.listDataGrid.Name = "listDataGrid";
            this.listDataGrid.Size = new System.Drawing.Size(240, 150);
            this.listDataGrid.TabIndex = 0;
            // 
            // listTitleLabel
            // 
            this.listTitleLabel.AutoSize = true;
            this.listTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTitleLabel.Location = new System.Drawing.Point(11, 25);
            this.listTitleLabel.Name = "listTitleLabel";
            this.listTitleLabel.Size = new System.Drawing.Size(156, 42);
            this.listTitleLabel.TabIndex = 0;
            this.listTitleLabel.Text = "List Title";
            // 
            // newListButton
            // 
            this.newListButton.Location = new System.Drawing.Point(183, 192);
            this.newListButton.Name = "newListButton";
            this.newListButton.Size = new System.Drawing.Size(75, 23);
            this.newListButton.TabIndex = 1;
            this.newListButton.Text = "New List";
            this.newListButton.UseVisualStyleBackColor = true;
            this.newListButton.Click += new System.EventHandler(this.newListButton_Click);
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "ListForm";
            this.Load += new System.EventHandler(this.ListForm_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel2, 0);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label listTitleLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView listDataGrid;
        private System.Windows.Forms.Button newListButton;
    }
}
