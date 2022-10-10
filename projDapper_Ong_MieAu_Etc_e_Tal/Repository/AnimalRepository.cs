using Dapper;
using projDapper_Ong_MieAu_Etc_e_Tal.Config;
using projDapper_Ong_MieAu_Etc_e_Tal.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projDapper_Ong_MieAu_Etc_e_Tal.Repository
{
    public class AnimalRepository : IAnimalRepository
    {
        private string _conn;

        public AnimalRepository()
        {
            _conn = DataBaseConfiguration.Get();
        }

        public bool Add(Animal animal)
        {
            bool result = false;
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                db.Execute(Animal.INSERT, animal);
                Console.WriteLine(">>>ANIMAL CADASTRADO<<<");
                Console.ReadKey();
                result = true;

            }
            return result;
        }

        public List<Animal> GetAll()
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var animais = db.Query<Animal>(Animal.SELECT);
                return (List<Animal>)animais;
            }
        }

        public bool Update(Animal animal)
        {
            bool result = false;
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                db.Execute(Animal.UPDATE, animal);
                result = true;

            }
            return result;
        }
        public List<Animal> GetAllNum_Chip()
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var animais = db.Query<Animal>(Animal.SELECTNum_Chip);
                return (List<Animal>)animais;
            }


        }
        public bool Delete(Animal animal)
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                db.Execute(Animal.DELETE + animal.Num_Chip, animal);
                return true;
            }
            return false;
        }
    }
}
