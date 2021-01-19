using System; 
using System.Collections.Generic; 

class URI {

    static void Main(string[] args) { 

      List<int> numbers = new List<int>( Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse));
      List<int> sortedNumbers = new List<int>();
      sortedNumbers.AddRange(numbers);
      sortedNumbers.Sort();

      foreach (int number in sortedNumbers) {
        Console.WriteLine(number);
      };
      Console.WriteLine();
      foreach (int number in numbers) {
        Console.WriteLine(number);
      };
    }

}
