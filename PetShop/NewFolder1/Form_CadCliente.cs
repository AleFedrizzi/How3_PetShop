using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetShop.Classes;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;
using PetShop;
using PetShop.Classes.Databases;
using PetShop.NewFolder1;

namespace PetShop.NewFolder1
{


    public partial class Form_CadCliente : Form
    {
        public Form_CadCliente()
        {
            InitializeComponent();

            LimparFormulario();

            Cmb_Estados.Items.Clear();
            Cmb_Estados.Items.Add("Acre (AC)");
            Cmb_Estados.Items.Add("Alagoas(AL)");
            Cmb_Estados.Items.Add("Amapá(AP)");
            Cmb_Estados.Items.Add("Amazonas(AM)");
            Cmb_Estados.Items.Add("Bahia(BA)");
            Cmb_Estados.Items.Add("Ceará(CE)");
            Cmb_Estados.Items.Add("Distrito Federal(DF)");
            Cmb_Estados.Items.Add("Espírito Santo(ES)");
            Cmb_Estados.Items.Add("Goiás(GO)");
            Cmb_Estados.Items.Add("Maranhão(MA)");
            Cmb_Estados.Items.Add("Mato Grosso(MT)");
            Cmb_Estados.Items.Add("Mato Grosso do Sul(MS)");
            Cmb_Estados.Items.Add("Minas Gerais(MG)");
            Cmb_Estados.Items.Add("Pará(PA)");
            Cmb_Estados.Items.Add("Paraíba(PB)");
            Cmb_Estados.Items.Add("Paraná(PR)");
            Cmb_Estados.Items.Add("Pernambuco(PE)");
            Cmb_Estados.Items.Add("Piauí(PI)");
            Cmb_Estados.Items.Add("Rio de Janeiro(RJ)");
            Cmb_Estados.Items.Add("Rio Grande do Norte(RN)");
            Cmb_Estados.Items.Add("Rio Grande do Sul(RS)");
            Cmb_Estados.Items.Add("Rondônia(RO)");
            Cmb_Estados.Items.Add("Roraima(RR)");
            Cmb_Estados.Items.Add("Santa Catarina(SC)");
            Cmb_Estados.Items.Add("São Paulo(SP)");
            Cmb_Estados.Items.Add("Sergipe(SE)");
            Cmb_Estados.Items.Add("Tocantins(TO)");

            Btn_BuscaCliente.Text = "Buscar";


            LimparFormulario();
        }

