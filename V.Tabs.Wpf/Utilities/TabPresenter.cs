using MvvmCross.Wpf.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCross.Platform.Exceptions;
using MvvmCross.Platform.Platform;
using MvvmCross.Plugins.Messenger;
using V.Tabs.Wpf.Views;

namespace V.Tabs.Wpf.Utilities
{
    public class TabPresenter : MvxWpfViewPresenter
    {
        private readonly ContentControl mainWindow;
        private readonly Stack<FrameworkElement> navigationStack = new Stack<FrameworkElement>();



        private HomeView homeView;

        public TabPresenter(ContentControl mainWindow)
        {
            this.mainWindow = mainWindow;
        }

        public override void Show(MvxViewModelRequest request)
        {
            try
            {
                var loader = Mvx.Resolve<IMvxSimpleWpfViewLoader>();
                var view = loader.CreateView(request);
                Present(view);
            }
            catch (Exception exception)
            {
                MvxTrace.Error("Error seen during navigation request to {0} - error {1}", request.ViewModelType.Name,
                               exception.ToLongString());
            }
        }

        public override void ChangePresentation(MvxPresentationHint hint)
        {
            if (hint is MvxClosePresentationHint)
            {
                //ensure we have at least 2 items on the stack
                //this will be the base view that shows the sliding menu and another view
                //that was selected on the base sliding view
                //ensure we do not pop the base sliding view
                if (navigationStack.Count >= 2)
                {
                    navigationStack.Pop();
                    if (1 == navigationStack.Count)
                    {
                        //we have navigated down to the last screen, this is a base
                        //view that shows the tab menu, show it                       
                        homeView.ContentGrid.Children.Clear();
                        homeView.ContentGrid.Children.Add(navigationStack.Peek());
                        mainWindow.Content = homeView;
                    }                   
                }
                return;
            }
            base.ChangePresentation(hint);
        }

        public override void Present(FrameworkElement frameworkElement)
        {
            //grab the attribute off of the view
            var attribute = frameworkElement
                                .GetType()
                                .GetCustomAttributes(typeof(RegionAttribute), true)
                                .FirstOrDefault() as RegionAttribute;

            var regionName = null == attribute ? Region.Unknown : attribute.Region;
            //based on region decide where we are going to show it
            switch (regionName)
            {               
                case Region.BaseTab:
                    //set the base tab
                    mainWindow.Content = frameworkElement;
                    homeView = (HomeView)frameworkElement;
                    break;
                case Region.Tab:                                       
                    if (navigationStack.Any())
                        navigationStack.Pop();
                    homeView.ContentGrid.Children.Clear();
                    homeView.ContentGrid.Children.Add(frameworkElement);
                    navigationStack.Push(frameworkElement);

                    break;
                case Region.FullScreen:
                    //view that requires full screen
                    //but can navigate backwards
                    mainWindow.Content = frameworkElement;
                    navigationStack.Push(frameworkElement);
                    break;
            }

        }
    }
}
