namespace WoWRealmlistManager
{
    partial class RealmlistInput
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
            this.BClose = new System.Windows.Forms.Button();
            this.BAccept = new System.Windows.Forms.Button();
            this.TBRInput = new System.Windows.Forms.TextBox();
            this.LInputPrompt = new System.Windows.Forms.Label();
            this.LRemoveSet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BClose
            // 
            this.BClose.Location = new System.Drawing.Point(93, 58);
            this.BClose.Name = "BClose";
            this.BClose.Size = new System.Drawing.Size(75, 23);
            this.BClose.TabIndex = 0;
            this.BClose.Text = "Cancel";
            this.BClose.UseVisualStyleBackColor = true;
            this.BClose.Click += new System.EventHandler(this.BClose_Click);
            // 
            // BAccept
            // 
            this.BAccept.Location = new System.Drawing.Point(12, 58);
            this.BAccept.Name = "BAccept";
            this.BAccept.Size = new System.Drawing.Size(75, 23);
            this.BAccept.TabIndex = 1;
            this.BAccept.Text = "Accept";
            this.BAccept.UseVisualStyleBackColor = true;
            this.BAccept.Click += new System.EventHandler(this.BAccept_Click);
            // 
            // TBRInput
            // 
            this.TBRInput.Location = new System.Drawing.Point(12, 32);
            this.TBRInput.Name = "TBRInput";
            this.TBRInput.Size = new System.Drawing.Size(336, 20);
            this.TBRInput.TabIndex = 2;
            // 
            // LInputPrompt
            // 
            this.LInputPrompt.AutoSize = true;
            this.LInputPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LInputPrompt.Location = new System.Drawing.Point(9, 9);
            this.LInputPrompt.Name = "LInputPrompt";
            this.LInputPrompt.Size = new System.Drawing.Size(135, 13);
            this.LInputPrompt.TabIndex = 3;
            this.LInputPrompt.Text = "Please type the server\'s IP:";
            // 
            // LRemoveSet
            // 
            this.LRemoveSet.AutoSize = true;
            this.LRemoveSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRemoveSet.ForeColor = System.Drawing.Color.Red;
            this.LRemoveSet.Location = new System.Drawing.Point(174, 63);
            this.LRemoveSet.Name = "LRemoveSet";
            this.LRemoveSet.Size = new System.Drawing.Size(0, 13);
            this.LRemoveSet.TabIndex = 4;
            this.LRemoveSet.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // RealmlistInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 87);
            this.Controls.Add(this.LRemoveSet);
            this.Controls.Add(this.LInputPrompt);
            this.Controls.Add(this.TBRInput);
            this.Controls.Add(this.BAccept);
            this.Controls.Add(this.BClose);
            this.Name = "RealmlistInput";
            this.Text = "Realmlist Input";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BClose;
        private System.Windows.Forms.Button BAccept;
        private System.Windows.Forms.TextBox TBRInput;
        private System.Windows.Forms.Label LInputPrompt;
        private System.Windows.Forms.Label LRemoveSet;
    }
}