using System;
using System.Linq;

namespace Tes1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int K;
            int[] A;

            //Tes 1
            A = new int[] { 4, 35, 80, 123, 12345, 44, 8, 5 };
            K = 10;
            Console.Write("Contoh Array : ");
            TampilkanArray(A);
            Console.WriteLine($"K = {K}");
            Console.WriteLine("Hasil");
            Solution(A, K);

            Console.WriteLine();
            Console.WriteLine();

            //Tes 2
            A = new int[] { 4, 35, 80, 123, 12345, 44, 8, 5, 24, 3 };
            K = 4;
            Console.Write("Contoh Array : ");
            TampilkanArray(A);
            Console.WriteLine($"K = {K}");
            Console.WriteLine("Hasil");
            Solution(A, K);

            Console.WriteLine();
            Console.WriteLine();

            //Tes 3
            A = new int[] { 4, 35, 80, 123, 12345, 44, 8, 5, 24, 3, 22, 35 };
            K = 4;
            Console.Write("Contoh Array : ");
            TampilkanArray(A);
            Console.WriteLine($"K = {K}");
            Console.WriteLine("Hasil");
            Solution(A, K);

            Console.ReadLine();
        }

        private static void TampilkanArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (i != a.Length - 1)
                {
                    Console.Write($"{a[i]}, ");
                }
                else
                {
                    Console.Write(a[i]);
                }
            }
            Console.WriteLine();
        }

        private static void Solution(int[] A, int K)
        {
            int panjangSel = A.Max().ToString().Length;

            if (A.Length > K)
            {
                int jumlahBaris = (A.Length + 1) / K;
                int indexAwal = 0;
                int indexAkhir = K;
                int panjangBatasAtasBawah = K * panjangSel + K + 1;
                for (int n = 0; n < jumlahBaris; n++)
                {
                    for (int i = 0; i < panjangBatasAtasBawah; i++)
                    {
                        if (i % (panjangSel + 1) == 0)
                        {
                            Console.Write("+");
                        }
                        else
                        {
                            Console.Write("-");
                        }
                    }
                    Console.WriteLine();
                    for (int i = indexAwal; i < indexAkhir; i++)
                    {
                        int panjangElemen = A[i].ToString().Length;
                        if (i == indexAwal)
                        {
                            Console.Write("|");
                        }
                        if (panjangElemen != panjangSel)
                        {
                            for (int j = 0; j <= panjangSel - panjangElemen; j++)
                            {
                                if (j == panjangSel - panjangElemen)
                                {
                                    Console.Write(A[i]);
                                    Console.Write("|");
                                }
                                else
                                {
                                    Console.Write(" ");
                                }
                            }
                        }
                        else
                        {
                            Console.Write(A[i]);
                            Console.Write("|");
                        }
                    }
                    indexAwal += K;
                    indexAkhir += K;
                    if (indexAkhir > A.Length)
                    {
                        indexAkhir = A.Length;
                    }
                    Console.WriteLine();
                }

                if (A.Length % K != 0)
                {
                    panjangBatasAtasBawah = (A.Length % K) * panjangSel + (A.Length % K) + 1;
                }

                for (int i = 0; i < panjangBatasAtasBawah; i++)
                {
                    if (i % (panjangSel + 1) == 0)
                    {
                        Console.Write("+");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
            }
            else
            {
                int panjangBatasAtasBawah = A.Length * panjangSel + A.Length + 1;

                for (int i = 0; i < panjangBatasAtasBawah; i++)
                {
                    if (i % (panjangSel + 1) == 0)
                    {
                        Console.Write("+");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
                for (int i = 0; i < A.Length; i++)
                {
                    int panjangElemen = A[i].ToString().Length;
                    if (i == 0)
                    {
                        Console.Write("|");
                    }
                    if (panjangElemen != panjangSel)
                    {
                        for (int j = 0; j <= panjangSel - panjangElemen; j++)
                        {
                            if (j == panjangSel - panjangElemen)
                            {
                                Console.Write(A[i]);
                                Console.Write("|");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                    }
                    else
                    {
                        Console.Write(A[i]);
                        Console.Write("|");
                    }
                }
                Console.WriteLine();
                for (int i = 0; i < panjangBatasAtasBawah; i++)
                {
                    if (i % (panjangSel + 1) == 0)
                    {
                        Console.Write("+");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
            }
        }
    }
}