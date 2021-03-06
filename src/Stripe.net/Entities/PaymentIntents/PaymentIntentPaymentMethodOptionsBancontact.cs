namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptionsBancontact : StripeEntity<PaymentIntentPaymentMethodOptionsBancontact>
    {
        /// <summary>
        /// Preferred language of the Bancontact authorization page that the customer is redirected
        /// to.
        /// </summary>
        [JsonProperty("preferred_language")]
        public string PreferredLanguage { get; set; }
    }
}
