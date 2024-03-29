﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloggen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //skapar en ny lista kallad inlägg //
            List<string[]> inlägg = new List<string[]>();
            //när den här är sann så fortsätter menyn att köras, annars återvänder menyn till sin start position//
            bool meny = true;
            Console.WriteLine("Hej och välkommen till bloggen!");
           //här är menyn med de 4 valen med en try parse för att åtgärda fel som kan uppstå när användaren skriver in annat än de 4 siffrorna// 
            while (meny)
            {
                Console.Clear();
                Console.WriteLine("Var vänlig och gör ett menyval!");
                Console.WriteLine("Tryck 1 för att skriva ut alla blogginlägg.");
                Console.WriteLine("Tryck 2 för att skriva ett nytt inlägg i bloggen.");
                Console.WriteLine("Tryck 3 för att söka inlägg i bloggen.");
                Console.WriteLine("Tryck 4 för att avsluta programmet.");
                int menyVal;
                Int32.TryParse(Console.ReadLine(), out menyVal);

                //en switch som kallas för menyval med 4 cases och en default case//
                switch (menyVal)
                {
                    case 1:
                        //här bläddrar vi i inläggen, för varje int i som är mindre än inläggens antal lägg till 1//
                        for (int i = 0; i < inlägg.Count; i++)
                        {   //la in så att man ser vilket inlägg man är på (visar inlägg 1,2 och 3 osv.//
                            Console.WriteLine("Inläggsnummer:" + (i + 1));
                            //här skriver vi ut inläggen som är sparade la även till två avskärare för tyckte att det blev snyggare med titeln och inlägg//
                            Console.WriteLine(inlägg[i][0] + " | " + inlägg[i][1]);
                            Console.WriteLine("______________________________________________");
                            Console.ReadLine();
                        }
                        break;

                        case 2:
                        //gör en string där användaren kan lägga till titel och inlägget
                        string[] inläggAnv = new string[2];
                        Console.WriteLine("Vänligen skriv in en titel på ditt blogginlägg, detta kan du senare använda för att söka efter inlägget");
                        //här sparas titeln//                       
                        inläggAnv[0] = Console.ReadLine();
                        Console.WriteLine("Toppen! vänligen skriv till inlägg:");
                        //här sparas inlägget//
                        inläggAnv[1] = Console.ReadLine();  
                        //lägger in inlägget i variabeln "inlägg"//
                        inlägg.Add(inläggAnv);
                        Console.WriteLine("Ditt inlägg har nu sparats!");
                        break;

                    case 3:
                        bool rättFel = false; //gör så att när boolen är falsk/sann skrivs olika saker ut, om den är sann skrivs inlägget ut och om den är falsk skrivs det ut att sökningen inte gav resultat//
                        Console.WriteLine("Skriv in titeln på inlägget du vill söka efter!");
                        string sökOrd = Console.ReadLine(); //sökordet är det användaren skriver in//
                        for (int i = 0; i < inlägg.Count; i++) //går igenom listan//
                        {
                            if (inlägg[i][0].ToLower() == sökOrd.ToLower()) //Jämför inlägg med sökord och gör om alla bokstäver till lowercase//
                            {
                                rättFel=true;   
                                Console.WriteLine("Här är inlägget du sökte efter " + inlägg[i][0] + " | " + inlägg[i][1]); //visar inlägget om det matchar, la även här in en avskärning för att göra det snyggare//
                            }
                            if (!rättFel) //om rättFel är falsk//
                            { 
                                Console.WriteLine("Sökningen gav inget resultat!");
                            }
                            
                        }
                        break;

                    case 4: //här stänger vi av menyn med meny=false och skriver ut ett meddelande//
                        meny = false;
                        Console.WriteLine("Tack för att du använde bloggen!");
                        break;

                   
                    default: //om användaren inte skriver in rätt menyval//
                        Console.WriteLine("Du måste skriva antingen 1, 2 ,3 eller 4!");
                        break;
                }
                Console.WriteLine("Tryck ENTER för att återgå!");
                Console.ReadLine();


            }
        }
    }
}
