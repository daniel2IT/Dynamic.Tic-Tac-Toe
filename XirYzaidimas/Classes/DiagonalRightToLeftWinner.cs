using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XirYzaidimas
{
    public class DiagonalRightToLeftWinner
    {

        private static dynamic musuX;
        private static dynamic musuY;
        public static string[,] multiDimensionalArray;


        public DiagonalRightToLeftWinner(int musuX, int musuY)
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
        public void fillTableToWinDiagonalRightToLeftX()
        {

            for (int i = 0; i < musuX; i++)
            {
                for (int j = 0; j < musuX; j++)
                {
                    // finding primary diagonal Is kaires i Desne
                    if (i == j)
                    {
                        multiDimensionalArray[i, j] = "X";
                    }
                    else
                    {
                        multiDimensionalArray[i, j] = "0";
                    }
                } // j
            } // i
        }

        //Diagonale i Kaire
        public string checkerDiagonalRightToLeftX()
        {
            string Xor0 = "X";

            fillTableToWinDiagonalRightToLeftX();

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
                            return Xor0;
                        }

                    }
                } // j
            } // i
            return "Sad Story";
        }


    }
}
