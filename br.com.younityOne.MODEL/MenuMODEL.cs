﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.younityOne.MODEL
{
    public class MenuMODEL
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public List<SubMenuMODEL> SubMenu { get; set; }

        public string NomeImagem { get; set; }
    }
}
