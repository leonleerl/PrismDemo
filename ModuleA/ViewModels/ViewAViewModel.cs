using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ModuleA.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        public ViewAViewModel()
        {
            ClickCommand = new DelegateCommand(Click, CanClick)
                .ObservesCanExecute(() => CanExecute);
        }



        private bool CanClick()
        {
            return CanExecute;
        }

        private void Click()
        {
            Title = "Clicked";
        }

        private string _title = "Hello from ViewAViewModel";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private bool _canExecute;
        public bool CanExecute
        {
            get { return _canExecute; }
            set
            {
                SetProperty(ref _canExecute, value);
            }
        }

        public DelegateCommand ClickCommand { get; private set; }

    }
}
