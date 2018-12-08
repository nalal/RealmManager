namespace WoWRealmlistManager
{
    partial class GameSelect
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
            this.LGameList = new System.Windows.Forms.ListBox();
            this.BAddG = new System.Windows.Forms.Button();
            this.BRemoveG = new System.Windows.Forms.Button();
            this.BSelectG = new System.Windows.Forms.Button();
            this.LTest = new System.Windows.Forms.Label();
            this.BRename = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LGameList
            // 
            this.LGameList.FormattingEnabled = true;
            this.LGameList.Location = new System.Drawing.Point(93, 12);
            this.LGameList.Name = "LGameList";
            this.LGameList.Size = new System.Drawing.Size(189, 121);
            this.LGameList.TabIndex = 0;
            // 
            // BAddG
            // 
            this.BAddG.Location = new System.Drawing.Point(12, 12);
            this.BAddG.Name = "BAddG";
            this.BAddG.Size = new System.Drawing.Size(75, 23);
            this.BAddG.TabIndex = 1;
            this.BAddG.Text = "Add";
            this.BAddG.UseVisualStyleBackColor = true;
            this.BAddG.Click += new System.EventHandler(this.BAddG_Click);
            // 
            // BRemoveG
            // 
            this.BRemoveG.Location = new System.Drawing.Point(12, 70);
            this.BRemoveG.Name = "BRemoveG";
            this.BRemoveG.Size = new System.Drawing.Size(75, 23);
            this.BRemoveG.TabIndex = 2;
            this.BRemoveG.Text = "Remove";
            this.BRemoveG.UseVisualStyleBackColor = true;
            this.BRemoveG.Click += new System.EventHandler(this.BRemoveG_Click);
            // 
            // BSelectG
            // 
            this.BSelectG.Location = new System.Drawing.Point(12, 110);
            this.BSelectG.Name = "BSelectG";
            this.BSelectG.Size = new System.Drawing.Size(75, 23);
            this.BSelectG.TabIndex = 3;
            this.BSelectG.Text = "Select";
            this.BSelectG.UseVisualStyleBackColor = true;
            this.BSelectG.Click += new System.EventHandler(this.BSelectG_Click);
            // 
            // LTest
            // 
            this.LTest.AutoSize = true;
            this.LTest.Location = new System.Drawing.Point(9, 136);
            this.LTest.Name = "LTest";
            this.LTest.Size = new System.Drawing.Size(0, 13);
            this.LTest.TabIndex = 4;
            // 
            // BRename
            // 
            this.BRename.Location = new System.Drawing.Point(12, 41);
            this.BRename.Name = "BRename";
            this.BRename.Size = new System.Drawing.Size(75, 23);
            this.BRename.TabIndex = 5;
            this.BRename.Text = "Rename";
            this.BRename.UseVisualStyleBackColor = true;
            this.BRename.Click += new System.EventHandler(this.BRename_Click);
            // 
            // GameSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 200);
            this.Controls.Add(this.BRename);
            this.Controls.Add(this.LTest);
            this.Controls.Add(this.BSelectG);
            this.Controls.Add(this.BRemoveG);
            this.Controls.Add(this.BAddG);
            this.Controls.Add(this.LGameList);
            this.Name = "GameSelect";
            this.Text = "Game Select";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BAddG;
        private System.Windows.Forms.Button BRemoveG;
        private System.Windows.Forms.Button BSelectG;
        private System.Windows.Forms.Label LTest;
        public System.Windows.Forms.ListBox LGameList;
        private System.Windows.Forms.Button BRename;
    }
}