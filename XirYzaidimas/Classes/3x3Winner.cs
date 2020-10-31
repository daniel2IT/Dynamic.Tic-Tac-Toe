using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XirYzaidimas.Classes
{
    public class _3x3Winner
    {
        private static string x;
        private static dynamic musuX;
        private static dynamic musuY;
        public static string[,] multiDimensionalArray;


        public _3x3Winner(int musuX, int musuY, string whatToCheck)
        {
            SetMusuX(musuX);
            SetMusuY(musuY);
            SetMusuKaTikrinsim(whatToCheck);

            multiDimensionalArray = new string[GetMusuX(), GetMusuY()];
        }

        public static int GetMusuX() { return musuX; }
        public static int SetMusuX(int musuXAteinantis)
        {
            musuX = musuXAteinantis;
            return musuX;

        }

        public static int GetMusuY() { return musuY; }
        public static string SetMusuKaTikrinsim(string musuKaTikrinsimAteinantis)
        {
            x = musuKaTikrinsimAteinantis;
            return x;
        }

        public static int SetMusuY(int musuYAteinantis)
        {
            musuY = musuYAteinantis;
            return musuY;
        }

        public void fillTableTo3x3Winner()
        {
            multiDimensionalArray = new string[,] {
                { "X", "0", "X",  "0"},
                { "0", "0", "0" , "X" },
                { "X", "0", "X" , "X" },
                { "0", "X", "0" , "0" }};
        }




        public string check1()
        {

            fillTableTo3x3Winner();


            for (int i = 0; i < musuX; i++)
            {
                for (int j = 0; j < musuY; j++)
                {
                    try
                    {
                        //Horizontal
                        if (multiDimensionalArray[i, j] == x && multiDimensionalArray[i - 1, j] == x && multiDimensionalArray[i + 1, j] == x) // For 5 maker need to   && button[i-2, j].Text == x && button[i+2, j].Text == x
                        {
                            return x;
                        }
                        //Eilute
                        if (multiDimensionalArray[i, j] == x && multiDimensionalArray[i, j - 1] == x && multiDimensionalArray[i, j + 1] == x)// For 5 maker need to  button[i, j - 2].Text == x && button[i, j + 2].Text == x
                        {
                            return x;
                        }
                        //Viena is Diagonales
                        if (multiDimensionalArray[i, j] == x && multiDimensionalArray[i - 1, j - 1] == x && multiDimensionalArray[i + 1, j + 1] == x) // For 5 maker need to && button[i + 2, j +2].Text == x && button[i - 2, j - 2].Text == x
                        {
                            return x;
                        }
                        //Viena is Diagonales2 For 3 Maker 
                        if (multiDimensionalArray[i, j] == x && multiDimensionalArray[i - 1, j + 1] == x && multiDimensionalArray[i + 1, j - 1] == x) // For 5 maker need to && button[i + 2, j - 2].Text == x && button[i - 2, j + 2].Text == x
                        {
                            return x;
                        }
                       // return "NeLygu";
                    }
                    catch
                    {
                        if (i == 0 && j == 0)
                        {
                            i++;
                            j++;
                            //Horizontal
                            if (multiDimensionalArray[i, j] == x && multiDimensionalArray[i - 1, j] == x && multiDimensionalArray[i + 1, j] == x) // For 5 maker need to   && button[i-2, j].Text == x && button[i+2, j].Text == x
                            {
                                return x;
                            }
                            //Eilute
                            if (multiDimensionalArray[i, j] == x && multiDimensionalArray[i, j - 1] == x && multiDimensionalArray[i, j + 1] == x)// For 5 maker need to  button[i, j - 2].Text == x && button[i, j + 2].Text == x
                            {
                                return x;
                            }
                            //Viena is Diagonales
                            if (multiDimensionalArray[i, j] == x && multiDimensionalArray[i - 1, j - 1] == x && multiDimensionalArray[i + 1, j + 1] == x) // For 5 maker need to && button[i + 2, j +2].Text == x && button[i - 2, j - 2].Text == x
                            {
                                return x;
                            }
                            //Viena is Diagonales2 For 3 Maker 
                            if (multiDimensionalArray[i, j] == x && multiDimensionalArray[i - 1, j + 1] == x && multiDimensionalArray[i + 1, j - 1] == x) // For 5 maker need to && button[i + 2, j - 2].Text == x && button[i - 2, j + 2].Text == x
                            {
                                return x;
                            }
                            //return "NeLygu";
                        }
                    }

                 
                } /// j
            } /// i
            return "NeLygu";
        } 
    }

    }
