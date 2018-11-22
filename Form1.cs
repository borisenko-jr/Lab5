using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetUserName
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetUserName_Click(object sender, EventArgs e)
        {
            StringBuilder builder = new StringBuilder(100);
            uint size = 100;
            WinAPIClass.GetUserNameEx((int)WinAPIClass.NameFormat.NameSamCompatible, builder, ref size);
            lblGetUserName.Text = String.Format("Имя пользователя: {0}", builder.ToString());
        }
    }
}
