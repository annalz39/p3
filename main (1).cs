/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class Program
{
  static void Main() 
  {
    
    Console.WriteLine("Vamos calcular o tempo de um evento: ");
    Console.WriteLine("Digite a primeira data: ");
    string dataInicioString = Console.ReadLine();
    
    Console.WriteLine("Digite a primeira data: ");
    string dataTerminoString = Console.ReadLine();
    
    dateTime dataInicio = dateTime.ParseExact("dd/MM/yyyy  hh:mm:ss",null);
    dateTime dataTermino = dateTime.ParseExact("dd/MM/yyyy  hh:mm:ss",null);
    
    timeSpan duracao = dataTermino - dataInicio;
    
    Console.WriteLine($"A duracao do evento sera: {duracao.Days}, dias , {duracao.Hours},horas ,{duracao.Minutes}, minutos, {duracao.Seconds}, segundos");tes;
   
}
}



