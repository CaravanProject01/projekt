using System;
using System.Collections.Generic;
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

namespace Caravans
{
    /// <summary>
    /// Логика взаимодействия для Towar.xaml
    /// </summary>
    public partial class Towar : Page
    {
        public object listBoxGlaw;

        public Towar()
        {
            InitializeComponent();
            ListBoxGlaw.DataContext = this;
        }

        public override bool Equals(object obj)
        {
            var towar = obj as Towar;
            return towar != null &&
                   base.Equals(obj) &&
                   EqualityComparer<ListBox>.Default.Equals(ListBoxGlaw, towar.ListBoxGlaw) &&
                   EqualityComparer<Image>.Default.Equals(apple_jpg1, towar.apple_jpg1) &&
                   EqualityComparer<Label>.Default.Equals(label, towar.label) &&
                   EqualityComparer<TextBlock>.Default.Equals(cenaapple, towar.cenaapple) &&
                   EqualityComparer<Label>.Default.Equals(iljab, towar.iljab) &&
                   EqualityComparer<TextBlock>.Default.Equals(iljabtour, towar.iljabtour) &&
                   EqualityComparer<Label>.Default.Equals(potjab, towar.potjab) &&
                   EqualityComparer<TextBlock>.Default.Equals(ilpotjab, towar.ilpotjab) &&
                   EqualityComparer<Label>.Default.Equals(labe2, towar.labe2) &&
                   EqualityComparer<TextBlock>.Default.Equals(cenatree, towar.cenatree) &&
                   EqualityComparer<Label>.Default.Equals(label3, towar.label3) &&
                   EqualityComparer<TextBlock>.Default.Equals(iltreetour, towar.iltreetour) &&
                   EqualityComparer<Label>.Default.Equals(pottree, towar.pottree) &&
                   EqualityComparer<TextBlock>.Default.Equals(ilpotdrzewo, towar.ilpotdrzewo) &&
                   EqualityComparer<Image>.Default.Equals(tree1_jpg, towar.tree1_jpg) &&
                   EqualityComparer<Label>.Default.Equals(labe3, towar.labe3) &&
                   EqualityComparer<TextBlock>.Default.Equals(cenameate, towar.cenameate) &&
                   EqualityComparer<Label>.Default.Equals(ilmeat, towar.ilmeat) &&
                   EqualityComparer<TextBlock>.Default.Equals(ilmeattour, towar.ilmeattour) &&
                   EqualityComparer<Label>.Default.Equals(potmeat, towar.potmeat) &&
                   EqualityComparer<TextBlock>.Default.Equals(ilpotmieso, towar.ilpotmieso) &&
                   EqualityComparer<Image>.Default.Equals(meat_jpg, towar.meat_jpg) &&
                   EqualityComparer<Image>.Default.Equals(meat_JPG, towar.meat_JPG) &&
                   EqualityComparer<Label>.Default.Equals(labe5, towar.labe5) &&
                   EqualityComparer<TextBlock>.Default.Equals(cenachleb, towar.cenachleb) &&
                   EqualityComparer<Label>.Default.Equals(label6, towar.label6) &&
                   EqualityComparer<TextBlock>.Default.Equals(ilchlebtour, towar.ilchlebtour) &&
                   EqualityComparer<Label>.Default.Equals(potchleb, towar.potchleb) &&
                   EqualityComparer<TextBlock>.Default.Equals(ilpotchleb, towar.ilpotchleb) &&
                   EqualityComparer<Image>.Default.Equals(chleb_jpg, towar.chleb_jpg) &&
                   EqualityComparer<Image>.Default.Equals(chleb_JPG, towar.chleb_JPG) &&
                   EqualityComparer<Label>.Default.Equals(labe7, towar.labe7) &&
                   EqualityComparer<TextBlock>.Default.Equals(cenabron, towar.cenabron) &&
                   EqualityComparer<Label>.Default.Equals(label8, towar.label8) &&
                   EqualityComparer<TextBlock>.Default.Equals(ilbrontour, towar.ilbrontour) &&
                   EqualityComparer<Label>.Default.Equals(potbron, towar.potbron) &&
                   EqualityComparer<TextBlock>.Default.Equals(ilpotbron, towar.ilpotbron) &&
                   EqualityComparer<Image>.Default.Equals(bron_jpg, towar.bron_jpg) &&
                   EqualityComparer<Image>.Default.Equals(bron_JPG, towar.bron_JPG) &&
                   EqualityComparer<Label>.Default.Equals(labe9, towar.labe9) &&
                   EqualityComparer<TextBlock>.Default.Equals(cenawino, towar.cenawino) &&
                   EqualityComparer<Label>.Default.Equals(label10, towar.label10) &&
                   EqualityComparer<TextBlock>.Default.Equals(ilwinotour, towar.ilwinotour) &&
                   EqualityComparer<Label>.Default.Equals(potwino, towar.potwino) &&
                   EqualityComparer<TextBlock>.Default.Equals(ilpotWino, towar.ilpotWino) &&
                   EqualityComparer<Image>.Default.Equals(wino_jpg, towar.wino_jpg) &&
                   EqualityComparer<Image>.Default.Equals(vino_JPG, towar.vino_JPG) &&
                   EqualityComparer<Label>.Default.Equals(label11, towar.label11) &&
                   EqualityComparer<TextBlock>.Default.Equals(cenatkanina, towar.cenatkanina) &&
                   EqualityComparer<Label>.Default.Equals(label12, towar.label12) &&
                   EqualityComparer<TextBlock>.Default.Equals(iltkaninatour, towar.iltkaninatour) &&
                   EqualityComparer<Label>.Default.Equals(pottkanina, towar.pottkanina) &&
                   EqualityComparer<TextBlock>.Default.Equals(ilpottkanina, towar.ilpottkanina) &&
                   EqualityComparer<Image>.Default.Equals(tkanina_jpg, towar.tkanina_jpg) &&
                   EqualityComparer<Image>.Default.Equals(tkanina_JPG, towar.tkanina_JPG) &&
                   EqualityComparer<Label>.Default.Equals(label13, towar.label13) &&
                   EqualityComparer<TextBlock>.Default.Equals(cenaperla, towar.cenaperla) &&
                   EqualityComparer<Label>.Default.Equals(label14, towar.label14) &&
                   EqualityComparer<TextBlock>.Default.Equals(ilperlatour, towar.ilperlatour) &&
                   EqualityComparer<Label>.Default.Equals(potperla, towar.potperla) &&
                   EqualityComparer<TextBlock>.Default.Equals(ilpotperla, towar.ilpotperla) &&
                   EqualityComparer<Image>.Default.Equals(perla_jpg, towar.perla_jpg) &&
                   EqualityComparer<Image>.Default.Equals(perla_JPG, towar.perla_JPG) &&
                   EqualityComparer<Label>.Default.Equals(labe15, towar.labe15) &&
                   EqualityComparer<TextBlock>.Default.Equals(cenaskora, towar.cenaskora) &&
                   EqualityComparer<Label>.Default.Equals(label16, towar.label16) &&
                   EqualityComparer<TextBlock>.Default.Equals(ilskoratour, towar.ilskoratour) &&
                   EqualityComparer<Label>.Default.Equals(potskora, towar.potskora) &&
                   EqualityComparer<TextBlock>.Default.Equals(ilpotskora, towar.ilpotskora) &&
                   EqualityComparer<Image>.Default.Equals(skora_jpg, towar.skora_jpg) &&
                   EqualityComparer<Image>.Default.Equals(skora_JPG, towar.skora_JPG) &&
                   EqualityComparer<Label>.Default.Equals(labe17, towar.labe17) &&
                   EqualityComparer<TextBlock>.Default.Equals(cenanafta, towar.cenanafta) &&
                   EqualityComparer<Label>.Default.Equals(label18, towar.label18) &&
                   EqualityComparer<TextBlock>.Default.Equals(ilnaftatour, towar.ilnaftatour) &&
                   EqualityComparer<Label>.Default.Equals(potnafta, towar.potnafta) &&
                   EqualityComparer<TextBlock>.Default.Equals(ilpotnafta, towar.ilpotnafta) &&
                   EqualityComparer<Image>.Default.Equals(nafta_jpg, towar.nafta_jpg) &&
                   EqualityComparer<Image>.Default.Equals(nafta_JPG, towar.nafta_JPG) &&
                   EqualityComparer<Label>.Default.Equals(labe19, towar.labe19) &&
                   EqualityComparer<TextBlock>.Default.Equals(cenaprzyprawy, towar.cenaprzyprawy) &&
                   EqualityComparer<Label>.Default.Equals(label20, towar.label20) &&
                   EqualityComparer<TextBlock>.Default.Equals(ilprzyprawytour, towar.ilprzyprawytour) &&
                   EqualityComparer<Label>.Default.Equals(potprzyprawy, towar.potprzyprawy) &&
                   EqualityComparer<TextBlock>.Default.Equals(ilpotprzyprawy, towar.ilpotprzyprawy) &&
                   EqualityComparer<Image>.Default.Equals(przyprawy_jpg, towar.przyprawy_jpg) &&
                   EqualityComparer<Image>.Default.Equals(przyprawy_JPG, towar.przyprawy_JPG) &&
                   _contentLoaded == towar._contentLoaded &&
                   EqualityComparer<object>.Default.Equals(listBoxGlaw, towar.listBoxGlaw);
        }
    }
}
