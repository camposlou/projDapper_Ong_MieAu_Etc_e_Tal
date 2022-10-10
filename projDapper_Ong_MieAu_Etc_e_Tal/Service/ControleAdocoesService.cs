
using projDapper_Ong_MieAu_Etc_e_Tal.Model;
using projDapper_Ong_MieAu_Etc_e_Tal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projDapper_Ong_MieAu_Etc_e_Tal.Service
{
    public class ControleAdocoesService
    {
        private IControleAdocoesRepository _controleadocoesRepository;

        public ControleAdocoesService()
        {
            _controleadocoesRepository = new ControleAdocoesRepository();
        }

       public bool Add(ControleAdocoes cadastroAdocoes)
        {
            return _controleadocoesRepository.Add(cadastroAdocoes);
        }
        public List<ControleAdocoes> GetAll()
        {
            return _controleadocoesRepository.GetAll();
        }

        
    }
}
