// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the TabTwoViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace V.Tabs.Core.ViewModels
{ 
    using MvvmCross.Core.ViewModels;
    using System.Windows.Input;

    /// <summary>
    /// Define the TabTwoViewModel type.
    /// </summary>
    public class TabTwoViewModel : BaseViewModel
    {
        /// <summary>
        /// Backing field for my property.
        /// </summary>
        private string myProperty = "Tab Two";

        /// <summary>
        ///  Backing field for my command.
        /// </summary>
        private MvxCommand myCommand;

        /// <summary>
        /// Gets or sets my property.
        /// </summary>
        public string MyProperty
        {
            get { return this.myProperty; }
            set { this.SetProperty(ref this.myProperty, value, ()=> this.MyProperty); }
        }
    

      
    }
}

