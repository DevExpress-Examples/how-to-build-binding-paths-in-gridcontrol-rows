using System.Windows;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using System.Windows.Media;
using DevExpress.Xpf.Grid;

namespace DXGridSample {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
    }
    public class ViewModel : BindableBase {
        public ObservableCollection<string> Countries {
            get { return GetValue<ObservableCollection<string>>(); }
            set { SetValue(value); }
        }
        public ObservableCollection<Item> Items {
            get { return GetValue<ObservableCollection<Item>>(); }
            set { SetValue(value); }
        }
        public bool HighlightVisited {
            get { return GetValue<bool>(); }
            set { SetValue(value); }
        }
        public ViewModel() {
            Countries = new ObservableCollection<string> { "USA", "Germany", "Russia" };
            Items = new ObservableCollection<Item>();
            int i = 0;
            foreach (var country in Countries)
                Items.Add(new Item { Country = country, Visits = i++ });
        }
    }
    public class Item : BindableBase {
        public string Country {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
        public int Visits {
            get { return GetValue<int>(); }
            set { SetValue(value); }
        }
        public Color Color {
            get { return GetValue<Color>(); }
            set { SetValue(value); }
        }
    }
}