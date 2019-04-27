using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Mvvm;

namespace ASync
{
    public class SearchInfo : BindableBase
    {
        public SearchInfo() 
        {
            list = new ObservableCollection<SearchItemResult>();
            list.CollectionChanged += delegate { OnPropertyChanged("List"); };
        }
        private ObservableCollection<SearchItemResult> list;
        private string searchTerm;

        public ObservableCollection<SearchItemResult> List
        {
            get
            {
                return list;
            }
        }

        public string SearchTerm
        {
            get
            {
                return searchTerm;
            }

            set
            {
                SetProperty(ref searchTerm, value);
            }
        }
    }
}
