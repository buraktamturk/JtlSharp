namespace Jtl.Connector.Core.Model;

public record Language : AbstractI18n
{
    /// <summary>
    /// Identity Unique language id
    /// </summary>
    public Identity? id { get; init; }

    /// <summary>
    /// boolean Flag default language for frontend. Exact 1 language must be marked as default
    /// </summary>
    public bool? isDefault { get; init; }

    /// <summary>
    /// string English term
    /// </summary>
    public string? nameEnglish { get; init; }

    /// <summary>
    /// string German term
    /// </summary>
    public string? nameGerman { get; init; }

}

