using System;
using System.Globalization;

namespace HelloDateSample 
{
	public static class Program 
	{
		public static void Main() 
		{
		        var result = DateTime.TryParse("29.01", new CultureInfo("nb-NO", false), DateTimeStyles.None, out var parsedDateTime);
			Console.WriteLine(parsedDateTime.ToString());
		}
	}
}