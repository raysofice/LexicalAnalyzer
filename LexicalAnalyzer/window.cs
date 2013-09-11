using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Analysis;

namespace LexicalAnalyzer
{
    public partial class window : Form
    {
        private Analyse Analyse;
        public window()
        {
            InitializeComponent();
        }

        private void window_Load(object sender, EventArgs e)
        {
            Analyse = new Analyse();
        }

        public string Trim(string input)
        {
            input = input.Replace("\r", "").Replace(" ", "").Replace("\t", "");
            while (input.Contains("\n\n"))
            {
                input = input.Replace("\n\n", "\n");
            }
            if (input.StartsWith("\n"))
            {
                input = input.Substring(1);
            }
            if (input.EndsWith("\n"))
            {
                input = input.Substring(0, input.Length - 1);
            }
            return input;
        }

        private void WorkButton_Click(object sender, EventArgs e)
        {
            string input = InBox.Text.Replace("\r","").Replace("\t"," ");
            if (input == string.Empty)
            {
                return;
            }
            Analyse.Work(input.Split('\n'));
            BindToken();
        }

        private void BindToken()
        {
            ResultView.GridLines = true;
            ResultView.View = View.Details;
            ResultView.Clear();
            ResultView.Columns.Add("ID", 40);
            ResultView.Columns.Add("类型", 100);
            ResultView.Columns.Add("内容", 120);
            ResultView.Columns.Add("行", 40);
            ResultView.Columns.Add("列", 40);
            foreach (Token log in Analyse.Token)
            {
                List<String> a = new List<string>();
                a.Add(log.Id.ToString());
                a.Add(log.Type.ToString());
                a.Add(log.Content);
                a.Add(log.Row.ToString());
                a.Add(log.Column.ToString());
                ListViewItem listViewItem = new ListViewItem(a.ToArray());
                ResultView.Items.Add(listViewItem);
            }
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string ins = "→";
            int select = identifierText.SelectionStart;
            string s1 = identifierText.Text.Substring(0, select);
            string s2 = identifierText.Text.Substring(select);
            identifierText.Text = s1 + ins + s2;
            identifierText.Select(select + ins.Length, 0);
            identifierText.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string ins = "ε";
            int select = identifierText.SelectionStart;
            string s1 = identifierText.Text.Substring(0, select);
            string s2 = identifierText.Text.Substring(select);
            identifierText.Text = s1 + ins + s2;
            identifierText.Select(select + ins.Length, 0);
            identifierText.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "text(*.txt)|*.txt";
            openFileDialog.ShowDialog();
            string fileName = openFileDialog.FileName;
            try
            {
                identifierText.Text = File.ReadAllText(fileName, System.Text.Encoding.Default).Replace("\r", "");
            }
            catch { }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string ins = "→";
            int select = constantText.SelectionStart;
            string s1 = constantText.Text.Substring(0, select);
            string s2 = constantText.Text.Substring(select);
            constantText.Text = s1 + ins + s2;
            constantText.Select(select + ins.Length, 0);
            constantText.Focus();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string ins = "ε";
            int select = constantText.SelectionStart;
            string s1 = constantText.Text.Substring(0, select);
            string s2 = constantText.Text.Substring(select);
            constantText.Text = s1 + ins + s2;
            constantText.Select(select + ins.Length, 0);
            constantText.Focus();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "text(*.txt)|*.txt";
            openFileDialog.ShowDialog();
            string fileName = openFileDialog.FileName;
            try
            {
                constantText.Text = File.ReadAllText(fileName, System.Text.Encoding.Default).Replace("\r", "");
            }
            catch { }
        }

        private void saveConstantButton_Click(object sender, EventArgs e)
        {
            if (constantText.Text == "")
            {
                MessageBox.Show("文法框不能为空");
                return;
            }
            string output = constantText.Text.Replace("\n", "\r\n");
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "text(*.txt)|*.txt";
            saveFileDialog.ShowDialog();
            string fileName = saveFileDialog.FileName;
            try
            {
                File.WriteAllText(fileName, output, System.Text.Encoding.Default);
                MessageBox.Show("保存成功");
            }
            catch (Exception)
            {
                MessageBox.Show("保存失败");
            }
        }

