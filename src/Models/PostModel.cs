using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ContosoCrafts.WebSite.Models
{
    /// <summary>
    /// Data representation model class for a product.
    /// </summary>
    public class PostModel
    {
        //Get/Set product ID
        public string Id { get; set; }

        //Get/set the maker of said product
        public string Maker { get; set; }
        
        [JsonPropertyName("img")]
        //Get/Set image for a product
        public string Image { get; set; }

        //Get/set URL for a product
        public string Url { get; set; }

        //Get/set Title of a product
        public string Title { get; set; }

        //Get/set Description for a product
        public string Description { get; set; }

        // Get/set list of ratings for a producrt
        public int[] Ratings { get; set; }

        //Get/set the setup used for catching the fish
        public string Setup { get; set; }

        //Get/set the date when the fish was caught
        public string Date { get; set; }

        //Get/set the water temperature when the fish was caught
        public int WaterTemp { get; set; }

        //Get/set the location when the fish was caught
        public string Location { get; set; }

        // Get/set ToString method to get a string representation
        public override string ToString() => JsonSerializer.Serialize<PostModel>(this);
    }
}