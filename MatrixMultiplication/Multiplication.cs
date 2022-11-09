using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace MatrixMultiplication
{
    class Multiplication
    {
        private int N;
        private static int[,] matrixA, matrixB, matrixC;
        private DataGridView dgvA, dgvB, dgvC;
        public Multiplication(int N, DataGridView dgvA, DataGridView dgvB, DataGridView dgvC)
        {
            this.N = N;
            this.dgvA = dgvA;
            this.dgvB = dgvB;
            this.dgvC = dgvC;
        }

        public void Create()
        {
            Random random = new Random();
            matrixA = new int[N, N];
            matrixB = new int[N, N];
            matrixC = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrixA[i, j] = random.Next(10);
                    matrixB[i, j] = random.Next(10);
                }
            }
            Show();
        }

        public void CreateTest()
        {
            matrixA = new int[,]{
                {2,3,4,5},
                {9,8,7,6},
                {5,4,2,3},
                {8,7,3,4}
            };
            matrixB = new int[,]{
                {3,5,7,6},
                {2,7,6,3},
                {7,5,3,2},
                {4,3,2,5}
            };
            matrixC = new int[N, N];
            Show();
        }

        public void Show()
        {
            int oldN = N;
            if (N > 30)
            {
                N = 30;
            }
            dgvA.RowCount = N;
            dgvB.RowCount = N;
            dgvC.RowCount = N;
            dgvA.ColumnCount = N;
            dgvB.ColumnCount = N;
            dgvC.ColumnCount = N;
            for (int i = 0; i < N; i++)
            {
                dgvA.Columns[i].Width = dgvA.Rows[i].Height; // only squier matrix
                dgvB.Columns[i].Width = dgvB.Rows[i].Height; // only squier matrix
                dgvC.Columns[i].Width = 50; // only squier matrix
                for (int j = 0; j < N; j++)
                {
                    dgvA.Rows[i].Cells[j].Value = matrixA[i, j];
                    dgvB.Rows[i].Cells[j].Value = matrixB[i, j];
                    if (matrixC.Length != 0)
                        dgvC.Rows[i].Cells[j].Value = matrixC[i, j];
                }
            }
            N = oldN;
        }

        // обычное умножение квадратных матриц
        public String doMultiplication()
        {
            TimeSpan dt = new TimeSpan();
            DateTime ts;
            DateTime te;
            ts = DateTime.Now;
            for (int i = 0; i < N; i++) // row A
            {
                for (int j = 0; j < N; j++) // columns B
                {
                    int sum = 0;
                    for (int p = 0; p < N; p++)// columns A
                    {
                        sum += matrixA[i, p] * matrixB[p, j];// matrColumns[p] * other.getValue(p, j);
                    }
                    matrixC[i, j] = sum;//tmpmatr.setValue(i, j, sum as T);
                }
            }
            te = DateTime.Now;
            dt = te - ts;
            Show();
            return dt.ToString();
        }


        // создает на каждую ячеку новой матрицы новый поток, который становится в очередь в пул, если матрица слишком больншая
        public String doParralellForMultiplication()
        {
            TimeSpan dt = new TimeSpan();
            DateTime ts;
            DateTime te;
            ts = DateTime.Now;
            Parallel.For(0, N, i =>
               Parallel.For(0, N, j =>
                   matrixC[i, j] = MultiplicationElement(i, j)
            ));
            te = DateTime.Now;
            dt = te - ts;
            Show();
            return dt.ToString();
        }

        // для подсчета суммы ячейки результирующей матрицы
        int MultiplicationElement(int i, int j)
        {
            int sum = 0;
            for (int p = 0; p < N; p++)
                sum += matrixA[i, p] * matrixB[p, j];
            return sum;
        }


        public String doParralelCannonOther(int dim)
        {
            matrixC = new int[N, N]; //clear C

            TimeSpan dt;
            DateTime ts;
            DateTime te;
            ts = DateTime.Now;

            Task[] tasks = new Task[dim];

            for (int k = 0; k < N; k++) // N is col matr A or row matr B  
            {
                for (int i = 0; i < N; i++)//row
                {
                    for (int j = 0; j < N; j++)//col
                    {
                        int a = (i * N + j + 1);

                        if (a % dim == 1)
                        {
                            if (a > 1)
                            {
                                Task.WaitAll(tasks.ToArray());
                                //tasks = new Task[dim]; // можно не обнулять, просто еще раз проверится завершенная задача прошлой неявной итерации Task-ов (от 0 до dim)
                            }
                        }

                        // i и j ??????
                        int ci = i;
                        int cj = j;
                        int ck = k;
                        tasks[(i * N + j) % dim] = Task.Run(
                            () =>
                            {
                                try
                                {
                                    if (ck == 0)
                                        matrixC[ci, cj] += matrixA[ci, (cj + ci) % N] * matrixB[(ci + cj) % N, cj];
                                    else
                                        matrixC[ci, cj] += matrixA[ci, (cj + ci + ck) % N] * matrixB[(ci + cj + ck) % N, cj];
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e);
                                    Console.WriteLine("Элемет: " + i.ToString() + ":" + j.ToString() + " K=" + k.ToString());
                                }
                            });
                    }
                }
            }
            Task.WaitAll(tasks.ToArray());

            void MulElement(int i, int j)
            {
                for (int k = 0; k < N; k++) // N is col matr A or row matr B  
                {
                    try
                    {
                        if (k == 0)
                            matrixC[i, j] += matrixA[i, (j + i) % N] * matrixB[(i + j) % N, j];
                        else
                            matrixC[i, j] += matrixA[i, (j + i + k) % N] * matrixB[(i + j + k) % N, j];
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        Console.WriteLine("Элемет: " + i.ToString() + ":" + j.ToString() + " K=" + k.ToString());
                    }
                }
            }

            te = DateTime.Now;
            dt = te - ts;
            Show();
            return dt.ToString();
        }

        public String doParralelCannon(int dim)
        {
            matrixC = new int[N, N]; //clear C

            TimeSpan dt;
            DateTime ts;
            DateTime te;
            ts = DateTime.Now;

            Task[] tasks = new Task[dim];

            // весь принцип цикла ниже (пример для матрицы 2x2 в 3 потока)
            /*tasks[0] = Task.Run(
                            () =>
                            {
                                MulElement(0, 0);
                            });
            tasks[1] = Task.Run(
                            () =>
                            {
                                MulElement(0, 1);
                            });
            tasks[2] = Task.Run(
                            () =>
                            {
                                MulElement(1, 0);
                            });
            Task.WaitAll(tasks.ToArray());
            tasks[0] = Task.Run(
                            () =>
                            {
                                MulElement(1, 1);
                            });
            Task.WaitAll(tasks.ToArray());*/



            for (int i = 0; i < N; i++)//row
            {
                for (int j = 0; j < N; j++)//col
                {
                    int a = (i * N + j + 1);

                    if (a % dim == 1)
                    {
                        if (a > 1)
                        {
                            Task.WaitAll(tasks.ToArray());
                            //tasks = new Task[dim]; // можно не обнулять, просто еще раз проверится завершенная задача прошлой неявной итерации Task-ов (от 0 до dim)
                        }
                    }

                    // i и j ??????
                    int ci = i;
                    int cj = j;
                    tasks[(i * N + j) % dim] = Task.Run(
                        () =>
                        {
                            MulElement(ci, cj);
                        });
                }
            }
            Task.WaitAll(tasks.ToArray());

            void MulElement(int i, int j)
            {
                for (int k = 0; k < N; k++) // N is col matr A or row matr B  
                {
                    try
                    {
                        if (k == 0)
                            matrixC[i, j] += matrixA[i, (j + i) % N] * matrixB[(i + j) % N, j];
                        else
                            matrixC[i, j] += matrixA[i, (j + i + k) % N] * matrixB[(i + j + k) % N, j];
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        Console.WriteLine("Элемет: " + i.ToString() + ":" + j.ToString()+" K=" + k.ToString());
                    }
                }
            }

            te = DateTime.Now;
            dt = te - ts;
            Show();
            return dt.ToString();
        }

        public String doMultiplicationCannonNonCreateMatr()
        {
            matrixC = new int[N, N]; //clear C

            TimeSpan dt;
            DateTime ts;
            DateTime te;
            ts = DateTime.Now;

            for (int s = 0; s < N; s++) // N is col matr A or row matr B  
            {
                for (int i = 0; i < N; i++)//row
                {
                    for (int j = 0; j < N; j++)//col
                    {
                        if (s == 0)
                            matrixC[i, j] += matrixA[i, (j + i) % N] * matrixB[(i + j) % N, j];
                        else
                            matrixC[i, j] += matrixA[i, (j + i + s) % N] * matrixB[(i + j + s) % N, j];
                    }
                }
            }
            // тоже самое
            // вместо ((j + i) % N + 1) % N    ->  ((j + i) % N + s) % N)
            // т.к. 1 было для смещения при создании новых матриц matrixA и matrixB
            // вопрос s ли добавлять... это преполагалось матрицей процессоров 3x3

            /* for (int s = 0; s < N; s++) // N is col matr A or row matr B  
             {
                 if(s == 0)
                 {
                     for (int i = 0; i < N; i++)//row
                     {
                         for (int j = 0; j < N; j++)//col
                         {
                             matrixC[i, j] += matrixA[i, (j + i) % N] * matrixB[(i + j) % N, j];
                         }
                     }
                 }
                 else
                 {
                     for (int i = 0; i < N; i++)//row
                     {
                         for (int j = 0; j < N; j++)//col
                         {
                             matrixC[i, j] += matrixA[i, ((j + i) % N + 1) % N] * matrixB[((i + j) % N + 1) % N, j];
                         }
                     }
                 }
             }*/

            te = DateTime.Now;
            dt = te - ts;
            Show();
            return dt.ToString();
        }

        public String doMultiplicationCannon()
        {
            matrixC = new int[N, N]; //clear C

            TimeSpan dt;
            DateTime ts;
            DateTime te;
            ts = DateTime.Now;

            int[,] tmpA = new int[N, N];
            int[,] tmpB = new int[N, N];

            int[,] newTmpA;
            int[,] newTmpB;

            // оказывается передается ссылка на int[,] а не новый обьект
            int[,] getNewMatrix(int[,] matr)
            {
                int[,] matrnew = new int[N, N];
                for (int i = 0; i < N; i++)//row
                {
                    for (int j = 0; j < N; j++)//col
                    {
                        matrnew[i, j] = matr[i, j];
                    }
                }
                return matrnew;
            }


            // первоначальное смещение матриц на 0, 1, 2, 3 ... влево для сторок матрицы A и вверх столбцов B c записью в новые матрицы
            void firstShift()
            {
                for (int i = 0; i < N; i++)//row
                {
                    for (int j = 0; j < N; j++)//col
                    {
                        tmpA[i, j] = matrixA[i, (j + i) % N]; // (j+i) % N  col matrA
                        tmpB[i, j] = matrixB[(i + j) % N, j];
                    }
                }
                newTmpA = getNewMatrix(tmpA);// for s=0 
                newTmpB = getNewMatrix(tmpB);
            }

            // смещение влево и вверх соответственно для newMatrA и newMatrB
            void doShift()
            {
                for (int i = 0; i < N; i++)//row
                {
                    for (int j = 0; j < N; j++)//col
                    {
                        newTmpA[i, j] = tmpA[i, (j + 1) % N]; // col matrA
                        newTmpB[i, j] = tmpB[(i + 1) % N, j];
                    }
                }
                tmpA = getNewMatrix(newTmpA);
                tmpB = getNewMatrix(newTmpB);
            }

            firstShift();
            for (int s = 0; s < N; s++) // N is col matr A or row matr B  
            {
                for (int i = 0; i < N; i++)//row
                {
                    for (int j = 0; j < N; j++)//col
                    {
                        matrixC[i, j] += newTmpA[i, j] * newTmpB[i, j]; // (j+i) % N  col matrA
                    }
                }
                if (s != N - 1)
                    doShift();
            }

            //firstShift();
            //doShift();
            //matrixC = newMatrixA;

            te = DateTime.Now;
            dt = te - ts;
            Show();
            return dt.ToString();
        }













        /*void code()
        {
            TimeSpan dt;
            DateTime ts;
            DateTime te;
            ts = DateTime.Now;

            int threedsMatrixDimension = 3;
            int parthsInRow = N / threedsMatrixDimension;
            int parthsInColumn = N / threedsMatrixDimension;

            Task[] tasks = new Task[threedsMatrixDimension * threedsMatrixDimension];

            for (int r = 0; r < threedsMatrixDimension; r++)
            {
                for (int c = 0; c < threedsMatrixDimension; c++)
                {
                    int sum = 0;
                    for (int q = 0; q < N; q++)// columns A
                    {
                        sum += matrixA[r, c] * matrixB[, j];// matrColumns[p] * other.getValue(p, j);
                    }
                    matrixC[r, c] = sum;
                }
            }

            // циклы отвечают за движение матрицы потоков по матрице NxN 
            // p - parth
            for (int pr = 0; pr < parthsInRow; pr++) // r - row
            {
                for (int pc = 0; pc < parthsInColumn; pc++) // c - column
                {
                    // назначение задачи на каждый поток 3х3 (9 потоков)
                    for (int r = 0; r < threedsMatrixDimension; r++)
                    {
                        for (int c = 0; c < threedsMatrixDimension; c++)
                        {
                            // сама задача на поток
                            tasks[r * threedsMatrixDimension + c] = Task.Run(
                                () =>
                                {
                                    try
                                    {

                                        int im = pr * threedsMatrixDimension + r;
                                        int jm = pc * threedsMatrixDimension + c;


                                        for (int i = 0; i < N; i++) // row A
                                        {
                                            for (int j = 0; j < N; j++) // columns B
                                            {
                                                int sum = 0;
                                                for (int p = 0; p < N; p++)// columns A
                                                {
                                                    sum += matrixA[i, p] * matrixB[p, j];// matrColumns[p] * other.getValue(p, j);
                                                }
                                                matrixC[im, jm] = sum;//tmpmatr.setValue(i, j, sum as T);
                                            }
                                        }

                                    }
                                    catch (Exception e)
                                    {
                                        MessageBox.Show(e.StackTrace);
                                    }
                                }
                            );
                        }
                    }
                    // WaitAll()
                    Task.WaitAll(tasks.ToArray());
                }
            }


            for (int i = 0; i < N; i++) // row A
            {
                for (int j = 0; j < N; j++) // columns B
                {
                    int sum = 0;
                    for (int p = 0; p < N; p++)// columns A
                    {
                        sum += matrixA[shiftI, p] * matrixB[p, shiftJ]; // matrColumns[p] * other.getValue(p, j);
                    }
                    matrixC[i, j] = sum; //tmpmatr.setValue(i, j, sum as T);

                    shiftJ--;
                    //shiftJ %= N -=1;
                }
                shiftJ += 1;
                shiftI--;
            }

            *//*// PE(i , j)
            k:= (i + j) mod N;
            a:= a[i][k];
            b:= b[k][j];
                c[i][j] := 0;
                for (l := 0; l < N; l++)
                {
                    c[i][j] := c[i][j] + a * b;
                    concurrently {
                        send a to PE(i, (j +N − 1) mod N);
                send b to PE((i +N − 1) mod N, j);
                }
                with {
                    receive a' from PE(i, (j + 1) mod N);
                    receive b' from PE((i + 1) mod N, j );
                }
                a := a';
                b := b';
            }*//*

            te = DateTime.Now;
            dt = te - ts;
            Show();
            //return dt.ToString();
        }*/
    }
}
