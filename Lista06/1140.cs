using System; 
using System.Linq; 

class URI {

    static void Main(string[] args) { 
      
      string entrada;
      char firstest_letter, currentLetter;
      string [] words;
      int counter = 0;
      do {
        entrada = Console.ReadLine();
        if (entrada == "*") break;
        
        counter = 0;
        words = entrada.Split(" ");
        firstest_letter = char.ToLower(words[0][0]);
        foreach (string word in words.Skip(1)) {
          currentLetter = char.ToLower(word[0]);
          if (currentLetter == firstest_letter) {
            counter ++;
          } else {
            break;
          };
        };
        if (counter > 0) {
          Console.WriteLine("Y");
        } else {
          Console.WriteLine("N");
        };

      } while (entrada != "*");
    }

}
