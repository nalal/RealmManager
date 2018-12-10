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

namespace WoWRealmlistManager
{
    public partial class GameSelect : Form
    {
        //Inits public vars for main
        public static string gamename = "";
        public static string gamever = "";
        public static string gamedir = "";
        public GameSelect()
        {
            InitializeComponent();
            //Checks for games and adds them to list
            if (Directory.GetFiles(Main.wowdir) != null)
            {
                string[] DIRLists = Directory.GetFiles(Main.wowdir);
                for (int i = 0; i < DIRLists.Length; i++)
                {
                    int rem = Main.wowdir.Length;
                    string add = DIRLists[i].Remove(0, (rem + 1));
                    LGameList.Items.Add(add);
                }
            }
        }

        //Adds item to game list
        private void BAddG_Click(object sender, EventArgs e)
        {
            Form GS = new GameSelectInput();
            GS.ShowDialog();
            LGameList.Items.Clear();
            string[] DIRLists = Directory.GetFiles(Main.wowdir);
            for (int i = 0; i < DIRLists.Length; i++)
            {
                int rem = Main.wowdir.Length;
                string add = DIRLists[i].Remove(0, (rem + 1));
                LGameList.Items.Add(add);
            }
        }

        //Removes item from game list
        private void BRemoveG_Click(object sender, EventArgs e)
        {
            if (LGameList.SelectedItem != null)
            {
                File.Delete(Path.Combine(Main.wowdir, Convert.ToString(LGameList.SelectedItem)));
                LGameList.Items.Remove(LGameList.SelectedItem);
                LGameList.Items.Clear();
                if (Directory.GetFiles(Main.wowdir) != null)
                {
                    string[] DIRLists = Directory.GetFiles(Main.wowdir);
                    for (int i = 0; i < DIRLists.Length; i++)
                    {
                        int rem = Main.wowdir.Length;
                        string add = DIRLists[i].Remove(0, (rem + 1));
                        LGameList.Items.Add(add);
                    }
                }
            }
        }

        //Selects game from list and passes data to public vars
        private void BSelectG_Click(object sender, EventArgs e)
        {
            if (LGameList.SelectedItem != null)
            {
                string filetarget = Path.Combine(Main.wowdir, Convert.ToString(LGameList.SelectedItem));
                string filename = File.ReadLines(filetarget).Skip(1).Take(1).First();
                string filever = File.ReadLines(filetarget).Skip(3).Take(1).First();
                string filedir = File.ReadLines(filetarget).Skip(5).Take(1).First();
                gamedir = filedir;
                gamename = filename;
                gamever = filever;


                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a client","Input error");
            }
        }

        //Renames item in list
        private void BRename_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(LGameList.SelectedItem) != "")
            {
                Form prompt = new RenameInput();
                prompt.ShowDialog();
                if (RenameInput.newname != "")
                {
                    string newname = RenameInput.newname;
                    string oldname = Convert.ToString(LGameList.SelectedItem);
                    File.Move(Path.Combine(Main.pdir, "WoWDIRs", oldname), Path.Combine(Main.pdir, "WoWDIRs", newname));
                    Directory.CreateDirectory(Path.Combine(Main.datadir, newname));
                    foreach (string newPath in Directory.GetFiles(Path.Combine(Main.datadir, oldname), "*.*",
                        SearchOption.AllDirectories))
                        File.Copy(newPath, newPath.Replace(Path.Combine(Main.datadir, oldname), Path.Combine(Main.datadir, newname)), true);
                    Directory.Delete(Path.Combine(Main.datadir, oldname), true);
                }
                if (Directory.GetFiles(Main.wowdir) != null)
                {
                    LGameList.Items.Clear();
                    string[] DIRLists = Directory.GetFiles(Main.wowdir);
                    for (int i = 0; i < DIRLists.Length; i++)
                    {
                        int rem = Main.wowdir.Length;
                        string add = DIRLists[i].Remove(0, (rem + 1));
                        LGameList.Items.Add(add);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a client", "Input Error");
            }
        }
    }
}
