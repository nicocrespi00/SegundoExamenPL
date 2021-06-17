using System;

namespace hola
{
    class Program
    {
        #region Declaración de Matrices y Asignacion de Valores
        
        /// <summary>
        /// Creamos la matriz 'pilotos' y le pasamos el metodo 'CargarPilotos'que le asignara sus valores
        /// </summary>
        static string[,] pilotos = CargarPilotos();

        /// <summary>
        /// Asigna valores de una matriz con 10 filas y 2 columnas
        /// </summary>
        /// <returns>devuelve estos valores en forma de matriz</returns>
        static string[,] CargarPilotos()
        {
            string[,] aux = new string[10, 2]
            {
                {"Leclerc","Sainz"},
                { null,null},
                { "Norris","Ricciardo"},
                { "Hamilton","Bottas"},
                { "Verstappen","Perez"},
                { null,null},
                { "Vettel","Stroll"},
                { "Russell","Latifi"},
                { null,null},
                { "Gasly","Tsunoda"}
            };
            return aux;
        }
        
        /// <summary>
        /// Creamos la matriz 'puntosPorCarrera' y le pasamos el metodo 'CargarPuntosPorCarrera'que le asignara sus valores
        /// </summary>
        static int[,] puntosPorCarrera = CargarPuntosPorCarrera();
        
        /// <summary>
        /// Asigna valores de una matriz con 10 filas y 10 columnas
        /// </summary>
        /// <returns>devuelve estos valores en forma de matriz</returns>
        static int[,] CargarPuntosPorCarrera()
        {
            int[,] aux = new int[10, 10]
            {
                {40,15,22,7,30,10,12,18,32,43},
                {0,0,0,0,0,0,0,0,0,0},
                {22,40,30,1,4,5,9,2,1,10},
                {30,25,1,22,8,9,10,1,2,1},
                {10,7,20,3,18,6,20,19,10,5},
                {0,0,0,0,0,0,0,0,0,0},
                {5,1,6,6,8,30,12,17,24,22},
                {1,9,6,3,4,15,22,20,1,30},
                {0,0,0,0,0,0,0,0,0,0},
                {15,8,14,10,22,8,13,12,10,1}
            };
            return aux;
        }
        
        /// <summary>
        /// Creamos la matriz unidimensional 'circuito' y le pasamos el metodo 'CargarCircuito'que le asignara sus valores
        /// </summary>
        static string[] circuito = CargarCircuito();
        
        /// <summary>
        /// Asigna valores de una matriz unidimensional con 10 registros
        /// </summary>
        /// <returns>devuelve estos valores en forma de matriz unidimensional</returns>
        static string[] CargarCircuito()
        {
            string[] aux = new string[10]
            {
                "Baku",
                null,
                "Monza",
                "Bahrein",
                "Spa",
                null,
                "Catalunia",
                "Interlagos",
                null,
                "Monaco"
            };
            return aux;
        }
        
        /// <summary>
        /// Creamos la matriz unidimensional 'constructores' y le pasamos el metodo 'CargarConstructores'que le asignara sus valores
        /// </summary>
        static string[] constructores = CargarConstructores();
        
        /// <summary>
        /// Asigna valores de una matriz unidimensional con 10 registros
        /// </summary>
        /// <returns>devuelve estos valores en forma de matriz unidimensional</returns>
        static string[] CargarConstructores()
        {
            string[] aux = new string[10]
            {
                "Ferrari",
                null,
                "Mclaren",
                "Mercedez",
                "Red Bull",
                null,
                "Alpha Tauri",
                "Aston Martin",
                null,
                "Williams"
            };
            return aux;
        }
        
        #endregion

        static void Main(string[] args)
        {
            int salida;
            do
            {
                salida = MostrarMenu();
            } while (salida != 5);
        }

        #region Control del programa

