using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace huvudmenu {
    public class Program {
        static void Main(string[] args) {
            Boolean Choise = false;    // boolean för menyval 
 
            while(!Choise) {        //  så länge Choise är falskt ska menyn fortsätta  
                Console.WriteLine("Meny \n0 - Avsluta \n1 - Åldersbestämning \n2 - Eko \n3 - 3:e ordet");


                string inputChoise = Console.ReadLine();    //läser in inmatning som string
                int MenuChoise = TryCastStringToInt(inputChoise);   // Menyval 0-3 

                switch(MenuChoise) {        // switch som hanterar de olika menyvalen
                    case 0: {               // Om valet är 0 för att avsluta
                        Console.WriteLine("Adjö!");
                        Choise = true;  // sätter boolean till true för att avsluta programmet
                        break;
                    }
                    case 1: {           //Ålderskontroll 
                        Console.WriteLine("Menyval 1 - Skriv ålder med siffror :");
                        TicketPrice();                 
                         break;
                    }
                    case 2: {                                                   
                       Console.WriteLine("Menyval 2 - Eka text med for-loop\n Skriv in valfri text");
                        string sentense = Console.ReadLine();                   // Läser in inmatning

                        for(int i = 0; i < 10; i++) {                           //skriver ut 10ggr på samma rad
                           Console.Write(i+1 + ". " + sentense + " ");
                        }
                    break;
                    }
                    case 3: {
                        Console.WriteLine("Menyval 3 - 3:e ordet.\n Skriv en mening innehållande minst tre ord.");
                        ThirdElement();
                        break;
                    }
                    default: {
                        MenuChoise = TryCastStringToInt(inputChoise);
                        break;
                    }
                } // end switch
            }  // end while                                
        } //end main

        public static int TryCastStringToInt(string input) { // försöker casta string to int
            int stringToInt = -1;

            try { 
                stringToInt = Convert.ToInt32(input);
            } catch(FormatException) {  // Om inte int 
                Console.WriteLine("VG ange heltal i siffror :");
            }
           return stringToInt; // returnerar -1 om misslyckat annars heltal
        }

        public static void TicketPrice() {
            int old = -1;
            while(old < 0) {  // Så länge som inmatning inte är i korrekt format
                 old = TryCastStringToInt(Console.ReadLine());    // läser inmatning och skickar det till försök  att konvertera. Returnerar -1 om ej int
            }

            if(old < 20) {                                    // Om under 20 
                Console.WriteLine("Ungdomspris: 80kr");
            } else if(old > 64) {                             // Om över 64
                Console.WriteLine("Pensionärspris: 90kr");
            } else {                                        // default
                Console.WriteLine("Standardpris: 120kr");
            }
        }
        public static void ThirdElement() {
             Boolean chechIfLessThanThree = false;
            // check number of spaces

            while(!chechIfLessThanThree) {
                string sentense = Console.ReadLine();               //Läser in inmatning så länge som inte tre ord

//                var regex = new Regex(@"\s"); // regular expression som letar efter whitespaces's
//                string b = sentense.Replace(regex, "xx");
                
                string[] t = sentense.Split(' ');                     // Splitar inläst string vid space (' ') och lagrar denna som array. 

                try {
                    Console.WriteLine(t[2]);                            // Skriver ut 3:e ordet
                    chechIfLessThanThree = true;
                } catch(IndexOutOfRangeException) {
                    Console.WriteLine("Minst tre ord");
                }
            }
          }
        /*public static void HasWhiteSpace(string input) {
             var regex = new Regex(@"\s"); // regular expression som letar efter whitespaces's
            string b = input.Replace(regex, " ");

            int i = input.Length;
            Console.WriteLine(i + " i "); // returnerar längden = index+1
            input.Trim();

 //           regex.IsMatch(text); // true

            if(regex.IsMatch(input)) {

                Console.WriteLine(regex+ "qq");
                // text contains a space
            } else {
                // text doesn't contain a space
            }
        }*/
    }
}
