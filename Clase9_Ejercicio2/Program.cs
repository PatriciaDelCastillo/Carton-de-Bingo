//Con los conocimientos vistos hasta ahora en clase realizar un programa que haga lo siguiente:

//Generar un programa que cree un cartón de bingo aleatorio y lo muestre por pantalla

//1)    Cartón de 3 filas por 9 columnas
//2)    El cartón debe tener 15 números y 12 espacios en blanco
//3)    Cada fila debe tener 5 números
//4)    Cada columna debe tener 1 o 2 números
//5)    Ningún número puede repetirse
//6)    La primer columna contiene los números del 1 al 9, la segunda del 10 al 19, la tercera del 20 al 29, así sucesivamente hasta la última columna la cual contiene del 80 al 90
//7)    Mostrar el carton por pantalla

int fil =2;
int col = 2;
int[,] carton = new int[fil, col];
Random rd = new Random();
int contador =0;
int aux1 = 0;
int aux2 = 0;

for (int columna = 0; columna < carton.Length; columna++)


{
    
    for (int fila = 0; fila < carton.Length;fila++)

    {
        
        if (columna == 0)
        {
            int num = rd.Next(1, 10);
            Console.WriteLine("numero" + num);
           
            if (num >= 1 && num <= 9)
            {                     
                    
                if (aux1 != num)
                {
                            
                            
                     if (contador < 2)
                     {
                        contador++;
                        Console.WriteLine("primera columna  " + num);
                        
                     }
                    
                }
               
                aux1 = num;

            }

        }


        
        if (columna == 1 )
        {
            int num = rd.Next(10, 20);
            Console.WriteLine("numero" + num);
            if (num >= 10 && num <= 19)
            {
                if (aux1 != num)
                {


                    if (contador < 2)
                    {
                        contador++;
                        Console.WriteLine("segunda columna  " + num);
                        
                    }

                }

                aux1 = num;

            }

        }
    }
}


//Console.WriteLine("=========================");
//Console.WriteLine("+  " + aux1 + "    +    " + aux2 +         "       +     ");
//Console.WriteLine("+  " + aux1 + "    +    " + aux2 +         "       +     ");
//Console.WriteLine("+  " + aux1 + "    +    " + aux2 +         "       +     ");
//Console.WriteLine("=========================");
