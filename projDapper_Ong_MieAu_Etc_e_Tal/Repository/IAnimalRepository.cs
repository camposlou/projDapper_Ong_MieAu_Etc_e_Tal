using projDapper_Ong_MieAu_Etc_e_Tal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projDapper_Ong_MieAu_Etc_e_Tal.Repository
{
    public interface IAnimalRepository
    {
        bool Add (Animal animal);
        bool Update (Animal animal);
        List<Animal> GetAll ();
        List<Animal> GetAllNum_Chip();

    }
}
