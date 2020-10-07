using System;

namespace htsnt
{
    class Program
    {
        #region htnt
        static bool kt(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                {
                    return false;
                }
            return true;

        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("nhap so n:");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < n; i++)
                if (kt(i))
                {
                    Console.WriteLine("noi dung hien thi:{0}", i);


                }
            #endregion



        }
}
}
