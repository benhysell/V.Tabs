// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the TabOneViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace V.Tabs.Core.ViewModels
{ 
    using MvvmCross.Core.ViewModels;
    using System.Windows.Input;

    /// <summary>
    /// Define the TabOneViewModel type.
    /// </summary>
    public class TabOneViewModel : BaseViewModel
    {
        /// <summary>
        /// Backing field for my property.
        /// </summary>
        private string myProperty = "Tab One";

      
        /// <summary>
        /// Gets or sets my property.
        /// </summary>
        public string MyProperty
        {
            get { return this.myProperty; }
            set { this.SetProperty(ref this.myProperty, value, ()=> this.MyProperty); }
        }

        private MvxCommand showFullScreenViewCommand;

        public MvxCommand ShowFullScreenViewCommand
        {
            get
            {
                showFullScreenViewCommand = showFullScreenViewCommand ?? new MvxCommand(DoShowFullScreenView);
                return showFullScreenViewCommand;
            }
        }

        private void DoShowFullScreenView()
        {
            ShowViewModel<DetailFullScreenViewModel>();
        }



    }
}

