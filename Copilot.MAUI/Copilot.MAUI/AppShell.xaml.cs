﻿namespace Copilot.MAUI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(StyleSelector), typeof(StyleSelector));
        }
    }
}
