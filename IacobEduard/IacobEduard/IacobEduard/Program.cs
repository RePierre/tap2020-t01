using System;
using System.Collections.Generic;
using System.Device.Location;
using Modules.Core.Assets;

namespace IacobEduard
{

    class Program
    {
        static void Main(string[] args)
        {
            string raspuns = null;
            int m_P = 0, camere = 0, etaj = 0, etaje = 0;
            House casa;//= new Case(250, 4, 2);
            OneRoom garsoniera;//= new Garsoniere(35, 1, 13);
            Flat apartament; //= new Apartamente(40, 3, 1);
            
            GeoCoordinate sCoord = null, eCoord = null;

            List<string[]> localizari = new List<string[]>();

            string[] locatie_apartament = { "Ciurchi", "47.1550049", "27.6140996" }, locatie_garsoniera = 
                { "Silvestru", "47.1707698", "27.561663" },  locatie_casa = {"Podisului", "47.1504339", "27.5527682" },
                locatie_centru = { "Palat", "47.1600983", "27.5863742" };
               
            
            localizari.Add(locatie_apartament);
            localizari.Add(locatie_garsoniera);
            localizari.Add(locatie_casa);

            /* casa.SetLocatie(locatie_casa);
             garsoneria.SetLocatie(locatie_garsoniera);
             apartament.SetLocatie(locatie_apartament);
             */

            /*int pret_garsoniera = garsoneria.CalcPret();
            int pret_apartament = apartament.CalcPret();
            int pret_casa = casa.CalcPret();

            Console.WriteLine(pret_apartament);
            Console.WriteLine(pret_garsoniera);
            Console.WriteLine(pret_casa);
            */
            Console.WriteLine("Welcome!\n");
            Console.WriteLine("To start press 'Enter'");
            ConsoleKeyInfo tasta = Console.ReadKey();

            while (tasta.Key == ConsoleKey.Enter) {
                Console.WriteLine("Do you want to add a new estate to calculate the comission?(Y/N): ");
                raspuns = Console.ReadLine();
                if (raspuns == "y" || raspuns == "Y")
                {
                    Console.WriteLine("What type of estate do you want to add(house/flat/one room)");
                    raspuns = Console.ReadLine();
                    if(raspuns == "house")
                    {
                        Console.WriteLine("How many square meters does have the house?");
                        raspuns = Console.ReadLine();
                        if(!int.TryParse(raspuns, out m_P)) { Console.WriteLine("You must enter a number"); }
                        /* Am folosit metoda de mai sus in care verific daca parsarea sa facut sau nu
                         * o alta metoda ar fi cea de mai jos cu blocuri try catch
                         * try { m_P = Int32.Parse(raspuns); }
                         * catch { Console.WriteLine("You must enter a number"); }*/
                        Console.WriteLine("How many rooms does have the house?");
                        raspuns = Console.ReadLine();
                        if (!int.TryParse(raspuns, out camere)) { Console.WriteLine("You must enter a number"); }
                        Console.WriteLine("How many floors does have the house?");
                        raspuns = Console.ReadLine();
                        if (!int.TryParse(raspuns, out etaje)) { Console.WriteLine("You must enter a number"); }
                        casa = new House(localizari[2][0],m_P, etaje, camere);
                        Console.WriteLine("The price of the house is {0}, and the obtained comission is {1}.", casa.get, casa.GetPrice);
                        Console.WriteLine("The house is located on {0} street.", localizari[2][0]);
                        sCoord = new GeoCoordinate(double.Parse(localizari[2][1]), double.Parse(localizari[2][2]));
                        eCoord = new GeoCoordinate(double.Parse(locatie_centru[1]), double.Parse(locatie_centru[2]));
                        Console.WriteLine("The distance from house to the city center is {0:0.00} km",casa.getDistance(sCoord, eCoord)/1000);
                    }
                    else if(raspuns == "flat")
                    {
                        Console.WriteLine("How many square meters does have the flat?");
                        raspuns = Console.ReadLine();
                        if (!int.TryParse(raspuns, out m_P)) { Console.WriteLine("You must enter a number"); }
                        Console.WriteLine("How many rooms does have the flat?");
                        raspuns = Console.ReadLine();
                        if (!int.TryParse(raspuns, out camere)) { Console.WriteLine("You must enter a number"); }
                        Console.WriteLine("On what floor is the flat?");
                        raspuns = Console.ReadLine();
                        if (!int.TryParse(raspuns, out etaj)) { Console.WriteLine("You must enter a number"); }
                        apartament= new Flat(localizari[0][0], m_P, etaj, camere);
                        Console.WriteLine("The price of the flat is {0}, and the obtained comission is {1}.", apartament., apartament);
                        Console.WriteLine("The house is located on {0} street.", localizari[0][0]);
                        sCoord = new GeoCoordinate(double.Parse(localizari[0][1]), double.Parse(localizari[0][2]));
                        eCoord = new GeoCoordinate(double.Parse(locatie_centru[1]), double.Parse(locatie_centru[2]));
                        Console.WriteLine("The distance from flat to the city center is {0:0.00} km", apartament.getDistance(sCoord, eCoord) / 1000);
                    }
                    else if(raspuns == "one room")
                    {
                        Console.WriteLine("How many square meters does have the one room?");
                        raspuns = Console.ReadLine();
                        if (!int.TryParse(raspuns, out m_P)) { Console.WriteLine("You must enter a number"); }
                        Console.WriteLine("How many rooms does have the one room?");
                        Console.WriteLine("You really answered to that? C'mon that's why is called one room.");
                        Console.WriteLine("On what floor is the one room?");
                        raspuns = Console.ReadLine();
                        if (!int.TryParse(raspuns, out etaj)) { Console.WriteLine("You must enter a number"); }
                        garsoniera = new OneRoom(localizari[1][0],m_P, etaj, 1);
                        Console.WriteLine("The price of the flat is {0}, and the obtained comission is {1}.", garsoniera., garsoniera.);
                        Console.WriteLine("The house is located on {0} street.", localizari[1][0]);
                        sCoord = new GeoCoordinate(double.Parse(localizari[1][1]), double.Parse(localizari[1][2]));
                        eCoord = new GeoCoordinate(double.Parse(locatie_centru[1]), double.Parse(locatie_centru[2]));
                        Console.WriteLine("The distance from one room to the city center is {0:0.00} km", garsoniera.getDistance(sCoord, eCoord) / 1000);
                    }
                }
                else
                {
                    Console.WriteLine("There is no second chance to add another house... you fool!");
                    break;
                }
            }
            
            Console.WriteLine("\nThx for using us. Have a nice day!");
        
        }
    }
}
