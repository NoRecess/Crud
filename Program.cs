﻿using System;

public class Program
{
    static List<string> pessoas = new List<string>();

    public static void Main()
    {
        string menu = "";
        while(true)
        {
            Console.WriteLine("======CRUDSystem======\n");
            Console.WriteLine("1 - Cadastrar");    
            Console.WriteLine("2 - Listar Usuários");
            Console.WriteLine("3 - Editar Usuários");
            Console.WriteLine("4 - Excluir Usuários\n");
            menu = Console.ReadLine();
            switch (menu)
            {
                case "1":
                    Create();
                    break;
                case "2":
                    Read();
                    break;
                case "3":
                    Update();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }      
    }

    private static void Update()
    {
        int index = 0;
        string newName = string.Empty;

        Console.WriteLine("Digite o número de usuário para editar: ");
        Read();

        index = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Digite o novo nome de usuário: ");
        newName = Console.ReadLine();

        for (int i = 0; i < pessoas.Count; i++)
        {
            if (i == index);
            {
                pessoas[i] = newName;
                Console.WriteLine("Nome alterado com sucesso!");
                return;
            }
        }
    }

    private static void Create() 
    {
        string userName = "";
        Console.Clear();
        Console.WriteLine("Digite o nome de usuário: ");
        userName = Console.ReadLine();
        pessoas.Add(userName);
        Console.Clear();
    } 

     private static async void Read()
     {
        Console.Clear();
        for (int i = 0; i < pessoas.Count(); i++)
        {
            Console.WriteLine(i + " - " + pessoas[i]);
        }
        Console.WriteLine("\n");
     }           
}