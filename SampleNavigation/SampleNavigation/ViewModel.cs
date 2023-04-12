using Chinook.DynamicMvvm;
using Chinook.StackNavigation;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleNavigation
{
    public class ViewModel : ViewModelBase, INavigableViewModel
    {
        public void SetView(object view)
        {
            // For Chinook.DynamicMvvm, we want to create an MVVM dispatcher using the CoreDispatcher of the Page.
            Dispatcher = new DispatcherQueueDispatcher((Page)view);
        }
    }
}
