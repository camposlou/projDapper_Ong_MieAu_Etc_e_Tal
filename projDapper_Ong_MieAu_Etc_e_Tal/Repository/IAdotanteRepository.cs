using projDapper_Ong_MieAu_Etc_e_Tal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projDapper_Ong_MieAu_Etc_e_Tal.Repository
{
    public interface IAdotanteRepository
    {
        bool VerifCPF(string cpf);
        bool Add (Adotante adotante);   //Metodo incluir informação (Add)
        bool Update (Adotante adotante);

        List<Adotante> GetAll ();       //Metodo consultar umas informações no DataBase (GetAll)

        List<Adotante> GetAllCpf();

        bool Delete(Adotante adotante);

        Adotante GetAdotante(string cpf);





    }
}
