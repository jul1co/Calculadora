using System;
using System.Collections.Generic;
namespace Calculadora
{
    public class Calculadora
    {
        private Stack<Operacoes> historicoOperacoes = new Stack<Operacoes>();

        public Stack<Operacoes> HistoricoOperacoes
        {
            get { return historicoOperacoes; }
        }
        public void ImprimirListaOperacoes(Queue<Operacoes> operacoes)
        {
            Console.WriteLine("Lista de Operações:");
            foreach (Operacoes op in operacoes)
            {
                Console.WriteLine("{0} {1} {2}", op.valorA, op.operador, op.valorB);
            }
        }
        public Operacoes calcular(Operacoes operacao)
        {
            switch(operacao.operador)
            {
                case '+': operacao.resultado = soma(operacao); break;
                case '-': operacao.resultado = subtracao(operacao); break;
                case '*': operacao.resultado = multiplicacao(operacao); break;
                case '/': operacao.resultado = divisao(operacao); break;
                default: operacao.resultado = 0; break;
            }
            historicoOperacoes.Push(operacao);
            return operacao;
        }
        public long soma(Operacoes operacao)
        {
            return operacao.valorA + operacao.valorB;
        }
        public long subtracao(Operacoes operacao)
        {
            return operacao.valorA - operacao.valorB;
        }
        public long multiplicacao(Operacoes operacao)
        {
            return operacao.valorA * operacao.valorB;
        }
        public long divisao(Operacoes operacao)
        {
            if (operacao.valorB == 0)
            {
                throw new DivideByZeroException("Divisão por zero não é permitida.");
            }
            return operacao.valorA / operacao.valorB;
        }
       
       
    }
}
