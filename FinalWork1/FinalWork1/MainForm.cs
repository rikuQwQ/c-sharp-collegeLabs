using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO.Compression;
using System.IO;
using System.Collections;

namespace FinalWork1
{
    public partial class MainForm : Form
    {
        public static List<Housing> hh = new List<Housing>();
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            AddHousing(new Flat("Сколов Р.А.", "Квартира", "ул.Некрасова", 77, 2, 6));
            AddHousing(new House("Сколова Т.А.", "Дом", "пр.Мира", 123, 2));

            ShowList();
        }
        public void AddHousing(Housing housing)
        {
            hh.Add(housing);
        }
        public void ShowList()
        {
            listView.Items.Clear();
            foreach (var h in hh)
            {
                listView.Items.Add("Владелец: " + h.MyFio);
                listView.Items.Add("Характеристика:");
                listView.Items.Add(h.Adress());
                listView.Items.Add("");
            }
        }
        private void btnShowList_Click(object sender, EventArgs e)
        {
            ShowList();
        }

        private void btnAddObject_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(hh);
            addForm.ShowDialog();
            ShowList();
        }

        private void btnDeleteLastObject_Click(object sender, EventArgs e)
        {
            try
            {
                hh.RemoveAt(hh.Count - 1);
            }
            catch
            {
                MessageBox.Show("Нет записей для удаления");
            }
            ShowList();
        }

        private void btnSortByFullname_Click(object sender, EventArgs e)
        {
            hh.Sort();
            ShowList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
            saveFileDialog1.ShowDialog();
            string path = saveFileDialog1.FileName;

            string s = DateTime.Now.ToString("dd.MM.yy hh.mm");

            try
            {
                FileStream fs = new FileStream(@path, FileMode.OpenOrCreate);
                GZipStream gzs = new GZipStream(fs, CompressionMode.Compress);
                BinaryFormatter bf = new BinaryFormatter();

                bf.Serialize(gzs, hh);

                gzs.Close();
                fs.Close();
                MessageBox.Show("Файл сохранен");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
                return;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            hh.Clear();
            ShowList();

            openFileDialog1.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
            openFileDialog1.ShowDialog();
            string path = openFileDialog1.FileName;

            if (path != "")
            {
                try
                {
                    FileStream fs = new FileStream(@path, FileMode.OpenOrCreate);
                    GZipStream gzs = new GZipStream(fs, CompressionMode.Decompress);
                    BinaryFormatter bf = new BinaryFormatter();

                    hh = (List<Housing>)bf.Deserialize(gzs);

                    gzs.Close();
                    fs.Close();
                    ShowList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                    return;
                }

            }
        }
    }
}
