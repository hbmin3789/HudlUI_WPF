using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HudUI_WPF_Test
{
    public class HudViewModelBase : BindableBase
    {
        private ObservableCollection<string> _itemsSource = new ObservableCollection<string>();
        public ObservableCollection<string> ItemsSource
        {
            get => _itemsSource;
            set => SetProperty(ref _itemsSource, value);
        }

        public async Task AddItems()
        {
            List<string> items = new List<string>();

            ItemsSource = new ObservableCollection<string>();

            for (int i = 0; i < 20; i++)
            {
                string newItem = string.Empty;
                newItem = i.ToString();
                await Task.Delay(40);
                App.Current.Dispatcher.Invoke(() =>
                {
                    ItemsSource.Add(newItem);
                });
            }

        }
    }
}
