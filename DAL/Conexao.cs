﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class Conexao
    {
        public static string stringDeConexao
        {
            get
            {
                return @"user ID=SA;Initial Catalog=Configuracao;Data SourcE=.\SQLESXPRESS2019;PASSWord=Senailab02";
            }

        }
        


    }
}
