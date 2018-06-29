using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace HangmanWindows
{
    public partial class HangMan : Form
    {
        public static char tempguess;
        public static string PlayWord;
        public GamePlayLogic Logic;
        public Graphics g;
        public HangMan()
        {
            InitializeComponent();
            g = Graphics.FromHwnd(Handle);

            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string InputFileLocation = string.Format("{0}Resources\\HangmanWords.txt", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            HangmanWords GameWords = new HangmanWords(InputFileLocation);
            Logic = new GamePlayLogic();
            PlayWord = GameWords.SelectAWord().ToUpper();

            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            tempguess = 'A';
            Logic.CheckUserGuess(tempguess, PlayWord);
            Logic.GameIsOver();
            button1.Enabled = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            tempguess = 'B';
            Logic.CheckUserGuess(tempguess, PlayWord);
            Logic.GameIsOver();
            button2.Enabled = false;
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            tempguess = 'C';
            Logic.CheckUserGuess(tempguess, PlayWord);
            Logic.GameIsOver();
            button3.Enabled = false;
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            tempguess = 'D';
            Logic.CheckUserGuess(tempguess, PlayWord);
            Logic.GameIsOver();
            button4.Enabled = false;
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            tempguess = 'E';
            Logic.CheckUserGuess(tempguess, PlayWord);
            Logic.GameIsOver();
            button5.Enabled = false;
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            tempguess = 'F';
            Logic.CheckUserGuess(tempguess, PlayWord);
            Logic.GameIsOver();
            button6.Enabled = false;
        }
        private void Button7_Click(object sender, EventArgs e)
        {
            tempguess = 'G';
            Logic.CheckUserGuess(tempguess, PlayWord);
            Logic.GameIsOver();
            button7.Enabled = false;
        }
        private void Button8_Click(object sender, EventArgs e)
        {
            tempguess = 'H';
            Logic.CheckUserGuess(tempguess, PlayWord);
            Logic.GameIsOver();
            button8.Enabled = false;
        }
        private void Button9_Click(object sender, EventArgs e)
        {
            tempguess = 'I';
            Logic.CheckUserGuess(tempguess, PlayWord);
            Logic.GameIsOver();
            button9.Enabled = false;
        }
        private void Button10_Click(object sender, EventArgs e)
        {
            tempguess = 'J';
            Logic.CheckUserGuess(tempguess, PlayWord);
            Logic.GameIsOver();
            button10.Enabled = false;
        }
        private void Button11_Click(object sender, EventArgs e)
        {
            tempguess = 'K';
            Logic.CheckUserGuess(tempguess, PlayWord);
            Logic.GameIsOver();
            button11.Enabled = false;
        }
        private void Button12_Click(object sender, EventArgs e)
        {
            tempguess = 'L';
            Logic.CheckUserGuess(tempguess, PlayWord);
            Logic.GameIsOver();
            button12.Enabled = false;
        }
        private void Button13_Click(object sender, EventArgs e)
        {
            tempguess = 'M';
            Logic.CheckUserGuess(tempguess, PlayWord);
            Logic.GameIsOver();
            button13.Enabled = false;
        }
        private void Button14_Click(object sender, EventArgs e)
        {
            tempguess = 'N';
            Logic.CheckUserGuess(tempguess, PlayWord);
            Logic.GameIsOver();
            button14.Enabled = false;
        }
        private void Button15_Click(object sender, EventArgs e)
        {
            tempguess = 'O';
            Logic.CheckUserGuess(tempguess, PlayWord);
            Logic.GameIsOver();
            button15.Enabled = false;
        }
        private void Button16_Click(object sender, EventArgs e)
        {
            tempguess = 'P';
            Logic.CheckUserGuess(tempguess, PlayWord);
            Logic.GameIsOver();
            button16.Enabled = false;
        }
        private void Button17_Click(object sender, EventArgs e)
        {
            tempguess = 'Q';
            Logic.CheckUserGuess(tempguess, PlayWord);
            Logic.GameIsOver();
            button17.Enabled = false;
        }
        private void Button18_Click(object sender, EventArgs e)
        {
            tempguess = 'R';
            Logic.CheckUserGuess(tempguess, PlayWord);
            Logic.GameIsOver();
            button18.Enabled = false;
        }
        private void Button19_Click(object sender, EventArgs e)
        {
            tempguess = 'S';
            Logic.CheckUserGuess(tempguess, PlayWord);
            Logic.GameIsOver();
            button19.Enabled = false;
        }
        private void Button20_Click(object sender, EventArgs e)
        {
            tempguess = 'T';
            Logic.CheckUserGuess(tempguess, PlayWord);
            Logic.GameIsOver();
            button20.Enabled = false;
        }
        private void Button21_Click(object sender, EventArgs e)
        {
            tempguess = 'U';
            Logic.CheckUserGuess(tempguess, PlayWord);
            Logic.GameIsOver();
            button21.Enabled = false;
        }
        private void Button22_Click(object sender, EventArgs e)
        {
            tempguess = 'V';
            Logic.CheckUserGuess(tempguess, PlayWord);
            Logic.GameIsOver();
            button22.Enabled = false;
        }
        private void Button23_Click(object sender, EventArgs e)
        {
            tempguess = 'W';
            Logic.CheckUserGuess(tempguess, PlayWord);
            Logic.GameIsOver();
            button23.Enabled = false;
        }
        private void Button24_Click(object sender, EventArgs e)
        {
            tempguess = 'X';
            Logic.CheckUserGuess(tempguess, PlayWord);
            Logic.GameIsOver();
            button24.Enabled = false;
        }
        private void Button25_Click(object sender, EventArgs e)
        {
            tempguess = 'Y';
            Logic.CheckUserGuess(tempguess, PlayWord);
            Logic.GameIsOver();
            button25.Enabled = false;
        }
        private void Button26_Click(object sender, EventArgs e)
        {
            tempguess = 'Z';
            Logic.CheckUserGuess(tempguess, PlayWord);
            Logic.GameIsOver();
            button26.Enabled = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            StringBuilder labelMaker = new StringBuilder();

            for (int i = 0; i < PlayWord.Length; i++)
            {
                labelMaker.Append(HangmanWords.WinningWord[i]);
                labelMaker.Append(" ");
            }
            label2.Text = labelMaker.ToString();

            if (Logic.IsWinner)
            {
                label1.Text = "Winner!";
                foreach (Control control in this.Controls)
                {
                    if (control is Button)
                    {
                        control.Enabled = false;
                    }
                }
            }

            Brush b = new SolidBrush(Color.Brown);
            Brush p = new SolidBrush(Color.Purple);
            //Draw the primary verticle support for the gallows
            Pen pen = new Pen(b, 15);
            Pen person = new Pen(p, 5);
            Point p1 = new Point(100, 25);
            Point p2 = new Point(100, 275);
            g.DrawLine(pen, p1, p2);

            //Draw the base of the Gallows
            Point p3 = new Point(50, 275);
            Point p4 = new Point(200, 275);
            g.DrawLine(pen, p3, p4);

            //Draw the hanging bar for the gallows
            Point p5 = new Point(100, 50);
            Point p6 = new Point(175, 50);
            g.DrawLine(pen, p5, p6);

            if (Logic.spentLives == 0)
            {
                return;
            }

            //Draw the rope
            Point rope1 = new Point(162, 50);
            Point rope2 = new Point(162, 75);
            g.DrawLine(pen, rope1, rope2);

            if (Logic.spentLives == 1)
            {
                return;
            }

            //Draw the Head
            g.DrawEllipse(person, 150, 75, 25, 25);

            if (Logic.spentLives == 2)
            {
                return;
            }
            
            //Draw the body
            Point b1 = new Point(162, 100);
            Point b2 = new Point(162, 150);
            g.DrawLine(person, b1, b2);

            if (Logic.spentLives == 3)
            {
                return;
            }

            //Draw the right arm
            Point ra1 = new Point(162, 115);
            Point ra2 = new Point(142, 125);
            g.DrawLine(person, ra1, ra2);

            if (Logic.spentLives == 4)
            {
                return;
            }

            //Draw the left arm
            Point la1 = new Point(162, 115);
            Point la2 = new Point(182, 125);
            g.DrawLine(person, la1, la2);

            if (Logic.spentLives == 5)
            {
                return;
            }

            //Draw the left leg
            Point ll1 = new Point(162, 148);
            Point ll2 = new Point(142, 158);
            g.DrawLine(person, ll1, ll2);

            if (Logic.spentLives == 6)
            {
                return;
            }

            //Draw the right leg
            Point rl1 = new Point(162, 148);
            Point rl2 = new Point(182, 158);
            g.DrawLine(person, rl1, rl2);
            label1.Text = string.Format("GameOver");
            if (Logic.gameActive == false)
            {
                b.Dispose();
                p.Dispose();
                foreach (Control control in this.Controls)
                {
                    if (control is Button)
                    {
                        control.Enabled = false;
                    }
                }
            }
        }
    }
}
