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
            ClickCommand = new DelegateCommand(Click, CanClick);
        }

        private bool CanClick()
        {
            return true;
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

        public DelegateCommand ClickCommand { get; private set; }

    }
}