        private void saveidentifierbutton_Click(object sender, EventArgs e)
        {
            if (identifierText.Text == "")
            {
                MessageBox.Show("文法框不能为空");
                return;
            }
            string output = identifierText.Text.Replace("\n", "\r\n");
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "text(*.txt)|*.txt";
            saveFileDialog.ShowDialog();
            string fileName = saveFileDialog.FileName;
            try
            {
                File.WriteAllText(fileName, output, System.Text.Encoding.Default);
                MessageBox.Show("保存成功");
            }
            catch (Exception)
            {
                MessageBox.Show("保存失败");
            }
        }

        private void identifierImportButton_Click(object sender, EventArgs e)
        {
            string input = Trim(identifierText.Text);
            if (input == string.Empty)
            {
                return;
            }                 
            Analyse.AddDFA(input.Split('\n'),WordType.Identifier);
            MessageBox.Show("导入成功");
            //Identifiercheck.Checked = true;

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string input = Trim(constantText.Text);
            if (input == string.Empty)
            {
                return;
            }
            Analyse.AddDFA(input.Split('\n'), WordType.Constant);
            MessageBox.Show("导入成功");
            //Constantcheck.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "text(*.txt)|*.txt";
            openFileDialog.ShowDialog();
            string fileName = openFileDialog.FileName;
            try
            {
                InBox.Text = File.ReadAllText(fileName, System.Text.Encoding.Default).Replace("\r", "");
            }
            catch { }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string ins = "→";
            int select = keyWordText.SelectionStart;
            string s1 = keyWordText.Text.Substring(0, select);
            string s2 = keyWordText.Text.Substring(select);
            keyWordText.Text = s1 + ins + s2;
            keyWordText.Select(select + ins.Length, 0);
            keyWordText.Focus();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string ins = "→";
            int select = operatorText.SelectionStart;
            string s1 = operatorText.Text.Substring(0, select);
            string s2 = operatorText.Text.Substring(select);
            operatorText.Text = s1 + ins + s2;
            operatorText.Select(select + ins.Length, 0);
            operatorText.Focus();
        }

