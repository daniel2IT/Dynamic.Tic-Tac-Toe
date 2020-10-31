using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XirYzaidimas.Classes
{
    public class NoOneWon
    {

        private static dynamic musuX;
        private static dynamic musuY;
        public static string[,] multiDimensionalArray;
        public Boolean AtitinkaCiklas = false;

        // Create a Random object  
        Random r = new Random();



        public NoOneWon(int musuX, int musuY)
        {
            SetMusuX(musuX);
            SetMusuY(musuY);

            multiDimensionalArray = new string[GetMusuX(), GetMusuY()];
        }


        public static int GetMusuX() { return musuX; }
        public static int SetMusuX(int musuXAteinantis)
        {
            musuX = musuXAteinantis;
            return musuX;

        }

        public static int GetMusuY() { return musuY; }
        public static int SetMusuY(int musuYAteinantis)
        {
            musuY = musuYAteinantis;
            return musuY;
        }

        //Diagonale i Kaire
        public void fillTableToNoOneWin()
        {

            multiDimensionalArray = new string[,] { 
                { "X", "0", "X",  "0"},
                { "0", "X", "X" , "0" },
                { "X", "0", "0" , "X" },
                { "0", "X", "0" , "0" }};
            /*
            for (int i = 0; i < musuX; i++)
            {
                for (int j = 0; j < musuX; j++)
                {
                    int rString = r.Next(0, 10); //for ints
                    if (rString <= 5)
                    {
                        multiDimensionalArray[i, j] = "X";
                    }
                    else
                    {
                        multiDimensionalArray[i, j] = "0";
                    }
                } // j
            } // i */
        }

        public string CheckAll()
        {

            fillTableToNoOneWin();

            while (AtitinkaCiklas == false )
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
                        return "Atitinka";
                    }

                if(Atitinka == 4)
                {
                        AtitinkaCiklas = true;
                 return "NeiVienasNelaimejo";

                }
                }
                else
                {
                    AtitinkaCiklas = true;
                    return "Atitinka";
                } // Esles
            }
            return "Atitinka";
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
                        if (multiDimensionalArray[j, pereiti].ToString() == Xor0 && flag == true)
                        {
                            sutapo++;
                            if (sutapo == musuX)
                            {
                                Console.WriteLine("Sutapo: " + Xor0);
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
                        if (multiDimensionalArray[pereiti, j].ToString() == Xor0 && flag == true)
                        {
                            sutapo++;
                            if (sutapo == musuX)
                            {
                                Console.WriteLine("Sutapo: " + Xor0);
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
                        if (Convert.ToString(multiDimensionalArray[i, j]) == "X")
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
                        if (Convert.ToString(multiDimensionalArray[i, j]) == Xor0)
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
    }
}
