namespace ConsoleAppTask7Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            /* 1) Verilmish metnde {a} simvolun sayi {b} simvolun sayinda nece defe coxdur?
             */

            //Console.Write("Metni daxil edin: ");
            //string text = Console.ReadLine();

            //Console.Write("A simvolunu daxil edin: ");
            //char a = Console.ReadKey().KeyChar;

            //Console.Write("\nB simvolunu daxil edin: ");
            //char b = Console.ReadKey().KeyChar;

            //int aCount = 0, bCount = 0;

            //foreach (char c in text)
            //{
            //    if (c == a)
            //    {
            //        aCount++;
            //    }
            //    else if (c == b)
            //    {
            //        bCount++;
            //    }
            //}

            //if (aCount > bCount)
            //{
            //    Console.WriteLine("\n{0} simvolunun sayi {1} simvolunun sayindan {2} defe coxdur.", a, b, aCount - bCount);
            //}
            //else if (bCount > aCount)
            //{
            //    Console.WriteLine("\n{0} simvolunun sayi {1} simvolunun sayindan {2} defe coxdur.", b, a, bCount - aCount);
            //}
            //else
            //{
            //    Console.WriteLine("\n{0} simvolunun sayi {1} simvolunun sayina beraberdir.", a, b);
            //}
            #endregion

            #region Task2

            //Console.Write("metni daxil edin:");
            //string metn = Console.ReadLine();

            //double count1 = 0;
            //for (int i = 0; i < metn.Length; i += 2)
            //{
            //    if (metn[i] != 'a')
            //    {
            //        count1++;
            //        break;
            //    }
            //}
            //if (count1 == 0)
            //{
            //    Console.WriteLine("sol terefden tek yerde dayanan simvollarin hamisi {a} simvoludur");
            //}
            //else
            //{
            //    Console.WriteLine("sol terefden tek yerde dayanan simvollarin hamisi {a} simvolu deyil");
            //}

            #endregion

            #region Task3

            //Console.Write("metni daxil edin:");
            //string metn = Console.ReadLine();
            //double count1 = 0;
            //for (int i = 0; i < metn.Length; i+=2)
            //{
            //    if (metn[i] == 'b')
            //    {
            //        count1++;
            //    }
            //}
            //Console.WriteLine($"Verilmish metnde sol terefden tek yerde dayanan simvollardan {count1} b-ye beraberdir");
            //Console.WriteLine(count1);

            #endregion

            #region Task4

            //Console.Write("metni daxil edin:");
            //string metn = Console.ReadLine();
            //double sira = 0;
            //for (int i = 0; i < metn.Length; i ++)
            //{
            //    if (metn[i] == 'a')
            //    {
            //        sira = i;
            //        break;
            //    }
            //}
            //if (sira % 2 == 0) 
            //{
            //    Console.WriteLine("tek yerdedir");
            //}
            //else
            //{
            //    Console.WriteLine("cut yerdedir");
            //}

            #endregion

            #region Task4v2

            //Console.Write("Metni daxil edin:");
            //string str = Console.ReadLine();
            //int index = str.IndexOf("a");

            //if (index % 2 == 0) 
            //{
            //    Console.WriteLine("Tek yerdedir");
            //}
            //else
            //{
            //    Console.WriteLine("Cut yerdedir");
            //}

            #endregion

            #region Task5

            //Console.Write("metni daxil edin:");
            //string metn = Console.ReadLine();
            //string simvol = "";
            //for (int i = 0; i < metn.Length; i++)
            //{
            //    if (metn[i] == 'a')
            //    {
            //        simvol = "a";
            //        break;
            //    }
            //    if (metn[i] == 'b')
            //    {
            //        simvol = "b";
            //        break;
            //    }
            //    if (metn[i] == 'c')
            //    {
            //        simvol = "c";
            //        break;
            //    }
            //}
            //Console.WriteLine($"Birinci gelen {simvol} simvoludur");
            //Console.WriteLine(simvol);

            #endregion

            #region Task6

            //Console.Write("Metni daxil edin:");
            //string str = Console.ReadLine();
            //int index = str.IndexOf("a");
            //int index_last = str.LastIndexOf("a");
            //if (index == index_last)
            //{
            //    Console.WriteLine("Serti odeyir");
            //}
            //else
            //{
            //    Console.WriteLine("Serti odemir");
            //}

            #endregion

            #region Task7

            //Console.Write("Metni daxil edin:");
            //string str = Console.ReadLine();
            //int index_a = str.IndexOf("a");
            //int index_b = str.IndexOf("b");
            //int index_c = str.IndexOf("c");


            //if (index_a < index_b && index_b < index_c) 
            //{
            //    Console.WriteLine("Serti odeyir");
            //}
            //else
            //{
            //    Console.WriteLine("Serti odemir");
            //}

            #endregion

            #region Task8

            //Console.Write("metni daxil edin:");
            //string metn = Console.ReadLine();

            //for (int i = 0; i < metn.Length; i++)
            //{
            //    if (metn[i] == 'a')
            //    {
            //        for (int j = 0; j < 10; j++)
            //        {
            //            Console.Write(metn[i + 1]);
            //        }
            //        break;
            //    }
            //}

            #endregion

            #region Task8v2

            //l1:
            //Console.Write("metni daxil edin:");
            //string metn = Console.ReadLine();
            //int index = metn.IndexOf("a");

            //if(index == -1)
            //{
            //    goto l1;
            //}
            //else
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        Console.Write(metn[index + 1]);
            //    }
            //}


            #endregion

            #region Task9

            //Console.Write("metni daxil edin:");
            //string metn = Console.ReadLine();
            //string a = "";
            //string b = "";
            //int uzunluq = metn.Length-1;
            //while (uzunluq > -1) 
            //{
            //    a = metn[uzunluq].ToString();
            //    uzunluq--;
            //    b += a;
            //}

            //string first_3 = metn.Substring(0, 3);
            //string last_3 = b.Substring(0, 3);

            //if (first_3 == last_3)
            //{
            //    Console.WriteLine("Beraberdir");
            //}
            //else
            //{
            //    Console.WriteLine("Beraber deyil");
            //}

            #endregion

            #region Task10

            //Console.Write("metni daxil edin:");
            //string metin = Console.ReadLine();
            //string output = new string(metin.Where(c=>!char.IsDigit(c)).ToArray());
            //Console.WriteLine(output);


            #endregion

            #region Task11

            //Console.Write("metini daxil edin:");
            //string metin = Console.ReadLine();
            //char[] element = new char[2];

            //char a = ' ';
            //string c = "";
            //for (int i = 0; i < metin.Length; i++)
            //{
            //    a = metin[i];
            //    if (a == 'b')
            //    {
            //        c = Convert.ToString(a);
            //        c = "ba";
            //        Console.WriteLine(c);
            //    }
            //    else if (a == 'a')
            //    {
            //        c = Convert.ToString(a);
            //        c = "ab";
            //        Console.WriteLine(c);
            //    }
            //    else
            //    {
            //        Console.WriteLine(a);
            //    }

            //}

            #endregion

            #region Task12

            //Console.Write("metini daxil edin:");
            //string metin = Console.ReadLine();

            //int ilk_a = metin.IndexOf("a");
            //int son_a = metin.LastIndexOf("a");

            //for (int i = 0; i < metin.Length; i++)
            //{
            //    if (i == ilk_a || i == son_a)  
            //    {
            //        Console.WriteLine(metin[i]);
            //    }
            //    else if (metin[i]!='a')
            //    {
            //        Console.WriteLine(metin[i]);
            //    }
            //}
            #endregion

            #region Task13

            //Console.Write("metini daxil edin:");
            //string metin = Console.ReadLine();

            //string a, b;

            //for (int i = 0; i < metin.Length; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        a = metin.ToUpper();
            //        Console.Write(a[i]);
            //    }

            //    else
            //    {
            //        b = metin.ToLower();
            //        Console.Write(b[i]);
            //    }
            //}

            #endregion

            #region Task14

            //Console.Write("metini daxil edin:");
            //string metin = Console.ReadLine();

            //for (int i = 0; i < metin.Length - 1; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        string a = metin.ToUpper();
            //        string b = metin.Replace(metin[i], a[i + 1]);
            //        Console.Write(b[i]);                
            //    }

            //    else
            //    {
            //        Console.Write(metin[i]);
            //    }
            //}
            //Console.Write(metin[metin.Length-1]);

            #endregion

        }
    }
}