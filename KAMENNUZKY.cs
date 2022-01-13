using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
          
          while (true)
          {
                Console.WriteLine("NOVÁ HRA  Pravidla : Mas kamen - #  Nuzky - V Papir - -");
                 znovaaa:

                 

                char znakoduzivatele = char.Parse(Console.ReadLine());
                Random cislo = new Random();
                int vygenerovanecislo = cislo.Next(0, 4);


                switch (znakoduzivatele)
                {
                    case '#':

                        switch (vygenerovanecislo)
                        {
                            case 0:
                                Console.WriteLine("Znovu! Počítač použil kámen");
                                goto znovaaa;

                                break;
                            case 1:
                                Console.WriteLine("Vyhrál jsi! Počítač použil nůžky");
                                break;
                            case 2:
                                Console.WriteLine("Prohrál jsi! Počítač použil papír");
                                break;

                        }
                        break;


                    case 'V':
                        switch (vygenerovanecislo)
                        {
                            case 0:
                                Console.WriteLine("Prohrál jsi! Počítač použil kamen");

                                break;
                            case 1:
                                Console.WriteLine("Znovu! Počítač použil nuzky");
                                goto znovaaa;
                                break;
                            case 2:
                                Console.WriteLine("Vyhrál jsi! Počítač použil papir");
                                break;

                        }

                        break;


                    case '-':
                        switch (vygenerovanecislo)
                        {
                            case 0:
                                Console.WriteLine("Vyhrál jsi! Počítač použil kamen");

                                break;
                            case 1:
                                Console.WriteLine("Prohrál jsi! Počítač použil nuzky");
                                break;
                            case 2:
                                Console.WriteLine("Znovu! Počítač použil papir");
                                goto znovaaa;
                                break;

                        }
                        break;

                    default:
                        Console.WriteLine("spatny znak");
                        continue;



                }
                Console.WriteLine("Zmackni enter pro dalsi hru");
                Console.ReadLine();
               
                Console.Clear();
          }
            
            
           
           
        
        }
    }
}
