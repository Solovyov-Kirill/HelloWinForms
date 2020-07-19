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


        public Form1()
        {
            InitializeComponent();





        }

    }