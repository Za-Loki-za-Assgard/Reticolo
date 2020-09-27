using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANEKDOT
{
    public partial class Form1 : Form
    {
        private Random _random;
        private readonly string _filePath = "..\\..\\Resources\\jokes.txt";
        private List<string> _jokes;

        public Form1()
        {
            InitializeComponent();
            _jokes = new List<string>();
            GetJokes();
            _random = new Random();

            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = GetRandomJoke();
        }

        public void GetJokes()
        {
            using (StreamReader reader = new StreamReader(_filePath))
            {
                string joke = "";
                string newLine = "";

                while (!String.IsNullOrEmpty(newLine = reader.ReadLine()))
                {
                    if (newLine[0] != '#')
                    {
                        joke += newLine;
                        joke += "\n";
                    } else
                    {
                        _jokes.Add(joke);
                        joke = "";
                    }
                }
            }
        }
        public string GetRandomJoke()
        {
            return _jokes[_random.Next(0, _jokes.Count)];
        }
    }
}
