using System;
using System.Collections.Generic;
using Copilot.MAUI.Themes;
using Microsoft.Maui.Controls;

namespace Copilot.MAUI
{
    /// <summary>
    /// Represents a page that allows the user to select a style.
    /// </summary>
    public partial class StyleSelector : ContentPage
    {
        private const string lightTheme = "LightTheme";
        private const string darkTheme = "DarkTheme";
        private string currentTheme = "";

        /// <summary>
        /// Initializes a new instance of the <see cref="StyleSelector"/> class.
        /// </summary>
        public StyleSelector()
        {
            InitializeComponent();
            SetCurrentTheme(lightTheme, new LightTheme());
        }

        /// <summary>
        /// Handles the Clicked event of the Button control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            if (currentTheme == lightTheme)
            {
                SetCurrentTheme(darkTheme, new DarkTheme());
            }
            else
            {
                SetCurrentTheme(lightTheme, new LightTheme());
            }
        }

        /// <summary>
        /// Sets the current theme.
        /// </summary>
        /// <param name="themeName">Name of the theme.</param>
        /// <param name="theme">The theme.</param>
        void SetCurrentTheme(string themeName, ResourceDictionary theme)
        {
            ICollection<ResourceDictionary> mergedDictionaries = this.Resources.MergedDictionaries;
            if (mergedDictionaries != null)
            {
                mergedDictionaries.Clear();
                mergedDictionaries.Add(theme);
                currentTheme = themeName;
            }
        }
    }
}
