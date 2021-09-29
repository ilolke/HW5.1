using System;

namespace HW5._1
{
    class Program
    {
        // Задание 1.
        // Воспользовавшись решением задания 3 четвертого модуля
        // 1.1. Создать метод, принимающий число и матрицу, возвращающий матрицу умноженную на число
        // 1.2. Создать метод, принимающий две матрицу, возвращающий их сумму
        // 1.3. Создать метод, принимающий две матрицу, возвращающий их произведение




        /// <summary>
        /// Заполнение матрицы случайными числами
        /// </summary>
        /// <param name="mat"></param>
        static void fillRandom(int[,] mat)
        {

            Random random = new Random();
            for (int a = 0; a < mat.GetLength(0); a++)
            {
                for (int b = 0; b < mat.GetLength(1); b++)
                {
                    mat[a, b] = random.Next(-999, 1000);
                }

            }
            
        }

        /// <summary>
        /// Печать матрицы на экран
        /// </summary>
        /// <param name="mat"></param>
        static void writeMatrix(int[,] mat)
        {

            for (int a = 0; a < mat.GetLength(0); a++)
            {
                for (int b = 0; b < mat.GetLength(1); b++)
                {
                    Console.Write($" {mat[a, b],10} ");
                }
                Console.WriteLine();
            }

        }

        /// <summary>
        /// Метод умножения матрицы на число
        /// </summary>
        /// <param name="Mat1"></Исходная матрица>
        /// <param name="Mult"></Множитель>
        /// <returns></returns>
        static int[,] multNumbMatrix(int[,] mat1, int Mult)
        {
            int[,] matrix = new int[mat1.GetLength(0), mat1.GetLength(1)];


            for (int a = 0; a < mat1.GetLength(0); a++)
            {
                for (int b = 0; b < mat1.GetLength(1); b++)
                {
                    matrix[a, b] = mat1[a, b] * Mult;
                }

            }
            return matrix;
        }

        /// <summary>
        /// Сложение матриц
        /// </summary>
        /// <param name="mat1"></param>
        /// <param name="mat2"></param>
        /// <returns></returns>
        static int[,] SumMatrix(int[,] mat1, int[,] mat2)
        {
            int[,] matrix = new int[mat1.GetLength(0), mat1.GetLength(1)];

            for (int a = 0; a < mat1.GetLength(0); a++)
            {
                for (int b = 0; b < mat1.GetLength(1); b++)
                {
                    matrix[a, b] = mat1[a, b] + mat2[a, b];
                }

            }
            return matrix;
        }

        /// <summary>
        /// Вычитание матриц
        /// </summary>
        /// <param name="mat1"></param>
        /// <param name="mat2"></param>
        /// <returns></returns>
        static int[,] SubMatrix(int[,] mat1, int[,] mat2)
        {
            int[,] matrix = new int[mat1.GetLength(0), mat1.GetLength(1)];

            for (int a = 0; a < mat1.GetLength(0); a++)
            {
                for (int b = 0; b < mat1.GetLength(1); b++)
                {
                    matrix[a, b] = mat1[a, b] - mat2[a, b];
                }

            }
            return matrix;
        }

        /// <summary>
        /// Умножение матрицы
        /// </summary>
        /// <param name="mat1"></param>
        /// <param name="mat2"></param>
        /// <param name="Mult"></param>
        /// <returns></returns>
        static int[,] multMatrix(int[,] mat1, int[,] mat2)
        {
            int[,] matrix = new int[mat1.GetLength(0), mat1.GetLength(1)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int a = 0; a < mat2.GetLength(0); a++)
                {
                    for (int b = 0; b < mat1.GetLength(0); b++)
                    {
                        matrix[i, a] += mat1[i, b] * mat2[b, a];

                    }

                }

            }

            return matrix;
        }




