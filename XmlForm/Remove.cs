using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sofxml
{
    public partial class Remove : Form
    {
        private string N_zach;
        private string Subject;
        private string Mark;
        public string subject
        {
            get { return Subject; }
            set { Subject = value; }
        }
        public string mark
        {
            get { return Mark; }
            set { Mark = value; }
        }
        public string n_zach
        {
            get { return N_zach; }
            set { N_zach = value; }
        }
        public Remove()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n_zach = textBoxZach.Text;
            subject = textBoxSubject.Text;
            mark = textBoxMark.Text;
        }
    }
}
