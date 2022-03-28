using System;


// O mesmo nome de classe
namespace Aula2
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
           Console.WriteLine(s.Desempilha()); // Provocando uma excepção
        }
    }
}


// O arquivo program está contido no próprio namespace

// Na linha 11, vai acontecer o nascimento de uma nova pilha. Empilha 1, 10 e 100 dando o comando dotnet run

/* Na linha 11 o ponto vermelho é o Breakpoint. Na execução, no modo Debug, 
 a execução parará nessa linha e poderemos ir avançando linha a linha. É importante 
 para entender a execução de um código quando existe algum problema */

/* Para debugar, basta pressionar F5 e na pasta bin, surgirá o código já compilado */ 

/* Apertando o F11 iremos para dentro de cada linha e com F10 passaremos linha
a linha  */