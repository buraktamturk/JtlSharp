namespace Jtl.Connector.Core.Model;

public record ImageI18n : AbstractI18n
{
    /// <summary>
    /// Identity
    /// </summary>
    public Identity? id { get; init; }

    /// <summary>
    /// string
    /// </summary>
    public string? altText { get; init; }

}

