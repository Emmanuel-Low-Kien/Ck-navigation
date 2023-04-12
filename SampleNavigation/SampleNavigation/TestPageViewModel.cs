using Chinook.DynamicMvvm;
using Chinook.SectionsNavigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleNavigation
{

    public class TestPageViewModel : ViewModel
    {
        public string Content
        {
            get => this.Get(initialValue: string.Empty);
            set => this.Set(value);
        }

        public IDynamicCommand Submit => this.GetCommand(() =>
        {
            Result = Content;
        });

        public string Result
        {
            get => this.Get(initialValue: string.Empty);
            private set => this.Set(value);
        }

        public IDynamicCommand NavigateToSettingSection => this.GetCommandFromTask(async ct =>
        {
            await this.GetService<ISectionsNavigator>().SetActiveSection(ct, "Settings", () => new SettingsPageViewModel());
        });

        public IDynamicCommand NavigateBack => this.GetCommandFromTask(async ct =>
        {
            await this.GetService<ISectionsNavigator>().NavigateBack(ct);
        });
    }
}
