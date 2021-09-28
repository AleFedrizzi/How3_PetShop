using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetShop;

namespace PetShop
{
    public partial class Frm_Busca : Form
    {
        List<List<string>> _ListaBusca = new List<List<string>>();

        public string idSelect { get; set; }

        public Frm_Busca(List<List<string>> ListaBusca)
        {
            _ListaBusca = ListaBusca;

            InitializeComponent();
            this.Text = "Busca";
            PreencherLista();

            Lst_Busca.Sorted = true;
        }

        private void PreencherLista()
        {
            Lst_Busca.Items.Clear();
            for(int i = 0; i <= _ListaBusca.Count - 1; i++)
            {

                ItemBox X = new ItemBox();
                X.cpf = _ListaBusca[i][0];
                X.nome = _ListaBusca[i][1];
                Lst_Busca.Items.Add(X);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Btn_Atualiza_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            ItemBox ItemSelecionado = (ItemBox)Lst_Busca.Items[Lst_Busca.SelectedIndex];
            idSelect = ItemSelecionado.cpf;
            this.Close();
        }

        class ItemBox
        {
            public string cpf { get; set; }
            public string nome { get; set; }

            public override string ToString()
            {
                return nome;
            }
        }


    }
}
