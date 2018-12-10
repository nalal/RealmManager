using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace WoWRealmlistManager
{
    public partial class GameSelectInput : Form
    {
        public GameSelectInput()
        {
            InitializeComponent();
        }

        //Opens directory select and pushes to TBDIR
        private void BBrowse_Click(object sender, EventArgs e)
        {
            FBDWoWDIR.ShowDialog();
            TBDIR.Text = FBDWoWDIR.SelectedPath;
        }

        //Adds game to game list from DIR with name
        private void BAccept_Click(object sender, EventArgs e)
        {
            if (TBName.Text == "" || TBDIR.Text == "")
            {
                LError.Text = "Please fill all";
            }
            else
            {
                string WoWName = TBName.Text;
                string WoWDIR = TBDIR.Text;
                string filetarget = Path.Combine(Main.wowdir, WoWName);
                if (File.Exists(filetarget) != true && File.Exists(Path.Combine(WoWDIR, "WoW.exe")) == true)
                {
                    File.Create(filetarget).Dispose();
                    var versionInfo = FileVersionInfo.GetVersionInfo(Path.Combine(WoWDIR, "WoW.exe"));
                    string version = versionInfo.ProductVersion;
                    string[] output =
                    {
                        "Name",
                        WoWName,
                        "Client Version",
                        version,
                        "Location",
                        WoWDIR
                    };
                    File.WriteAllLines(filetarget, output);
                    this.Close();
                }
                else if (File.Exists(filetarget) == true)
                {
                    LError.Text = "Entry exists with that name";
                }
                else if (File.Exists(Path.Combine(WoWDIR, "WoW.exe")) != true)
                {
                    LError.Text = "That DIR doesn't\n contain WoW.exe";
                }
            }
        }

        //Closes dialog
        private void BCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
