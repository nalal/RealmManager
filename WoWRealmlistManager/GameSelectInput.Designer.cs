namespace WoWRealmlistManager
{
    partial class GameSelectInput
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
            this.TBName = new System.Windows.Forms.TextBox();
            this.TBDIR = new System.Windows.Forms.TextBox();
            this.BBrowse = new System.Windows.Forms.Button();
            this.BAccept = new System.Windows.Forms.Button();
            this.BCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FBDWoWDIR = new System.Windows.Forms.FolderBrowserDialog();
            this.LTest = new System.Windows.Forms.Label();
            this.LError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(12, 29);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(148, 20);
            this.TBName.TabIndex = 0;
            // 
            // TBDIR
            // 
            this.TBDIR.Location = new System.Drawing.Point(12, 68);
            this.TBDIR.Name = "TBDIR";
            this.TBDIR.Size = new System.Drawing.Size(148, 20);
            this.TBDIR.TabIndex = 1;
            // 
            // BBrowse
            // 
            this.BBrowse.Location = new System.Drawing.Point(166, 66);
            this.BBrowse.Name = "BBrowse";
            this.BBrowse.Size = new System.Drawing.Size(50, 23);
            this.BBrowse.TabIndex = 2;
            this.BBrowse.Text = "Browse";
            this.BBrowse.UseVisualStyleBackColor = true;
            this.BBrowse.Click += new System.EventHandler(this.BBrowse_Click);
            // 
            // BAccept
            // 
            this.BAccept.Location = new System.Drawing.Point(12, 94);
            this.BAccept.Name = "BAccept";
            this.BAccept.Size = new System.Drawing.Size(50, 23);
            this.BAccept.TabIndex = 3;
            this.BAccept.Text = "Accept";
            this.BAccept.UseVisualStyleBackColor = true;
            this.BAccept.Click += new System.EventHandler(this.BAccept_Click);
            // 
            // BCancel
            // 
            this.BCancel.Location = new System.Drawing.Point(68, 94);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(50, 23);
            this.BCancel.TabIndex = 4;
            this.BCancel.Text = "Cancel";
            this.BCancel.UseVisualStyleBackColor = true;
            this.BCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Directory";
            // 
            // LTest
            // 
            this.LTest.AutoSize = true;
            this.LTest.Location = new System.Drawing.Point(163, 9);
            this.LTest.Name = "LTest";
            this.LTest.Size = new System.Drawing.Size(0, 13);
            this.LTest.TabIndex = 7;
            // 
            // LError
            // 
            this.LError.AutoSize = true;
            this.LError.ForeColor = System.Drawing.Color.Red;
            this.LError.Location = new System.Drawing.Point(124, 94);
            this.LError.Name = "LError";
            this.LError.Size = new System.Drawing.Size(0, 13);
            this.LError.TabIndex = 8;
            // 
            // GameSelectInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 125);
            this.Controls.Add(this.LError);
            this.Controls.Add(this.LTest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.BAccept);
            this.Controls.Add(this.BBrowse);
            this.Controls.Add(this.TBDIR);
            this.Controls.Add(this.TBName);
            this.Name = "GameSelectInput";
            this.Text = "Add WoW Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.TextBox TBDIR;
        private System.Windows.Forms.Button BBrowse;
        private System.Windows.Forms.Button BAccept;
        private System.Windows.Forms.Button BCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog FBDWoWDIR;
        private System.Windows.Forms.Label LTest;
        private System.Windows.Forms.Label LError;
    }
}