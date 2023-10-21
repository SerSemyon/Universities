using System.Diagnostics.Tracing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Universities
{
    public partial class FormMain : Form
    {
        private List<University> allUniversities = new List<University>();
        private List<University> selectedUnivesities;
        private Dictionary<int, string> Cities = new Dictionary<int, string>();

        public FormMain()
        {
            InitializeComponent();
            LoadCities();
            LoadUniversities();
        }

        private void LoadCities()
        {
            cityComboBox.Items.Add("Все города");
            StreamReader reader = new StreamReader("City.txt");
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                int cityId = Convert.ToInt32(line.Split()[0].Trim(new char[] { '.' }));
                string cityName = line.Split()[1];
                cityComboBox.Items.Add(cityName);
                Cities.Add(cityId, cityName);
            }
            reader.Close();
        }

        private void LoadUniversities()
        {
            StreamReader reader = new StreamReader("Universities.txt");
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] words = line.Replace(",", "").Split();
                string name = words[1];
                int cityId = Convert.ToInt32(words[2]);
                University.counter = Convert.ToInt32(words[3]);
                allUniversities.Add(new University()
                {
                    id = University.counter,
                    name = name,
                    cityName = Cities[cityId],
                    imagePath = "Images\\" + University.counter + " " + name + ".jpg"
                });
            }
            selectedUnivesities = allUniversities;
            dataGridViewUniversities.DataSource = selectedUnivesities;
            reader.Close();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUniversity formUniversity = new FormUniversity(CreateUniversity);
            formUniversity.ShowDialog();
        }

        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = DetectSelectedUniversity();
            University selectedUniversity = allUniversities.FirstOrDefault(x => x.id == id);
            FormUniversity formUniversity = new FormUniversity(selectedUniversity, ChangeUniversity);
            formUniversity.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = DetectSelectedUniversity();
            selectedUnivesities = selectedUnivesities.Where(u => u.id != id).ToList();
            allUniversities = allUniversities.Where(u => u.id != id).ToList();
            dataGridViewUniversities.DataSource = selectedUnivesities;
        }

        private void cityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private int DetectSelectedUniversity()
        {
            int selectedRow = dataGridViewUniversities.CurrentRow.Index;
            string id = dataGridViewUniversities.Rows[selectedRow].Cells[0].Value.ToString();
            return Convert.ToInt32(id);
        }

        private void RefreshData()
        {
            if (cityComboBox.SelectedItem != null && cityComboBox.Text != "Все города")
            {
                selectedUnivesities = allUniversities.Where(u => u.cityName == cityComboBox.SelectedItem.ToString()).ToList();
                dataGridViewUniversities.DataSource = selectedUnivesities;
            }
            else
            {
                dataGridViewUniversities.DataSource = allUniversities.ToList();
            }
        }

        public void ChangeUniversity(University university, int id)
        {
            allUniversities[id - 1] = university;
            RefreshData();
        }

        public void CreateUniversity(University university)
        {
            allUniversities.Add(university);
            RefreshData();
        }

        private void dataGridViewUniversities_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = DetectSelectedUniversity();
            University selectedUniversity = allUniversities.FirstOrDefault(x => x.id == id);
            FormUniversity formUniversity = new FormUniversity(selectedUniversity, ChangeUniversity, true);
            formUniversity.ShowDialog();
        }
    }
}