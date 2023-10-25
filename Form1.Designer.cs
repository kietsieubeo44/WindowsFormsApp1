namespace WindowsFormsApp1
{
    partial class Form1
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
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.txtCreat = new System.Windows.Forms.TextBox();
            this.txtUpdate = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCreat = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(626, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(232, 532);
            this.listBox1.TabIndex = 4;
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(284, 175);
            this.txtDelete.Multiline = true;
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(210, 99);
            this.txtDelete.TabIndex = 5;
            this.txtDelete.TextChanged += new System.EventHandler(this.txtDelete_TextChanged);
            // 
            // txtCreat
            // 
            this.txtCreat.Location = new System.Drawing.Point(275, 31);
            this.txtCreat.Multiline = true;
            this.txtCreat.Name = "txtCreat";
            this.txtCreat.Size = new System.Drawing.Size(210, 92);
            this.txtCreat.TabIndex = 6;
            this.txtCreat.TextChanged += new System.EventHandler(this.txtCreat_TextChanged);
            // 
            // txtUpdate
            // 
            this.txtUpdate.Location = new System.Drawing.Point(284, 328);
            this.txtUpdate.Multiline = true;
            this.txtUpdate.Name = "txtUpdate";
            this.txtUpdate.Size = new System.Drawing.Size(210, 99);
            this.txtUpdate.TabIndex = 7;
            this.txtUpdate.TextChanged += new System.EventHandler(this.txtUpdate_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(275, 460);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(228, 103);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCreat
            // 
            this.btnCreat.Location = new System.Drawing.Point(12, 31);
            this.btnCreat.Name = "btnCreat";
            this.btnCreat.Size = new System.Drawing.Size(228, 92);
            this.btnCreat.TabIndex = 0;
            this.btnCreat.Text = "Creat";
            this.btnCreat.UseVisualStyleBackColor = true;
            this.btnCreat.Click += new System.EventHandler(this.btnCreat_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(12, 461);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(228, 103);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 325);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(228, 102);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 175);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(228, 99);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 620);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtUpdate);
            this.Controls.Add(this.txtCreat);
            this.Controls.Add(this.txtDelete);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnCreat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.TextBox txtCreat;
        private System.Windows.Forms.TextBox txtUpdate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCreat;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
    }
}

