using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Classes.Databases
{
    public class FicharioDB
    {

        public string mensagem;
        public bool status;
        public string tabela;
        public LocalDBClass db;

        public FicharioDB(string Tabela)
        {
            status = true;

            try
            {
                db = new LocalDBClass();
                tabela = Tabela;
                mensagem = "Conexão com a Tabela criada com sucesso";
            }
            catch (Exception ex) 
            {
                status = false;
                mensagem = "Conexão com a Tabela com erro: " + ex.Message;
            }
        }

        public void Incluir(string Cpf, string jsonUnit)
        {
            status = true;

            try
            {
                //INSERT INTO CLIENT (CPF, JSON) VALUES ('000001', '{...}')

                var SQL = "INSERT INTO " + tabela + " (Cpf, JSON) VALUES ('" + Cpf + "', '" + jsonUnit + "')";
                db.SQLCommand(SQL);

                status = true;
                mensagem = "Inclusão não permitida porque o cliente já existe: " + Cpf;
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Conexão com o fichario com erro" + ex.Message;
            }
        }

        public string Buscar(string Cpf)
        {
            status = true;
            try
            {
                //SELECT CPF, JSON FROM CLIENTE WHERE CPF = '00001'

                var SQL = "SELECT CPF, JSON FROM " + tabela + " WHRE CPF = '" + Cpf + "'";
                var dt = db.SQLQuery(SQL);
                if(dt.Rows.Count > 0)
                {
                    string conteudo = dt.Rows[0]["JSON"].ToString();
                    status = true;
                    mensagem = "Inclusão efetuada com sucesso. : " + Cpf;
                    return conteudo;
                }
                else
                {
                    status = false;
                    mensagem = "CPF não existente: " + Cpf;
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
                //SELECT CPF, JSON FROM CLIENTE

                var SQL = "SELECT CPF, JSON FROM " + tabela;
                var dt = db.SQLQuery(SQL);

                 if(dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        string conteudo = dt.Rows[i]["JSON"].ToString();
                        List.Add(conteudo);
                    }
                    return List;

                }
                else
                {
                    status = false;
                    mensagem = "Não existem clientes na base de dados";
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro ao buscar CPF do cliente" + ex.Message;
            }
            return List;
        }

        public void Apagar(string Cpf)
        {
            status = true;
            try
            {
                var SQL = "SELECT CPF, JSON FROM " + tabela + " WHERE CPF = '" + Cpf + "'";
                var dt = db.SQLQuery(SQL);
                if (dt.Rows.Count > 0) 
                {
                    //DELETE FROM CLIENTE WHERE ID '000001'

                    SQL = "DELETE FROM " + tabela + " WHERE CPF = '" + Cpf + "'";
                    db.SQLCommand(SQL);

                    status = true;
                    mensagem = "Cliente excluido com sucesso. : " + Cpf;
                }
                else
                {
                    status = false;
                    mensagem = "CPF não existente: " + Cpf;
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

                var SQL = "SELECT CPF, JSON FROM " + tabela + " WHERE CPF = '" + Cpf + "'";
                var dt = db.SQLQuery(SQL);

                if (dt.Rows.Count > 0)
                {
                    //UPDATE CLIENTE SET JSON = '{...}' WHERE CPF '000001'

                    SQL = "UPDATE " + tabela + " SET JSON = '" + jsonUnit + "' WHERE CPF = '" + Cpf + "'";
                    db.SQLCommand(SQL);

                    status = true;
                    mensagem = "Alteração efetuada com sucesso. : " + Cpf;
                }
                else
                {
                    status = false;
                    mensagem = "Alteração não permitida porque o cliente não existe: " + Cpf;
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
