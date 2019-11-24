using System;

namespace SwitchStatement
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome, please tap your favourite gen of movie: ");
      string genre = Console.ReadLine();
      
    switch (genre)
    {
     case "Drama":
        Console.WriteLine("It's an Drama Movie!");
        break;
        
      case "Comedy":
        Console.WriteLine("It's a Comedy Movie!");
        break;
        
      case "Adventure":
        Console.WriteLine("It's a Adventure Movie!");
        break;
        
      case "Horror":
        Console.WriteLine("It's a Horror Movie!");
        break;
        
      case "Science Fiction":
        Console.WriteLine("It's a Science Fiction Movie!");
        break;
        
      default:
        Console.WriteLine("Not movie found");
        break;
      }

    }
  }
}
