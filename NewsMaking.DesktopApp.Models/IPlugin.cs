namespace NewsMaking.DesktopApp.Models
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
        /// Address of the main page of the plugin.
        /// </summary>
        public Uri IndexPageAddress { get; set; }

        /// <summary>
        /// Address of the settings page of the plugin.
        /// </summary>
        public Uri SettingsPageAddress { get; set; }

        /// <summary>
        /// Address of the help page of the plugin.
        /// </summary>
        public Uri HelpPageAddress { get; set; }
    }
}