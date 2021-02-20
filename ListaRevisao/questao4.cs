using System;

class MainClass {
  public static void Main (string[] args) {
    Intervalo intervalo = new Intervalo();
    intervalo.setIntervalo(2, 30, 40);

    int horas, minutos, segundos;
    intervalo.getIntervalo(out horas, out minutos, out segundos);
    Console.WriteLine("horas = {0}, minutos = {1}, segundos = {2}", horas, minutos, segundos);
    
    Console.WriteLine("Digite um novo intervalo:");
    string[] entrada = Console.ReadLine().Split(" ");
    TimeSpan novoIntervalo = new TimeSpan(0, int.Parse(entrada[0]), int.Parse(entrada[1]), int.Parse(entrada[2]));
    Console.WriteLine($"Soma: {intervalo.somar(novoIntervalo)}");
    Console.WriteLine($"Subtração: {intervalo.subrair(novoIntervalo)}");

    Console.WriteLine($"Intervalo inicial: {intervalo.ToString()}");
  }
}

class Intervalo {
  private int horas;
  private int minutos;
  private int segundos;

  public void setIntervalo(int horas, int minutos, int segundos) {
    if (horas >= 0 && minutos >= 0 && segundos >= 0) {
      this.horas = horas;
      this.minutos = minutos;
      this.segundos = segundos;
    };
  }

  public void getIntervalo(out int horas, out int minutos, out int segundos) {
    horas = this.horas;
    minutos = this.minutos;
    segundos = this.segundos;
  }

  public TimeSpan somar(TimeSpan intervalo) {
    TimeSpan intervaloInicial = new TimeSpan(0, horas, minutos, segundos);
    return intervaloInicial + intervalo;
  }

  public TimeSpan subrair(TimeSpan intervalo) {
    TimeSpan intervaloInicial = new TimeSpan(0, horas, minutos, segundos);
    return intervaloInicial - intervalo;
  }

  public override string ToString() {
    TimeSpan intervaloInicial = new TimeSpan(0, horas, minutos, segundos);
    return intervaloInicial.ToString();
  }
}