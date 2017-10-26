using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompareCSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCSV1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
            {
                txtPathCSV1.Text = openFileDialog1.FileName;
            }
        }

        private void btnCSV2_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtPathCSV2.Text = openFileDialog2.FileName;
            }
        }

        private void btnReadCSV1_Click(object sender, EventArgs e)
        {
            

            //List<string> columns = new List<string>();
            //using (var reader = new CsvFileReader(txtPathCSV1.Text))
            //{
            //    reader.Delimiter = '\t';
            //    while (reader.ReadRow(columns)) 
            //    {
            //        MessageBox.Show(columns[0] + "\t" + columns[1] + "\t" + columns[2] + "\t" + columns[3] + "\t" + columns[4]);
            //    }
            //}

            Dictionary<string, string> dictRet = readFileCSV(txtPathCSV1.Text, '\t', new List<int> { 0, 1, 2 }, new List<int> { 3, 4, 5 });

            foreach (string key in dictRet.Keys) {
                MessageBox.Show("key: " + key + "; value: " + dictRet[key]);
            }

        }
      
        private void btnCompareCSVFile_Click(object sender, EventArgs e)
        {
            string pathCSV1;
            string pathCSV2;
            pathCSV1 = txtPathCSV1.Text;
            pathCSV2 = txtPathCSV2.Text;



            if (string.IsNullOrEmpty(pathCSV1) || string.IsNullOrEmpty(pathCSV2))
            {
                MessageBox.Show("Choose files to compare", "Notify");
                return;
            }
            
            // read CSV1
            Dictionary<string, string> dictRet1 = readFileCSV(txtPathCSV1.Text, '\t', new List<int> { 0, 1, 2 }, new List<int> { 3, 4, 5 });
            // read CSV2
            Dictionary<string, string> dictRet2 = readFileCSV(txtPathCSV2.Text, '\t', new List<int> { 0, 1, 2 }, new List<int> { 3, 4, 5 });

            List<String> inserted = new List<string>();
            List<String> updated = new List<string>();
            List<String> deleted = new List<string>();

            // compare
            foreach (string k in dictRet1.Keys)
            {
                if (!dictRet2.ContainsKey(k))
                {
                    deleted.Add(k);
                }
                else
                {
                    if (!dictRet2[k].Equals(dictRet1[k]))
                    {
                        updated.Add(k);
                    }
                }
            }

            foreach (string k in dictRet2.Keys)
            {
                if (!dictRet1.ContainsKey(k))
                {
                    inserted.Add(k);
                }
            }


            //// print result
            if (inserted.Count == 0 && updated.Count == 0 && deleted.Count == 0)
                MessageBox.Show("Two file are identical!", "Notify");
            else
            {
                foreach (string key in inserted)
                {                    
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    row.Cells[0].Value = key;
                    row.Cells[1].Value = "inserted";
                    row.DefaultCellStyle.ForeColor = Color.Blue;
                    this.dataGridView1.Rows.Add(row);
                }
                foreach (string key in updated)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    row.Cells[0].Value = key;
                    row.Cells[1].Value = "updated";
                    row.DefaultCellStyle.ForeColor = Color.Green;
                    this.dataGridView1.Rows.Add(row);
                }
                foreach (string key in deleted)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    row.Cells[0].Value = key;
                    row.Cells[1].Value = "deleted";
                    row.DefaultCellStyle.ForeColor = Color.Red;
                    this.dataGridView1.Rows.Add(row);
                }
            }
        }


















        public Dictionary<string, string> readFileCSV(string filePath, char delimiter,
                                                      List<int> columnKeyIndexs,
                                                      List<int> columnValueIndexs)
        {
            Dictionary<string, string> dictRet = new Dictionary<string, string>();

            List<string> columns = new List<string>();

            using (var reader = new CsvFileReader(filePath, EmptyLineBehavior.Ignore))
            {
                reader.Delimiter = delimiter;
                while (reader.ReadRow(columns))
                {
                    String key = string.Empty;
                    String value = string.Empty;
                    foreach (int k in columnKeyIndexs)
                    {
                        key = key + columns[k] + " | ";
                    }

                    foreach (int v in columnValueIndexs)
                    {
                        value = value + columns[v];
                    }

                    dictRet.Add(key, value);
                }
            }

            return dictRet;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }        

    }
}
