/**       
 *--------------------------------------------------------------------
 * 	   File name: Temperature Table.cs
 * 	Project name: Homework 6
 *--------------------------------------------------------------------
 * Author’s name and email:	 Jameel Salami salamij@etsu.edu				
 *          Course-Section:  002
 *           Creation Date:	 30 March 2022		
 * -------------------------------------------------------------------
 */

public class Program
{
    public static double celsius(double f)
    {
        var c = 5.0 * (f - 32.0) / 9;
        return c;
    }
    public static void Main(String[] args)
    {
        Console.WriteLine("Fahrenheit     Celcius");
        for (int f = 0; f <= 20; f++)
        {
            Console.Write(f + "              " + celsius(f) + "\n" );
        }
    }
}