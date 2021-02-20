using System;

class MainClass {
  public static void Main (string[] args) {
    //Viagem travel = new Viagem(30, 2);
    Viagem travel = new Viagem();
    travel.setTempo(2);
    travel.setDistancia(10);

    Console.WriteLine($"Velocidade Média: {travel.calcVelocidade():0.00}");
  }
}

class Viagem {
  private static double distancia;
  private static double tempo;
  /*
  public Viagem(double d, double t) {
    if (t > 0) tempo = t;
    if (d > 0) distancia = d;
  }
  */
  public void setTempo(double t) {
    if (t > 0) tempo = t;    
  }
  public void setDistancia(double d) {
    if (d > 0) distancia = d;    
  }
  
  public double getDistancia() => distancia;
  public double getTempo() => tempo;

  public double calcVelocidade() => distancia / tempo;

  public override string ToString() => $"(Distancia={distancia}, Tempo={tempo})";
}