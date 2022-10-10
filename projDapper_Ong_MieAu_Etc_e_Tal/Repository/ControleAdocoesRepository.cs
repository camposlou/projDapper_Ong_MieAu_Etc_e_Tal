
using Dapper;
using projDapper_Ong_MieAu_Etc_e_Tal.Config;
using projDapper_Ong_MieAu_Etc_e_Tal.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace projDapper_Ong_MieAu_Etc_e_Tal.Repository
{
    public class ControleAdocoesRepository : IControleAdocoesRepository
    {
        private string _conn;

        public ControleAdocoesRepository()
        {
            _conn = DataBaseConfiguration.Get();
        }
      
        public bool Add(ControleAdocoes cadastroAdocoes)
        {
            bool result = false;
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                db.Execute(ControleAdocoes.INSERT, cadastroAdocoes);
                result = true;

            }
            return result;        
        
        }
        public List<ControleAdocoes> GetAll()
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var adocoes = db.Query<ControleAdocoes>(ControleAdocoes.SELECT);
                return (List<ControleAdocoes>)adocoes;
            }

        }
    }
}
