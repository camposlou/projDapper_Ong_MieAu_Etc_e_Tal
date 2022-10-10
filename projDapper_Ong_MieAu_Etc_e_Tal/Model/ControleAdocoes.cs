using projDapper_Ong_MieAu_Etc_e_Tal.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projDapper_Ong_MieAu_Etc_e_Tal.Model
{

    public class ControleAdocoes
    {
        #region Constante
        public readonly static string INSERT = "INSERT INTO CONTROLEADOCOES (Num_Chip, CPF, Data_Adocao) VALUES (@Num_Chip, @CPF, @Data_Adocao)";
        public readonly static string SELECT = "SELECT a.Id, d.CPF, d.Nome, n.Num_Chip, n.Raca, a.Data_Adocao " +
                "FROM CONTROLEADOCOES a, ADOTANTE d, ANIMAL n " +
                "WHERE d.CPF = a.CPF AND n.Num_Chip = a.Num_Chip;";


        #endregion
        #region Propriedades   
        public int Id { get; set; }
        public int Num_Chip { get; set; }
        public string CPF { get; set; }
        public DateTime Data_Adocao { get; set; }
        #endregion
        public override string ToString()
        {
            return "\nId: " + Id +
                "\nNum_Chip: " + Num_Chip +
                "\nCPF: " + CPF +
                "\nData_Adocao: " + Data_Adocao.ToShortDateString();                 
        }
        public void CadastrarAdocao()
        {
            Console.WriteLine(">>> REGISTRO DE ADOÇÃO: <<< \n");
            Console.WriteLine("Escolha o CPF cadastrado");
            new AdotanteService().GetAllCpf().ForEach(x => Console.WriteLine(x.CPF));           
            Console.WriteLine("Digite o CPF do adotante selecionado: \n");
            CPF = Console.ReadLine();
            Console.WriteLine("Escolha o numero do Chip do animalzinho");
            new AnimalService().GetAllNum_Chip().ForEach(x => Console.WriteLine(x.Num_Chip));
            Console.WriteLine("Digite o Numero do CHIP do animal: ");
            Num_Chip = int.Parse(Console.ReadLine());
            Console.ReadKey();
            Data_Adocao = DateTime.Now;
            
        }

    }
}
