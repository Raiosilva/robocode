﻿using System;
using System.Collections.Generic;
using System.Text;
using Capitulo03.Modelos;

namespace Capitulo03
{
    class Exercicio15
    {
        static void NotMain(string[] args)
        {
            var f = new Funcionario03("João", "Silva", "Cientista de Dados", 18000f);
            Console.WriteLine(f.GetTotalPagar());
            Console.ReadKey();
        }
    }
}
