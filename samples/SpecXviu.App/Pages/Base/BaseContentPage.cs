using SpecXviu.App.ViewModels.Base;
namespace SpecXviu.App;
abstract class BaseContentPage<T> : ContentPage where T : BaseViewModel
{
	protected BaseContentPage(T? viewModel, string? pageTitle) => (base.BindingContext, Title) = (viewModel, pageTitle);
	protected new T BindingContext => (T)base.BindingContext;
}