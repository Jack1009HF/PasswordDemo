using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PasswordDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ckBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(ckBoxPassword.Checked)
            {
                tBoxPassword.PasswordChar = '\0';   //直接显示输入
            }
            else
            {
                tBoxPassword.PasswordChar = '*';   //直接显示*
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ckBoxPassword_CheckedChanged(sender,e);
        }
    }
}
