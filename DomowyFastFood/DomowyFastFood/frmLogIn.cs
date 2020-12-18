using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomowyFastFood
{
    public partial class frmLogIn : Form
    {
        public int Authorization { get; set; }
        public string Identity { get; set; }

        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister r = new frmRegister();
            r.ShowDialog();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            using (DomowyFastFoodContext Context = new DomowyFastFoodContext())
            {
                if (Context.Klients.AsParallel().Where(x => x.Nick == txtBoxLogin.Text).Count() > 0
                    && Context.Klients.AsParallel().Where(x => x.Password == txtBoxPassword.Text).Count() > 0)
                {
                    Identity = txtBoxLogin.Text;
                    frmUserControlPanel f = new frmUserControlPanel(Identity);
                    f.ShowDialog();
                }
                else if (Context.Pracowniks.AsParallel().Where(x => x.Nick == txtBoxLogin.Text).Count() > 0
                    && Context.Pracowniks.AsParallel().Where(x => x.Password == txtBoxPassword.Text).Count() > 0)
                {
                    Authorization = Context.Pracowniks.AsParallel().Where(x => x.Nick == txtBoxLogin.Text).FirstOrDefault().Autoryzacja;
                    Identity = txtBoxLogin.Text;
                    frmAdminControlPanel f = new frmAdminControlPanel(Authorization, Identity);
                    f.ShowDialog();
                }
                else MessageBox.Show("Błąd Logowania", "Niepoprawny login lub hasło", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
