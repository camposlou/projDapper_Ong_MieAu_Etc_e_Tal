using projDapper_Ong_MieAu_Etc_e_Tal.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projDapper_Ong_MieAu_Etc_e_Tal.Model
{
    public class Animal
    {
        #region Constantes
        public readonly static string INSERT = "INSERT INTO ANIMAL (Nome, Sexo, Raca, Familia) VALUES (@Nome, @Sexo, @Raca, @Familia)";
        public readonly static string SELECT = "SELECT Num_Chip, Nome, Sexo, Raca, Familia FROM ANIMAL";
        public readonly static string SELECTNum_Chip = "SELECT Num_Chip FROM ANIMAL";
        public readonly static string UPDATE = "UPDATE ANIMAL SET Nome = @Nome, Raca = @Raca, Sexo = @Sexo, " +
                "Familia = @Familia WHERE Nome = @Novo;";
        public readonly static string DELETE = "DELETE FROM ANIMAL WHERE Num_Chip = @Num_Chip";
        #endregion

        #region Propriedades
        public int Num_Chip { get; set; }
        public string Nome { get; set; }
        public char Sexo { get; set; }
        public string Raca { get; set; }
        public string Familia { get; set; }
        #endregion

        #region Metodo
        public override string ToString()
        {
            return "\nNum_Chip: " + Num_Chip +
                "\nNome: " + Nome +
                "\nSexo: " + Sexo +
                "\nRaça: " + Raca + 
                "\nFamilia: " + Familia;
        }
        #endregion

        public void CadastrarAnimal()
        {
            Console.WriteLine(">>> ♥ CADASTRO DO ANIMALZINHO ♥ <<<\n");
            Console.WriteLine("DIGITE AS INFORMAÇÕES DO ANIMAL ABAIXO: ");
            Console.Write("Nome: ");
            Nome = Console.ReadLine();
            Console.Write("Raça: ");
            Raca = Console.ReadLine();
            Console.Write("Sexo: ");
            Sexo = char.Parse(Console.ReadLine());
            Console.Write("Familia: ");
            Familia = Console.ReadLine();


        }
        public void UpdateAnimal()
        {
            Console.Write("Digite o nome do animal que deseja alterar o cadastro:\n ");
            string alt = Console.ReadLine();
            Console.Write("Novo Nome: ");
            Nome = Console.ReadLine();
            Console.Write("Raça: ");
            Raca = Console.ReadLine();
            Console.Write("Sexo: ");
            Sexo = char.Parse(Console.ReadLine());
            Console.Write("Familia: ");
            Familia = Console.ReadLine();
        }
        
    }
}
