using System.Collections.Generic;
using System.Text.Json.Serialization;

// ==== TODAS LAS CLASES NECESARIAS ====

namespace DigimonData
{
    

public class Digimon
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("descriptions")]
    public List<Description> Descriptions { get; set; }

    [JsonPropertyName("levels")]
    public List<Level> Levels { get; set; }

    [JsonPropertyName("types")]
    public List<TypeDigi> Types { get; set; }

    [JsonPropertyName("attributes")]
    public List<AttributeDigi> Attributes { get; set; }

    [JsonPropertyName("fields")]
    public List<Field> Fields { get; set; }

    [JsonPropertyName("releaseDate")]
    public string ReleaseDate { get; set; }

    [JsonPropertyName("skills")]
    public List<Skill> Skills { get; set; }

    [JsonPropertyName("images")]
    public List<Image> Images { get; set; }
}

public class Description
{
    [JsonPropertyName("origin")]
    public string Origin { get; set; }

    [JsonPropertyName("description")]
    public string DescriptionText { get; set; }
}

public class Level
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("level")]
    public string LevelName { get; set; }
}

public class TypeDigi
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }
}

public class AttributeDigi
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("attribute")]
    public string AttributeName { get; set; }
}

public class Field
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("field")]
    public string FieldName { get; set; }
}

public class Skill
{
    [JsonPropertyName("skill")]
    public string SkillName { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }
}

public class Image
{
    [JsonPropertyName("href")]
    public string Href { get; set; }
}

}