        private void LimparFormulario()
        {
            Msk_CPF.Text = "";
            Txt_nomeCliente.Text = "";
            Msk_Nasc.Text = "";
            Msk_Tel.Text = "";
            Txt_Prof.Text = "";
            Txt_NomePet.Text = "";
            Txt_Raca.Text = "";
            Txt_Especie.Text = "";
            Msk_CEP.Text = "";
            Txt_End.Text = "";
            Txt_Num.Text = "";
            Txt_Compl.Text = "";
            Txt_Bairro.Text = "";
            Txt_Cidade.Text = "";
            Cmb_Estados.SelectedIndex = -1;
            Rdb_Macho.Checked = false;
            Rdb_Femea.Checked = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Incluir_Click(object sender, EventArgs e)
        {
            try
            {

                Cliente.Unit C = new Cliente.Unit();
                //C.CPF = Msk_CPF.Text;
                C = LeituraFormulario();
                C.validaClasse();
                C.validaComplemento();
                //C.IncluirFichario("C:\\Users\\bruno\\Desktop\\WinForms\\UNIVALI\\PetShop\\Fichario");
                //C.IncluirFicharioDB("Cliente");
                C.IncluirFicharioSQL("Cliente");
                MessageBox.Show("OK: cliente incluido com sucesso", "Cão.mia", MessageBoxButtons.OK, MessageBoxIcon.Information);


                //string clienteJason = Cliente.SerializedClassUnit(C);

                //Fichario F = new Fichario("C:\\Users\\bruno\\Desktop\\WinForms\\UNIVALI\\PetShop\\Fichario");
                //if (F.status)
                //{
                //    F.Incluir(C.cpf, clienteJason);
                //    if (F.status)
                //    {
                //        MessageBox.Show("OK: " + F.mensagem, "Cão.mia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    }
                //    else
                //    {
                //        MessageBox.Show("ERROR: " + F.mensagem, "Cão.mia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    }
                //}
                //else
                //{
                //    MessageBox.Show("ERRO: " + F.mensagem, "Cão.mia", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //}



            }
            catch (ValidationException Ex)
            {
                MessageBox.Show(Ex.Message, "Cão.mia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Btn_Busca_Click(object sender, EventArgs e)
        {
            if (Msk_CPF.Text == "")
            {
                MessageBox.Show("CPF do cliente vazio.", "Cão.mia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Cliente.Unit C = new Cliente.Unit();
                    //C = C.BuscarFichario(Msk_CPF.Text, "C:\\Users\\bruno\\Desktop\\WinForms\\UNIVALI\\PetShop\\Fichario");
                    //C = C.BuscarFicharioDB(Msk_CPF.Text, "Cliente");
                    C = C.BuscarFicharioSQL(Msk_CPF.Text, "Cliente");

                    if (C == null)
                    {
                        MessageBox.Show("Identificador não encontrado", "Cão.mia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        EscreveFormulario(C);
                    }

                    EscreveFormulario(C);

                    //Fichario F = new Fichario("C:\\Users\\bruno\\Desktop\\WinForms\\UNIVALI\\PetShop\\Fichario");
                    //if (F.status)
                    //{
                    //    string clienteJson = F.Buscar(Msk_CPF.Text);
                    //    Cliente.Unit C = new Cliente.Unit();
                    //    C = Cliente.DesSerializedClassUnit(clienteJson);
                    //    EscreveFormulario(C);
                    //}
                    //else
                    //{
                    //    MessageBox.Show("ERRO: " + F.mensagem, "Cão.mia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "Cão.mia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void Btn_Atualiza_Click(object sender, EventArgs e)
        {
            if (Msk_CPF.Text == "")
            {
                MessageBox.Show("CPF do cliente vazio.", "Cão.mia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {

                    Cliente.Unit C = new Cliente.Unit();
                    //C.CPF = Msk_CPF.Text;
                    C = LeituraFormulario();
                    C.validaClasse();
                    C.validaComplemento();
                    //C.AlterarFichario("C:\\Users\\bruno\\Desktop\\WinForms\\UNIVALI\\PetShop\\Fichario");
                    //C.AlterarFicharioDB("Cliente");
                    C.AlterarFicharioSQL("Cliente");
                    MessageBox.Show("OK: cliente alterado com sucesso", "Cão.mia", MessageBoxButtons.OK, MessageBoxIcon.Information);



                    //string clienteJason = Cliente.SerializedClassUnit(C);

                    //Fichario F = new Fichario("C:\\Users\\bruno\\Desktop\\WinForms\\UNIVALI\\PetShop\\Fichario");
                    //if (F.status)
                    //{
                    //    F.Alterar(C.cpf, clienteJason);
                    //    if (F.status)
                    //    {
                    //        MessageBox.Show("OK: " + F.mensagem, "Cão.mia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    }
                    //    else
                    //    {
                    //        MessageBox.Show("ERROR: " + F.mensagem, "Cão.mia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    }
                    //}
                    //else
                    //{
                    //    MessageBox.Show("ERRO: " + F.mensagem, "Cão.mia", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //}



                }
                catch (ValidationException Ex)
                {
                    MessageBox.Show(Ex.Message, "Cão.mia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }





        }

        private void Btn_Exclui_Click(object sender, EventArgs e)
        {
            if (Msk_CPF.Text == "")
            {
                MessageBox.Show("CPF do cliente vazio.", "Cão.mia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Cliente.Unit C = new Cliente.Unit();

                    //C = C.BuscarFichario(Msk_CPF.Text, "C:\\Users\\bruno\\Desktop\\WinForms\\UNIVALI\\PetShop\\Fichario");

                    //C = C.BuscarFicharioDB(Msk_CPF.Text, "Cliente");
                    C = C.BuscarFicharioSQL(Msk_CPF.Text, "Cliente");

                    if (C == null)
                    {
                        MessageBox.Show("Identificador não encontrado", "Cão.mia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        EscreveFormulario(C);

                        Frm_Questao Db = new Frm_Questao("cut", "Você quer excluir o cliente?");
                        Db.ShowDialog();
                        if (Db.DialogResult == DialogResult.Yes)
                        {
                            //C.ExcluirFichario("C:\\Users\\bruno\\Desktop\\WinForms\\UNIVALI\\PetShop\\Fichario");
                            //C.ExcluirFicharioDB("Cliente");
                            C.ExcluirFicharioSQL("Cliente");
                            MessageBox.Show("OK: cliente excluido com sucesso", "Cão.mia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimparFormulario();
                        }
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "Cão.mia", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }










                //Fichario F = new Fichario("C:\\Users\\bruno\\Desktop\\WinForms\\UNIVALI\\PetShop\\Fichario");
                //if (F.status)
                //{
                //    string clienteJson = F.Buscar(Msk_CPF.Text);
                //    Cliente.Unit C = new Cliente.Unit();
                //    C = Cliente.DesSerializedClassUnit(clienteJson);
                //    EscreveFormulario(C);

                //    Frm_Questao Db = new Frm_Questao("cut", "Você quer excluir o cliente?");
                //    Db.ShowDialog();
                //    if(Db.DialogResult == DialogResult.Yes)
                //    {
                //        F.Apagar(Msk_CPF.Text);
                //        if (F.status)
                //        {
                //            MessageBox.Show("OK: " + F.mensagem, "Cão.mia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //            LimparFormulario();
                //        }
                //        else
                //        {
                //            MessageBox.Show("ERROR: " + F.mensagem, "Cão.mia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //        }
                //    }
                //}
                //else
                //{
                //    MessageBox.Show("ERRO: " + F.mensagem, "Cão.mia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }


        }

        private void Btn_Limpa_Click(object sender, EventArgs e)
        {
            LimparFormulario();
        }

        Cliente.Unit LeituraFormulario()
        {
            Cliente.Unit C = new Cliente.Unit();
            C.Cpf = Msk_CPF.Text;
            C.Nome = Txt_nomeCliente.Text;
            C.Nasc = Msk_Nasc.Text;
            C.Tel = Msk_Tel.Text;
            C.Prof = Txt_Prof.Text;
            C.NomePet = Txt_NomePet.Text;
            C.Raca = Txt_Raca.Text;
            C.Especie = Txt_Especie.Text;
            if (Rdb_Macho.Checked)
            {
                C.Sexo = 0;
            }
            if (Rdb_Femea.Checked)
            {
                C.Sexo = 1;
            }
            C.CEP = Msk_CEP.Text;
            C.End = Txt_End.Text;
            C.Num = Txt_Num.Text;
            C.Compl = Txt_Compl.Text;
            C.Bairro = Txt_Bairro.Text;
            C.Cidade = Txt_Cidade.Text;

            if (Cmb_Estados.SelectedIndex < 0)
            {
                C.Estado = "";
            }
            else
            {
                C.Estado = Cmb_Estados.Items[Cmb_Estados.SelectedIndex].ToString();
            }

            //Parte da renda familiar para incluir precisa inserir em referência o Microsoft Visual Basic e inserir using....
            //if (Information.IsNumeric(Txt_RendaFamiliar.Text))
            //{
            //double vrenda = Convert.ToDouble(Txt_RendaFamiliar.Text);
            //if (vrenda < 0)
            //{
            //C.RendaFamiliar = 0;
            //}
            //else
            //{
            //C.RendaFamiliar = vrenda;
            //}
            //}



            return C;
        }

        void EscreveFormulario(Cliente.Unit C)
        {
            Msk_CPF.Text = C.Cpf;
            Txt_nomeCliente.Text = C.Nome;
            Msk_Nasc.Text = C.Nasc;
            Msk_Tel.Text = C.Tel;
            Txt_Prof.Text = C.Prof;
            Txt_NomePet.Text = C.NomePet;
            Txt_Raca.Text = C.Raca;
            Txt_Especie.Text = C.Especie;

            if (C.Sexo == 0)
            {
                Rdb_Macho.Checked = true;
            }
            if (C.Sexo == 1)
            {
                Rdb_Femea.Checked = true;
            }

            Msk_CEP.Text = C.CEP;
            Txt_End.Text = C.End;
            Txt_Num.Text = C.Num;
            Txt_Compl.Text = C.Compl;
            Txt_Bairro.Text = C.Bairro;
            Txt_Cidade.Text = C.Cidade;

            if (C.Estado == "")
            {
                Cmb_Estados.SelectedIndex = -1;
            }
            else
            {
                for (int i = 0; i <= Cmb_Estados.Items.Count - 1; i++)
                {
                    if (C.Estado == Cmb_Estados.Items[i].ToString())
                    {
                        Cmb_Estados.SelectedIndex = i;
                    }
                }
            }
        }

        private void Msk_CEP_Leave(object sender, EventArgs e)
        {

            string vCep = Msk_CEP.Text;
            if (vCep != "")
            {
                if (vCep.Length == 8)
                {
                    if (Information.IsNumeric(vCep))
                    {
                        var vJason = Cls_Uteis.GeraJSONCEP(vCep);

                        Cep.Unit CEP = new Cep.Unit();
                        CEP = Cep.DesSerializedClassUnit(vJason);
                        Txt_End.Text = CEP.logradouro;
                        Txt_Bairro.Text = CEP.bairro;
                        Txt_Cidade.Text = CEP.localidade;

                        Cmb_Estados.SelectedIndex = -1;

                        for (int i = 0; i <= Cmb_Estados.Items.Count - 1; i++)
                        {
                            var vPos = Strings.InStr(Cmb_Estados.Items[i].ToString(), "(" + CEP.uf + ")");
                            if (vPos > 0)
                            {
                                Cmb_Estados.SelectedIndex = i;
                            }
                        }
                    }
                }
            }


        }

        private void Btn_BuscaCliente_Click(object sender, EventArgs e)
        {


            try
            {
                Cliente.Unit C = new Cliente.Unit();
                //List<string> List = new List<string>();
                //List = C.ListaFichario("C:\\Users\\bruno\\Desktop\\WinForms\\UNIVALI\\PetShop\\Fichario");
                //List = C.ListaFicharioDB("Cliente"); 
                var ListaBusca = C.ListaFicharioSQL("Cliente");
                Frm_Busca FForm = new Frm_Busca(ListaBusca);
                FForm.ShowDialog();
                if (FForm.DialogResult == DialogResult.OK)
                {
                    var idSelect = FForm.idSelect;
                    //C.BuscarFichario(idSelect, "C:\\Users\\bruno\\Desktop\\WinForms\\UNIVALI\\PetShop\\Fichario");
                    //C.BuscarFicharioDB(idSelect, "Cliente");
                    C.BuscarFicharioSQL(idSelect, "Cliente");

                    if (C == null)
                    {
                        MessageBox.Show("Identificador não encontrado", "Cão.mia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        EscreveFormulario(C);
                    }
                }
            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Cão.mia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //    Cliente.Unit C = new Cliente.Unit();
        //    List<string> List = new List<string>();
        //    //List = C.ListaFichario("C:\\Users\\bruno\\Desktop\\WinForms\\UNIVALI\\PetShop\\Fichario");
        //    //List = C.ListaFicharioDB("Cliente");
        //    List = C.ListaFicharioSQL("Cliente");
        //    if (List == null)
        //    {
        //        MessageBox.Show("Base de dados está vazia. Não existe cliente cadastrado.", "Cão.mia", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //    }
        //    else
        //    {
        //        List<List<string>> ListaBusca = new List<List<string>>();
        //        for (int i = 0; i <= List.Count - 1; i++)
        //        {
        //            C = Cliente.DesSerializedClassUnit(List[i]);
        //            ListaBusca.Add(new List<string> { C.Cpf, C.Nome });
        //        }
        //        Frm_Busca FForm = new Frm_Busca(ListaBusca);
        //        FForm.ShowDialog();

        //        if (FForm.DialogResult == DialogResult.OK)
        //        {
        //            var idSelect = FForm.idSelect;
        //            //C.BuscarFichario(idSelect, "C:\\Users\\bruno\\Desktop\\WinForms\\UNIVALI\\PetShop\\Fichario");
        //            C.BuscarFicharioDB(idSelect, "Cliente");

        //            if (C == null)
        //            {
        //                MessageBox.Show("Identificador não encontrado", "Cão.mia", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //            else
        //            {
        //                EscreveFormulario(C);
        //            }



        //        }
        //    }




        //}
        //catch (Exception Ex)
        //{
        //    MessageBox.Show(Ex.Message, "Cão.mia", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //}

        //Fichario F = new Fichario("C:\\Users\\bruno\\Desktop\\WinForms\\UNIVALI\\PetShop\\Fichario");
        //if (F.status)
        //{
        //    List<string> List = new List<string>();
        //    List = F.BuscarTodos();
        //    if (F.status)
        //    {
        //        List<List<string>> ListaBusca = new List<List<string>>();
        //        for (int i = 0; i <= List.Count -1; i++)
        //        {
        //            Cliente.Unit C = Cliente.DesSerializedClassUnit(List[i]);
        //            ListaBusca.Add(new List<string> { C.cpf, C.Nome });
        //        }
        //        Frm_Busca FForm = new Frm_Busca(ListaBusca);
        //        FForm.ShowDialog();

        //        if(FForm.DialogResult == DialogResult.OK)
        //        {
        //            var idSelect = FForm.idSelect;
        //            string clienteJson = F.Buscar(idSelect);
        //            Cliente.Unit C = new Cliente.Unit();
        //            C = Cliente.DesSerializedClassUnit(clienteJson);
        //            EscreveFormulario(C);

        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("ERRO " + F.mensagem, "Cão.mia", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //}
        //else
        //{
        //    MessageBox.Show("ERRO: " + F.mensagem, "Cão.mia", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //}

    }


}

