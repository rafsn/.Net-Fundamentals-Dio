﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
namespace NetFundamentals.Exemplos
{
  class Program
  {
    static void Main()
    {
      var s = new Pilha();
      s.Empilha(1);
      s.Empilha(10);
      s.Empilha(100);
      Console.WriteLine(s.Desempilha());
      Console.WriteLine(s.Desempilha());
      Console.WriteLine(s.Desempilha());
    }
  }
}