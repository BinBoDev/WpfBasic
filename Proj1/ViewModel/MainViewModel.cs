using Proj1.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Proj1.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<User> Users { get; set; }
        private User selectedUser;

        public User SelectedUser
        {
            get { return selectedUser; }
            set 
            { 
                selectedUser = value;
                OnPropertyChanged(nameof(SelectedUser));
            
            }
        }
        public string Name { get; set; }
        public string Number { get; set; }
        public string Email { get; set; }

        public ICommand AddCommand { get; set; }
        public ICommand DelCommand { get; set; }
        public ICommand EditCommand { get; set; }


        public MainViewModel()
        {
            Users = new ObservableCollection<User>();
            AddCommand = new RelayCommand(Add);
            DelCommand = new RelayCommand(Delete, CanDelete);
            EditCommand = new RelayCommand(Update, CanUpdate);
        }

        private bool CanUpdate(object? obj)
        {
            return selectedUser != null;
        }

        private void Update(object? obj)
        {
            if (SelectedUser != null)
            {
                selectedUser.Name = Name;
                selectedUser.Number = Number;
                selectedUser.Email = Email;
                OnPropertyChanged(nameof (Users));
            }
        }

        private bool CanDelete(object? obj)
        {
            return selectedUser != null;
        }

        private void Delete(object? obj)
        {
            if (selectedUser != null)
            {
                Users.Remove(selectedUser);
            }
        }

        private void Add(object? obj)
        {
            Users.Add(new User { Name = Name ,Number = Number,Email = Email});
            ClearFields();
        }

        private void ClearFields()
        {
            Name = string.Empty;
            Number = string.Empty;
            Email = string.Empty;
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
