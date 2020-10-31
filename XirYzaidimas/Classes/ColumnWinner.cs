using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XirYzaidimas
{
    public class ColumnWinner
    {
        private static dynamic musuX;
        private static dynamic musuY;
        public static string[,] multiDimensionalArray;


        public ColumnWinner(int musuX, int musuY)
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




        //Stulpelio
        static void fillTableToWinColumn()
        {
            //Stulpelio Ikisimas !
            for (int pereiti = 0; pereiti < musuX; pereiti++) //- 1
            {
                multiDimensionalArray[pereiti, 0] = "0";

                for (int perejimasNeEilute = 1; perejimasNeEilute < musuY; perejimasNeEilute++)
                {
                    multiDimensionalArray[pereiti, perejimasNeEilute] = "X";
                }
            }
        }

        //Stulpelis
        public string checkerColumnForX()
        {
            string Xor0 = "0";
            fillTableToWinColumn();

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
                                //  win(Xor0);

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

            return Xor0;
        }
    }
}
