using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Modelo.Pessoas;
using Modelo.Seres_Vivos;
using Persistencia.Context;
using Persistencia.DAL;
namespace APOO.Servico
{
    public class PetServico
    {
        private PetDAL petDAL = new PetDAL();
        public IQueryable<Pet> ObterPetsClassificadosPorNome()
        {
            return petDAL.ObterPetsClassificadosPorNome();
        }
        public Pet ObterPetPorId(long id)
        {
            return petDAL.ObterPetPorId(id);
        }
        public void GravarPet(Pet pet)
        {
            petDAL.GravarPet(pet);
        }
        public Pet EliminarPetPorId(long id)
        {
            return petDAL.EliminarPetPorId(id);
        }
    }
}