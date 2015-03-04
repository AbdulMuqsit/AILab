using System.Collections.ObjectModel;
using SecondLab.Model;
using SecondLab.ViewModel;

namespace SecondLab.Infrastructure
{
    class GraphViewModel : ViewModelBase
    {
        private ObservableCollection<Node<int>> _graph;

        public ObservableCollection<Node<int>> Graph
        {
            get { return _graph; }
            set
            {
                if (Equals(value, _graph)) return;
                _graph = value;
                OnPropertyChanged();
            }
        }
    }
}
