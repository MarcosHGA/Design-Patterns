﻿using DesignPatterns.AbstractFactory;
using System;

namespace DesignPatterns
{
    static class Program
    {
        private static void Main()
        {
            Console.WriteLine("Escolha a Operacao:");
            Console.WriteLine("---------------------");
            Console.WriteLine("Creational Patterns");
            Console.WriteLine("---------------------");
            Console.WriteLine("1 - Abstract Factory");
            Console.WriteLine("2 - Method Factory");
            Console.WriteLine("3 - Singleton");
            Console.WriteLine("---------------------");
            Console.WriteLine("Structural Patterns");
            Console.WriteLine("---------------------");
            Console.WriteLine("4 - Adapter");
            Console.WriteLine("5 - Facade");
            Console.WriteLine("---------------------");
            Console.WriteLine("Behavioral Patterns");
            Console.WriteLine("---------------------");
            Console.WriteLine("6 - Command");
            Console.WriteLine("7 - Strategy");
            Console.WriteLine("8 - Observer");
            Console.WriteLine("---------------------");
            Console.WriteLine("9 - Exit");

            var opcao = Console.ReadKey();

            Console.WriteLine("\n---------------------\n");

            switch (opcao.KeyChar)
            {
                case '1':
                    ExecucaoAbstractFactory.Executar();
                    break;

                case '2':
                    //ExecucaoFactoryMethod.Executar();
                    break;

                case '3':
                    //ExecucaoSingleton.Executar();
                    break;

                case '4':
                    //ExecucaoAdapter.Executar();
                    break;

                case '5':
                    //ExecucaoFacade.Executar();
                    break;

                case '6':
                    //ExecucaoCommand.Executar();
                    break;

                case '7':
                    //ExecucaoStrategy.Executar();
                    break;

                case '8':
                    //ExecucaoObserver.Executar();
                    break;

                case '9':
                    Environment.Exit(0);
                    break;
            }

            Console.WriteLine("Press any key to restart");
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}

