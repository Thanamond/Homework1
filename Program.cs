using System;

namespace workshop2_1
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Enter The Organization : ");
            string OG = Console.ReadLine();

           Console.Write("Enter The Code : ");
           int code = int.Parse(Console.ReadLine());
               int n3k = code/100000;
               int rest_code1 = code - (n3k*100000);
               int n2k = rest_code1/10000;
               int rest_code2 = rest_code1 - (n2k*10000);
               int n1k = rest_code2/1000; //condition 1
               int rest_code3 = rest_code2 - (n1k*1000);
               int n100 = rest_code3/100;
               int rest_code4 = rest_code3 - (n100*100);
               int n10 = rest_code4/10; //condition 2
               int rest_code5 = rest_code4 - (n10*10);
               int n1 = rest_code5/1; //condition 3
               int rest_code6 = rest_code5 - (n1*1);
           switch (OG)
           {
            case "CIA":                                     //check 126426,126421,126433,128462
                if (n1k >= 6 && n1k != 8) //condition 1
                {
                    if (n10 != 1 && n10 != 3 && n10 != 5) //condition 2
                    {
                        if (n1%3 == 0) //condition 3
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                    }
                    else
                    {
                        Console.WriteLine("False");   
                    }
                }
                else
                {
                    Console.WriteLine("False");
                }
                break;
            case "FBI" :                                    //check 534480
                if (4 <= n3k && n3k <= 7) //condition 1
                {
                    if (n2k%2 != 0) //condition 2
                    {
                        if (n100%2 == 0 && n100 != 6) //condition 3 
                        {
                            Console.WriteLine("True");
                        }       
                        else
                        {
                            Console.WriteLine("False");
                        }    
                    }
                    else
                    {
                        Console.WriteLine("False");
                    } 
                }
                else
                {
                    Console.WriteLine("False");
                }
                break;
            case "NSA" :                                    //check 773956
                if (n1 == 1 || n1 == 2 || n1 == 3 || n1 == 5 || n1 == 6 || n1== 10 || n1 == 15 || n1 == 30) //condition 1
                {
                    if (n100%3 == 0 && n100%2 != 0) //condition 2
                    {
                        if (n3k == 7 || n2k == 7 || n1k == 7 || n100 == 7 || n10 == 7 || n1 ==7) //condition 3
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                    }
                    else
                    {
                        Console.WriteLine("False");
                    } 
                }
                else
                {
                    Console.WriteLine("False");
                }
                break;
            default:
                Console.WriteLine("Please Try Again");
                break;      
            } 
        }
    }
}