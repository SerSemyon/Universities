using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Universities
{
    enum Mode
    {
        Create,
        Read,
        Change
    }
    public partial class FormUniversity : Form
    {
        University? university;
        Mode mode;

        public FormUniversity()
        {
            InitializeComponent();
            mode = Mode.Create;
        }

        public FormUniversity(University changingUniversity, bool onlyRead)
        {
            InitializeComponent();
            university = changingUniversity;
            if (onlyRead)
            {
                mode = Mode.Read;
            }
            else
            {
                mode = Mode.Change;
            }
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
