using projDapper_Ong_MieAu_Etc_e_Tal.Model;
using projDapper_Ong_MieAu_Etc_e_Tal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projDapper_Ong_MieAu_Etc_e_Tal.Service
{
    public class AdotanteService
    {
        private IAdotanteRepository _adotanteRepository;

        public AdotanteService()
        {
            _adotanteRepository = new AdotanteRepository();
        }

        public bool Add(Adotante adotante)
        {
            return _adotanteRepository.Add(adotante);
        }

        public bool Update(Adotante adotante)
        {
            return _adotanteRepository.Update(adotante);
        }

        public List<Adotante> GetAll()
        {
            return _adotanteRepository.GetAll();
        }
        public List<Adotante> GetAllCpf()
        {
            return _adotanteRepository.GetAllCpf();
        }

        public bool VerifCPF(string cpf)
        {
            return _adotanteRepository.VerifCPF(cpf);
        }

        public Adotante GetAdotante(string cpf)
        {
            return _adotanteRepository.GetAdotante(cpf);
        }

        public bool Delete(Adotante adotante)
        {
            return _adotanteRepository.Delete(adotante);
        }

    }
}
