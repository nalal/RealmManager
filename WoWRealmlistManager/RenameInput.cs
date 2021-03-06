﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoWRealmlistManager
{
    public partial class RenameInput : Form
    {
        //Inits public var
        public static string newname = "";
        public RenameInput()
        {
            InitializeComponent();
        }

        //Sets public new name var
        private void BAccept_Click(object sender, EventArgs e)
        {
            if (TBName.Text != "")
            {
                newname = TBName.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Name cannot be blank","Input Error");
            }
        }

        //Closes dialog
        private void BCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
