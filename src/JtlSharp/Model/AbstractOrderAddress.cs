namespace Jtl.Connector.Core.Model;

public record AbstractOrderAddress : AbstractIdentity
{
    /// <summary>
    /// string City
    /// </summary>
    public string? city { get; init; }

    /// <summary>
    /// string Company name
    /// </summary>
    public string? company { get; init; }

    /// <summary>
    /// string Country ISO 3166-2 (2 letter Uppercase
    /// </summary>
    public string? countryIso { get; init; }

    /// <summary>
    /// string Delivery instruction e.g. "c/o John Doe
    /// </summary>
    public string? deliveryInstruction { get; init; }

    /// <summary>
    /// string E-Mail address
    /// </summary>
    public string? eMail { get; init; }

    /// <summary>
    /// string Extra address line e.g. 'Apartment 2.5
    /// </summary>
    public string? extraAddressLine { get; init; }

    /// <summary>
    /// string Fax number
    /// </summary>
    public string? fax { get; init; }

    /// <summary>
    /// string First name
    /// </summary>
    public string? firstName { get; init; }

    /// <summary>
    /// string Last name
    /// </summary>
    public string? lastName { get; init; }

    /// <summary>
    /// string Mobile phone number
    /// </summary>
    public string? mobile { get; init; }

    /// <summary>
    /// string Phone number
    /// </summary>
    public string? phone { get; init; }

    /// <summary>
    /// string Salutation e.g. 'Mr
    /// </summary>
    public string? salutation { get; init; }

    /// <summary>
    /// string State
    /// </summary>
    public string? state { get; init; }

    /// <summary>
    /// string Street + streetnumber
    /// </summary>
    public string? street { get; init; }

    /// <summary>
    /// string Title e.g. ("Prof. Dr
    /// </summary>
    public string? title { get; init; }

    /// <summary>
    /// string Zip / postal code
    /// </summary>
    public string? zipCode { get; init; }

}

