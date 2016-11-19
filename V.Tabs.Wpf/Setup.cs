// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the Setup type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using MvvmCross.BindingEx.Wpf;

namespace V.Tabs.Wpf
{
    using MvvmCross.Core.ViewModels;
    using MvvmCross.Wpf.Platform;
    using MvvmCross.Wpf.Views;
    using System.Windows.Threading;

    /// <summary>
    ///  Defines the Setup type.
    /// </summary>
    public class Setup : MvxWpfSetup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Setup"/> class.
        /// </summary>
        /// <param name="dispatcher">The dispatcher.</param>
        /// <param name="presenter">The presenter.</param>
        public Setup(Dispatcher dispatcher, IMvxWpfViewPresenter presenter)
            : base(dispatcher, presenter)
        {
        }

        /// <summary>
        /// Creates the app.
        /// </summary>
        /// <returns>An instance of MvxApplication</returns>
        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }


        protected override void InitializeLastChance()
        {
            base.InitializeLastChance();

            var builder = new MvxWindowsBindingBuilder();            
            builder.DoRegistration();
        }
    }
}
