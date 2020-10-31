using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XirYzaidimas
{
    public partial class Start : Form
    {

        public static int SetValueForX;
        public static int SetValueForY;
        public static string SetValueForXorO = "";

        public Start()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxX.Text != null && textBoxY.Text != null
                && !string.IsNullOrWhiteSpace(textBoxX.Text)
                && !string.IsNullOrWhiteSpace(textBoxY.Text))
            {  
            SetValueForX = Convert.ToInt32(textBoxX.Text);
            SetValueForY = Convert.ToInt32(textBoxY.Text);
                if (SetValueForX == SetValueForY)
                {
                    //SetValueForXorO = textBox3.Text;

                    Start start = new Start();
                    if(checkBoxForX.Checked)
                    {
                
                        Form1 frm1 = new Form1(SetValueForX, SetValueForY, checkBoxForX.Text);
                        this.Hide();

                        frm1.Closed += (s, args) => this.Close();

                        frm1.Show();
                    }
                    if (checkBoxFor0.Checked)
                    {
                 
                        Form1 frm1 = new Form1(SetValueForX, SetValueForY, checkBoxFor0.Text);
                        this.Hide();

                        frm1.Closed += (s, args) => this.Close();

                        frm1.Show();
                    }

         
                }
                else
                {
                    MessageBox.Show("We can't create Tic-Tac-Toe game for " +
                    SetValueForX + "x" + SetValueForY + " table X-O");
                }
            }
            else
            {
                MessageBox.Show("Fill Values");
            }


        }

        private void Start_Load(object sender, EventArgs e)
        {

        }


        // Tas Atsakingas Custom Draggable Windows Form Application
        private void Start_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        Point lastPoint;
        private void Start_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

 
    }
}
