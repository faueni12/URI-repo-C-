using System;

class MainClass {
  public static void Main (string[] args) {
    Fibonacci fib = new Fibonacci();
    fib.iniciar();
    // os próximos 10 fibonaccis
    for (int i=1; i<=10; i++) fib.proximo();
  }
}

class Fibonacci {
  private static int numBefore;
  private static int numAfter;

  public void iniciar() {
    numBefore = 0;
    numAfter = 1;
  }

  public int proximo() {
    int aux = numAfter;
    numAfter += numBefore;
    numBefore = aux;
    Console.WriteLine(numAfter);
    return numAfter;
  }
}