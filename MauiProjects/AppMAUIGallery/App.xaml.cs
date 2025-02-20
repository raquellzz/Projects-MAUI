namespace AppMAUIGallery
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
#if WINDOWS
                    return new Window(new AppFlyout());
#else
            throw new PlatformNotSupportedException("Window is only supported on Windows.");
#endif
        }
    }
}