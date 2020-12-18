using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomowyFastFood
{
    public partial class frmAdminControlPanel : Form
    {
        public int Authorization { get; set; }
        public string Identity { get; set; }
        public frmAdminControlPanel(int Authorization, string Identity)
        {
            this.Authorization = Authorization;
            this.Identity = Identity;
            InitializeComponent();
        }

        private void frmAdminControlPanel_Load(object sender, EventArgs e)
        {
          

            DataTable dt = new DataTable();
            dt.Columns.Add("ID_Zamowienia");
            dt.Columns.Add("Pracownik");
            dt.Columns.Add("Telefon Pracownika");
            dt.Columns.Add("Nazwa Restauracji");
            dt.Columns.Add("Danie Dnia");
            dt.Columns.Add("Telefon Restauracji");
            dt.Columns.Add("Data Zamowienia");
            dt.AcceptChanges();

          

            using (var Context = new DomowyFastFoodContext())
            {

                var clientDatav2 = Context.Zamowienies    // your starting point - table in the "from" statement
                  .Join(Context.Klients, // the source table of the inner join
                     zam => zam.ID_Klienta,        // Select the primary key (the first part of the "on" clause in an sql "join" statement)
                     client => client.ID_Klienta,   // Select the foreign key (the second part of the "on" clause)
                     (zam, client) => new { Zam = zam, Client = client }) // selection
                  .Where(x => x.Zam.ID_Klienta == x.Client.ID_Klienta)
                  .Join(Context.Restauracjas, // the source table of the inner join
              zam => zam.Zam.ID_Restauracji,        // Select the primary key (the first part of the "on" clause in an sql "join" statement)
              restaurant => restaurant.ID_Restauracji,   // Select the foreign key (the second part of the "on" clause)
              (zam, restaurant) => new { Zam2 = zam, Restaurant = restaurant }) // selection
           .Where(x => x.Zam2.Zam.ID_Restauracji == x.Restaurant.ID_Restauracji);


                var filteredClientDatav2 = clientDatav2.AsParallel().Select(x => new {x.Zam2.Zam.ID_Zamowienia,x.Zam2.Client.Nick, x.Zam2.Client.Telefon,x.Restaurant.NazwaRestauracji, x.Zam2.Zam.DanieDnia, x.Zam2.Zam.DataZamowienia}).ToList();
                var filteredRestaurantdata = clientDatav2.AsParallel().Select(x => x.Restaurant.Telefon).ToList();
                var orderDate = Context.Zamowienies.Select(x => x.DataZamowienia).ToList();

                foreach (var item in filteredClientDatav2.Zip(filteredRestaurantdata, Tuple.Create))
                {
                    dt.Rows.Add(item.Item1.ID_Zamowienia,item.Item1.Nick, item.Item1.Telefon, item.Item1.NazwaRestauracji, item.Item1.DanieDnia, item.Item2, item.Item1.DataZamowienia);
                }
                dt.AcceptChanges();
                dgvOrder.DataSource = dt;
                //     // var clientData = Context.Klients.AsParallel().Select(x => new { x.Nick, x.Telefon}).ToList();
                //     var clientData = Context.Zamowienies    // your starting point - table in the "from" statement
                //        .Join(Context.Klients, // the source table of the inner join
                //           zam => zam.ID_Klienta,        // Select the primary key (the first part of the "on" clause in an sql "join" statement)
                //           client => client.ID_Klienta,   // Select the foreign key (the second part of the "on" clause)
                //           (zam,client) => new { Zam = zam,Client = client }) // selection
                //        .Where(x => x.Zam.ID_Klienta == x.Client.ID_Klienta);



                //     var filteredClientData = clientData.AsParallel().Select(x => new { x.Client.Nick, x.Client.Telefon }).ToList();

                //     //var restaurantData = Context.Restauracjas.AsParallel().Select(x => new { x.NazwaRestauracji, x.DanieDnia, x.Telefon }).ToList();
                //     var restaurantData = Context.Zamowienies    // your starting point - table in the "from" statement
                //.Join(Context.Restauracjas, // the source table of the inner join
                //   zam => zam.ID_Restauracji,        // Select the primary key (the first part of the "on" clause in an sql "join" statement)
                //   restaurant => restaurant.ID_Restauracji,   // Select the foreign key (the second part of the "on" clause)
                //   (zam, restaurant) => new { Zam = zam, Restaurant = restaurant }) // selection
                //.Where(x => x.Zam.ID_Restauracji == x.Restaurant.ID_Restauracji);
                //     var filteredRestaurantData = restaurantData.AsParallel().Select(x => new { x.Restaurant.NazwaRestauracji,x.Restaurant.DanieDnia ,x.Restaurant.Telefon }).ToList();
            }
        }

        private void btnDelOrder_Click(object sender, EventArgs e)
        {
            var id = int.Parse(dgvOrder.Rows[dgvOrder.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
            using (var Context = new DomowyFastFoodContext()) 
            {
                var removeOrder = Context
                     .Zamowienies
                     .FirstOrDefault(x => x.ID_Zamowienia == id);
                var removeCommand = Context
                           .Entry(removeOrder);
                removeCommand.State = EntityState.Deleted;
                Context.SaveChanges();
            }
            this.OnLoad(e);
        }
    }
}
