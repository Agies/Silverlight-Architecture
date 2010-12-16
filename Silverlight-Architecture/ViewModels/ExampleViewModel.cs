using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Linq;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace SilverlightArchitecture
{
    [Export]
    public class ExampleViewModel : ExampleDetailViewModel<ExampleModel>
    {
        [ImportingConstructor]
        public ExampleViewModel(IModelRepository<ExampleModel> modelRepository) : base(modelRepository)
        {

        }

        // basic binding
        public int EmployeeCode
        {
            get { return Model.EmployeeCode;}
            set
            {
                if (Model.EmployeeCode == value) return;
                Model.EmployeeCode = value;
                RaisePropertyChanged("EmployeeCode");
            }
        }

        // Secondary change binding
        public string FirstName
        {
            get { return Model.FirstName;}
            set
            {
                if (Model.FirstName == value) return;
                Model.FirstName = value;
                RaisePropertyChanged("FirstName");
                RaisePropertyChanged("FullName");
            }
        }

        // Secondary change binding
        public string LastName
        {
            get { return Model.LastName;}
            set
            {
                if (Model.LastName == value) return;
                Model.LastName = value;
                RaisePropertyChanged("LastName");
                RaisePropertyChanged("FullName");
            }
        }

        // One-way binding
        public string FullName
        {
            get { return Model.GetFullName();}
        }

        private ObservableCollection<ProjectViewModel> projects;
        public ObservableCollection<ProjectViewModel> Projects
        {
            get { return projects;}
            set
            {
                if (projects == value) return;
                projects = value;
                RaisePropertyChanged("Projects");
            }

        }

        private RelayCommand refreshCommand;
        public RelayCommand RefreshCommand
        {
            get { return (refreshCommand ?? (refreshCommand = new RelayCommand(Refresh, CanRefresh))); }
        }

        private bool CanRefresh()
        {
            return true;
        }

        protected override void Refresh()
        {
            base.Refresh();
            Projects = new ObservableCollection<ProjectViewModel>(Model.Projects.Select(p=>new ProjectViewModel(p)));
            RaisePropertyChanged("FirstName");
            RaisePropertyChanged("LastName");
            RaisePropertyChanged("FullName");
        }

        #region Message Brokering
        private ProjectViewModel selectedItem;
        public ProjectViewModel SelectedItem
        {
            get { return selectedItem;}
            set
            {
                if (selectedItem == value) return;
                selectedItem = value;
                RaisePropertyChanged("SelectedItem");
                Messenger.Default.Send(new GenericMessage<ProjectViewModel>(selectedItem));
            }

        }
        #endregion

    }
}
