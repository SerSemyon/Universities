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
        University? lastCopy;
        University university;
        Mode mode;

        public FormUniversity()
        {
            InitializeComponent();
            mode = Mode.Create;
            university = new University();
        }

        public FormUniversity(University changingUniversity, bool onlyRead)
        {
            InitializeComponent();
            lastCopy = changingUniversity;
            university = changingUniversity;
            textBoxName.Text = university.name;
            textBoxCity.Text = university.cityName;
            pictureBox.ImageLocation = "Images\\" + university.id + " " + university.name + ".jpg";
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

        private void pictureBox_Click(object sender, EventArgs e)
        {
            if (mode != Mode.Create)
                return;
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            pictureBox.ImageLocation = openFileDialog1.FileName;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
