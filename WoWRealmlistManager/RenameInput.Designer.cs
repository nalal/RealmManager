namespace WoWRealmlistManager
{
    partial class RenameInput
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
            this.BCancel = new System.Windows.Forms.Button();
            this.BAccept = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(12, 21);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(156, 20);
            this.TBName.TabIndex = 0;
            // 
            // BCancel
            // 
            this.BCancel.Location = new System.Drawing.Point(93, 47);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(75, 23);
            this.BCancel.TabIndex = 1;
            this.BCancel.Text = "Cancel";
            this.BCancel.UseVisualStyleBackColor = true;
            this.BCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // BAccept
            // 
            this.BAccept.Location = new System.Drawing.Point(12, 47);
            this.BAccept.Name = "BAccept";
            this.BAccept.Size = new System.Drawing.Size(75, 23);
            this.BAccept.TabIndex = 2;
            this.BAccept.Text = "Accept";
            this.BAccept.UseVisualStyleBackColor = true;
            this.BAccept.Click += new System.EventHandler(this.BAccept_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // RenameInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 82);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BAccept);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.TBName);
            this.Name = "RenameInput";
            this.Text = "Input new name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Button BCancel;
        private System.Windows.Forms.Button BAccept;
        private System.Windows.Forms.Label label1;
    }
}