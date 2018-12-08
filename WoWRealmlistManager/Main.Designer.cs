namespace WoWRealmlistManager
{
    partial class Main
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
            this.BAdd = new System.Windows.Forms.Button();
            this.RLList = new System.Windows.Forms.ListBox();
            this.BRemove = new System.Windows.Forms.Button();
            this.BAddFile = new System.Windows.Forms.Button();
            this.BSelectGame = new System.Windows.Forms.Button();
            this.LLocation = new System.Windows.Forms.Label();
            this.LGameDIR = new System.Windows.Forms.Label();
            this.LGameType = new System.Windows.Forms.Label();
            this.LType = new System.Windows.Forms.Label();
            this.BGameStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BLoad = new System.Windows.Forms.Button();
            this.LCName = new System.Windows.Forms.Label();
            this.LActiveClient = new System.Windows.Forms.Label();
            this.RealmFile = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BAdd
            // 
            this.BAdd.Location = new System.Drawing.Point(12, 54);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(75, 23);
            this.BAdd.TabIndex = 0;
            this.BAdd.Text = "Add";
            this.BAdd.UseVisualStyleBackColor = true;
            this.BAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // RLList
            // 
            this.RLList.FormattingEnabled = true;
            this.RLList.Location = new System.Drawing.Point(93, 54);
            this.RLList.Name = "RLList";
            this.RLList.Size = new System.Drawing.Size(196, 199);
            this.RLList.TabIndex = 1;
            // 
            // BRemove
            // 
            this.BRemove.Location = new System.Drawing.Point(12, 112);
            this.BRemove.Name = "BRemove";
            this.BRemove.Size = new System.Drawing.Size(75, 23);
            this.BRemove.TabIndex = 2;
            this.BRemove.Text = "Remove";
            this.BRemove.UseVisualStyleBackColor = true;
            this.BRemove.Click += new System.EventHandler(this.BRemove_Click);
            // 
            // BAddFile
            // 
            this.BAddFile.Location = new System.Drawing.Point(12, 83);
            this.BAddFile.Name = "BAddFile";
            this.BAddFile.Size = new System.Drawing.Size(75, 23);
            this.BAddFile.TabIndex = 4;
            this.BAddFile.Text = "Add from file";
            this.BAddFile.UseVisualStyleBackColor = true;
            this.BAddFile.Click += new System.EventHandler(this.BAddFile_Click);
            // 
            // BSelectGame
            // 
            this.BSelectGame.Location = new System.Drawing.Point(298, 141);
            this.BSelectGame.Name = "BSelectGame";
            this.BSelectGame.Size = new System.Drawing.Size(180, 42);
            this.BSelectGame.TabIndex = 5;
            this.BSelectGame.Text = "Select Game";
            this.BSelectGame.UseVisualStyleBackColor = true;
            this.BSelectGame.Click += new System.EventHandler(this.BSelectGame_Click);
            // 
            // LLocation
            // 
            this.LLocation.AutoSize = true;
            this.LLocation.Location = new System.Drawing.Point(295, 110);
            this.LLocation.Name = "LLocation";
            this.LLocation.Size = new System.Drawing.Size(51, 13);
            this.LLocation.TabIndex = 6;
            this.LLocation.Text = "Location:";
            // 
            // LGameDIR
            // 
            this.LGameDIR.AutoSize = true;
            this.LGameDIR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LGameDIR.Location = new System.Drawing.Point(298, 123);
            this.LGameDIR.Name = "LGameDIR";
            this.LGameDIR.Size = new System.Drawing.Size(98, 15);
            this.LGameDIR.TabIndex = 7;
            this.LGameDIR.Text = "No game selected!";
            // 
            // LGameType
            // 
            this.LGameType.AutoSize = true;
            this.LGameType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LGameType.Location = new System.Drawing.Point(298, 95);
            this.LGameType.Name = "LGameType";
            this.LGameType.Size = new System.Drawing.Size(98, 15);
            this.LGameType.TabIndex = 9;
            this.LGameType.Text = "No game selected!";
            // 
            // LType
            // 
            this.LType.AutoSize = true;
            this.LType.Location = new System.Drawing.Point(295, 82);
            this.LType.Name = "LType";
            this.LType.Size = new System.Drawing.Size(42, 13);
            this.LType.TabIndex = 8;
            this.LType.Text = "Version";
            // 
            // BGameStart
            // 
            this.BGameStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGameStart.Location = new System.Drawing.Point(12, 259);
            this.BGameStart.Name = "BGameStart";
            this.BGameStart.Size = new System.Drawing.Size(466, 42);
            this.BGameStart.TabIndex = 10;
            this.BGameStart.Text = "START WORLD OF WARCRAFT";
            this.BGameStart.UseVisualStyleBackColor = true;
            this.BGameStart.Click += new System.EventHandler(this.BGameStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "Realmlist Manager";
            // 
            // BLoad
            // 
            this.BLoad.Location = new System.Drawing.Point(12, 230);
            this.BLoad.Name = "BLoad";
            this.BLoad.Size = new System.Drawing.Size(75, 23);
            this.BLoad.TabIndex = 13;
            this.BLoad.Text = "Load";
            this.BLoad.UseVisualStyleBackColor = true;
            this.BLoad.Click += new System.EventHandler(this.BLoad_Click);
            // 
            // LCName
            // 
            this.LCName.AutoSize = true;
            this.LCName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LCName.Location = new System.Drawing.Point(298, 67);
            this.LCName.Name = "LCName";
            this.LCName.Size = new System.Drawing.Size(98, 15);
            this.LCName.TabIndex = 14;
            this.LCName.Text = "No game selected!";
            // 
            // LActiveClient
            // 
            this.LActiveClient.AutoSize = true;
            this.LActiveClient.Location = new System.Drawing.Point(295, 54);
            this.LActiveClient.Name = "LActiveClient";
            this.LActiveClient.Size = new System.Drawing.Size(66, 13);
            this.LActiveClient.TabIndex = 15;
            this.LActiveClient.Text = "Active Client";
            // 
            // RealmFile
            // 
            this.RealmFile.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Realmlists:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(487, 353);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LActiveClient);
            this.Controls.Add(this.LCName);
            this.Controls.Add(this.BLoad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BGameStart);
            this.Controls.Add(this.LGameType);
            this.Controls.Add(this.LType);
            this.Controls.Add(this.LGameDIR);
            this.Controls.Add(this.LLocation);
            this.Controls.Add(this.BSelectGame);
            this.Controls.Add(this.BAddFile);
            this.Controls.Add(this.BRemove);
            this.Controls.Add(this.RLList);
            this.Controls.Add(this.BAdd);
            this.Name = "Main";
            this.Text = "Realmlist Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BAdd;
        private System.Windows.Forms.Button BRemove;
        private System.Windows.Forms.Button BAddFile;
        private System.Windows.Forms.Button BSelectGame;
        private System.Windows.Forms.Label LLocation;
        private System.Windows.Forms.Label LGameDIR;
        private System.Windows.Forms.Label LGameType;
        private System.Windows.Forms.Label LType;
        private System.Windows.Forms.Button BGameStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BLoad;
        private System.Windows.Forms.Label LCName;
        private System.Windows.Forms.Label LActiveClient;
        private System.Windows.Forms.OpenFileDialog RealmFile;
        public System.Windows.Forms.ListBox RLList;
        private System.Windows.Forms.Label label2;
    }
}

