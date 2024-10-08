using Proj1.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
                OnPropertyChanged(nameof(Name));
                OnPropertyChanged(nameof(Number));
                OnPropertyChanged(nameof(Email));
                UpdateFields();
            }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        private string number;
        public string Number
        {
            get { return number; }
            set
            {
                number = value;
                OnPropertyChanged(nameof(Number));
            }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public ICommand AddCommand { get; set; }
        public ICommand DelCommand { get; set; }
        public ICommand EditCommand { get; set; }

        public MainViewModel()
        {
            Users = new ObservableCollection<User>();
            AddCommand = new RelayCommand(Add);
            DelCommand = new RelayCommand(Del, CanDelete);
            EditCommand = new RelayCommand(Update, CanUpdate);
        }

        private bool CanUpdate(object? obj) => SelectedUser != null;

        private void Update(object? obj)
        {
            if (SelectedUser != null)
            {
                SelectedUser.Name = Name;
                SelectedUser.Number = Number;
                SelectedUser.Email = Email;
                OnPropertyChanged(nameof(Users));
            }
        }

        private bool CanDelete(object? obj) => SelectedUser != null;

        private void Del(object? obj)
        {
            if (SelectedUser != null)
            {
                Users.Remove(SelectedUser);
                ClearFields();
            }
        }

        private void Add(object? obj)
        {
            var newUser = new User { Name = Name, Number = Number, Email = Email };
            Users.Add(newUser);
            ClearFields();
        }

        private void ClearFields()
        {
            Name = string.Empty;
            Number = string.Empty;
            Email = string.Empty;
        }

        private void UpdateFields()
        {
            if (SelectedUser != null)
            {
                Name = SelectedUser.Name;
                Number = SelectedUser.Number;
                Email = SelectedUser.Email;
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}

