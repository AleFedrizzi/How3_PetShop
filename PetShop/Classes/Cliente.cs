using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using PetShop.Classes;
using PetShop.NewFolder1;
using PetShop;
using Newtonsoft.Json;
using PetShop.NewFolder1;
using PetShop.Classes.Databases;

namespace PetShop.Classes
{
    class Cliente
    {
        public class Unit
        {
            [Required(ErrorMessage ="CPF é obrigatório")]
            [RegularExpression("([0-9]+)", ErrorMessage ="CPF só aceita valores numéricos.")]
            [StringLength(11, MinimumLength =11,ErrorMessage ="CPF do cliente deve ter 11 digitos.")]
            public string Cpf {get; set; }

            [Required(ErrorMessage = "Nome do cliente é obrigatório")]
            [StringLength(50, ErrorMessage = "Nome do cliente deve ter no máximo 50 caracteres.")]
            public string Nome {get; set; }

            [Required(ErrorMessage = "Data de nascimento do cliente é obrigatório")]
            [RegularExpression("([0-9]+)", ErrorMessage = "Data de nascimento do cliente só aceita valores numéricos.")]
            [StringLength(8, MinimumLength = 8, ErrorMessage = "Data de nascimento do cliente deve ter 8 digitos.")]
            public string Nasc {get; set; }

            [Required(ErrorMessage = "Telefone é obrigatório")]
            [RegularExpression("([0-9]+)", ErrorMessage = "Telefone só aceita valores numéricos.")]
            public string Tel {get; set; }

            [Required(ErrorMessage = "Profissão é obrigatório")]
            [StringLength(50, ErrorMessage = "Profissão deve ter no máximo 50 caracteres.")]
            public string Prof {get; set; }

            [Required(ErrorMessage = "Nome do Pet é obrigatório")]
            [StringLength(50, ErrorMessage = "Nome do Pet deve ter no máximo 50 caracteres.")]
            public string NomePet {get; set; }

            [Required(ErrorMessage = "Raça do Pet é obrigatório")]
            [StringLength(50, ErrorMessage = "Raça do Pet deve ter no máximo 50 caracteres.")]
            public string Raca {get; set; }

            [Required(ErrorMessage = "Espécie do Pet é obrigatório")]
            [StringLength(50, ErrorMessage = "Espécie do Pet deve ter no máximo 50 caracteres.")]
            public string Especie {get; set; }

            [Required(ErrorMessage = "Sexo do Pet é obrigatório")]
            public int Sexo {get; set; }

            [Required(ErrorMessage = "CEP é obrigatório")]
            [RegularExpression("([0-9]+)", ErrorMessage = "CEP só aceita valores numéricos.")]
            [StringLength(8, MinimumLength = 8, ErrorMessage = "CEP deve ter 8 digitos.")]
            public string CEP {get; set; }

            [Required(ErrorMessage = "Endereço é obrigatório")]
            [StringLength(100, ErrorMessage = "Endereço deve ter no máximo 100 caracteres.")]
            public string End {get; set; }

            [Required(ErrorMessage = "Número do endereço é obrigatório")]
            [StringLength(10, ErrorMessage = "Número do endereço deve ter no máximo 10 caracteres.")]
            public string Num {get; set; }

            [StringLength(30, ErrorMessage = "Complemento do endereço deve ter no máximo 30 caracteres.")]
            public string Compl {get; set; }

            [Required(ErrorMessage = "Bairro é obrigatório")]
            [StringLength(50, ErrorMessage = "Bairro deve ter no máximo 50 caracteres.")]
            public string Bairro {get; set; }

            [Required(ErrorMessage = "Cidade é obrigatório")]
            [StringLength(50, ErrorMessage = "Cidade deve ter no máximo 50 caracteres.")]
            public string Cidade {get; set; }

            [Required(ErrorMessage = "Estado é obrigatório")]
            [StringLength(50, ErrorMessage = "Estado deve ter no máximo 50 caracteres.")]
            public string Estado {get; set; }

