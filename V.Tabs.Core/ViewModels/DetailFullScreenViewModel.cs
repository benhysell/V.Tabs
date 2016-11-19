// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the DetailFullScreenViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace V.Tabs.Core.ViewModels
{ 
    using MvvmCross.Core.ViewModels;
    using System.Windows.Input;

    /// <summary>
    /// Define the DetailFullScreenViewModel type.
    /// </summary>
    public class DetailFullScreenViewModel : BaseViewModel
    {
        /// <summary>
        /// Backing field for my property.
        /// </summary>
        private string myProperty = "Full Screen View";

      

        /// <summary>
        /// Gets or sets my property.
        /// </summary>
        public string MyProperty
        {
            get { return this.myProperty; }
            set { this.SetProperty(ref this.myProperty, value, ()=> this.MyProperty); }
        }

        private MvxCommand closeCommand;

        public MvxCommand CloseCommand
        {
            get
            {
                closeCommand = closeCommand ?? new MvxCommand(DoCloseCommand);
                return closeCommand;
            }
        }

        private void DoCloseCommand()
        {
            Close(this);
        }



    }
}

