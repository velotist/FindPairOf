using System;

class Program
{
    static int[] itemList = new int[100];

    static int SockMerchant(int n, int[] ar)
    {
        if (n == 0 || ar == null)
            throw new ArgumentNullException("n, ar");

        int pairs;
        int previousItem = ar[0];
        int x = 0;

        SortList(ar);

        foreach (var item in ar)
        {
            
            if (item == previousItem)
                itemList[x] = item;
            x++;
        }

        pairs = x % 2;

        return pairs;
    }

    static void SortList(int[] ar)
    {
        if (ar == null)
            throw new ArgumentNullException("ar");

        int temp;
        int j;

        for (int i = 1; i < ar.Length; i++)
        {
            j = i;

            while (j > 0 && (ar[j - 1] > ar[j]))
            {
                temp = ar[j - 1];
                ar[j - 1] = ar[j];
                ar[j] = temp;
                j--;
            }
        }
    }

    static void Main(string[] args)
    {
        if (args == null)
            throw new ArgumentNullException("args");

        int n = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
        int result = SockMerchant(n, ar);

        Console.WriteLine(result);
    }
}