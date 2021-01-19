using System; 

class URI {

    static void Main(string[] args) { 
      
      int countNotasValidas = 0;
      double num, soma = 0;
      for (int i = 0; countNotasValidas < 2; i++) {
        num = double.Parse(Console.ReadLine());
        if (num >= 1 && num <= 10) {
          soma += num;
          countNotasValidas ++;
        } else {
          Console.WriteLine("nota invalida"); 
        };
      }
      Console.WriteLine("media = {0:0.00}", soma/2); 
    }

}