        static void Main(string[] args)
        {

            int rowA;
            int columnA;
            int rowB;
            int columnB;
            int Mult;
            double number;

            int[,] matrixA;
            int[,] matrixB;
            int[,] matrixC;


            ////Инициализация, проверка правильности ввода и заполнение матрицы A
            do
            {
                rowA = -1;
                try
                {
                    Console.Write("Введите число строк матрицы A:");
                    rowA = Convert.ToInt32(Console.ReadLine());
                    if (rowA < 0)
                    {
                        Console.Write("Матриц с отрицательным количеством строк не существует введите значение > 0 \n");
                    }

                }
                catch (FormatException)
                {
                    Console.Write("Неверный формат ввода. Введите число действительного типа \n");
                }
            } while (rowA < 0);


            do
            {
                columnA = -1;
                try
                {
                    Console.Write("Введите число стобцов матрицы A:");
                    columnA = Convert.ToInt32(Console.ReadLine());
                    if (columnA < 0)
                    {
                        Console.Write("Матриц с отрицательным количеством столбцов не существует введите значение > 0 \n");
                    }

                }
                catch (FormatException)
                {
                    Console.Write("Неверный формат ввода. Введите число действительного типа \n");
                }

            } while (columnA < 0);


            matrixA = new int[rowA, columnA];
            Console.WriteLine();

            //Инициализация, проверка правильности ввода и заполнение матрицы B
            do
            {
                rowB = -1;
                try
                {
                    Console.Write("Введите число строк матрицы B:");
                    rowB = Convert.ToInt32(Console.ReadLine());
                    if (rowB < 0)
                    {
                        Console.Write("Матриц с отрицательным количеством столбцов не существует введите значение > 0 \n");
                    }

                }
                catch (FormatException)
                {
                    Console.Write("Неверный формат ввода. Введите число действительного типа \n");
                }        

            } while (rowB < 0);

            do
            {
                columnB = -1;
                try
                {
                    Console.Write("Введите число стобцов матрицы B:");
                    columnB = Convert.ToInt32(Console.ReadLine());
                    if (columnB < 0) 
                    {
                        Console.Write("Матриц с отрицательным количеством столбцов не существует введите значение > 0 \n");
                    }

                }
                catch (FormatException)
                {
                    Console.Write("Неверный формат ввода. Введите число действительного типа \n");
                }                     


           
            } while (columnB < 0);


            matrixB = new int[rowB, columnB];
            Console.WriteLine();
            Console.Write("Введите число множитель:");
            Mult = Convert.ToInt32(Console.ReadLine());



            //Заполнение и вывод исходных матриц на экран
            Console.WriteLine("Исходная матрица A");
            fillRandom(matrixA);
            writeMatrix(matrixA);

            Console.WriteLine();

            Console.WriteLine("Исходная матрица B");
            fillRandom(matrixB);
            writeMatrix(matrixB);
            Console.WriteLine();


            //Произведение матрицы А на число:
            matrixC = multNumbMatrix(matrixA, Mult);
            Console.WriteLine($"Произведение матрицы А на множитель {Mult}"); ;
            writeMatrix(matrixC);
            Console.WriteLine();

            matrixC = multNumbMatrix(matrixB, Mult);
            Console.WriteLine($"Произведение матрицы B на множитель {Mult}");
            writeMatrix(matrixC);
            Console.WriteLine();




            if (matrixA.GetLength(0) == matrixB.GetLength(0) && matrixA.GetLength(1) == matrixB.GetLength(1))
            {
                matrixC = SumMatrix(matrixA, matrixB);
                Console.WriteLine($"Сумма матриц А и B");
                writeMatrix(matrixC);
                Console.WriteLine();

                matrixC = SubMatrix(matrixA, matrixB);
                Console.WriteLine($"С = А - B");
                writeMatrix(matrixC);
                Console.WriteLine();

                matrixC = SubMatrix(matrixB, matrixA);
                Console.WriteLine($"С = B - A");
                writeMatrix(matrixC);
                Console.WriteLine();

            }
            else
            {

                Console.WriteLine("Размерность матриц отличаеться! \nОперации сложении и вычитания выполнить нельзя!!! \n");

            }

            if (columnA == rowB || rowA == columnB)
            {
                matrixC = multMatrix(matrixA, matrixB);
                Console.WriteLine($"Произведение матриц А и В:");
                writeMatrix(matrixC);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"Умножить матрицы невозможно! Произведение двух матриц АВ имеет смысл только в том случае, когда число столбцов матрицы А совпадает с числом строк матрицы В. ");
            }








        }
    }
}
