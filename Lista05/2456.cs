using System; 
using System.Collections.Generic;
using System.Linq;

class URI {

    static void Main(string[] args) { 

        List<int> numbers = new List<int>( Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse));
        
        int comparator = numbers[0];
        int sorted = 0;
        int decreasing = 0;
        foreach (int number in numbers.Skip(1)) {
          if (number > comparator) {
            sorted += 1;
          } else if (number < comparator) {
            decreasing += 1;
          };
          comparator = number;
        };

        if (sorted == 4) {
          Console.WriteLine("C");
        } else if (decreasing == 4) {
          Console.WriteLine("D");
        } else {
          Console.WriteLine("N");
        };

    }

}
