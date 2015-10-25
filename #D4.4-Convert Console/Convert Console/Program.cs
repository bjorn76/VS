/*
 * Created by SharpDevelop.
 * User: Björn
 * Date: 2015-02-03
 * Time: 13:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Globalization;

namespace Convert_Console
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			string sVikt;
			decimal dvikt = 1, dv;
            CultureInfo svCult = new CultureInfo("sv");
 
            /*CultureInfo danishCulture = new CultureInfo("da");
            *
            * format the number so that correct Danish decimal and group separators are used
            * decimal totalPrice = 1234.5m;
            * Console.WriteLine(totalPrice.ToString("#,###.##", danishCulture));
            * 
            */

             
			
			ConsoleKeyInfo  cki; //skapa en varibel som lagrar det tecken som skrivs in
			
			
			Console.WriteLine("Hej, detta program omvändlar enheter.");
			Console.WriteLine("Skriv in din vikt i kg. Avsluta med enter!");
					
			//sVikt = Console.ReadLine; // här får programmet din vikt.
			sVikt = Console.ReadLine();
			try 
			{
			  dvikt = Convert.ToDecimal(sVikt);
			} 
			catch (FormatException e)
             {
               // Extract some information from this exception, and then 
                // throw it to the parent method.
                if (e.Source != null)
                  Console.WriteLine("FormatException source: {0}", e.Source);
                  Console.Write("Du måste ange siffror. Press any key to exit");
                  Console.ReadKey(true);
                  Environment.Exit(0);
               //throw;
           
			}
			
			
			
			Console.WriteLine("Din vikt är " + dvikt + "kg");
			

			
			Console.Write("\nVill du omvandla till \n " +
			              "kilo - skriv ett k \n" +
			              "hekto - skriv ett h \n" +
			              "deci - skriv ett d \n" +
			              "centi - skriv ett c \n" +
			              "milli - skriv ett m \n"
			             );
		    			
			
			cki = Console.ReadKey(true); // väljer användaren enhet
			
			//Console.WriteLine ("Du skrev \"" + cki.KeyChar + "\".");  //debug rad
			
			if (cki.KeyChar == 'k')
			{
				Console.WriteLine ("Du valde kilo");
			}
			
			else if (cki.KeyChar == 'h')
			{
				Console.WriteLine ("Du väger " + dvikt*10 + " hektogram (hg)");
			}
			else if (cki.KeyChar == 'd')
			{
				Console.WriteLine ("Du väger " + dvikt * 10000  + " decigram (dg)");
			}
			else if (cki.KeyChar == 'c')
			{
				dv=dvikt*100000;
				Console.WriteLine ("Du väger " + dv.ToString ("#,###")+ " centigram (cg)");
			}
			else if (cki.KeyChar == 'm')
			{
				
				//Console.WriteLine ("Du väger " + dvikt * 100000  + " milligram (mg)");
				//Console.WriteLine ("Du väger " + string.Format(svCult, "{0:N0}", dvikt * 100000)  + " milligram (mg)");
				
				dv= dvikt * 100000;
				//Console.WriteLine ("Du väger " + dv.ToString ("#,###",svCult)+ " milligram (mg)");
				Console.WriteLine ("Du väger " + dv.ToString ("#,###")+ " milligram (mg)");
				                   
				
				
			}
			
			else
			{
			Console.WriteLine ("Du valde ingen omvandling.");	
			}
			
			
			
			Console.WriteLine("");
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
			
		}
	}
}