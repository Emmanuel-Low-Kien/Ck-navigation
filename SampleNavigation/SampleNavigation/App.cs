using Chinook.DynamicMvvm;
using Chinook.SectionsNavigation;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.Threading;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;

namespace SampleNavigation
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        /// <remarks>
        /// If you're looking for App.xaml.cs, the file is present in each platform head
        /// of the solution.
        /// </remarks>
        public App()
        {
        }

        /// <summary>
        /// Gets the main window of the app.
        /// </summary>
        internal static Window MainWindow { get; private set; }

        /// <summary>
        /// Invoked when the application is launched normally by the end user.  Other entry points
        /// will be used such as when the application is launched to open a specific file.
        /// </summary>
        /// <param name="args">Details about the launch request and process.</param>
        protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
        {
#if DEBUG
		    if (System.Diagnostics.Debugger.IsAttached)
		    {
			    // this.DebugSettings.EnableFrameRateCounter = true;
		    }
#endif

#if WINDOWS
            MainWindow = new Window();
#else
            MainWindow = Microsoft.UI.Xaml.Window.Current;
#endif
            if (MainWindow.Content == null)
            {
                // Set the Shell as the window content.
                MainWindow.Content = new Shell();
            }

            var contentRootPath = GetContentRootPath();

            var serviceProvider = new HostBuilder()
                .UseContentRoot(contentRootPath)
                .ConfigureServices(serviceCollection => serviceCollection
                    .AddSingleton<IDynamicCommandBuilderFactory, DynamicCommandBuilderFactory>()
                    .AddSingleton<IDynamicPropertyFactory, DynamicPropertyFactory>()
                    .AddSingleton<ISectionsNavigator>(new FrameSectionsNavigator(
                      multiFrame: (MainWindow.Content as Shell).MultiFrame,
                      globalRegistrations: GetPageRegistrations()
                    ))
                  )
                  .Build()
                  .Services;

            ViewModelBase.DefaultServiceProvider = serviceProvider;

            var navigator = serviceProvider.GetService<ISectionsNavigator>();

            // Do an initial navigation
            _ = navigator.SetActiveSection(CancellationToken.None, "Home", () => new MainPageViewModel());

            MainWindow.Activate();
        }

        /// <summary>
        /// Invoked when Navigation to a certain page fails
        /// </summary>
        /// <param name="sender">The Frame which failed navigation</param>
        /// <param name="e">Details about the navigation failure</param>
        void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            throw new InvalidOperationException($"Failed to load {e.SourcePageType.FullName}: {e.Exception}");
        }

        /// <summary>
        /// Invoked when application execution is being suspended.  Application state is saved
        /// without knowing whether the application will be terminated or resumed with the contents
        /// of memory still intact.
        /// </summary>
        /// <param name="sender">The source of the suspend request.</param>
        /// <param name="e">Details about the suspend request.</param>
        private void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();
            //TODO: Save the application state and stop any background activity
            deferral.Complete();
        }

        private static IReadOnlyDictionary<Type, Type> GetPageRegistrations() => new Dictionary<Type, Type>()
        {
          // Assuming that MainPageViewModel is a class that inherits from the ViewModel class of the previous step.
          { typeof(MainPageViewModel), typeof(MainPage) },
          { typeof(TestPageViewModel), typeof(TestPage) },
          { typeof(SettingsPageViewModel), typeof(SettingsPage) }
        };

        private string GetContentRootPath()
        {
#if WINDOWS_UWP || __ANDROID__ || __IOS__
            return Windows.Storage.ApplicationData.Current.LocalFolder.Path;
#else
            return string.Empty;
#endif
        }
    }
}