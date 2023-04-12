using Chinook.SectionsNavigation;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace SampleNavigation
{
    public sealed partial class Shell : UserControl
    {
        public Shell()
        {
            this.InitializeComponent();
        }

        public MultiFrame MultiFrame => NavigationRoot;
    }
}
