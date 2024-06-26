using System;
class Program
{
  static void Main(string[] args)
  {
     int[] N = new int[20];
     Random rand = new Random();
     for (int i = 0; i < N.Length; i++)
     {
        N[i] = rand.Next(1, 101); // Valores aleatórios entre 1 e 100
     }
     int menor = N[0];
     int posicao = 0;
    for (int i = 1; i < N.Length; i++){
       if (N[i] < menor){
          menor = N[i];
         posicao = i;
       }
    }
    Console.WriteLine($"O menor elemento de N é {menor} e sua posição dentro do vetor é: {posicao}");
  }
}
