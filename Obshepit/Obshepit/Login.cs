using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obshepit
{
    public partial class Login : Form
    {
        public bool n = false, z = true;

        public Login()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (n == true)
            {
                textBox2.UseSystemPasswordChar = true;
                button1.ForeColor = Color.Black;
                n = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = false;
                button1.ForeColor = Color.Green;
                n = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 2; i++)
            {
                if ((textBox1.Text == Properties.Settings.Default.l) && (textBox2.Text == Properties.Settings.Default.p))
                {
                    Form MainMenu = new MainMenu();
                    MainMenu.Show();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль!");
                    pictureBox1.Visible = true;
                    textBox3.Visible = true;
                    update.Visible = true;
                    i++;
                    label3.Text = "Попытка №"+ i;
                }
            }
                
        }

        string text;

        private Bitmap CreateImage(int Width, int Height)
        {
            Random rnd = new Random();
            Bitmap result = new Bitmap(Width, Height);

            int Xpos = 10;
            int Ypos = 10;

            Brush[] colors = {
                Brushes.Black,
                Brushes.Red,
                Brushes.RoyalBlue,
                Brushes.Green,
                Brushes.Yellow,
                Brushes.White,
                Brushes.Tomato,
                Brushes.Sienna,
                Brushes.Pink };

            Pen[] colorpens = {
                Pens.Black,
                Pens.Red,
                Pens.RoyalBlue,
                Pens.Green,
                Pens.Yellow,
                Pens.White,
                Pens.Tomato,
                Pens.Sienna,
                Pens.Pink };

            FontStyle[] fontstyle = {
                FontStyle.Bold,
                FontStyle.Italic,
                FontStyle.Regular,
                FontStyle.Strikeout,
                FontStyle.Underline};

            Int16[] rotate = { 1, -1, 2, -2, 3, -3, 4, -4, 5, -5, 6, -6 };

            Graphics g = Graphics.FromImage((Image)result);

            g.Clear(Color.Gray);

            g.RotateTransform(rnd.Next(rotate.Length));

            text = String.Empty;
            string ALF = "7890QWERTYUIOPASDFGHJKLZXCVBNM";
            for (int i = 0; i < 5; ++i)
                text += ALF[rnd.Next(ALF.Length)];

            //Нарисуем сгенирируемый текст
            g.DrawString(text,
            new Font("Arial", 25, fontstyle[rnd.Next(fontstyle.Length)]),
            colors[rnd.Next(colors.Length)],
            new PointF(Xpos, Ypos));

            //Добавим немного помех
            //Линии из углов
            g.DrawLine(colorpens[rnd.Next(colorpens.Length)],
            new Point(0, 0),
            new Point(Width - 1, Height - 1));
            g.DrawLine(colorpens[rnd.Next(colorpens.Length)],
            new Point(0, Height - 1),
            new Point(Width - 1, 0));

            //Белые точки
            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 20 == 0)
                        result.SetPixel(i, j, Color.White);

            return result;
        }

        private void update_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = this.CreateImage(pictureBox1.Width, pictureBox1.Height);
        }


        private void Login_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = this.CreateImage(pictureBox1.Width, pictureBox1.Height);
        }
    }
}