        private static int MostrarMenu()
        {
            int aux = 0;
            int opcionElegida;
            bool auxBool = false;
            int filaABorrar;
            int columnaABorrar;
            Console.Clear();
            DibujarEncabezado();
            Console.WriteLine("1. Pilotos");
            Console.WriteLine("2. Constructores");
            Console.WriteLine("3. Circuitos");
            Console.WriteLine("4. Campeonato de Constructores");
            Console.WriteLine("5. Salir");
            aux = ValidarEntero(1, 5, "Error, reingresa opción: ", "Opción elegida: ");
            switch (aux)
            {
                case 1:
                    opcionElegida = MostrarSubMenu("PILOTOS");
                    switch (opcionElegida)
                    {
                        case 1:
                            MostrarMatrizString(pilotos, "PILOTOS");
                            break;
                        case 2:
                            MostrarMatrizString(pilotos, "PILOTOS");
                            filaABorrar = ValidarEntero(0, 9, "Error, reingresa fila: ", "Fila elegida: ");
                            columnaABorrar = ValidarEntero(0, 1, "Error, reingrese columna: ", "Columna elegida: ");
                            ModificarInfoMatrizString(pilotos, filaABorrar, columnaABorrar, 1);
                            break;
                        case 3:
                            MostrarMatrizString(pilotos, "PILOTOS");
                            filaABorrar = ValidarEntero(0, 9, "Error, reingresa fila: ", "Fila elegida: ");
                            columnaABorrar = ValidarEntero(0, 1, "Error, reingrese columna: ", "Columna elegida: ");
                            ModificarInfoMatrizString(pilotos, filaABorrar, columnaABorrar, 2);
                            break;
                        case 4:
                            break;
                    }
                    return 0;
                case 2:
                    opcionElegida = MostrarSubMenu("CONSTRUCTORES");
                    Disparador(opcionElegida, "CONSTRUCTORES", constructores);
                    return 0;
                case 3:
                    opcionElegida = MostrarSubMenu("CIRCUITOS");
                    Disparador(opcionElegida, "CIRCUITOS", circuito);
                    return 0;
                case 4:
                    MostrarCampeonato(puntosPorCarrera, circuito, constructores);
                    return 0;
                case 5:
                    return 5;
                default:
                    return 0;
            }
        }

        static int MostrarSubMenu(string seleccion)
        {
            int aux;
            MostrarCategoria(seleccion);
            Console.WriteLine("1. Ver información");
            Console.WriteLine("2. Agregar/Editar Registros");
            Console.WriteLine("3. Eliminar Registros");
            Console.WriteLine("4. Volver al Menu Principal");
            aux = ValidarEntero(1, 4, "Error, reingresa opción: ", "Opción elegida: ");
            return aux;
        }

        private static void Disparador(int opcionElegida, string categoria, string[] aux)
        {
            int idABorrar;
            switch (opcionElegida)
            {
                case 1:
                    MostrarArrayString(aux, categoria);
                    break;
                case 2:
                    MostrarArrayString(aux, categoria);
                    idABorrar = ValidarEntero(0, 10, "Error, reingresa opción: ", "Opción elegida: ");
                    ModificarInfoArray(aux, idABorrar, 1);
                    break;
                case 3:
                    MostrarArrayString(aux, categoria);
                    idABorrar = ValidarEntero(0, 10, "Error, reingresa opción: ", "Opción elegida: ");
                    ModificarInfoArray(aux, idABorrar, 2);
                    break;
                default:
                    break;
            }
        }

        #endregion

        #region Vista de los registros

        static void MostrarMatrizString(string[,] aux, string categoria)
        {
            MostrarCategoria(categoria);
            Console.WriteLine(" ===================== 0 ========= 1 ====");
            for (int f = 0; f < aux.GetLength(0); f++)
            {
                Console.Write("|");
                Console.Write($"{ f}) {constructores[f],-12}||");
                for (int c = 0; c < aux.GetLength(1); c++)
                {
                    Console.Write($"{aux[f, c],-11}|");
                }
                Console.WriteLine();
            }
            Console.WriteLine(" ===================== 0 ========= 1 ====");
            VolverAlMenu();
        }

        static void MostrarCampeonato(int[,] aux, string[] circuito, string[] constructores)
        {
            int filaElegida;
            int columnaElegida;
            int accion;
            int puntos;
            MostrarCategoria("MUNDIAL DE CONSTRUCTORES");
            Console.WriteLine("------------------------------------------------------------");
            Console.Write("|            |");
            MostrarArrayStringMundial(circuito);
            Console.Write("Total|");
            Console.WriteLine();
            for (int f = 0; f < aux.GetLength(0); f++)
            {
                Console.Write($"|{constructores[f],-12}|");
                for (int c = 0; c < aux.GetLength(1); c++)
                {
                    Console.Write($"{aux[f, c],-3}|");
                }
                Console.Write($" {puntos = MundialPuntos(f),-4}|");
                Console.WriteLine();
            }
            Console.WriteLine("------------------------------------------------------------");

            Console.WriteLine("1.Agregar o modificar registro\n2.Eliminar registro\n3.Volver al Menu Principal");
            accion = ValidarEntero(1, 3, "Reingrese opcion: ", "Opción elegida: ");
            if (accion != 3)
            {
                filaElegida = ValidarEntero(0, 9, "Error, reingresa fila: ", "Fila elegida: ");
                columnaElegida = ValidarEntero(0, 1, "Error, reingrese columna: ", "Columna elegida: ");
                ModificarInfoMatrizInt(puntosPorCarrera, filaElegida, columnaElegida, accion);
            }
            else
                return;
        }