            //Usado para valores
            //[Required(ErrorMessage = "Renda do cliente é obrigatória")]
            //[Range(0, double.MaxValue,ErrorMessage ="Renda familiar deve ser um valor positovo.")]
            //public double RendaFamiliar { get; set; }

            public void validaClasse()
            {
                ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
                List<ValidationResult> results = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(this, context, results, true);

                if (isValid == false)
                {
                    StringBuilder sbrErrors = new StringBuilder(); 
                    foreach (var validationResult in results)
                    {
                        sbrErrors.AppendLine(validationResult.ErrorMessage);
                    }
                    throw new ValidationException(sbrErrors.ToString());
                }
            }

            public void validaComplemento()
            {
                if(this.Nome == this.NomePet)
                {
                    throw new Exception("Nome do cliente e do Pet não podem ser iguais");
                }
            }

        #region "CRUD do Fichario"

            public void IncluirFichario(string Conexao)
            {
                string clienteJason = Cliente.SerializedClassUnit(this);
                Fichario F = new Fichario(Conexao);
                if (F.status)
                {
                    F.Incluir(this.Cpf, clienteJason);
                    if (!(F.status))
                    {
                        throw new Exception(F.mensagem);
                    }
                }
                else
                {
                    throw new Exception(F.mensagem);
                }

            }

            public Unit BuscarFichario(string cpf, string conexao)
            {
                Fichario F = new Fichario(conexao);
                if (F.status)
                {
                    string clienteJson = F.Buscar(cpf);
                    return Cliente.DesSerializedClassUnit(clienteJson);
                }
                else
                {
                    throw new Exception(F.mensagem);
                }
            }

            public void AlterarFichario(string conexao)
            {
                string clienteJason = Cliente.SerializedClassUnit(this);
                Fichario F = new Fichario(conexao);
                if (F.status)
                {
                    F.Alterar(this.Cpf, clienteJason);
                    if (!(F.status))
                    {
                        throw new Exception(F.mensagem);
                    }
                }
                else
                {
                    throw new Exception(F.mensagem);
                }
            }

            public void ExcluirFichario(string conexao)
            {
                Fichario F = new Fichario(conexao);
                if (F.status)
                {
                    F.Apagar(this.Cpf);
                    if (!(F.status))
                    {
                        throw new Exception(F.mensagem);
                    }
                }
                else
                {
                    throw new Exception(F.mensagem);
                }
            }

            public List<string> ListaFichario(string conexao)
            {
                Fichario F = new Fichario(conexao);
                if (F.status)
                {
                    List<string> todosJson = F.BuscarTodos();
                    return todosJson;
                }
                else
                {
                    throw new Exception(F.mensagem);
                }
            }

            #endregion

        #region "CRUD do FicharioDB Local DB"

            public void IncluirFicharioDB(string Conexao)
            {
                string clienteJson = Cliente.SerializedClassUnit(this);
                FicharioDB F = new FicharioDB(Conexao);
                if (F.status)

                {
                    F.Incluir(this.Cpf, clienteJson);
                    if (!(F.status))
                    {
                        throw new Exception(F.mensagem);
                    }
                }

                else
                {
                    throw new Exception(F.mensagem);
                }

            }

            public Unit BuscarFicharioDB(string Cpf, string conexao)
            {
                FicharioDB F = new FicharioDB(conexao);
                if (F.status)
                {
                    string clienteJson = F.Buscar(Cpf);
                    return Cliente.DesSerializedClassUnit(clienteJson);
                }

                else
                {
                    throw new Exception(F.mensagem);
                }
            }

            public void AlterarFicharioDB(string conexao)
            {
                string clienteJson = Cliente.SerializedClassUnit(this);
                FicharioDB F = new FicharioDB(conexao);
                if (F.status)
                {
                    F.Alterar(this.Cpf, clienteJson);
                    if (!(F.status))

                    {
                        throw new Exception(F.mensagem);
                    }
                }
                else
                {
                    throw new Exception(F.mensagem);
                }
            }

