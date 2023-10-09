using System;

namespace lab_personnummer;

class Program
{
    /*
    Grupp-nummer 5
    Gruppmedlem1 = Farid
    Gruppmedlem2 = Elisabeth
    */
    static bool isValidPNR(string number, int längd)
    {

        int summa1=0;
        int summa2 = 0;
        int summa = 0;
        int delSumma = 0;
        int[] j = { 2, 1, 2, 1, 2, 1, 2, 1, 2, 1 };
        int z=0;



        if (kollaLängd(number, längd)) 
        { 
            
            foreach (char c in number)//Plockar ut varje "char" från string
            {
                int nummer = Convert.ToInt32(new string(c, 1));//konverterar "char" till "int"     

                for (int i = 0; i < 1; i++) // for-loop för att multiplicera varje nummer från personnumret med kontrollraden
                {
                    delSumma = nummer * j[z];
                    if (delSumma >= 10)
                    {
                        summa1 = delSumma / 10;
                        summa2 = delSumma % 10;
                        summa += summa1 + summa2;
                    }
                    else
                    {
                        //Console.WriteLine($"{summa1}, {summa2}");
                        summa += delSumma;
                    }
                    z++;
                }
               
            }
            return (summa % 10==0);//Om summan är jämnt delbar på 10 är personumret giltigt
        }

        return false;



    }
    static bool kollaLängd(string number,int längd)
    {

        return (number.Length == längd);
        


    }

    public static void Main(string[] args)
    {        
        Console.WriteLine("Skriv ditt personnummer: (10 siffror");
        int längd = 10;
        string personnummer=Console.ReadLine();
        //string personnummer = "91032598761";
        if (isValidPNR(personnummer,längd))
        {
            Console.WriteLine("Giltigt nummer.");
        }
        
        else
        {
            Console.WriteLine("Ej giltigt pnr.");
            
        }
        Console.ReadKey();
    }
}

