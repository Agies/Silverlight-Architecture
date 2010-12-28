using GalaSoft.MvvmLight;

namespace SilverlightArchitecture
{
    public class DetailViewModel<TModel> : ViewModelBase where TModel : class
    {
        protected IModelRepository<TModel> Repository { get; set; }
        
        private TModel model;
        public TModel Model
        {
            get { return model;}
            set
            {
                if (model == value) return;
                model = value;
                RaisePropertyChanged("Model");
            }
        }

        public DetailViewModel(IModelRepository<TModel> repository)
        {
            Repository = repository;
            Refresh();
        }

        public DetailViewModel(TModel model)
        {
            this.model = model;
        }

        protected virtual void Refresh()
        {
            Model = Repository.Get();
        }
    }
}