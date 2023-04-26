using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Author : Form
    {
        public Author()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Author_Load(object sender, EventArgs e)
        {
            string CurDir = System.IO.Directory.GetCurrentDirectory();
            wbAuthor.Url = new Uri(String.Format("file:///{0}/author.html", CurDir));
            wbAuthor.ScriptErrorsSuppressed = true;
        }
    }
}
