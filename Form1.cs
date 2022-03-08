using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wordle
{
    public partial class Form1 : Form
    {
        private string _word;
        public string Word { get => _word; set { _word = value; UpdateBoard(); } }
        private int _attempts;
        public int Attempts { get => _attempts; set { _attempts = value; UpdateBoard(); } }

        public Color LetterCorrect = Color.Green;
        public Color LetterIncorrect = Color.Red;
        public Color LetterIncorrectPlace = Color.Orange;

        private TextBox[] letters;

        public Form1(string word, int attempts)
        {
            InitializeComponent();

            Word = word;
            Attempts = attempts;
        }

        private void UpdateBoard()
        {
            if (letters != null)
            {
                for (int i = 0; i < letters.Length; i++)
                {
                    this.Controls.Remove(letters[i]);
                    letters[i].Dispose();
                }
            }

            letters = new TextBox[_word.Length*_attempts];

            for (int i = 0; i < letters.Length; i++)
            {
                TextBox txt = new TextBox();
                txt.Size = new Size(flpLetter.Width / _word.Length, 0);
                txt.Font = new Font("Microsoft Sans Serif", txt.Size.Width / 4, FontStyle.Regular);
                txt.Margin = new Padding(0, 0, 0, 0);
                txt.MaxLength = 1;
                txt.TextAlign = HorizontalAlignment.Center;

                flpLetter.Controls.Add(txt);
            }
        }
    }
}
