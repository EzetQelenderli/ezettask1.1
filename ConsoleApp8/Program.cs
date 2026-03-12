//string word = Console.ReadLine();
//int count = 0;
//for (int i = 0; i < word.Length; i++)
//{
//    if (word[i]=='a'|| word[i] == 'o' || word[i]=='u'|| word[i] == 'e' || word[i]=='i')
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);
//merekkeb ededleri tap
//int[] eded = { 2, 79, 16, 49, 40, 89, 20 };


//for (int i = 0; i < eded.Length; i++)
//{
//    int n = eded[i];
//    int count= 0;
//    for (int j = 2; j <= n; j++)
//    {
//        if (n % j == 0)
//            count+= eded[i];
//        break;
//    }
//    Console.WriteLine(count);

//}
//int[] eded = { 2,8,10,78};
//int x = 8 ;
//bool tapildi= false;
//for (int i = 0; i <eded.Length; i++)
//    if (eded[i]==x)
//{
//        Console.WriteLine(i);
//        tapildi = true;
//        break;
//}
//if(!tapildi)
//{
//    Console.WriteLine("not faund");
//}
//int n = 18;
//int x = 0;
//for (int i = 0; i <n; i++)
//{

//}sual1
//class Program
//{
//    public static void Main()
//    {
//        int n = 80;
//        Console.WriteLine(sayinitap(n));
//    }
//    static int sayinitap(int n)
//    {
//        int say = 0;
//        for (int i = 0; i <= n; i++)
//        {
//            if (i >= 10 && i <= 99)
//            {
//                say++;
//            }

//        }
//        return say;
//    }


//Sual 2
//}
//class Program
//{
//    public static void Main()
//    {
//        int x = 6;
//        int y = 5;
//        Console.WriteLine(quvvetihesabla( x, y));
//    }
//    public static double quvvetihesabla(int x, int y)
//    {
//        double netice = 1;
//        for (int i = 0; i < y; i++)
//            netice = netice * x;
//        return netice;
//    }
//} sual 3
//class Program
//{
//    public static void Main()
//    {
//        int[] x = { 10, 90, 37, 22 };
//        Console.WriteLine(ceminitap(x));
//    }
//    public static int ceminitap(int[] x)
//    {
//        int cem = 0;
//        for (int i = 0; i < x.Length; i++)
//        {
//            if (x[i]%5 == 0)
//            {
//                cem += x[i];
//            }
//        }
//        return cem;
//    }
//}

//Sual4
//class Program
//{
//    public static void Main()
//    {
//        int[] x = [10, 68, 90, 67];
//        Console.WriteLine(enboyuktap(x));
//    }
//    public static int enboyuktap(int[]x)
//    {
//        int max  = 0;
//        for (int i = 0; i < x.Length; i++)
//        {
//            if (x[i]>max)
//            {
//                max = x[i];
//            }
//        }
//        return max;
//    }
////} 
/////sual 5
//class Program
//{
//    public static void Main()
//    {
//        int x = 6;
//        int y = 12;
//        enboyukeded(x, y);
//    }
//    public static void enboyukeded(int x, int y)
//    {
//        if (x > y)
//        {
//            Console.WriteLine(x * 10 + y);
//        }
//        else
//        {
//            Console.WriteLine(y * 10 + x);
//        }

//    }
//}