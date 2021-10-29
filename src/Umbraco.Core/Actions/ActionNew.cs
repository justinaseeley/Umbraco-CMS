﻿namespace Umbraco.Cms.Core.Actions
{
    /// <summary>
    /// This action is invoked upon creation of a document
    /// </summary>
    public class ActionNew : IAction
    {
        public const string ActionAlias = "create";
        public const char ActionLetter = 'C';

        /// <inheritdoc/>
        public char Letter => ActionLetter;

        /// <inheritdoc/>
        public string Alias => ActionAlias;

        /// <inheritdoc/>
        public string Icon => "add";

        /// <inheritdoc/>
        public bool ShowInNotifier => true;

        /// <inheritdoc/>
        public bool CanBePermissionAssigned => true;

        /// <inheritdoc/>
        public string Category => Constants.Conventions.PermissionCategories.ContentCategory;
    }
}
