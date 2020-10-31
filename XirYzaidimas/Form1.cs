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
    public partial class Form1 : Form
    {
        Button[,] button;

        String zingsnis;

        public static int isVisoZingsniu;
        public static int padarytiZingsniai = 0;
        public static int musuX;
        public static int musuY;
        public static string Xor0Sender;

        //public int KiekX; // Lyginimui result
     //   public int Kiek0; // Lyginimui result
        public Form1(int X, int Y, string Xor0Start) // bool 3x3Checker
        {
            musuX = X;
            musuY = Y;
            Xor0Sender = Xor0Start;
            isVisoZingsniu = musuX * musuY;

            //  MessageBox.Show(musuX.ToString());

            // pasirinktinai nuo naudotojo bus is karto naudojamas arba X arba 0
            zingsnis = Xor0Sender;


            InitializeComponent();
            button = new Button[X, Y];

            

            int unikalusTegas = 0; // priskirimui unikalo kodo
      

            for (int i = 0; i < X; i++)
            {
                for(int j = 0; j < Y; j++)
                {
                    button[i, j] = new Button(); // kiekviena mygtuka inicializuojam
                    button[i, j].Parent = panel1; // atvaizdavymas
                    button[i, j].Width = panel1.Width / X; // atvaizdavymo nustatymai
                    button[i, j].Height = panel1.Height / X;

                    button[i, j].Top = j*panel1.Height / X; // pagal duota algoritma mygtukai
                    button[i, j].Left= i*panel1.Width / X; // issideles 100% langos dydziu
                    button[i, j].Click += new EventHandler(onclick);// Po kiekvieno paspaudimo, kvieciamas methodas
                    button[i, j].Tag = unikalusTegas; // priskirimas kiekvienam unikalo kodo
                    
                    int newSize = 22;
                    button[i, j].Font = new Font(button[i, j].Font.FontFamily, newSize, FontStyle.Bold);

      

                    unikalusTegas++;
                }
            }
        }

        private int c = 0;
        //Mygtuku blokavimas, kad niekas nevaiksciuotu
        private void win(string Xor0)
        {
            for (int i = 0; i < musuX; i++)
            {
                for (int j = 0; j < musuY; j++)
                {
                    if (button[i, j].Text == Xor0)
                    {
                        button[i, j].BackColor = Color.FromArgb(0, 255, 0); // kiekviena mygtuka inicializuojam
                    }
                    if (button[i, j].Text != Xor0)
                    {
                        button[i, j].BackColor = Color.FromArgb(128, 0, 0); // kiekviena mygtuka inicializuojam
                    }
                    if (button[i, j].Text == "")
                    {
                        button[i, j].BackColor = Color.FromArgb(0, 0, 0); // kiekviena mygtuka inicializuojam
                    }

                }
            }
            DialogResult result = MessageBox.Show(Xor0 + " Won this game", "Play Again?", MessageBoxButtons.YesNo);

            if(Convert.ToString(result) == "Yes")
            {
                Start frmStart = new Start();
                this.Hide();
                frmStart.Closed += (s, args) => this.Close();
                frmStart.Show();
            }
            else
            {
                this.Close();
            }
        }

        public void check1(int i, int j, string x)
        { 
            try
            {
                //Horizontal
                if (button[i, j].Text == x && button[i - 1, j].Text == x && button[i + 1, j].Text == x) // For 5 maker need to   && button[i-2, j].Text == x && button[i+2, j].Text == x
                {
                    win(x);
                }
                //Eilute
                if (button[i, j].Text == x && button[i, j - 1].Text == x && button[i, j + 1].Text == x)// For 5 maker need to  button[i, j - 2].Text == x && button[i, j + 2].Text == x
                {
                    win(x);
                }
                //Viena is Diagonales
                if (button[i, j].Text == x && button[i - 1, j - 1].Text == x && button[i + 1, j + 1].Text == x) // For 5 maker need to && button[i + 2, j +2].Text == x && button[i - 2, j - 2].Text == x
                {
                    win(x);
                }
                //Viena is Diagonales2 For 3 Maker 
                if (button[i, j].Text == x && button[i - 1, j + 1].Text == x && button[i + 1, j - 1].Text == x) // For 5 maker need to && button[i + 2, j - 2].Text == x && button[i - 2, j + 2].Text == x
                {
                    win(x);
                }
            }
            catch
            {
                if (i == 0 && j == 0)
                {
                    i++;
                    j++;
                    //Horizontal
                    if (button[i, j].Text == x && button[i - 1, j].Text == x && button[i + 1, j].Text == x) // For 5 maker need to   && button[i-2, j].Text == x && button[i+2, j].Text == x
                    {
                        win(x);
                    }
                    //Eilute
                    if (button[i, j].Text == x && button[i, j - 1].Text == x && button[i, j + 1].Text == x)// For 5 maker need to  button[i, j - 2].Text == x && button[i, j + 2].Text == x
                    {
                        win(x);
                    }
                    //Viena is Diagonales
                    if (button[i, j].Text == x && button[i - 1, j - 1].Text == x && button[i + 1, j + 1].Text == x) // For 5 maker need to && button[i + 2, j +2].Text == x && button[i - 2, j - 2].Text == x
                    {
                        win(x);
                    }
                    //Viena is Diagonales2 For 3 Maker 
                    if (button[i, j].Text == x && button[i - 1, j + 1].Text == x && button[i + 1, j - 1].Text == x) // For 5 maker need to && button[i + 2, j - 2].Text == x && button[i - 2, j + 2].Text == x
                    {
                        win(x);
                    }
                }
            }
           

        }
        //3x3
        private void check3x3()
        {
            for (int i = 0; i < musuX; i++)
            {
                for (int j = 0; j < musuY; j++)
                {
                    check1(i, j, "X");
                    check1(i, j, "0");
                }
            }
        }
        //Eilute
        private void checkerRow(int j, string Xor0)
        {
            int IsViso = musuX;
            int sutapo = 0;

            bool flag = true; // Kol True darom tai

            //Eilute skaiciavimas !
            for (int pereiti = 0; pereiti < musuX ; pereiti++) //- 1
            {
                if (button[pereiti, j].Text == Xor0 && flag == true)
                {
                    sutapo++;
                    if(sutapo == musuX)
                    {
                        win(Xor0);
                    
                    }
                }
                else
                {
                    sutapo = 0;
                    break;
                }
            }
        }

        //Stulpelis
        private void checkerColumn( int j, string Xor0)
        {
            int IsViso = musuX;
            int sutapo = 0;


            bool flag = true; // Kol True darom tai

            //Stulpelio skaiciavimas !
            for (int pereiti = 0; pereiti < musuX; pereiti++) //- 1
            {
                if (button[j, pereiti].Text == Xor0 && flag == true)
                {
                    sutapo++;
                    if (sutapo == musuX)
                    {
                        win(Xor0);
                        //return;
                    }
                }
                else
                {
                
                    break;
                }
            }

        }

        //VEIKIA! Reikia TIk Pajungti
        public void checkerDiagonalLeftToRight(string Xor0)
        {
            int diagonalPasikartojaKaireIDesne = 0;
           for (int i = 0; i < musuX; i++)
            {
              for (int j = 0; j < musuX; j++)
              {
               // finding primary diagonal Is kaires i Desne
               if (i == j){
                   if(button[i, j].Text == Xor0)
                   {
                       diagonalPasikartojaKaireIDesne++;
                    //MessageBox.Show("Sutampa " + "musuX " + musuX + " na ir musu Diagonal pasikartoja kartu : " + diagonalPasikartojaKaireIDesne);
                }
                   else
                   {
                      break;
                   }
                   if(musuX == diagonalPasikartojaKaireIDesne)
                   {
                            // MessageBox.Show("Sutampa");
                            win(Xor0);
                            return;
                        }

                    }
              } // j
          } // i
        }

        //VEIKIA! Reikia TIk Pajungti
        private void checkerDiagonalRightToLeft(string Xor0)
        {
            int diagonalPasikartojaDesneIKaire = 0;

            for (int i = 0; i < musuX; i++)
            {
                for (int j = 0; j < musuX; j++)
                {

                    // finding sum of secondary diagonal Is Desines i Kaire
                    if (i == musuX - j - 1)
                      {
                             if(button[i,j].Text == Xor0)
                             {
                                diagonalPasikartojaDesneIKaire++;
                             }
                             else
                             {
                                break;
                             }
                             if(musuX == diagonalPasikartojaDesneIKaire)
                             {
                               win(Xor0);
                             }
                      }
                } // j
            } // i

        }
        private void checker()
        {
           
                        for (int i = 0; i < musuX; i++)
                        {
                            checkerRow(i, "X");
                            checkerRow(i, "0");

                            checkerColumn(i, "X");
                            checkerColumn(i, "0");

                        }

                        checkerDiagonalLeftToRight("X");
                        checkerDiagonalLeftToRight("0");

                        checkerDiagonalRightToLeft("X");
                        checkerDiagonalRightToLeft("0");


           // check3x3();

            if (padarytiZingsniai == isVisoZingsniu)
            {
                CheckAll();
            }
         
     
          
    }



  
        private void onclick(object sender, EventArgs e)
        {

            // Print X to 0 , on table 
            Button b = (Button)sender;
            if(b.Text == ""){  
                b.Text = zingsnis;
                padarytiZingsniai++;
            }
    
            // Switch from X to O
            if (zingsnis == "X")
            {
                zingsnis = "0";
            } 
            else
            {
                zingsnis = "X";
            }


            checker();
            //checker();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }




        public Boolean AtitinkaCiklas = false;

        //Draw
        public void CheckAll()
        {


            while (AtitinkaCiklas == false)
            {
                int Atitinka = 0;
                if (Atitinka != 4)
                {

                    if (checkerRowForX().Contains("false") && checkerColumnForX().Contains("false") &&
                        checkerDiagonalLeftToRightX().Contains("false") && checkerDiagonalRightToLeftX().Contains("false"))
                    {
                        Atitinka = 4;
                    }
                    else
                    {
                        AtitinkaCiklas = true;
                        Atitinka = 0;
                        MessageBox.Show("Atitinka");
                    }

                    if (Atitinka == 4)
                    {
                        AtitinkaCiklas = true;
                        MessageBox.Show("NeiVienasNelaimejo");

                    }
                }
                else
                {
                    AtitinkaCiklas = true;
                    MessageBox.Show("Atitinka");
                } // Esles
            }
            MessageBox.Show("Atitinka");
        }


        //Eilute
        public string checkerRowForX()
        {
            string Xor0 = "X";

            //  fillTableToWinRow();

            for (int i = 0; i < musuX; i++)
            {

                for (int j = 0; j < musuY; j++)
                {

                    int sutapo = 0;

                    bool flag = true; // Kol True darom tai

                    //Eilute skaiciavimas !
                    for (int pereiti = 0; pereiti < musuX; pereiti++) //- 1
                    {
                        if (button[j, pereiti].Text == Xor0 && flag == true)
                        {
                            sutapo++;
                            if (sutapo == musuX)
                            {
                               
                                return "true";

                            }
                        }
                        else
                        {
                            sutapo = 0;
                            break;
                        }
                    }

                }
            }
            return "false";
        }
        //Stulpelis
        public string checkerColumnForX()
        {
            string Xor0 = "X";
            // fillTableToWinColumn();

            for (int i = 0; i < musuX; i++)
            {

                for (int j = 0; j < musuY; j++)
                {
                    // checkerColumn(i, j, "X");
                    //checker1(i, j, "0");



                    int IsViso = musuX;
                    int sutapo = 0;

                    bool flag = true; // Kol True darom tai

                    //Eilute skaiciavimas !
                    for (int pereiti = 0; pereiti < musuX; pereiti++) //- 1
                    {
                        if (button[pereiti, j].Text == Xor0 && flag == true)
                        {
                            sutapo++;
                            if (sutapo == musuX)
                            {
                              
                                return "true";

                            }
                        }
                        else
                        {
                            sutapo = 0;
                            break;
                        }
                    }

                }
            }

            return "false";
        }

        //Diagonale i Desne
        public string checkerDiagonalLeftToRightX()
        {

            int diagonalPasikartojaDesneIKaire = 0;

            //  fillTableToWinDiagonalLeftToRightX();

            for (int i = 0; i < musuX; i++)
            {
                for (int j = 0; j < musuX; j++)
                {
                    if (i == musuX - j - 1)
                    {
                        if (Convert.ToString(button[i, j]) == "X")
                        {
                            diagonalPasikartojaDesneIKaire++;
                        }
                        else
                        {
                            break;
                        }
                        if (musuX == diagonalPasikartojaDesneIKaire)
                        {
                            //   MessageBox.Show("Sutampa");
                            return "true";
                        }
                    }
                } // j
            } // i
            return "false";
        }

        //Diagonale i Kaire
        public string checkerDiagonalRightToLeftX()
        {
            string Xor0 = "X";

            // fillTableToWinDiagonalRightToLeftX();

            int diagonalPasikartojaKaireIDesne = 0;
            for (int i = 0; i < musuX; i++)
            {
                for (int j = 0; j < musuX; j++)
                {
                    // finding primary diagonal Is kaires i Desne
                    if (i == j)
                    {
                        if (Convert.ToString(button[i, j]) == Xor0)
                        {
                            diagonalPasikartojaKaireIDesne++;
                            //MessageBox.Show("Sutampa " + "musuX " + musuX + " na ir musu Diagonal pasikartoja kartu : " + diagonalPasikartojaKaireIDesne);
                        }
                        else
                        {
                            break;
                        }
                        if (musuX == diagonalPasikartojaKaireIDesne)
                        {
                            // MessageBox.Show("Sutampa");
                            //win(Xor0);
                            return "true";
                        }

                    }
                } // j
            } // i
            return "false";
        }



        // Tas Atsakingas Custom Draggable Windows Form Application
        private void Start_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
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
