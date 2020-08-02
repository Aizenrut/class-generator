using Core.Builders;
using Core.Enums;
using Core.Models;
using System;
using System.Windows.Forms;

namespace ClassGenerator
{
    public partial class FormClassGenerator : Form
    {
        public FormClassGenerator()
        {
            InitializeComponent();
        }

        private void btnSelecionarPasta_Click(object sender, EventArgs e)
        {
            SelecionarPasta();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            var tipoGerador = ObterTipoGerador();
            var gerador = ObterGerador(tipoGerador);

            gerador.Generate();

            LimparCampos();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            foreach (var control in Controls)
            {
                var textBox = control as TextBoxBase;

                if (textBox != null)
                {
                    textBox.Text = "";
                }
            }
        }

        private void SelecionarPasta()
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtBoxPasta.Text = dialog.SelectedPath;
            }
        }

        private Generator ObterGerador(GeneratorTypes tipoGerador)
        {
            string nome = txtBoxClasse.Text;
            string namespaceClasse = txtBoxNamespace.Text;
            string conteudo = richTxtBoxConteudo.Text;
            string pasta = txtBoxPasta.Text;

            return new GeneratorBuilder().ForGeneratorType(tipoGerador)
                                         .WithClassName(nome)
                                         .WithNamespace(namespaceClasse)
                                         .WithContent(conteudo)
                                         .AtDirectory(pasta)
                                         .Build();
        }

        private GeneratorTypes ObterTipoGerador()
        {
            if (radioBtnJson.Checked)
                return GeneratorTypes.JSON;

            throw new ArgumentOutOfRangeException("É necessário selecionar um tipo de gerador!");
        }
    }
}
