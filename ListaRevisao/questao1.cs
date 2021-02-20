using System;

class MainClass {
  public static void Main (string[] args) {
    Esfera ball = new Esfera(2.0);

    Console.WriteLine($"Área: {ball.calcArea():0.00}");
    Console.WriteLine($"Volume: {ball.calcVolume():0.00}");
  }
}

class Esfera {
  private static double raio;

  public Esfera(double r) {
    if (r > 0) raio = r;
  }

  public void setRaio(double r) {
    if (r > 0) raio = r;
  }
  public double getRaio() => raio;

  public double calcVolume() => (4/3) * Math.PI * Math.Pow(raio, 3);

  public double calcArea() {
    Console.WriteLine(4 * Math.PI * Math.Pow(raio, 2));
    return 4 * Math.PI * Math.Pow(raio, 2);
  }

}