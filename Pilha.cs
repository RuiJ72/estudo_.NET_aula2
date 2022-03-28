using System;


//O Namespace deve ser do mesmo nome do projeto/ O prefixo das classes do projeto
namespace Aula2
{


    // O primeiro a entrar será o último a sair, o conceito de pilha
    public class Pilha
    {

        //O primeiro da pilha
        Posicao primeiro;
        

        
        public void Empilha(object item)
        {
            primeiro = new Posicao(primeiro, item);
        }


        // Neste método, se dá o contrário, o desempilha retira um item , 
        /* Como o primeiro é nulo, haverá uma excepção -InvalidOperationException 
        nessa estrutura condicional pois não há nulos (linha 29)*/
        public object Desempilha()
        {
            if (primeiro == null) 
            {
                throw new InvalidOperationException();
            }

            object resultado = primeiro.item;
            primeiro = primeiro.proximo;
            return resultado;
        }

        class Posicao
        {
            public Posicao proximo;

            public object item;

            public Posicao(Posicao proximo, object item)
            {
                this.proximo = proximo;
                this.item = item;
            }

        }
    }
}


