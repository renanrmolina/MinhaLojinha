using MongoDB.Bson;
using MongoDB.Bson.Serialzation.Attributes;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialzation;

namespace LojinhaServer.Collections;

    [Table("products")]
    [BsonIgnoreExtraElements]
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }  

        [BsonElement("name")]
         [JsonPropertyName("Nome")]  
        public string Name { get; set; }

        [BsonElement("Description")]
        [JsonPropertyName("Descrição")]  
        public string Description { get; set; }

        [BsonElement("Price")]
        [JsonPropertyName("Preço")]  
        public decimal Price { get; set; }

        [BsonElement("OffPrice")]
        [JsonPropertyName("Desconto")]  
        public decimal OffPrice { get; set; }

        [BsonElement("Categories")]
        [JsonPropertyName("Categorias")]  
        public List<string> Categories { get; set; }

        [BsonElement("Tags")]
        [JsonPropertyName("Tags")]  
        public List<string> Tags { get; set; }

        [BsonElement("Brand")]
        [JsonPropertyName("Marca")]  
        public string Brand { get; set; }

    }
