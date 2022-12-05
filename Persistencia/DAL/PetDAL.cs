using Persistencia.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Seres_Vivos;
using System.Data.Entity;

namespace Persistencia.DAL
{
    public class PetDAL
    {
        private EFContext context = new EFContext();
        public IQueryable<Pet> ObterPetsClassificadosPorNome()
        {
            return context.Pets.Include(c => c.Cliente).Include(f => f.Especie).OrderBy(n => n.Nome);
        }
        public Pet ObterPetPorId(int id)
        {
            return context.Pets.Where(p => p.Id == id).Include(c => c.Cliente).Include(f => f.Especie).First();
        }
        public void GravarPet(Pet pet)
        {
            if (pet.Nome == null)
            {
                context.Pets.Add(pet);
            }
            else
            {
                context.Entry(pet).State = EntityState.Modified;
            }
            context.SaveChanges();
        }
        public Pet EliminarPetPorId(int id)
        {
            Pet pet = ObterPetPorId(id);
            context.Pets.Remove(pet);
            context.SaveChanges();
            return pet;
        }
    }
}