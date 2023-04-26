using System;

public class Geometrica : ICalcMedia
{
  public double CalculaMedia(double P1, double P2)
  {
    return Math.Sqrt(P1 * P2);
  }
  public string Situacao(double media)
  {
    if (media > 7)
    {
      return "Aprovado";
    }
    else
    {
      return "reprovado";
    }
  }
}