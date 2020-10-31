using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XirYzaidimas
{
    public class DiagonalLeftToRightWinner
    {

        private static dynamic musuX;
        private static dynamic musuY;
        public static string[,] multiDimensionalArray;


        public DiagonalLeftToRightWinner(int musuX, int musuY)
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


        //Diagonale i Desne
        public void fillTableToWinDiagonalLeftToRightX()
        {
            for (int i = 0; i < musuX; i++)
            {
                for (int j = 0; j < musuY; j++)
                {
                    if (i == musuX - j - 1)
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
        //Diagonale i Desne
        public string checkerDiagonalLeftToRightX()
        {
            string Xor0 = "X";
            int diagonalPasikartojaDesneIKaire = 0;

            fillTableToWinDiagonalLeftToRightX();

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
                            return Xor0;
                        }
                    }
                } // j
            } // i
            return "Sad Story";
        }

    }
}
