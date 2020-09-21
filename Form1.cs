using System;
using System.Windows.Forms;
using System.IO;

namespace Caesar_Code
{
    public partial class form : Form
    {
        private coder coding = new coder();
        public form()
        {
            InitializeComponent();
        }

        private void code_Click(object sender, EventArgs e)
        {
            coding.set_str(input.Text);
            try { coding.set_shift(Convert.ToInt32(shift.Text)); }
            catch { MessageBox.Show("Input error in shift.Text!"); }
            coding.do_code();
            output_code.Text = coding.get_str;
            coding.clear();
        }

        private void Smart_Decode_Click(object sender, EventArgs e)
        {
            string line = input.Text;
            line.Trim(' ');
            int counter = 0, index = -1;
            for (int i = 0; i < line.Length; i++)
            {
                try {if ((line[i] == ' ') && (line[i + 1] != ' ')) counter++;}
                catch { }
            }
            string[] words = new string[counter + 1];
            counter = 0;
            for (int i = 0; i < line.Length; i++)
            {
                try
                {
                    if (line[i] != ' ') words[counter] += line[i];
                    else if ((line[i] == ' ') && (line[i + 1] != ' ')) counter++;
                }
                catch { }
            }
            output_code.Text = "";
            for (int j = 0; j < words.Length; j++)
            {
                for(int i = 0; i < 26; i++)
                {
                    if(words[j] != "")
                    {
                        coding.set_str(words[j]);
                        coding.set_shift(i);
                        coding.do_decode();
                        string variat = coding.get_str;
                        StreamReader ENGwords = new StreamReader("ENGwords");
                        while (!ENGwords.EndOfStream)
                        {
                            if (go_small(coding.get_str) == ENGwords.ReadLine())
                            {
                                index++;
                                coding.set_str(line);
                                coding.set_shift(i);
                                coding.do_decode();
                                output_code.Text += coding.get_str;
                                coding.clear();
                                coding.set_str(words[j]);
                                coding.set_shift(i);
                                coding.do_decode();
                                output_code.Text += " // " + go_small(coding.get_str) + Environment.NewLine;
                            }
                        }
                        coding.clear();
                    }
                }
            }
            if (index == -1) MessageBox.Show("Error, word not founded!");
        }

        private void decode_Click(object sender, EventArgs e)
        {
            coding.set_str(input.Text);
            try { coding.set_shift(Convert.ToInt32(shift.Text)); }
            catch { MessageBox.Show("Input error in shift.Text!"); }
            coding.do_decode();
            output_code.Text = coding.get_str;
            coding.clear();
        }

        private void decode_all_Click(object sender, EventArgs e)
        {
            output_code.Text = null;
            string[] variants = new string[26];
            for (int i = 0; i < 26; i++)
            {
                coding.set_str(input.Text);
                coding.set_shift(i);
                coding.do_decode();
                variants[i] = coding.get_str;
                output_code.Text += variants[i] + Environment.NewLine;
            }
        }

        private void cls_Click(object sender, EventArgs e) => input.Text = "";

        private void cls_all_Click(object sender, EventArgs e)
        {
            cls.PerformClick();
            shift.Text = "0";
        }

        private void input_TextChanged(object sender, EventArgs e) => output_code.Text = "";

        string reverse(string str)
        {
            string ans = "";
            for (int i = str.Length - 1; i >= 0; i--)
                ans += str[i];
            return ans;
        }

        public static string go_small(string line)
        {
            if (line != null)
            {
                char[] word = new char[line.Length];
                word = line.ToCharArray();
                for (int j = 0; j < word.Length; j++)
                {
                    if ((word[j] >= 0x41) && (word[j] <= 0x5A))
                        word[j] = Convert.ToChar(word[j] + (char)0x20);
                }
                string answ = new string(word);
                return answ;
            }
            return null;
        }
        class coder
        {
            public string str;
            public int shift;

            public void clear()
            {
                set_str("");
                set_shift(0);
            }

            public int get_shift => this.shift;
            public string get_str => this.str;
            public void set_shift(int shift) => this.shift = shift % 26;
            public void set_str(string str) => this.str = str;

            public void do_code()
            {
                char[] converted = new char[this.str.Length];
                for (int i = 0; i < this.str.Length; i++)
                {
                    if ((this.str[i] >= 0x41) && (this.str[i] <= 0x5A))
                    {
                        converted[i] = Convert.ToChar(this.shift + Convert.ToInt32(this.str[i]));
                        if (converted[i] > 0x5A)
                            converted[i] = Convert.ToChar(Convert.ToInt32(converted[i]) - 26);
                    }
                    else if ((this.str[i] > 0x61) && (this.str[i] <= 0x7A))
                    {
                        converted[i] = Convert.ToChar(this.shift + Convert.ToInt32(this.str[i]));
                        if (converted[i] > 0x7A)
                            converted[i] = Convert.ToChar(Convert.ToInt32(converted[i]) - 26);
                    }
                    else converted[i] = str[i];
                }
                string line = "";
                foreach (char i in converted)
                    line += i;
                set_str(line);
            }
            public void do_decode()
            {
                if (this.str == null) return;
                char[] converted = new char[this.str.Length];
                for (int i = 0; i < this.str.Length; i++)
                {
                    if ((this.str[i] >= 0x41) && (this.str[i] <= 0x5A))
                    {
                        converted[i] = Convert.ToChar(Convert.ToInt32(this.str[i]) - this.shift);
                        if (converted[i] < 0x41)
                            converted[i] = Convert.ToChar(Convert.ToInt32(converted[i]) + 26);
                    }
                    else if ((this.str[i] >= 0x61) && (this.str[i] <= 0x7A))
                    {
                        converted[i] = Convert.ToChar(Convert.ToInt32(this.str[i]) - this.shift);
                        if (converted[i] < 0x61)
                            converted[i] = Convert.ToChar(Convert.ToInt32(converted[i]) + 26);
                    }
                    else converted[i] = str[i];
                }
                string line = "";
                foreach (char i in converted)
                    line += i;
                set_str(line);
            }
        };

        private void shift_TextChanged(object sender, EventArgs e)
        {
            if (shift.Text != "")
            {
                try
                {
                    Convert.ToInt32(shift.Text);
                }
                catch
                {
                    char[] line = new char[shift.Text.Length];
                    line = shift.Text.ToCharArray();
                    line[line.Length - 1] = '\0';
                    string answ = new string(line);
                    shift.Text = answ;
                }
            }
        }
    };
}