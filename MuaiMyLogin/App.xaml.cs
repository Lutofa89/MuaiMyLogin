using MuaiMyLogin.Model;

namespace MuaiMyLogin;

public partial class App : Application
{
	public static UserInfo userInfo;
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
