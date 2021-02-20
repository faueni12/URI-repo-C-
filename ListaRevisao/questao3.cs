using System;

class MainClass {
  public static void Main (string[] args) {
    Pessoa pessoa = new Pessoa();
    pessoa.setNome("Jurisbaldo");
    Console.WriteLine("Digite sua data de nascimento (YYYY/MM/DD):");
    DateTime dataNascimento = DateTime.Parse(Console.ReadLine());
    pessoa.setNascimento(dataNascimento);

    Console.WriteLine($"{pessoa.getNome()}, você tem {pessoa.idade()} anos!");

  }
}

class Pessoa {
  private static string name;
  private static DateTime dataNascimento;

  public void setNome(string n) {
    if (n.Length > 0) name = n;
  }

  public void setNascimento(DateTime nascimento) => dataNascimento = nascimento;

  public string getNome() => name;

  public DateTime getNascimento() => dataNascimento;

  public int idade() => DateTime.Now.Year - dataNascimento.Year;
}