using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PetShop.Classes.Databases
{
    public class Fichario
    {
        public string diretorio;
        public string mensagem;
        public bool status;

        public Fichario (string Diretorio)
        {
            status = true;
            try
            {
                if (!(Directory.Exists(Diretorio)))
                {
                    Directory.CreateDirectory(Diretorio);
                }
                diretorio = Diretorio;
                mensagem = "Conexão com o fichario criada com sucesso";
            }
            catch(Exception ex)
            {
                status = false;
                mensagem = "Conexão com o fichario com erro" + ex.Message;
            }
        }

        public void Incluir(string Cpf, string jsonUnit)
        {
            status = true;

            try
            {
                if (File.Exists(diretorio + "\\" + Cpf + ".jspn"))
                {
                    status = false;
                    mensagem = "Inclusão não permitida porque o cliente já existe: " + Cpf;
                }
                else
                {
                    File.WriteAllText(diretorio + "\\" + Cpf + ".jspn", jsonUnit);
                    status = true;
                    mensagem = "Inclusão efetuada com sucesso. : " + Cpf;
                }
            } 
            catch(Exception ex)
            {
                status = false;
                mensagem = "Conexão com o fichario com erro" + ex.Message;
            }
        }

        public string Buscar(string cpf)
        {
            status = true;
            try
            {
                if (!(File.Exists(diretorio + "\\" + cpf + ".jspn")))
                {
                    status = false;
                    mensagem = "CPF não existente: " + cpf;
                }
                else
                {
                    string conteudo = File.ReadAllText(diretorio + "\\" + cpf + ".jspn");
                    status = true;
                    mensagem = "Inclusão efetuada com sucesso. : " + cpf;
                    return conteudo;
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro ao buscar CPF do cliente" + ex.Message;
            }
            return "";
        }

        public List<string> BuscarTodos()
        {
            status = true;
            List<string> List = new List<string>();

            try
            {
                var Arquivos = Directory.GetFiles(diretorio, "*.jspn");

                for (int i = 0; i <= Arquivos.Length - 1; i++)
                {
                    string conteudo = File.ReadAllText(Arquivos[i]);
                    List.Add(conteudo);

                }
                return List;
            }

            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro ao buscar CPF do cliente" + ex.Message;
            }
            return List;
        }

        public void Apagar(string cpf)
        {
            status = true;
            try
            {
                if (!(File.Exists(diretorio + "\\" + cpf + ".jspn")))
                {
                    status = false;
                    mensagem = "CPF não existente: " + cpf;
                }
                else
                {
                    File.Delete(diretorio + "\\" + cpf + ".jspn");
                    status = true;
                    mensagem = "Exclusão efetuada com sucesso. : " + cpf;
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro ao buscar CPF do cliente" + ex.Message;
            }
        }

        public void Alterar(string Cpf, string jsonUnit)
        {
            status = true;

            try
            {
                if (!(File.Exists(diretorio + "\\" + Cpf + ".jspn")))
                {
                    status = false;
                    mensagem = "Alteração não permitida porque o cliente não existe: " + Cpf;
                }
                else
                {
                    File.Delete((diretorio + "\\" + Cpf + ".jspn"));
                    File.WriteAllText(diretorio + "\\" + Cpf + ".jspn", jsonUnit);
                    status = true;
                    mensagem = "Alteração realizada com sucesso. : " + Cpf;
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Conexão com o fichario com erro" + ex.Message;
            }
        }
    }
}
