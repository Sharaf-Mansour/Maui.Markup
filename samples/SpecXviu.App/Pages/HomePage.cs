using SpecXviu.App.ViewModels.Base;

namespace SpecXviu.App;
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
