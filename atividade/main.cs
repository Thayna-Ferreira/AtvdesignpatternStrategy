using System;
using System.Collections.Generic;

namespace Program
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Escolha uma opção:");
      Console.Write("1- Aritmetica\n2- Geometrica\n|");
      var opcao = int.Parse(Console.ReadLine());

      var nome = "Padroes de Desenvolvimento";
      var P1 = 10;
      var P2 = 5;

      Disciplina d = new Disciplina(opcao, nome, P1, P2);

      Console.Write("\nP1:{0} P2:{1} Media:{2}  Situacao: {3}", d.P1, d.P2, d.media.ToString("N2"), d.situacao);
    }
  }
}