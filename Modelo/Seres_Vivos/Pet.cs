﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Pessoas;
using Modelo.Trabalhos;


namespace Modelo.Seres_Vivos
{
    public class Pet
    {
        //public Pet()
        //{
        //    Consultas = new List<Consulta>();
        //}
        public long Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }
        [DisplayName("Tutor")]
        public int? ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        [DisplayName("Espécie")]
        public int? EspecieId { get; set; }
        public Especie Especie { get; set; }
        public IList<Consulta> Consultas { get; set; }

    }
}
