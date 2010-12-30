using System;
using System.ComponentModel.Composition;

namespace SilverlightArchitecture
{
    [Export]
    public class ProjectViewModel : DetailViewModel<Project>
    {
        public string Name
        {
            get { return Model.Name;}
            set
            {
                if (Model.Name == value) return;
                Model.Name = value;
                RaisePropertyChanged("Name");
            }
        }

        public string Website
        {
            get { return Model.Website.AbsoluteUri;}
            set
            {
                if (Model.Website.AbsoluteUri == value) return;
                Model.Website = new Uri(value);
                RaisePropertyChanged("Website");
            }
        }

        [ImportingConstructor]
        public ProjectViewModel(Project model) : base(model)
        {
        }
    }
}