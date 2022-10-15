using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace IG
{
    public partial class Janela1 : Form
    {
        public Janela1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void criançaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroC cc = new CadastroC();
            cc.StartPosition = FormStartPosition.CenterScreen;
            cc.Size = new Size(this.Width/2, this.Height/2);
            cc.Show();
            
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Buscar buscar = new Buscar();
            buscar.StartPosition = FormStartPosition.CenterScreen;
            buscar.Size = new Size(this.Width/2, this.Height/2);
            buscar.Show();
        }

        private void salaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DAO banco = new DAO();
            banco.ExTabela();
        }
    }
}