using Dapper;
using projDapper_Ong_MieAu_Etc_e_Tal.Config;
using projDapper_Ong_MieAu_Etc_e_Tal.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projDapper_Ong_MieAu_Etc_e_Tal.Repository
{
    public class AdotanteRepository : IAdotanteRepository
    {
        private string _conn;

        public AdotanteRepository()
        {
            _conn = DataBaseConfiguration.Get();
        }        

        public bool Add(Adotante adotante)
        {
            bool result = false;
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                db.Execute(Adotante.INSERT, adotante);
                Console.WriteLine(">>>ADOTANTE CADASTRADO<<<");
                Console.ReadKey();
                result = true;

            }
            return result;
        }

        public bool Update(Adotante adotante)
        {
            bool result = false;
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                db.Execute(Adotante.UPDATE, adotante);
                result = true;

            }
            return result;
        }

        public List<Adotante> GetAll()
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var adotantes = db.Query<Adotante>(Adotante.SELECT);
                return (List<Adotante>)adotantes;

            }
        }
        public List<Adotante> GetAllCpf()
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var adotantes = db.Query<Adotante>(Adotante.SELECTCpf);
                return (List<Adotante>)adotantes;
            }
        }
        public Adotante GetAdotante(string cpf)
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var dados = db.Query<Adotante>(Adotante.SELECT + $" WHERE CPF = {cpf}");
                Adotante adotante = new()
                {
                    CPF = dados.First().CPF,
                    Nome = dados.First().Nome,
                    Data_Nasc = dados.First().Data_Nasc,
                    Sexo = dados.First().Sexo,
                    Telefone = dados.First().Telefone,
                    Logradouro = dados.First().Logradouro,
                    Numero = dados.First().Numero,
                    Complemento = dados.First().Complemento,
                    Bairro = dados.First().Bairro,
                    Cidade = dados.First().Cidade,
                    UF = dados.First().UF,
                    CEP = dados.First().CEP,
                };
                return adotante;
            }
        }
        public bool Delete(Adotante adotante)
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                db.Execute(Adotante.DELETE + adotante.CPF, adotante);
                return true;
            }
            return false;
        }
        public bool VerifCPF(string cpf)
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var retorno = db.ExecuteScalar(Adotante.SELECTCPF + $"{cpf}");
                if (retorno != null) return true;
                else return false;
            }
            return false;
        }
    }
}
