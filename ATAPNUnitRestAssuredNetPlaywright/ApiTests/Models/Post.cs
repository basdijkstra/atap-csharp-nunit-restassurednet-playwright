using Newtonsoft.Json;

namespace ATAPNUnitRestAssuredNetPlaywright.ApiTests.Models
{
    public class Post
    {
        [JsonProperty("userId")]
        public int UserId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }
    }
}
