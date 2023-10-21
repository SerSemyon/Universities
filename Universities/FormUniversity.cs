using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
        University university;
        Mode mode;
        UniversityChanger? changer;
        UniversityCreator? creator;

        public FormUniversity(UniversityCreator creator)
        {
            InitializeComponent();
            mode = Mode.Create;
            university = new University();
            this.creator = creator;
            this.Text = "Создание нового университета";
        }

        public FormUniversity(University changingUniversity, UniversityChanger changer, bool onlyRead = false)
        {
            InitializeComponent();
            university = changingUniversity;
            textBoxName.Text = university.name;
            this.Text = university.name;
            textBoxCity.Text = university.cityName;
            pictureBox.ImageLocation = university.imagePath;
            if (onlyRead)
            {
                mode = Mode.Read;
                textBoxName.ReadOnly = true;
                textBoxCity.ReadOnly = true;
            }
            else
            {
                mode = Mode.Change;
                this.changer = changer;
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            if (mode == Mode.Read)
                return;
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            pictureBox.ImageLocation = openFileDialog1.FileName;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (mode == Mode.Create)
            {
                University.counter++;
                University newUniversity = new University()
                {
                    id = University.counter,
                    name = textBoxName.Text,
                    cityName = textBoxCity.Text,
                    imagePath = pictureBox.ImageLocation
                };
                creator?.Invoke(newUniversity);
            }
            if (mode == Mode.Change)
            {
                University newUniversity = new University()
                {
                    id = university.id,
                    name = textBoxName.Text,
                    cityName = textBoxCity.Text,
                    imagePath = pictureBox.ImageLocation
                };
                changer?.Invoke(newUniversity, university.id);
            }
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
