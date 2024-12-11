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
      double n1, n2, n3, n4, media, notaExame, mediaFinal ;
    Console.WriteLine("Digite o valor das notas de um aluno: ");
    Console.WriteLine("Digite o valor da primeira nota: ");
    n1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o valor da segunda nota: ");
    n2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o valor da terceira nota: ");
    n3 = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o valor da quarta nota: ");
    n4 = double.Parse(Console.ReadLine());
    
    media = (n1 * 2 + n2 * 3 + n3 * 4 + n4 * 1) / (2 + 3 + 4 + 1);
    Console.WriteLine($"Sua media e {media:F1}");
    
    if (media >= 7)
 {
     Console.WriteLine("Aluno aprovado!");
 }   
    else if (media <= 6.9 && media >= 5 )
    {
        Console.WriteLine("Aluno em exame.");
        Console.WriteLine("Agora digite sua nota do exame: ");
        notaExame = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Agora vamos recalcular sua media.");
        mediaFinal =  (notaExame + media) / 2 ;
        
        {
            if (mediaFinal >= 5)
            {
            Console.WriteLine("Aluno aprovado.");
            Console.WriteLine($"Sua media final foi {mediaFinal:F1}");
        }
        else
        {
        Console.WriteLine("Aluno Reprovado");
        Console.WriteLine($"Sua media final foi {mediaFinal:F1}");
    }
        }
    }
    
    else
{
   Console.WriteLine("Aluno reprovado.");
        }
}
}



