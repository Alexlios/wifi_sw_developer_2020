using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebungen
{
    class Uebung8
    {
        public static void Start()
        {
            int windHeight = Console.WindowHeight;
            int windWidth = Console.WindowWidth;

            int x = 0;
            int y = 0;

            string input = string.Empty;
            bool isInputValid = false;

            int[][] coordinates = new int[windHeight][];
            for(int i = 0;i < windHeight;++i)
            {
                coordinates[i] = new int[windWidth];
                for(int n = 0;n < windWidth;++n)
                {
                    coordinates[i][n] = 32;
                }
            }

            while(!isInputValid)
            {
                Console.Write($"Bitte Koordinate angeben (X <= {windWidth} Y <= {windHeight}): ");
                input = Console.ReadLine();

                string[] xyCoordinate = input.Split(' ');

                if(input.Length >= 3)
                {
                    if (xyCoordinate.Length < 3 && xyCoordinate.Length > 1)
                    {
                        isInputValid = true;
                        foreach (char c in xyCoordinate[0])
                        {
                            if (!char.IsDigit(c))
                            {
                                isInputValid = false;
                                break;
                            }
                        }

                        if (isInputValid)
                        {
                            foreach (char c in xyCoordinate[1])
                            {
                                if (!char.IsDigit(c))
                                {
                                    isInputValid = false;
                                    break;
                                }
                            }
                        }

                        if (isInputValid)
                        {
                            x = int.Parse(xyCoordinate[0]) - 1;
                            y = int.Parse(xyCoordinate[1]) - 1;

                            if (x < 0 || x > windWidth || y < 0 || y > windHeight)
                            {
                                isInputValid = false;
                                Console.WriteLine($"Bitte die Koordinaten nur in den Bereichen X: von 1 bis {windWidth} Y: von 1 bis {windHeight}!");
                                continue;
                            }

                            coordinates[y][x] = 'X';

                            if (isInputValid)
                            {
                                Console.Clear();
                                foreach (int[] arr in coordinates)
                                {
                                    foreach (char i in arr)
                                    {
                                        Console.Write(i);
                                    }
                                }
                            }
                        }
                        else
                        {
                            isInputValid = false;
                            Console.WriteLine($"Bitte Koordinaten im Format (X Y) angeben. Im Bereich X <= {windWidth} und  Y <= {windHeight}!");
                            continue;
                        }
                    }
                    else
                    {
                        isInputValid = false;
                        Console.WriteLine($"Bitte Koordinaten im Format (X Y) angeben. Im Bereich X <= {windWidth} und  Y <= {windHeight}!");
                        continue;
                    }
                }
                else
                {
                    isInputValid = false;
                    Console.WriteLine($"Bitte Koordinaten im Format (X Y) angeben. Im Bereich X <= {windWidth} und  Y <= {windHeight}!");
                }
            }

            Console.ReadKey();
        }
    }
}
