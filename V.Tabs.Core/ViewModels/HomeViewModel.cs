// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the HomeViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace V.Tabs.Core.ViewModels
{ 
    using MvvmCross.Core.ViewModels;
    using System.Windows.Input;

    /// <summary>
    /// Define the HomeViewModel type.
    /// </summary>
    public class HomeViewModel : BaseViewModel
    {

        private MvxCommand showTabOneCommand;

        public MvxCommand ShowTabOneCommand
        {
            get
            {
                showTabOneCommand = showTabOneCommand ?? new MvxCommand(DoShowTabOne);
                return showTabOneCommand;
            }
        }

        private void DoShowTabOne()
        {
            ShowViewModel<TabOneViewModel>();
        }

        private MvxCommand showTabTwoCommand;

        public MvxCommand ShowTabTwoCommand
        {
            get
            {
                showTabTwoCommand = showTabTwoCommand ?? new MvxCommand(DoShowTabTwo);
                return showTabTwoCommand;
            }
        }

        private void DoShowTabTwo()
        {
            ShowViewModel<TabTwoViewModel>();
        }

        private MvxCommand showTabThreeCommand;

        public MvxCommand ShowTabThreeCommand
        {
            get
            {
                showTabThreeCommand = showTabThreeCommand ?? new MvxCommand(DoShowTabThree);
                return showTabThreeCommand;
            }
        }

        private void DoShowTabThree()
        {
            ShowViewModel<TabThreeViewModel>();
        }




    }
}

