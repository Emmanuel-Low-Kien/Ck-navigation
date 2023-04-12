using Chinook.DynamicMvvm;
using Chinook.SectionsNavigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SampleNavigation
{
    public class MainPageViewModel : ViewModel
    {
        public IDynamicCommand NavigateToTest => this.GetCommandFromTask(async ct =>
        {
            await this.GetService<ISectionsNavigator>().Navigate(ct, () => new TestPageViewModel());
        });

        public IDynamicCommand NavigateToSettingSection => this.GetCommandFromTask(async ct =>
        {
            await this.GetService<ISectionsNavigator>().SetActiveSection(ct, "Settings", () => new SettingsPageViewModel());
        });
    }
}
