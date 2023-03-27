using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Observable_Collection
{
    public class MyClass
    {
        private ObservableCollection<string> _myCollection;

        public MyClass()
        {
            _myCollection = new ObservableCollection<string>();
            _myCollection.CollectionChanged += OnCollectionChanged;
        }

        private void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (string item in e.NewItems)
                {
                    Console.WriteLine($"Element '{item}' is added in collection");
                }
            }
            else if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                foreach (string item in e.OldItems)
                {
                    Console.WriteLine($"Element '{item}' is removed from collection");
                }
            }
        }

        public void Add(string item)
        {
            _myCollection.Add(item);
        }

        public void Remove(string item)
        {
            _myCollection.Remove(item);
        }
    }

}
