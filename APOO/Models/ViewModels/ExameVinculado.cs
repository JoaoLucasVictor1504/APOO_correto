﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APOO.Models.ViewModels
{
    public class ExameVinculado
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool Vinculado { get; set; }
    }
}