            public void ExcluirFicharioDB(string conexao)
            {
                FicharioDB F = new FicharioDB(conexao);
                if (F.status)
                {
                    F.Apagar(this.Cpf);
                    if (!(F.status))

                    {
                        throw new Exception(F.mensagem);
                    }
                }
                else
                {
                    throw new Exception(F.mensagem);
                }
            }

            
            public List<string> ListaFicharioDB(string conexao)
            {
                FicharioDB F = new FicharioDB(conexao);
                if (F.status)
                {
                    List<string> todosJson = F.BuscarTodos();
                    return todosJson;
                }
                else
                {
                    throw new Exception(F.mensagem);
                }
            }

            #endregion

        #region "CRUD do Fichario DB SQL Server"

            public void IncluirFicharioSQL(string Conexao)
            {
                string clienteJson = Cliente.SerializedClassUnit(this);
                FicharioSQLServer F = new FicharioSQLServer(Conexao);
                if (F.status)

                {
                    F.Incluir(this.Cpf, clienteJson);
                    if (!(F.status))
                    {
                        throw new Exception(F.mensagem);
                    }
                }

                else
                {
                    throw new Exception(F.mensagem);
                }

            }

            public Unit BuscarFicharioSQL(string Cpf, string conexao)
            {
                FicharioSQLServer F = new FicharioSQLServer(conexao);
                if (F.status)
                {
                    string clienteJson = F.Buscar(Cpf);
                    return Cliente.DesSerializedClassUnit(clienteJson);
                }

                else
                {
                    throw new Exception(F.mensagem);
                }
            }

            public void AlterarFicharioSQL(string conexao)
            {
                string clienteJson = Cliente.SerializedClassUnit(this);
                FicharioSQLServer F = new FicharioSQLServer(conexao);
                if (F.status)
                {
                    F.Alterar(this.Cpf, clienteJson);
                    if (!(F.status))

                    {
                        throw new Exception(F.mensagem);
                    }
                }
                else
                {
                    throw new Exception(F.mensagem);
                }
            }

            public void ExcluirFicharioSQL(string conexao)
            {
                FicharioSQLServer F = new FicharioSQLServer(conexao);
                if (F.status)
                {
                    F.Apagar(this.Cpf);
                    if (!(F.status))

                    {
                        throw new Exception(F.mensagem);
                    }
                }
                else
                {
                    throw new Exception(F.mensagem);
                }
            }


            public List<List<string>> ListaFicharioSQL(string conexao)
            {
                FicharioSQLServer F = new FicharioSQLServer(conexao);
                if (F.status)
                {
                    List<string> List = new List<string>();
                    List = F.BuscarTodos();
                    if (F.status)
                    {
                        List<List<string>> ListaBusca = new List<List<string>>();
                        for (int i = 0; i <= List.Count - 1; i++)
                        {
                            Cliente.Unit C = Cliente.DesSerializedClassUnit(List[i]);
                            ListaBusca.Add(new List<string> { C.Cpf, C.Nome });
                        }
                        return ListaBusca;
                    }
                    else
                    {
                        throw new Exception(F.mensagem);
                    }
                }
                else
                {
                    throw new Exception(F.mensagem);
                }
            }

            //public List<List<string>> ListaFicharioSQL(string conexao)
            //{
            //    FicharioSQLServer F = new FicharioSQLServer(conexao);
            //    if (F.status)
            //    {
            //        List<string> todosJson = F.BuscarTodos();
            //        return todosJson;
            //    }
            //    else
            //    {
            //        throw new Exception(F.mensagem);
            //    }
            //}

            #endregion

        }



        public class List
        {
            public List<Unit> ListUnit { get; set; }
        }

        public static Unit DesSerializedClassUnit(string vJsason)
        {
            return JsonConvert.DeserializeObject<Unit>(vJsason);
        }

        public static string SerializedClassUnit(Unit unit)
        {
            return JsonConvert.SerializeObject(unit);
        }
    }
}
