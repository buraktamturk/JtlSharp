namespace Jtl.Connector.Core.Model;

public record CustomerOrderPaymentInfo : AbstractIdentity
{
    /// <summary>
    /// string Bank account holder name
    /// </summary>
    public string? accountHolder { get; init; }

    /// <summary>
    /// string Bank account number (deprecated in DE since SEPA
    /// </summary>
    public string? accountNumber { get; init; }

    /// <summary>
    /// string Bank code (deprecated in DE since SEPA
    /// </summary>
    public string? bankCode { get; init; }

    /// <summary>
    /// string Bank name
    /// </summary>
    public string? bankName { get; init; }

    /// <summary>
    /// string Bank Identifier Code (BIC
    /// </summary>
    public string? bic { get; init; }

    /// <summary>
    /// string Credit card expiration date
    /// </summary>
    public string? creditCardExpiration { get; init; }

    /// <summary>
    /// string
    /// </summary>
    public string? creditCardHolder { get; init; }

    /// <summary>
    /// string Credit card number
    /// </summary>
    public string? creditCardNumber { get; init; }

    /// <summary>
    /// string Credit card type (e.g. "visa
    /// </summary>
    public string? creditCardType { get; init; }

    /// <summary>
    /// string Credit card verification number
    /// </summary>
    public string? creditCardVerificationNumber { get; init; }

    /// <summary>
    /// string International Bank Account Number (IBAN
    /// </summary>
    public string? iban { get; init; }

}

