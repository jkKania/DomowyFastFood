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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                using (DomowyFastFoodContext Context = new DomowyFastFoodContext())
                {
                    Context.Klients.Add(new Klient
                    {
                        ID_Klienta = Context.Klients.Max(x => x.ID_Klienta) + 1,
                        Nick = txtboxNick.Text,
                        Password = txtboxPassword.Text,
                        Adres = txtboxAdress.Text,
                        Telefon = txtboxPhone.Text
                    });
                    Context.SaveChanges();
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
