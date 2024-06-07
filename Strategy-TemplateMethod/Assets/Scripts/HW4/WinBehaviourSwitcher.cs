public class WinBehaviourSwitcher
{
    private StartPanel _panel;
    private Level _level;
    public WinBehaviourSwitcher(StartPanel panel, Level level)
    {
        _panel = panel;
        _level = level;
        _panel.OnAllModeSelected += ApplyAllMode;
        _panel.OnColorModeSelected += ApplyColorMode;
        // отписаться в IDisposable Zenject ? 
    }

    private void ApplyAllMode()
    {
        _level.SetGameMode(new PopAllBehaviour());
    }

    private void ApplyColorMode()
    {
        _level.SetGameMode(new PopColorBehaviour());
    }
}
