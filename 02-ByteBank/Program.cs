using ByteBank;
using System;

namespace _02_ByteBank
{
    class Program

    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Gabriela";
            Console.WriteLine("Saldo: " + conta.saldo);

            conta.saldo = 200;

            Console.WriteLine(conta.titular);
            Console.WriteLine("Agência: " + conta.agencia);
            Console.WriteLine("Saldo: " + conta.saldo);

            Console.ReadLine();
        }
    }
}