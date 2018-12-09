/*
 Program:
 Reamlist Manager
 
 Writen by:
 Nac/Nacalal/Nalal
 
 Initialization Date:
 Dec. 8th 2018
 */

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
    public partial class Main : Form
    {
        public static string game = "";
        public static string pdir = Path.GetDirectoryName(Application.ExecutablePath);
        public static string wowdir = Path.Combine(pdir, "WoWDIRs");
        public static string datadir = Path.Combine(pdir, "RLFiles");
        public Main()
        {
            InitializeComponent();
            Directory.CreateDirectory(wowdir);
        }

        private void BAdd_Click(object sender, EventArgs e)
        {
            if (game != "")
            {
                Form inp = new RealmlistInput();
                game = LCName.Text;
                inp.ShowDialog();
                if (RealmlistInput.RealmInput.filename != "")
                {
                    string addval = RealmlistInput.RealmInput.rli;
                    string fileval = RealmlistInput.RealmInput.filename;
                    //string realmfile = Path.Combine(datadir, game, fileval);
                    //LTest.Text = ("TEST:\n" + addval + "\n" + fileval + "\n" + realmfile);
                    RLList.Items.Add(addval);
                }
            }
            else
            {
                MessageBox.Show(Path.Combine("Please select a client"), "Input Error");
            }
        }

        private void BLoad_Click(object sender, EventArgs e)
        {
            if (game != "")
            {
                string activelist = Convert.ToString(RLList.SelectedItem);
                if (activelist != "")
                {
                    string filetarget = Path.Combine(datadir, game, activelist + ".wtf");

                    if (File.Exists(filetarget) == true)
                    {
                        File.Copy(filetarget, Path.Combine(LGameDIR.Text, "realmlist.wtf"), true);
                        MessageBox.Show(Path.Combine("File coppied, you can now launch your client"), "Opperation Complete");
                    }
                }
                else
                {
                    MessageBox.Show(Path.Combine("Please select a realmlist"), "Input Error");
                }
            }
            else
            {
                MessageBox.Show(Path.Combine("Please select a client"), "Input Error");
            }
         }

        private void BRemove_Click(object sender, EventArgs e)
        {
            if (game != "")
            {
                if (RLList.SelectedItem != null)
                {
                    string activelist = Convert.ToString(RLList.SelectedItem);
                    File.Delete(Path.Combine(datadir, game, activelist + ".wtf"));
                    RLList.Items.Remove(RLList.SelectedItem);
                }
                else
                {
                    MessageBox.Show(Path.Combine("Please select a realmlist"), "Input Error");
                }
            }
            else
            {
                MessageBox.Show(Path.Combine("Please select a client"), "Input Error");
            }
        }

        private void BSelectGame_Click(object sender, EventArgs e)
        {
            Form gsel = new GameSelect();
            RLList.Items.Clear();
            gsel.ShowDialog();
            LCName.Text = GameSelect.gamename;
            LGameDIR.Text = GameSelect.gamedir;
            LGameType.Text = GameSelect.gamever;
            game = LCName.Text;
            Directory.CreateDirectory(Path.Combine(datadir, game));
            if (Directory.GetFiles(datadir) != null)
            {
                RLList.Items.Clear();
                string[] RealmLists = Directory.GetFiles(Path.Combine(datadir, game));
                for (int i = 0; i < RealmLists.Length; i++)
                {
                    int rem = Path.Combine(datadir + game).Length + 1;
                    string add = RealmLists[i].Remove(0, (rem + 1));
                    string addclean = add.Replace(".wtf", "");
                    RLList.Items.Add(addclean);
                }
            }
        }

        private void BGameStart_Click(object sender, EventArgs e)
        {
            if (game != "")
            {
                Process.Start(Path.Combine(LGameDIR.Text, "WoW.exe"));
                Application.Exit();
            }
            else
            {
                MessageBox.Show(Path.Combine("Please select a client"), "Input Error");
            }
        }

        private void BAddFile_Click(object sender, EventArgs e)
        {
            if (game != "")
            {
                RealmFile.ShowDialog();
                if (RealmFile.FileName.Contains(".wtf"))
                {
                    string fileloc = RealmFile.FileName;
                    string filenm = RealmFile.SafeFileName;
                    string realmip = File.ReadAllText(fileloc);
                    game = LCName.Text;
                    realmip = realmip.Replace("set realmlist ", "");
                    //realmip = realmip.Remove(realmip.Length - 2);
                    if (!File.Exists(Path.Combine(datadir, game, realmip + ".wtf")))
                    {
                        File.Copy(fileloc, Path.Combine(datadir, game, realmip + ".wtf"));
                        RLList.Items.Clear();
                        string[] RealmLists = Directory.GetFiles(Path.Combine(datadir, game));
                        for (int i = 0; i < RealmLists.Length; i++)
                        {
                            int rem = Path.Combine(datadir + game).Length + 1;
                            string add = RealmLists[i].Remove(0, (rem + 1));
                            string addclean = add.Replace(".wtf", "");
                            RLList.Items.Add(addclean);
                        }
                    }
                    else if (File.Exists(Path.Combine(datadir, game, realmip + ".wtf")))
                    {
                        MessageBox.Show("That realmlist already exists", "Input error");
                    }
                }
                else if (!RealmFile.FileName.Contains(".wtf"))
                {
                    MessageBox.Show("Not a valid format", "Input error");
                }
            }
            else
            {
                MessageBox.Show("Please select a client", "Input error");
            }
        }
    }
}
