using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XF.CollectionView.Views;

namespace XF.CollectionView.ViewModels
{
    public class ExamplesPageViewModel
    {
        public ICommand OpenVerticalListPageCommand { get; private set; }
        public ICommand OpenHorizontalListPageCommand { get; private set; }
        public ICommand OpenHorizontalGridPageCommand { get; private set; }
        public ICommand OpenVerticalGridPageCommand { get; private set; }

        public ExamplesPageViewModel()
        {
            OpenVerticalListPageCommand = new Command(OpenVerticalListPage);
            OpenHorizontalListPageCommand = new Command(OpenHorizontalListPage);
            OpenHorizontalGridPageCommand = new Command(OpenHorizontalGridPage);
            OpenVerticalGridPageCommand = new Command(OpenVerticalGridPage);
        }

        private void OpenVerticalGridPage()
        {
            App.Current.MainPage.Navigation.PushAsync(new VerticalGridPage());
        }

        private void OpenHorizontalGridPage()
        {
            App.Current.MainPage.Navigation.PushAsync(new HorizontalGridPage());
        }

        private void OpenHorizontalListPage()
        {
            App.Current.MainPage.Navigation.PushAsync(new HorizontalListPage());
        }

        private void OpenVerticalListPage()
        {
            App.Current.MainPage.Navigation.PushAsync(new VerticalListPage());
        }
    }
}
