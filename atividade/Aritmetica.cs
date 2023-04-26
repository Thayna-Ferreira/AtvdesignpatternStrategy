public class Aritmetica : ICalcMedia
{
  public double CalculaMedia(double P1, double P2)
  {
    return ((P1 + P2) / 2);
  }
  public string Situacao(double media)
  {
    if (media > 5)
    {
      return "Aprovado";
    }
    else
    {
      return "reprovado";
    }
  }
}