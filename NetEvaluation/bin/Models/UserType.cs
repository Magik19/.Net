namespace NetEvaluation.bin.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum UserType
    {
        Buyer = 1,
        Seller = 2
    }
}