using System.Collections.Generic;

public class Disciplina
{
  public double media;
  public string nome;
  public double P1;
  public double P2;
  public string situacao;

  public void CalcularMedia(Aritmetica tipoCalculo)
  {
    media = tipoCalculo.CalculaMedia(P1, P2);
    situacao = tipoCalculo.Situacao(media);
  }
  public void CalcularMedia(Geometrica tipoCalculo)
  {
    media = tipoCalculo.CalculaMedia(P1, P2);
    situacao = tipoCalculo.Situacao(media);
  }
  public Disciplina(int op, string nome, double P1, double P2)
  {
    this.nome = nome;
    this.P1 = P1;
    this.P2 = P2;
    if (op == 1)
    {
      Aritmetica aritmetica = new Aritmetica();
      CalcularMedia(aritmetica);
    }
    if (op == 2)
    {
      Geometrica geometrica = new Geometrica();
      CalcularMedia(geometrica);
    }
  }
}