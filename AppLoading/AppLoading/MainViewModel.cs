using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppLoading
{
    public class MainViewModel : BaseViewModel
    {
        public ICommand DispararEventoCommand { get; private set; }

        bool _IsLoading;

        public bool IsLoading
        {
            get { return _IsLoading; }
            set
            {
                SetValue(ref _IsLoading, value);
                OnPropertyChanged(nameof(_IsLoading));
            }
        }

        public MainViewModel()
        {
            DispararEventoCommand = new Command(DispararEvento);
            IsLoading = false;
        }

        async void DispararEvento()
        {
            IsLoading = true;

            await Task.Delay(6000);

            IsLoading = false;
        }
    }
}