        private void constantText_TextChanged(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            string ins = "→";
            int select = delimiterText.SelectionStart;
            string s1 = delimiterText.Text.Substring(0, select);
            string s2 = delimiterText.Text.Substring(select);
            delimiterText.Text = s1 + ins + s2;
            delimiterText.Select(select + ins.Length, 0);
            delimiterText.Focus();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string ins = "ε";
            int select = operatorText.SelectionStart;
            string s1 = operatorText.Text.Substring(0, select);
            string s2 = operatorText.Text.Substring(select);
            operatorText.Text = s1 + ins + s2;
            operatorText.Select(select + ins.Length, 0);
            operatorText.Focus();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string ins = "ε";
            int select = delimiterText.SelectionStart;
            string s1 = delimiterText.Text.Substring(0, select);
            string s2 = delimiterText.Text.Substring(select);
            delimiterText.Text = s1 + ins + s2;
            delimiterText.Select(select + ins.Length, 0);
            delimiterText.Focus();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "text(*.txt)|*.txt";
            openFileDialog.ShowDialog();
            string fileName = openFileDialog.FileName;
            try
            {
                keyWordText.Text = File.ReadAllText(fileName, System.Text.Encoding.Default).Replace("\r", "");
            }
            catch { }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "text(*.txt)|*.txt";
            openFileDialog.ShowDialog();
            string fileName = openFileDialog.FileName;
            try
            {
                operatorText.Text = File.ReadAllText(fileName, System.Text.Encoding.Default).Replace("\r", "");
            }
            catch { }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "text(*.txt)|*.txt";
            openFileDialog.ShowDialog();
            string fileName = openFileDialog.FileName;
            try
            {
                delimiterText.Text = File.ReadAllText(fileName, System.Text.Encoding.Default).Replace("\r", "");
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (keyWordText.Text == "")
            {
                MessageBox.Show("文法框不能为空");
                return;
            }
            string output = keyWordText.Text.Replace("\n", "\r\n");
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "text(*.txt)|*.txt";
            saveFileDialog.ShowDialog();
            string fileName = saveFileDialog.FileName;
            try
            {
                File.WriteAllText(fileName, output, System.Text.Encoding.Default);
                MessageBox.Show("保存成功");
            }
            catch (Exception)
            {
                MessageBox.Show("保存失败");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (operatorText.Text == "")
            {
                MessageBox.Show("文法框不能为空");
                return;
            }
            string output = operatorText.Text.Replace("\n", "\r\n");
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "text(*.txt)|*.txt";
            saveFileDialog.ShowDialog();
            string fileName = saveFileDialog.FileName;
            try
            {
                File.WriteAllText(fileName, output, System.Text.Encoding.Default);
                MessageBox.Show("保存成功");
            }
            catch (Exception)
            {
                MessageBox.Show("保存失败");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (delimiterText.Text == "")
            {
                MessageBox.Show("文法框不能为空");
                return;
            }
            string output = delimiterText.Text.Replace("\n", "\r\n");
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "text(*.txt)|*.txt";
            saveFileDialog.ShowDialog();
            string fileName = saveFileDialog.FileName;
            try
            {
                File.WriteAllText(fileName, output, System.Text.Encoding.Default);
                MessageBox.Show("保存成功");
            }
            catch (Exception)
            {
                MessageBox.Show("保存失败");
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            string input = Trim(delimiterText.Text);
            if (input == string.Empty)
            {
                return;
            }
            Analyse.AddDFA(input.Split('\n'), WordType.Delimiter);
            MessageBox.Show("导入成功");
            //Delimitercheck.Checked = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string input = Trim(keyWordText.Text);
            if (input == string.Empty)
            {
                return;
            }
            Analyse.AddDFA(input.Split('\n'), WordType.KeyWord);
            MessageBox.Show("导入成功");
            //KeyWordcheck.Checked = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string input = Trim(operatorText.Text);
            if (input == string.Empty)
            {
                return;
            }
            Analyse.AddDFA(input.Split('\n'), WordType.Operator);
            MessageBox.Show("导入成功");
            //Operatorcheck.Checked = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ins = "ε";
            int select = keyWordText.SelectionStart;
            string s1 = keyWordText.Text.Substring(0, select);
            string s2 = keyWordText.Text.Substring(select);
            keyWordText.Text = s1 + ins + s2;
            keyWordText.Select(select + ins.Length, 0);
            keyWordText.Focus();
        }

        private void DelimiterPage_Click(object sender, EventArgs e)
        {

        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            if (KeyWordcheck.Checked && Analyse.DFAs.ContainsKey(WordType.KeyWord))
            {
                Analyse.DFAs.Remove(WordType.KeyWord);
            }
            if(Identifiercheck.Checked && Analyse.DFAs.ContainsKey(WordType.Identifier))
            {
                Analyse.DFAs.Remove(WordType.Identifier);
            }
            if (Constantcheck.Checked && Analyse.DFAs.ContainsKey(WordType.Constant))
            {
                Analyse.DFAs.Remove(WordType.Constant);
            }
            if (Operatorcheck.Checked && Analyse.DFAs.ContainsKey(WordType.Operator))
            {
                Analyse.DFAs.Remove(WordType.Operator);
            }
            if (Delimitercheck.Checked && Analyse.DFAs.ContainsKey(WordType.Delimiter))
            {
                Analyse.DFAs.Remove(WordType.Delimiter);
            }
            MessageBox.Show("移除成功");
            /*if (KeyWordcheck.Checked)
            {
                string input = Trim(keyWordText.Text);
                if (input == string.Empty)
                {
                    return;
                }
                try
                {
                    Analyse.AddDFA(input.Split('\n'), WordType.KeyWord);
                }
                catch { }
            }
            if(Identifiercheck.Checked)
            {
                string input = Trim(identifierText.Text);
                if (input == string.Empty)
                {
                    return;
                }                 
                Analyse.AddDFA(input.Split('\n'),WordType.Identifier);
            }
            if (Constantcheck.Checked)
            {
                string input = Trim(constantText.Text);
                if (input == string.Empty)
                {
                    return;
                }
                Analyse.AddDFA(input.Split('\n'), WordType.Constant);
            }
            if (Operatorcheck.Checked)
            {
                string input = Trim(operatorText.Text);
                if (input == string.Empty)
                {
                    return;
                }
                Analyse.AddDFA(input.Split('\n'), WordType.Operator);
            }
            if(Delimitercheck.Checked)
            {
                string input = Trim(delimiterText.Text);
                if (input == string.Empty)
                {
                    return;
                }
                Analyse.AddDFA(input.Split('\n'), WordType.Delimiter);
            }
            MessageBox.Show("导入成功");
             * */
        }

        private void Delimitercheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        
    }

}
