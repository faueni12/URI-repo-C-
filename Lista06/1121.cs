using System; 
using System.Linq; 

class URI {

    static void Main(string[] args) { 
      int numberCases = int.Parse(Console.ReadLine());
      int number, casesRestZero;
      for (int i = 1; i < numberCases; i++) {
        casesRestZero = 0;
        number = int.Parse(Console.ReadLine());
        for (int j = 2; j <= number; j++) {
          if ((number % j) == 0) {
            casesRestZero ++;
          };
        };

        if (casesRestZero == 1) {
          Console.WriteLine("Prime");
        } else {
          Console.WriteLine("Not Prime");
        };
      };
    }

}
