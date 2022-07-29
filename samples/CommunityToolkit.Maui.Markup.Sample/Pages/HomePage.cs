using CommunityToolkit.Maui.Markup.Sample.ViewModels.Base;

namespace HelloMotherFuckers;
class HomePage : BaseContentPage<BaseViewModel>
{
	public HomePage() : base(null,"") 
	=> Content = new ScrollView
	{
		Content = new VerticalStackLayout
		{		 
			Children =
			{
				new WebView
				{
						Source = "https://specxviu.online "
				},		 
			}
		}
	};
}
