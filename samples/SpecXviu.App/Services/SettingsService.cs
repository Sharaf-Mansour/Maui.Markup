namespace SpecXviu.App.Services;

public class SettingsService
{
	public const int MinimumStoriesToFetch = 1;
	public const int MaximumStoriesToFetch = 50;

	readonly IPreferences preferences;

	public SettingsService(IPreferences preferences) => this.preferences = preferences;

	public int NumberOfTopStoriesToFetch
	{
		get => preferences.Get(nameof(NumberOfTopStoriesToFetch), 25, nameof(SpecXviu.App));
		set => preferences.Set(nameof(NumberOfTopStoriesToFetch), Math.Clamp(value, MinimumStoriesToFetch, MaximumStoriesToFetch), nameof(SpecXviu.App));
	}
}