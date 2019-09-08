﻿using System;
using System.IO;

namespace CursoCSharp.API
{
    class ExemploDirectoryInfo
    {
        public static void Executar()
        {
            string dirProjeto = @"~/source/repos/CursoCSharp/CursoCSharp".ParseHome();

            var dirInfo = new DirectoryInfo(dirProjeto);

            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }

            Console.WriteLine("===================== Arquivos =====================");
            var arquivos = dirInfo.GetFiles();
            foreach (var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("\n\n==================== Diretórios ====================");
            var pastas = dirInfo.GetDirectories();
            foreach (var pasta in pastas)
            {
                Console.WriteLine(pasta.Name);
            }

            Console.WriteLine("\n\n================ Outras Informações ================");
            Console.WriteLine(dirInfo.CreationTime);
            Console.WriteLine(dirInfo.FullName);
            Console.WriteLine(dirInfo.Root);
            Console.WriteLine(dirInfo.Parent);
            Console.WriteLine(dirInfo.Parent.Parent);
        }
    }
}
