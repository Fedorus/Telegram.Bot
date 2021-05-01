using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.Bot.Types.Payments;

namespace Telegram.Bot.Types.InlineQueryResults
{
    /// <summary>
    /// Represents the content of an invoice message to be sent as the result of an inline query.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class InputInvoiceMessageContent : InputMessageContentBase
    {
        /// <summary>
        /// Product name, 1-32 characters
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public string Title { get; set; }

        /// <summary>
        /// Product description, 1-255 characters
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public string Description { get; set; }

        /// <summary>
        /// Bot-defined invoice payload, 1-128 bytes. This will not be displayed to the user, use for your internal processes.
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public string Payload { get; set; }

        /// <summary>
        /// Payments provider token, obtained via BotFather
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public string ProviderToken { get; set; }

        /// <summary>
        /// Three-letter ISO 4217 currency code
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public string Currency { get; set; }

        /// <summary>
        /// Price breakdown, a list of components (e.g. product price, tax, discount, delivery cost, delivery tax, bonus, etc.)
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public IEnumerable<LabeledPrice> Prices { get; }

        /// <summary>
        /// Optional. The maximum accepted amount for tips in the smallest units of the currency (integer, not float/double). For example, for a maximum tip of US$ 1.45 pass max_tip_amount = 145. See the exp parameter in currencies.json, it shows the number of digits past the decimal point for each currency (2 for the majority of currencies). Defaults to 0
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int MaxTipAmount { get; set; }


        /// <summary>
        /// Optional. A JSON-serialized array of suggested amounts of tips in the smallest units of the currency (integer, not float/double). At most 4 suggested tip amounts can be specified. The suggested tip amounts must be positive, passed in a strictly increased order and must not exceed max_tip_amount.
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int[] SuggestedTipAmounts { get; set; }

        /// <summary>
        /// JSON-encoded data about the invoice, which will be shared with the payment provider. A detailed description of required fields should be provided by the payment provider.
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ProviderData { get; set; }

        /// <summary>
        /// URL of the product photo for the invoice. Can be a photo of the goods or a marketing image for a service. People like it better when they see what they are paying for.
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string PhotoUrl { get; set; }

        /// <summary>
        /// Photo size
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int PhotoSize { get; set; }

        /// <summary>
        /// Photo width
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int PhotoWidth { get; set; }

        /// <summary>
        /// Photo height
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int PhotoHeight { get; set; }

        /// <summary>
        /// Pass True, if you require the user's full name to complete the order
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool NeedName { get; set; }

        /// <summary>
        /// Pass True, if you require the user's phone number to complete the order
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool NeedPhoneNumber { get; set; }

        /// <summary>
        /// Pass True, if you require the user's email to complete the order
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool NeedEmail { get; set; }

        /// <summary>
        /// Pass True, if you require the user's shipping address to complete the order
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool NeedShippingAddress { get; set; }

        /// <summary>
        /// Pass True, if user's phone number should be sent to provider
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool SendPhoneNumberToProvider { get; set; }

        /// <summary>
        /// Pass True, if user's email address should be sent to provider
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool SendEmailToProvider { get; set; }

        /// <summary>
        /// Pass True, if you require the user's email to complete the order
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool IsFlexible { get; set; }

        private InputInvoiceMessageContent()
        {
        }


        /// <summary>
        /// Initializes with title, description, payload, providerToken, currency and an array of <see cref="LabeledPrice"/>
        /// </summary>
        /// <param name="title">Product name, 1-32 characters</param>
        /// <param name="description">Product description, 1-255 characters</param>
        /// <param name="payload">Bot-defined invoice payload, 1-128 bytes</param>
        /// <param name="providerToken">Payments provider token, obtained via BotFather</param>
        /// <param name="currency">Three-letter ISO 4217 currency code</param>
        /// <param name="prices">Price breakdown, a list of components (e.g. product price, tax, discount, delivery cost, delivery tax, bonus, etc.)</param>

        public InputInvoiceMessageContent(
            string title,
            string description,
            string payload,
            string providerToken,
            string currency,
            IEnumerable<LabeledPrice> prices
            )
        {
            Title = title;
            Description = description;
            Payload = payload;
            ProviderToken = providerToken;
            Currency = currency;
            Prices = prices;
        }
    }
}