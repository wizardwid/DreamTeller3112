using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DreamTeller3112
{
    public partial class FormHistory : Form
    {
        List<string> history;
        Form1 form1;

        public FormHistory(Form1 form)
        {
            this.form1 = form;
            InitializeComponent();
            UpdateHistory();
        }

        private void LoadHistory()
        {
            try
            {
                string filename = "history.csv";
                history = File.ReadAllLines(filename).ToList();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"파일을 불러올 수 없습니다.\n{ex.Message}", "파일 없음");
                history = new List<string>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"알 수 없는 오류가 발생했습니다.\n{ex.Message}", "알 수 없는 오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                history = new List<string>();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateHistory();
        }

        public void UpdateHistory()
        {
            LoadHistory();
            lbHistory.Items.Clear();
            lbHistory.Items.AddRange(history.ToArray());
        }

        private void lbHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbHistory.SelectedIndex >= 0)
            {
                string message = history[lbHistory.SelectedIndex];
                form1.LoadHistory(message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}