using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ligue
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        void AddKhaled()
        {
            int bazi = 0, bord = 0, mosavi = 0, bakht = 0, zade = 0, khorde = 0, tafazol = 0, emtiaz = 0;
            bazi = Convert.ToInt32(khaled_bazi.Content);
            bord = Convert.ToInt32(khaled_bord.Content);
            mosavi = Convert.ToInt32(khaled_mosavi.Content);
            bakht = Convert.ToInt32(khaled_bakht.Content);
            zade = Convert.ToInt32(khaled_zade.Content);
            khorde = Convert.ToInt32(khaled_khorde.Content);
            tafazol = Convert.ToInt32(khaled_tafazol.Content);
            emtiaz = Convert.ToInt32(khaled_emtiaz.Content);

            bazi += 1;
            khaled_bazi.Content = bazi.ToString();

            if (game_bord.IsChecked == true)
            {
                bord += 1;
                khaled_bord.Content = bord.ToString();
            }
            else if (game_mosavi.IsChecked == true)
            {
                mosavi += 1;
                khaled_mosavi.Content = mosavi;
            }
            else if (game_bakht.IsChecked == true)
            {
                bakht += 1;
                khaled_bakht.Content = bakht;
            }

            zade += Convert.ToInt32(game_zade.Text);
            khaled_zade.Content = zade.ToString();

            khorde += Convert.ToInt32(game_khorde.Text);
            khaled_khorde.Content = khorde.ToString();

            tafazol = zade - khorde;
            khaled_tafazol.Content = tafazol.ToString();

            emtiaz = Convert.ToInt32(khaled_emtiaz.Content);
            emtiaz += game_bord.IsChecked == true ? 3 : game_mosavi.IsChecked == true ? 1 : 0;
            khaled_emtiaz.Content = emtiaz.ToString();
        }

        void AddRohollah()
        {
            int bazi = 0, bord = 0, mosavi = 0, bakht = 0, zade = 0, khorde = 0, tafazol = 0, emtiaz = 0;
            bazi = Convert.ToInt32(rohollah_bazi.Content);
            bord = Convert.ToInt32(rohollah_bord.Content);
            mosavi = Convert.ToInt32(rohollah_mosavi.Content);
            bakht = Convert.ToInt32(rohollah_bakht.Content);
            zade = Convert.ToInt32(rohollah_zade.Content);
            khorde = Convert.ToInt32(rohollah_khorde.Content);
            tafazol = Convert.ToInt32(rohollah_tafazol.Content);
            emtiaz = Convert.ToInt32(rohollah_emtiaz.Content);

            bazi += 1;
            rohollah_bazi.Content = bazi.ToString();

            if (game_bord.IsChecked == true)
            {
                bord += 1;
                rohollah_bord.Content = bord.ToString();
            }
            else if (game_mosavi.IsChecked == true)
            {
                mosavi += 1;
                rohollah_mosavi.Content = mosavi;
            }
            else if (game_bakht.IsChecked == true)
            {
                bakht += 1;
                rohollah_bakht.Content = bakht;
            }

            zade += Convert.ToInt32(game_zade.Text);
            rohollah_zade.Content = zade.ToString();

            khorde += Convert.ToInt32(game_khorde.Text);
            rohollah_khorde.Content = khorde.ToString();

            tafazol = zade - khorde;
            rohollah_tafazol.Content = tafazol.ToString();

            emtiaz = Convert.ToInt32(rohollah_emtiaz.Content);
            emtiaz += game_bord.IsChecked == true ? 3 : game_mosavi.IsChecked == true ? 1 : 0;
            rohollah_emtiaz.Content = emtiaz.ToString();
        }

        void AddHamed()
        {
            int bazi = 0, bord = 0, mosavi = 0, bakht = 0, zade = 0, khorde = 0, tafazol = 0, emtiaz = 0;
            bazi = Convert.ToInt32(hamed_bazi.Content);
            bord = Convert.ToInt32(hamed_bord.Content);
            mosavi = Convert.ToInt32(hamed_mosavi.Content);
            bakht = Convert.ToInt32(hamed_bakht.Content);
            zade = Convert.ToInt32(hamed_zade.Content);
            khorde = Convert.ToInt32(hamed_khorde.Content);
            tafazol = Convert.ToInt32(hamed_tafazol.Content);
            emtiaz = Convert.ToInt32(hamed_emtiaz.Content);

            bazi += 1;
            hamed_bazi.Content = bazi.ToString();

            if (game_bord.IsChecked == true)
            {
                bord += 1;
                hamed_bord.Content = bord.ToString();
            }
            else if (game_mosavi.IsChecked == true)
            {
                mosavi += 1;
                hamed_mosavi.Content = mosavi;
            }
            else if (game_bakht.IsChecked == true)
            {
                bakht += 1;
                hamed_bakht.Content = bakht;
            }

            zade += Convert.ToInt32(game_zade.Text);
            hamed_zade.Content = zade.ToString();

            khorde += Convert.ToInt32(game_khorde.Text);
            hamed_khorde.Content = khorde.ToString();

            tafazol = zade - khorde;
            hamed_tafazol.Content = tafazol.ToString();

            emtiaz = Convert.ToInt32(hamed_emtiaz.Content);
            emtiaz += game_bord.IsChecked == true ? 3 : game_mosavi.IsChecked == true ? 1 : 0;
            hamed_emtiaz.Content = emtiaz.ToString();
        }

        void AddAbdollah()
        {
            int bazi = 0, bord = 0, mosavi = 0, bakht = 0, zade = 0, khorde = 0, tafazol = 0, emtiaz = 0;
            bazi = Convert.ToInt32(abdollah_bazi.Content);
            bord = Convert.ToInt32(abdollah_bord.Content);
            mosavi = Convert.ToInt32(abdollah_mosavi.Content);
            bakht = Convert.ToInt32(abdollah_bakht.Content);
            zade = Convert.ToInt32(abdollah_zade.Content);
            khorde = Convert.ToInt32(abdollah_khorde.Content);
            tafazol = Convert.ToInt32(abdollah_tafazol.Content);
            emtiaz = Convert.ToInt32(abdollah_emtiaz.Content);

            bazi += 1;
            abdollah_bazi.Content = bazi.ToString();

            if (game_bord.IsChecked == true)
            {
                bord += 1;
                abdollah_bord.Content = bord.ToString();
            }
            else if (game_mosavi.IsChecked == true)
            {
                mosavi += 1;
                abdollah_mosavi.Content = mosavi;
            }
            else if (game_bakht.IsChecked == true)
            {
                bakht += 1;
                abdollah_bakht.Content = bakht;
            }

            zade += Convert.ToInt32(game_zade.Text);
            abdollah_zade.Content = zade.ToString();

            khorde += Convert.ToInt32(game_khorde.Text);
            abdollah_khorde.Content = khorde.ToString();

            tafazol = zade - khorde;
            abdollah_tafazol.Content = tafazol.ToString();

            emtiaz = Convert.ToInt32(abdollah_emtiaz.Content);
            emtiaz += game_bord.IsChecked == true ? 3 : game_mosavi.IsChecked == true ? 1 : 0;
            abdollah_emtiaz.Content = emtiaz.ToString();
        }

        void BeTartib()
        {
            int[] emtiazes = new int[4];
            emtiazes[0] = Convert.ToInt32(khaled_emtiaz.Content);
            emtiazes[1] = Convert.ToInt32(rohollah_emtiaz.Content);
            emtiazes[2] = Convert.ToInt32(hamed_emtiaz.Content);
            emtiazes[3] = Convert.ToInt32(abdollah_emtiaz.Content);
            //aval.Content = i == 0 ? "khaled" : i == 1 ? "rohollah" : i == 2 ? "hamed" : "abdollah";
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int c;
                    if (emtiazes[i] > emtiazes[j])
                    {
                        c = emtiazes[i];
                        emtiazes[i] = emtiazes[j];
                        emtiazes[j] = c;
                    }
                }
            }
            aval.Content = emtiazes[0] == Convert.ToInt32(khaled_emtiaz.Content)
                               ? "khaled"
                               : emtiazes[0] == Convert.ToInt32(rohollah_emtiaz.Content)
                                     ? "rohollah"
                                     : emtiazes[0] == Convert.ToInt32(hamed_emtiaz.Content) ? "hamed" : "abdollah";

            dovom.Content = emtiazes[1] == Convert.ToInt32(khaled_emtiaz.Content)
                               ? "khaled"
                               : emtiazes[1] == Convert.ToInt32(rohollah_emtiaz.Content)
                                     ? "rohollah"
                                     : emtiazes[1] == Convert.ToInt32(hamed_emtiaz.Content) ? "hamed" : "abdollah";

            sevom.Content = emtiazes[2] == Convert.ToInt32(khaled_emtiaz.Content)
                   ? "khaled"
                   : emtiazes[2] == Convert.ToInt32(rohollah_emtiaz.Content)
                         ? "rohollah"
                         : emtiazes[2] == Convert.ToInt32(hamed_emtiaz.Content) ? "hamed" : "abdollah";

            charom.Content = emtiazes[3] == Convert.ToInt32(khaled_emtiaz.Content)
                   ? "khaled"
                   : emtiazes[3] == Convert.ToInt32(rohollah_emtiaz.Content)
                         ? "rohollah"
                         : emtiazes[3] == Convert.ToInt32(hamed_emtiaz.Content) ? "hamed" : "abdollah";

            aval_emtiaz.Content = emtiazes[0] == Convert.ToInt32(khaled_emtiaz.Content)
                                      ? khaled_emtiaz.Content
                                      : emtiazes[0] == Convert.ToInt32(rohollah_emtiaz.Content)
                                            ? rohollah_emtiaz.Content
                                            : emtiazes[0] == Convert.ToInt32(hamed_emtiaz.Content)
                                                  ? hamed_emtiaz.Content
                                                  : abdollah_emtiaz.Content;

            dovom_emtiaz.Content = emtiazes[1] == Convert.ToInt32(khaled_emtiaz.Content)
                          ? khaled_emtiaz.Content
                          : emtiazes[1] == Convert.ToInt32(rohollah_emtiaz.Content)
                                ? rohollah_emtiaz.Content
                                : emtiazes[1] == Convert.ToInt32(hamed_emtiaz.Content)
                                      ? hamed_emtiaz.Content
                                      : abdollah_emtiaz.Content;

            sevom_emtiaz.Content = emtiazes[2] == Convert.ToInt32(khaled_emtiaz.Content)
                          ? khaled_emtiaz.Content
                          : emtiazes[2] == Convert.ToInt32(rohollah_emtiaz.Content)
                                ? rohollah_emtiaz.Content
                                : emtiazes[2] == Convert.ToInt32(hamed_emtiaz.Content)
                                      ? hamed_emtiaz.Content
                                      : abdollah_emtiaz.Content;

            charom_emtiaz.Content = emtiazes[3] == Convert.ToInt32(khaled_emtiaz.Content)
                          ? khaled_emtiaz.Content
                          : emtiazes[3] == Convert.ToInt32(rohollah_emtiaz.Content)
                                ? rohollah_emtiaz.Content
                                : emtiazes[3] == Convert.ToInt32(hamed_emtiaz.Content)
                                      ? hamed_emtiaz.Content
                                      : abdollah_emtiaz.Content;

        }

        string path = "C:\\Users\\khaled\\Desktop";
        private void main_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            if (names.Text == "khaled")
            {
                AddKhaled();
            }
            else if (names.Text == "rohollah")
            {
                AddRohollah();
            }
            else if (names.Text == "hamed")
            {
                AddHamed();
            }
            else if (names.Text == "abdollah")
            {
                AddAbdollah();
            }
            MessageBox.Show("Ezafe Shod!");
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            File.WriteAllText(path + "\\khaled.txt",
                              khaled_bazi.Content + Environment.NewLine + khaled_bord.Content + Environment.NewLine + khaled_mosavi.Content + Environment.NewLine +
                              khaled_bakht.Content + Environment.NewLine + khaled_zade.Content + Environment.NewLine + khaled_khorde.Content + Environment.NewLine +
                              khaled_tafazol.Content + Environment.NewLine + khaled_emtiaz.Content);
            File.WriteAllText(path + "\\rohollah.txt",
                              rohollah_bazi.Content + Environment.NewLine + rohollah_bord.Content + Environment.NewLine + rohollah_mosavi.Content + Environment.NewLine +
                              rohollah_bakht.Content + Environment.NewLine + rohollah_zade.Content + Environment.NewLine + rohollah_khorde.Content + Environment.NewLine +
                              rohollah_tafazol.Content + Environment.NewLine + rohollah_emtiaz.Content);
            File.WriteAllText(path + "\\hamed.txt",
                              hamed_bazi.Content + Environment.NewLine + hamed_bord.Content + Environment.NewLine + hamed_mosavi.Content + Environment.NewLine +
                              hamed_bakht.Content + Environment.NewLine + hamed_zade.Content + Environment.NewLine + hamed_khorde.Content + Environment.NewLine +
                              hamed_tafazol.Content + Environment.NewLine + hamed_emtiaz.Content);
            File.WriteAllText(path + "\\abdollah.txt",
                              abdollah_bazi.Content + Environment.NewLine + abdollah_bord.Content + Environment.NewLine + abdollah_mosavi.Content + Environment.NewLine +
                              abdollah_bakht.Content + Environment.NewLine + abdollah_zade.Content + Environment.NewLine + abdollah_khorde.Content + Environment.NewLine +
                              abdollah_tafazol.Content + Environment.NewLine + abdollah_emtiaz.Content);
            MessageBox.Show("Save Shod");
        }

        private void load_Click(object sender, RoutedEventArgs e)
        {
            string[] khaleds = File.ReadAllLines(path + "\\khaled.txt");
            string[] rohollahs = File.ReadAllLines(path + "\\rohollah.txt");
            string[] hameds = File.ReadAllLines(path + "\\hamed.txt");
            string[] abdollahs = File.ReadAllLines(path + "\\abdollah.txt");


            khaled_bazi.Content = khaleds[0];
            khaled_bord.Content = khaleds[1];
            khaled_mosavi.Content = khaleds[2];
            khaled_bakht.Content = khaleds[3];
            khaled_zade.Content = khaleds[4];
            khaled_khorde.Content = khaleds[5];
            khaled_tafazol.Content = khaleds[6];
            khaled_emtiaz.Content = khaleds[7];

            rohollah_bazi.Content = rohollahs[0];
            rohollah_bord.Content = rohollahs[1];
            rohollah_mosavi.Content = rohollahs[2];
            rohollah_bakht.Content = rohollahs[3];
            rohollah_zade.Content = rohollahs[4];
            rohollah_khorde.Content = rohollahs[5];
            rohollah_tafazol.Content = rohollahs[6];
            rohollah_emtiaz.Content = rohollahs[7];

            hamed_bazi.Content = hameds[0];
            hamed_bord.Content = hameds[1];
            hamed_mosavi.Content = hameds[2];
            hamed_bakht.Content = hameds[3];
            hamed_zade.Content = hameds[4];
            hamed_khorde.Content = hameds[5];
            hamed_tafazol.Content = hameds[6];
            hamed_emtiaz.Content = hameds[7];

            abdollah_bazi.Content = abdollahs[0];
            abdollah_bord.Content = abdollahs[1];
            abdollah_mosavi.Content = abdollahs[2];
            abdollah_bakht.Content = abdollahs[3];
            abdollah_zade.Content = abdollahs[4];
            abdollah_khorde.Content = abdollahs[5];
            abdollah_tafazol.Content = abdollahs[6];
            abdollah_emtiaz.Content = abdollahs[7];


            BeTartib();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string c = game_zade.Text;
            game_zade.Text = game_khorde.Text;
            game_khorde.Text = c;
            if (game_bord.IsChecked == true)
            {
                game_bakht.IsChecked = true;
                return;
            }
            if (game_bakht.IsChecked == true)
            {
                game_bord.IsChecked = true;
                return;
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            matches list = new matches();
            list.Show();
        }
    }
}
