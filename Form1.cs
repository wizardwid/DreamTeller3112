using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DreamTeller3112
{
    public partial class Form1 : Form
    {
        List<string> results;

        public Form1()
        {
            InitializeComponent();
            LoadResults();
        }

        private void LoadResults()
        {
            try
            {
                string exePath = AppDomain.CurrentDomain.BaseDirectory; // 실행 파일 경로
                string filename = Path.Combine(exePath, "results.csv");
                results = File.ReadAllLines(filename)
                              .Where(line => !string.IsNullOrWhiteSpace(line))
                              .ToList();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"결과 파일을 찾을 수 없습니다.\n{ex.Message}", "파일 없음");
                results = new List<string>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"알 수 없는 오류가 발생했습니다.\n{ex.Message}", "오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                results = new List<string>();
            }
        }

        private string GetDreamInterpretation(string keyword)
        {
            if (results == null || results.Count == 0)
                return "해몽 데이터가 없습니다.";

            var filtered = results.Where(r => r.Split('|')[0].Contains(keyword)).ToList();
            if (filtered.Count == 0)
                return "해당 키워드와 관련된 꿈이 없습니다.";

            Random random = new Random();
            int index = random.Next(filtered.Count);
            return filtered[index];
        }

        private void btnShowResult_Click(object sender, EventArgs e)
        {
            string keyword = tbDreamKeyword.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("꿈 키워드를 입력해주세요.");
                return;
            }

            string result = GetDreamInterpretation(keyword);

            if (result == "해당 키워드와 관련된 꿈이 없습니다." ||
                result == "해몽 데이터가 없습니다.")
            {
                tbResult.Text = result;
                return;
            }

            string dream = result.Split('|')[0];
            string meaning = result.Split('|')[1];

            tbResult.Text = $"[당신의 꿈: {keyword}]\r\n" +
                            $"꿈: {dream}\r\n" +
                            $"해몽: {meaning}";

            SaveHistory($"{keyword}|{dream}|{meaning}");
        }

        private void SaveHistory(string history)
        {
            try
            {
                string filename = "history.csv";
                string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                File.AppendAllText(filename, $"{timestamp}|{history}{Environment.NewLine}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"내역 저장 중 오류 발생\n{ex.Message}", "파일 오류");
            }
        }

        internal void LoadHistory(string history)
        {
            string[] parts = history.Split('|');
            if (parts.Length < 4) return;

            string timestamp = parts[0];
            string keyword = parts[1];
            string dream = parts[2];
            string meaning = parts[3];

            tbDreamKeyword.Text = keyword.Trim();
            tbResult.Text = $"[상담 시각: {timestamp}]\r\n" +
                            $"[당신의 꿈: {keyword}]\r\n" +
                            $"꿈: {dream}\r\n" +
                            $"해몽: {meaning}";
        }

        private void 상담내역불러오기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistory form = Application.OpenForms["FormHistory"] as FormHistory;
            if (form != null) form.Activate();
            else
            {
                form = new FormHistory(this);
                form.Show();
            }
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 포춘텔러정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout form = new FormAbout();
            form.ShowDialog();
        }

        private void groupBox2_Enter(object sender, EventArgs e) { }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }

        private void 내역불러오기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            상담내역불러오기ToolStripMenuItem_Click(sender, e);
        }
    }
}