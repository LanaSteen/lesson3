using System.Threading.Channels;

namespace loopsAndExeptions
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // დავალება 1
            //დაწერეთ პროგრამა რომელიც კონსოლიდან შემოყვანილი რაიმე n რიცხვისთვის დაითვლის ყველა ციფრის
            //ჯამს 1–დან n–მდე.მაგ 7 - ის შემთხვევაში დაითვლის 1 + 2 + 3 + 4 + 5 + 6 + 7 ჯამს.
            //შესაყვანი სატესტო მონაცემი: 7
            //მოსალოდნელი შედეგი: 
            //1 2 3 4 5 6 7
            //7–მდე ყველა ნატურალური ციფრის ჯამია: 28

            //try { 
            //  Console.WriteLine("enter the number");
            //  string num =Console.ReadLine();
            //  int.TryParse(num, out int number);
            //    int sum = 0;
            //    for (int i=1; i<=number; i++)
            //    {
            //        Console.Write($"{i} ");
            //        sum += i;
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine($"Sum of all numbers until the {number}  is {sum}");
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}





            //დავალება 2
            //გააკეთე კონსოლიდან შემოყვანილი რიცხვის გამრავლების ტაბულის ერთი ბლოკი. (ათის ნამრავლის
            //ჩათვლით)
            //შესაყვანი სატესტო მონაცემი: 13
            //მოსალოდნელი შედეგი: 
            //13 * 1 = 13
            //13 * 2 = 26.........
            //13 * 10 = 130


            //Console.WriteLine("enter the number");
            //string num = Console.ReadLine();
            //int.TryParse(num, out int number);
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write($"{number} * {i} = {number*i}");
            //    Console.WriteLine();
            //}




            //დავალება 3
            //დაწერეთ პროგრამა რომელიც გამოიტანს კონსოლში ფიფქებით შედგენილ ნახევარპირამიდის ფორმას.
            //მაგალითად ციფრი 4–ის შეყვანისას კონსოლში გამოვა შემდეგი სახის ნახევარ პირამიდა:
            //*
            //**
            //***
            //****

            //Console.WriteLine("enter the number");
            //string num = Console.ReadLine();
            //int.TryParse(num, out int number);

            //for (int i = 1; i <= number; i++)
            //{
            //    for (int j =1; j<=i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            //დავალება 4
            //გამოთვალეთ კონსოლიდან შემოყვანილი რიცხვის ფაქტორიალი.
            //მაგ 5!(ფაქტორიალი) არის 1 * 2 * 3 * 4 * 5 და უდრის 120
            //3! არის 1 * 2 * 3 უდრის 6





            //დავალება 5
            //დაწერეთ პროგრამა რომელიც კონსოლიდან წაკითხული რიცხვის მიხედვით გამოიტანს ციფრებით გამოსახულ
            //პირამიდას მაგ: შემოტანილი რიცხვია თუ არის 4, გამოსატან პირამიდას ექნება ასეთი სახე:
            //            1
            // 2 2
            //3 3 3
            //4 4 4 4


            //Console.WriteLine("Enter the number:");
            //string num = Console.ReadLine();

            //if (decimal.TryParse(num, out decimal number) && number > 0)
            //{
            //    int n = (int)number;
            //    for (int i = 1; i <= n; i++)
            //    {
            //        for (int space = 0; space < n - i; space++)
            //        {
            //            Console.Write(' ');
            //        }
            //        for (int j = 1; j <= i; j++)
            //        {
            //            Console.Write(i + " ");
            //        }
            //        Console.WriteLine();
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Please enter a valid positive number.");
            //}

            //დავალება  6
            //მომხმარებელს კლავიატურის გამოყენებით შეჰყავს 2 რიცხვი.ჩვენი ამოცანაა, რომ ვაჩვენოთ ყველა
            //ლუწი რიცხვი მითითებულ დიაპაზონში. თუ დიაპზონის საზღვრები არასწორად არის მოცემული, თქვენ უნდა
            //ჩაასწოროთ ის.მაგალითად, თუ მომხმარებელმა შეიყვანა 20 და 11, ჩასწორებაა საჭირო, რადგან დიაპაზონის
            //დასაწყისი უნდა იყოს -11, და დასასრული -20.

            try {
                
             Console.WriteLine("Enter first number of interval");
                string num1 = Console.ReadLine();
                int.TryParse(num1, out var number1);
                Console.WriteLine("Enter last number of interval");
                string num2 = Console.ReadLine();
                int.TryParse(num2, out var number2);
                if (number1>number2)
                {
                    int temp = number1;
                    number1 = number2;
                    number2 = temp;
                }
                int change = number1 % 2;
               
                   for (int i=number1+change; i< number2; i+=2)
                   {
                       Console.Write($" {i}");
                   }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}