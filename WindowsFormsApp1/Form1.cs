//using System.Drawing;
//using System.Windows.Forms;

//namespace WindowsFormsApp1
//{
//    public partial class Form1 : Form
//    {
//        Button minusBtn;
//        Button button;
//        Button up;
//        Button down;
//        public Form1()
//        {
//            InitializeComponent();


//            button = new Button();
//            button.Text = "->";
//            button.Size = new Size(45, 45);
//            button.Location = new Point(200, 150);
//            button.Click += Button_Click;
//            //button.LocationChanged += Button_LocationChanged1;
//            this.Controls.Add(button);

//            minusBtn = new Button();
//            minusBtn.Location = new Point(140, 150);
//            minusBtn.Text = "<-";
//            minusBtn.Size = new Size(45, 45);
//            minusBtn.Click += MinusBtn_Click;
//            this.Controls.Add(minusBtn);

//            up = new Button();
//            up.Location = new Point(170,100);
//            up.Text = "up";
//            up.Size = new Size(45, 45);
//            up.Click += Up_Click;
//            this.Controls.Add(up);

//            down = new Button();
//            down.Location = new Point(170, 200);
//            down.Text = "down";
//            down.Size = new Size(45, 45);
//            down.Click += Down_Click;
//            this.Controls.Add(down);
//        }

//        private void Down_Click(object sender, System.EventArgs e)
//        {
//            this.Location = new Point(this.Location.X, this.Location.Y + 5);
//        }

//        private void Up_Click(object sender, System.EventArgs e)
//        {
//            this.Location = new Point(this.Location.X, this.Location.Y - 5);
//        }

//        private void MinusBtn_Click(object sender, System.EventArgs e)
//        {
//            this.Location = new Point(this.Location.X -5, this.Location.Y );
//        }

//        //private void Button_LocationChanged1(object sender, System.EventArgs e)
//        //{
//        //    Button button = sender as Button;
//        //    //this.Size -   размер формы
//        //    if (button.Location.Y > (this.Size.Height / 2))
//        //        //меняем задний фон на красный
//        //        button.BackColor = Color.Red;
//        //    else
//        //        button.BackColor = Color.Green;
//        //}


//        private void Button_Click(object sender, System.EventArgs e)
//        {
//            ////говорим что работаем с кнопкой (текуще нажатая кнопка)
//            //Button button = sender as Button;
//            ////перестанавливаем координаты ей
//            //button.Location = new Point(button.Location.X, button.Location.Y + 5);
//            this.Location = new Point(this.Location.X + 5, this.Location.Y);
//        }
//    }
//}

using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        TextBox textBox;
        Button isEnable_TB;
        Button find2;
        TextBox textBox2;
        Button test;
        public Form1()
        {
            InitializeComponent();

            test = new Button();
            test.Location = new Point(300, 300);
            test.Click += Test_Click;
            this.Controls.Add(test);


            textBox = new TextBox();
            textBox.KeyDown += TextBox_KeyDown;
            textBox.Size = new Size(150, 150);
            textBox.Multiline = true;
            textBox.AcceptsTab = true;
            textBox.TextAlign = HorizontalAlignment.Center;
            textBox.Font = new Font("Times New Roman", 14);
            this.Controls.Add(textBox);

            textBox2 = new TextBox();
            textBox2.KeyDown += TextBox_KeyDown;
            textBox2.Size = new Size(150, 50);
            textBox2.Location = new Point(200, 0);
            textBox2.Multiline = true;
            textBox2.AcceptsTab = true;
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.Font = new Font("Times New Roman", 14);
            this.Controls.Add(textBox2);

            isEnable_TB = new Button();
            isEnable_TB.Text = "find";
            isEnable_TB.Location = new Point(235, 60);
            isEnable_TB.Click += IsEnable_TB_Click;
            this.Controls.Add(isEnable_TB);

            find2 = new Button();
            find2.Text = "find2";
            find2.Location = new Point(235, 100);
            find2.Click += Find2_Click; ;
            this.Controls.Add(find2);
        }

        private void Test_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void Find2_Click(object sender, EventArgs e)
        {
            int nom = textBox.Text.IndexOf(textBox2.Text);
            nom += nom+1;
            MessageBox.Show($"{nom}");
        }

        private void IsEnable_TB_Click(object sender, System.EventArgs e)
        {
            //if (textBox.Enabled == false)
            //    textBox.Enabled = true;
            //else
            //    textBox.Enabled = false;
            //textBox.Enabled = !textBox.Enabled;

            //MessageBox.Show("Yes!");
            int res = textBox.Text.IndexOf(textBox2.Text);
            MessageBox.Show(res < 0 ? "No" : "Yes");
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            //e.KeyValue    вернет ASCII номер символа
            //MessageBox.Show(((char)e.KeyValue).ToString());
            //if (Char.IsDigit((char)e.KeyValue))
            //{
            //    MessageBox.Show("Yes!");
            //    //textBox.Text.IndexOf((char)e.KeyValue)    получить индекс введенного символа в строке
            //    //textBox.Text.Remove                       удалить символ (с позиции, по количество)
            //    //textBox.Text = textBox.Text.Remove(textBox.Text.IndexOf((char)e.KeyValue), 1);
            //}
            //в заголовок формы перенести длину текста
            //this.Text = textBox.Text.Length.ToString();
        }
    }
}
