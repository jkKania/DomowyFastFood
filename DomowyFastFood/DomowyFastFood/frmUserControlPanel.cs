using HtmlAgilityPack;
using System;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Windows.Forms;

namespace DomowyFastFood
{
    public partial class frmUserControlPanel : Form 
    {
        string path = @"SyncDateTime.txt";
        public string Identity { get; set; }
        public frmUserControlPanel(string Identity)
        {
            InitializeComponent();
            this.Identity = Identity;
        }

        private void UserControlPanel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'domowyFastFoodDataSet3.Restauracja' table. You can move, or remove it, as needed.
            this.restauracjaTableAdapter2.Fill(this.domowyFastFoodDataSet3.Restauracja);

            var Lines = File.ReadAllText(path);
            lblSyncInfo.Text = Lines;
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            using (DomowyFastFoodContext Context = new DomowyFastFoodContext())
            {
                var currentDate = $"{DateTime.Now.ToShortDateString()} \t {DateTime.Now.ToShortTimeString()}";

                lblSyncInfo.Text = currentDate;

                File.WriteAllText(path,$"");
                File.AppendAllText(path, currentDate);

                string urlPoSwiecie = "http://www.poswieciekuchni.pl/menu-dnia/";
               
                HtmlWeb web = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument documentPoSwiecie = web.Load(urlPoSwiecie);


                var nodePoSwiecie = documentPoSwiecie.DocumentNode
                               .SelectNodes("//div[@class='wpb_wrapper']/p[position() > 5]").ToArray();

                string DinnerPoSwiecie = string.Empty;

                if (nodePoSwiecie != null)
                {
                    foreach (var item in nodePoSwiecie)
                    {
                        DinnerPoSwiecie += item.InnerText;
                    }
                }
                var resultPoSwiecie = Context.Restauracjas.SingleOrDefault(x => x.ID_Restauracji == 1);
                if (resultPoSwiecie != null)
                {
                    resultPoSwiecie.DanieDnia = DinnerPoSwiecie;
                    Context.SaveChanges();
                }
                string urlMaximus = "http://maximus.bielsko.pl/";

                HtmlAgilityPack.HtmlDocument documentMaximus = web.Load(urlMaximus);

                //switch (DateTime.Now.DayOfWeek )
                //{
                //    case DayOfWeek.Monday:
                //         var nodeMaximus = documentMaximus.DocumentNode
                //                           .SelectNodes("//div[@class='wpb_wrapper']/p[position() > 5]").ToArray();
                //        break;
                //    default:
                //}
                var nodeMaximus = documentMaximus.DocumentNode
                                                 .SelectNodes("//div[@class='views-row views-row-1 views-row-odd views-row-first views-row-last']/div/p[3]").ToArray();
                //*[@id="block-views-dish-of-the-day-block"]/div/div/div/div/div/p[3]
                string DinnerMaximus = string.Empty;

                if (nodeMaximus != null)
                {
                    foreach (var item in nodeMaximus)
                    {
                        DinnerMaximus += item.InnerText;
                    }
                }
                var resultMaximus = Context.Restauracjas.SingleOrDefault(x => x.ID_Restauracji == 2);
                if (resultMaximus != null)
                {
                    resultMaximus.DanieDnia = DinnerMaximus;
                    Context.SaveChanges();
                }
                this.OnLoad(e);
               // frmUserControlPanel form = new frmUserControlPanel(Identity);
               // form.Show();
                //this.Close();
                

                //            var node = document.DocumentNode.Descendants("P")
                //.Select(y => y.Descendants()
                //.Where(x => x.Attributes["class"].Value == "wpb_wrapper"))
                //.ToArray();

                //HtmlWeb web = new HtmlWeb();
                //var document = web.Load("");

                //HtmlNode[] nodes = document.DocumentNode.SelectNodes("//*[@id=block - views - dish - of - the - day - block]").ToArray();
                //MessageBox.Show(nodes[0].InnerText);
                //var Result = Context.Restauracjas.SingleOrDefault(x => x.NazwaRestauracji == "Maximus");
                //if (Result != null)
                //{
                //    Result.DanieDnia = nodes[0].InnerText;
                //    Context.SaveChanges();
                //}
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            using (DomowyFastFoodContext Context = new DomowyFastFoodContext())
            {
                var client = Context.Klients.SingleOrDefault(x => x.Nick == Identity);
                var id = client.ID_Klienta;
                var idRes = int.Parse(dgvRestaurant.Rows[dgvRestaurant.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
                var Dinner = Context.Restauracjas.SingleOrDefault(x => x.ID_Restauracji == idRes);

                Context.Zamowienies.Add(new Zamowienie
                {
                    ID_Zamowienia = Context.Zamowienies.Max(x => x.ID_Zamowienia) + 1,
                    ID_Klienta = id,
                    ID_Restauracji = idRes,
                    DanieDnia = Dinner.DanieDnia,
                    DataZamowienia = DateTime.Now.Date
            });
                Context.SaveChanges();
                MessageBox.Show("Pomyslnie dodano zamowienie","Zamow!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