        static int MundialPuntos(int f)
        {
            int puntos = 0;
            for (int c = 0; c < puntosPorCarrera.GetLength(1); c++)
            {
                puntos += puntosPorCarrera[f, c];
            }
            return puntos;
        }

        static void MostrarArrayStringMundial(string[] aux)
        {
            for (int i = 0; i < aux.Length; i++)
            {
                if (aux[i] == null)
                {
                    Console.Write("   |");
                }
                else
                {
                    Console.Write(aux[i].ToCharArray(0, 3));
                    Console.Write("|");
                }
            }
        }

        static void MostrarArrayString(string[] aux, string categoria)
        {
            DibujarEncabezado();
            MostrarCategoria(categoria);
            Console.WriteLine(" --------------");
            for (int f = 0; f < aux.Length; f++)
            {
                Console.WriteLine($"|{f}) {aux[f],-12}|");
            }
            Console.WriteLine(" --------------");
            VolverAlMenu();
        }

        #endregion

        #region Manipulación de Registros (Agregar, Editar, Eliminar)

        private static void ModificarInfoMatrizString(string[,] aux, int filElegida, int columnaElegida, int accion)
        {
            for (int f = 0; f < aux.GetLength(0); f++)
            {
                if (f == filElegida && accion == 1)
                {
                    for(int c = 0; c < aux.GetLength(1); c++)
                    {
                        if(c == columnaElegida)
                        {
                            aux[f,c] = Console.ReadLine();
                            break;
                        }
                    }
                }
                else if (f == filElegida && accion == 2)
                {
                    for (int c = 0; c < aux.GetLength(1); c++)
                    {
                        if (c == columnaElegida)
                        {
                            aux[f, c] = null;
                            break;
                        }
                    }
                }
            }
        }

        private static void ModificarInfoMatrizInt(int[,] aux, int filElegida, int columnaElegida, int accion)
        {
            for (int f = 0; f < aux.GetLength(0); f++)
            {
                if (f == filElegida && accion == 1)
                {
                    for (int c = 0; c < aux.GetLength(1); c++)
                    {
                        if (c == columnaElegida)
                        {
                            aux[f, c] = ValidarEntero(0,45,"Error, reingrese valor: ","Ingrese un valor entre 0 y 45: ");
                            break;
                        }
                    }
                }
                else if (f == filElegida && accion == 2)
                {
                    for (int c = 0; c < aux.GetLength(1); c++)
                    {
                        if (c == columnaElegida)
                        {
                            aux[f, c] = 0;
                            break;
                        }
                    }
                }
            }
        }

        private static void ModificarInfoArray(string[] aux, int idABorrar, int accion)
        {
            for(int f = 0; f < aux.Length; f++)
            {
                if(f == idABorrar && accion == 1)
                {
                    aux[f] = Console.ReadLine();
                    break;
                }
                else if (f == idABorrar && accion == 2)
                {
                    aux[f] = null;
                    break;
                }
            }
        }

        #endregion

        #region Adicionales graficos
       
        static void MostrarCategoria(string categoria)
        {
            Console.Clear();
            DibujarEncabezado();
            Console.WriteLine(categoria);
            Console.WriteLine();
        }

        static void DibujarEncabezado()
        {
            string titulo = "|>>>>>>>> Formula 1 <<<<<<<<|";
            string asterisquitos = string.Empty;

            for (int i = 0; i < titulo.Length; i++)
            {
                asterisquitos += "-";
            }

            Console.BackgroundColor = ConsoleColor.DarkRed;

            Console.WriteLine(asterisquitos);
            Console.WriteLine(titulo);


            Console.WriteLine(asterisquitos);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Black;
        }

        static void VolverAlMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
        }

        #endregion

        #region Validaciones

        private static int ValidarEntero(int min, int max, string error, string entrada)
        {
            int aux;
            bool auxBool = false;
            Console.WriteLine();
            Console.Write(entrada);
            auxBool = int.TryParse(Console.ReadLine(), out aux);
            while (auxBool != true || aux < min || aux > max)
            {
                Console.Write(error);
                auxBool = int.TryParse(Console.ReadLine(), out aux);
            };
            return aux;
        }

        #endregion

    }
}

   



