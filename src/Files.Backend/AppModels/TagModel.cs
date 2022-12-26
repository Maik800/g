﻿using Files.Sdk.Storage.LocatableStorage;

namespace Files.Backend.AppModels
{
    /// <summary>
    /// Represents an item tag.
    /// </summary>
    public sealed record class TagModel(string[] Tags, ILocatableStorable Storable);
}
