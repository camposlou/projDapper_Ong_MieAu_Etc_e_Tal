using projDapper_Ong_MieAu_Etc_e_Tal.Model;
using projDapper_Ong_MieAu_Etc_e_Tal.Service;
using System;

namespace projDapper_Ong_MieAu_Etc_e_Tal
{
    internal class Program
    {
        static void Menu()
        {
            int opcMenu;
            do
            {
                opcMenu = 9;
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("******** ♥ BEM VINDO A NOSSA ONG MIAU ETC E TAL ♥ *******");
                Console.WriteLine();
                Console.WriteLine("*********************MENU**********************");
                Console.WriteLine("|                                             |");
                Console.WriteLine("|  0 - Encerrar:                              |");
                Console.WriteLine("|  1 - Cadastrar novo Adotante:               |");
                Console.WriteLine("|  2 - Cadastrar novo Animal:                 |");
                Console.WriteLine("|  3 - Atualizar Cadastro do Adotante:        |");
                Console.WriteLine("|  4 - Deletar Adotante:                      |");
                Console.WriteLine("|  5 - Exibir lista de Adotantes Cadastrados: |");
                Console.WriteLine("|  6 - Exibir lista de Animais Cadastrados:   |");
                Console.WriteLine("|  7 - Inserir/Registrar Adoções:             |");
                Console.WriteLine("|  8 - Exibir lista de Adoções:               |");
                Console.WriteLine("|  Opção:                                     |");
                Console.WriteLine("|_____________________________________________|");
                Console.WriteLine();
                try
                {
                    opcMenu = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {

                }

                switch (opcMenu)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        Adotante adotante = new Adotante();
                        adotante.CadastrarAdotante();
                        new AdotanteService().Add(adotante);                        
                        break;
                    case 2:
                        Animal animal = new Animal();
                        animal.CadastrarAnimal();
                        new AnimalService().Add(animal);                        
                        break;
                    case 3:
                        Adotante upadotante = new Adotante();
                        upadotante.UpdateCadastro();
                        new AdotanteService().Update(upadotante);

                        break;
                    case 4:
                        Adotante deladotante = new Adotante();
                        deladotante.DeletarAdotante();
                        new AdotanteService().Delete(deladotante);
                        break;
                    case 5:                        
                        new AdotanteService().GetAll().ForEach(x => Console.WriteLine(x));
                        Console.ReadKey();

                        break;
                    case 6:                       
                        new AnimalService().GetAll().ForEach(x => Console.WriteLine(x));
                        Console.ReadKey();
                        break;
                        case 7:
                            ControleAdocoes instca= new ControleAdocoes();
                            instca.CadastrarAdocao();
                        new ControleAdocoesService().Add(instca);
                        break;
                        case 8:                           
                           new ControleAdocoesService().GetAll().ForEach(x => Console.WriteLine(x));
                        Console.ReadKey();
                        break;

                }

            } while (opcMenu != 9);
        }

        static void Main(string[] args)
        {
            Menu();
        }

    }
}