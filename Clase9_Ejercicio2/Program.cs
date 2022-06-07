int[,] carton = new int[3, 9];
Random numero = new Random();
int s = 0;
do
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 9; j++)
        {
            if (j == 0)
            {
                carton[i, j] = numero.Next(1, 10);
            }
            else if (j == 1)
            {
                carton[i, j] = numero.Next(10, 20);
            }
            else if (j == 2)
            {
                carton[i, j] = numero.Next(20, 30);
            }
            else if (j == 3)
            {
                carton[i, j] = numero.Next(30, 40);
            }
            else if (j == 4)
            {
                carton[i, j] = numero.Next(40, 50);
            }
            else if (j == 5)
            {
                carton[i, j] = numero.Next(50, 60);
            }
            else if (j == 6)
            {
                carton[i, j] = numero.Next(60, 70);
            }
            else if (j == 7)
            {
                carton[i, j] = numero.Next(70, 80);
            }
            else if (j == 8)
            {
                carton[i, j] = numero.Next(80, 90);
            }
        }
    }
    int aux0 = 0;
    int aux1 = 0;
    int aux2 = 0;
    int aux3 = 0;
    int aux4 = 0;
    int aux5 = 0;
    int aux6 = 0;
    int aux7 = 0;
    int aux8 = 0;
    int cont0 = 0;
    int cont1 = 0;
    int cont2 = 0;
    int cont3 = 0;
    int cont4 = 0;
    int cont5 = 0;
    int cont6 = 0;
    int cont7 = 0;
    int cont8 = 0;

    for (int i = 0; i < 3; i++)
    {

        for (int j = 0; j < 9; j++)
        {
            if (j == 0)
            {
                if (carton[i, j] != aux0)
                {
                    if (cont0 < 2)
                    {
                        Console.Write("\t\n\n " + carton[i, j]);
                        aux0 = carton[i, j];
                    }
                    else
                    {
                        Console.Write("\t\n\n " + "X");
                    }
                }
                else
                {
                    Console.Write("\t\n\n " + "X");
                }
                cont0++;
            }
            else if (j == 1)
            {
                if (carton[i, j] != aux1)
                {
                    if (cont1 < 2)
                    {
                        Console.Write("\t " + carton[i, j]);
                        aux1 = carton[i, j];
                    }
                    else
                    {
                        Console.Write("\t " + "X");
                    }

                }
                else
                {
                    Console.Write("\t " + "X");
                }
                cont1++;
            }

            else if (j == 2)
            {
                if (carton[i, j] != aux2)
                {
                    if (cont2 < 2)
                    {
                        Console.Write("\t " + carton[i, j]);
                        aux2 = carton[i, j];
                    }
                    else
                    {
                        Console.Write("\t " + "X");
                    }
                }
                else
                {
                    Console.Write("\t " + "X");
                }
                cont2++;
            }
            else if (j == 3)
            {
                if (carton[i, j] != aux3)
                {
                    if (cont3 < 2)
                    {
                        Console.Write("\t " + carton[i, j]);
                        aux3 = carton[i, j];
                    }
                    else
                    {
                        Console.Write("\t " + "X");
                    }
                }
                else
                {
                    Console.Write("\t " + "X");
                }
                cont3++;
            }
            else if (j == 4)
            {
                if (carton[i, j] != aux4)
                {
                    if (cont4 < 2)
                    {
                        Console.Write("\t " + carton[i, j]);
                        aux4 = carton[i, j];
                    }
                    else
                    {
                        Console.Write("\t " + "X");
                    }
                }
                else
                {
                    Console.Write("\t " + "X");
                }
                cont4++;
            }
            else if (j == 5)
            {
                if (carton[i, j] != aux5)
                {
                    if (cont5 < 2)
                    {
                        Console.Write("\t " + carton[i, j]);
                        aux5 = carton[i, j];
                    }
                    else
                    {
                        Console.Write("\t " + "X");
                    }
                }
                else
                {
                    Console.Write("\t " + "X");
                }
                cont5++;
            }
            else if (j == 6)
            {
                if (carton[i, j] != aux6)
                {
                    if (cont6 < 2)
                    {
                        Console.Write("\t " + carton[i, j]);
                        aux6 = carton[i, j];
                    }
                    else
                    {
                        Console.Write("\t " + "X");
                    }
                }
                else
                {
                    Console.Write("\t " + "X");
                }
                cont6++;
            }
            else if (j == 7)
            {
                if (carton[i, j] != aux7)
                {
                    if (cont7 < 2)
                    {
                        Console.Write("\t " + carton[i, j]);
                        aux7 = carton[i, j];
                    }
                    else
                    {
                        Console.Write("\t " + "X");
                    }
                }
                else
                {
                    Console.Write("\t " + "X");
                }
                cont7++;
            }
            else if (j == 8)
            {
                if (carton[i, j] != aux8)
                {
                    if (cont8 < 2)
                    {
                        Console.Write("\t " + carton[i, j]);
                        aux8 = carton[i, j];
                    }
                    else
                    {
                        Console.Write("\t " + "X");
                    }
                }
                else
                {
                    Console.Write("\t " + "X");
                }
                cont8++;
            }
        }
    }
    Console.WriteLine("\n");
    Console.WriteLine("Desea otro carton precione 0 si no precione 1");
    s = int.Parse(Console.ReadLine());
} while (s != 1);

































