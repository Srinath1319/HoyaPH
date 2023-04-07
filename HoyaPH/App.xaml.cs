using HoyaPH.Test;

namespace HoyaPH;

public partial class App : Application
{
    public App(MainPage mainPage)
    {
        InitializeComponent();

        MainPage = new NavigationPage(mainPage);

        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(BorderlessEntry), (handler, view) =>
        {
#if __ANDROID__
handler.PlatformView.SetBackgroundDrawable(null);
#endif
        });
    }
}
