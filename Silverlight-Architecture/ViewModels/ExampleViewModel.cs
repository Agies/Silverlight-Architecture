using System.ComponentModel;
using System.ComponentModel.Composition;

namespace SilverlightArchitecture
{
    [Export]
    public class ExampleViewModel : INotifyPropertyChanged
    {
        // basic binding
        private int employeeCode;
        public int EmployeeCode
        {
            get { return employeeCode;}
            set
            {
                if (employeeCode == value) return;
                employeeCode = value;
                RaisePropertyChanged("EmployeeCode");
            }

        }

        // Secondary change binding
        private string firstName;
        public string FirstName
        {
            get { return firstName;}
            set
            {
                if (firstName == value) return;
                firstName = value;
                RaisePropertyChanged("FirstName");
            }
        }

        // Secondary change binding
        private string lastName;
        public string LastName
        {
            get { return lastName;}
            set
            {
                if (lastName == value) return;
                lastName = value;
                RaisePropertyChanged("LastName");
            }
        }

        // One-way binding
        private string fullName = "Test Name";
        public string FullName
        {
            get { return fullName;}
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
