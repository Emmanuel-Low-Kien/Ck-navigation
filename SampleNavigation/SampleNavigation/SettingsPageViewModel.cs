using Chinook.DynamicMvvm;
using Chinook.SectionsNavigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleNavigation
{
    public class SettingsPageViewModel : ViewModel
    {
        public string Content
        {
            get => this.Get(initialValue: "Settings page view model");
            set => this.Set(value);
        }

        public IDynamicCommand NavigateToHomeSection=> this.GetCommandFromTask(async ct =>
        {
            await this.GetService<ISectionsNavigator>().SetActiveSection(ct, "Home");
        });
    }
}
