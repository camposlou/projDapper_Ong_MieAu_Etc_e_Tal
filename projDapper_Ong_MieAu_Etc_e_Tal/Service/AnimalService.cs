using projDapper_Ong_MieAu_Etc_e_Tal.Model;
using projDapper_Ong_MieAu_Etc_e_Tal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projDapper_Ong_MieAu_Etc_e_Tal.Service
{
    public class AnimalService
    {
        private IAnimalRepository _animalRepository;

        public AnimalService()
        {
            _animalRepository = new AnimalRepository();
        }

        public bool Add(Animal animal)
        {
            return _animalRepository.Add(animal);
        }
        public List<Animal> GetAll()
        {
            return _animalRepository.GetAll();
        }

        public bool Update(Animal animal)
        {
            return _animalRepository.Update(animal);
        }
        public List<Animal> GetAllNum_Chip()
        {
            return _animalRepository.GetAllNum_Chip();
        }
    }
}
