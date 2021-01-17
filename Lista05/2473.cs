using System; 
using System.Collections.Generic;
using System.Linq;

class URI {

    static void Main(string[] args) { 

        List<int> numbers = new List<int>( Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse));
        List<int> result = new List<int>( Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse));
        
        int hits = 0;
        foreach (int number in numbers) {
          bool numberIsInList = result.IndexOf(number) != -1;
          if (numberIsInList) {
            hits += 1;
          };
        };

        if (hits == 6) {
          Console.WriteLine("sena");
        } else if (hits == 5) {
          Console.WriteLine("quina");
        } else if (hits == 4) {
          Console.WriteLine("quadra");
        } else if (hits == 3) {
          Console.WriteLine("terno");
        } else {
          Console.WriteLine("azar");
        };
    }

}
