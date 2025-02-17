﻿// Copyright (c) Microsoft. All rights reserved.

namespace Microsoft.SemanticMemory.Core.AI.OpenAI;

/// <summary>
/// OpenAI settings.
/// </summary>
public class OpenAIConfig
{
    /// <summary>
    /// Model used for text generation. Chat models can be used too.
    /// </summary>
    public string TextModel { get; set; } = string.Empty;

    /// <summary>
    /// Model used to embedding generation/
    /// </summary>
    public string EmbeddingModel { get; set; } = string.Empty;

    /// <summary>
    /// OpenAI API key.
    /// </summary>
    public string APIKey { get; set; } = string.Empty;

    /// <summary>
    /// Optional OpenAI Organization ID.
    /// </summary>
    public string? OrgId { get; set; } = string.Empty;

    /// <summary>
    /// How many times to retry in case of throttling.
    /// </summary>
    public int MaxRetries { get; set; } = 10;
}
