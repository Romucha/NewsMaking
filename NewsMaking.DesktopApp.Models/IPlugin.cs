namespace NewMaking.Models
{
				/// <summary>
				/// Provides all the necessary fields to create a plugin for News Making Desktop Application.
				/// </summary>
				public interface IPlugin
				{
								/// <summary>
								/// Plugin id.
								/// </summary>
								public string Id { get; set; }

								/// <summary>
								/// Displayable name of plugin.
								/// </summary>
								public string DisplayName { get; set; }

								/// <summary>
								/// Plugin descripton.
								/// </summary>
								public string Description { get; set; }

								/// <summary>
								/// Plugin icon.
								/// </summary>
								public int Icon { get; set; }

								/// <summary>
								/// Initializes plugin data.
								/// </summary>
								/// <returns></returns>
								public Task InitializeAsync();

								/// <summary>
								/// Terminates plugin data.
								/// </summary>
								/// <returns></returns>
								public Task TerminateAsync();

								/// <summary>
								/// Updates plugin data.
								/// </summary>
								/// <returns></returns>
								public Task UpdateAsync();

								/// <summary>
								/// Calls for help web page.
								/// </summary>
								/// <returns></returns>
								public Task HelpAsync();
				}
}