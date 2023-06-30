using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectMAUI.ViewModel
{
   public partial class MainViewModel : ObservableObject
   {
      public MainViewModel()
      {
         Items = new ObservableCollection<string>();
      }

      [ObservableProperty]
      ObservableCollection<string> items;

      [ObservableProperty] // ця клас вміщує в собі нище закоментований код
      string text; /*      public string Text
      {
         get { return text; }
         set
         {
            text = value;
            OnPropertyChanged(nameof(Text));
         }
      }
      public event PropertyChangedEventHandler PropertyChanged;
      void OnPropertyChanged(string name) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));*/

      [RelayCommand]
      void Add()
      {
         if (string.IsNullOrEmpty(text)) return;
         Items.Add(Text);

         Text = string.Empty;
      }  
      [RelayCommand]
      void Delete(string s)
      {
         if (Items.Contains(s))
         {
            Items.Remove(s);
         }
      }
      [RelayCommand]
      async Task Tap(string s)
      {
         await Shell.Current.GoToAsync($"{nameof(DetailPage)}?Text={s}");
      }
   }
}
