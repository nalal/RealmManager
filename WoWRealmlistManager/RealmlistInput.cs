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
    public partial class RealmlistInput : Form
    {

        public RealmlistInput()
        {
            InitializeComponent();
        }

        public class RealmInput
        {
            public static string rli = "";
            public static string filename = "";
        }

        private void BAccept_Click(object sender, EventArgs e)
        {
            if (TBRInput.Text == "")
            {
                LRemoveSet.Text = "Input cannot be blank";
            }
            else if (TBRInput.Text.Contains("set realmlist") == true)
            {
                LRemoveSet.Text = "Please remove 'set realmlist'";
            } 
            else if (File.Exists(Path.Combine(Main.datadir, (TBRInput.Text + ".wtf"))) == true)
            {
                LRemoveSet.Text = "That realmlist already exists";
            }
            else
            {
                this.Close();
                RealmInput.rli = TBRInput.Text;
                RealmInput.filename = TBRInput.Text + ".wtf";
                string filename = RealmInput.filename;
                Directory.CreateDirectory(Main.datadir);
                File.Create(Path.Combine(Main.datadir, RealmInput.filename)).Dispose();
                using (TextWriter tw = new StreamWriter(Path.Combine(Main.datadir, RealmInput.filename)))
                {
                    tw.WriteLine("set realmlist " + TBRInput.Text);
                }
            }
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            RealmInput.filename = "";
            this.Close();
        }
    }
}
