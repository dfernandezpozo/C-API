using System;
using DigimonData; 
using System.Collections.Generic;

namespace DigimonData
{
    public static class InfoBasica
    {
        public static void Mostrar(Digimon digi)
        {
            Console.WriteLine("\n=== Información completa del Digimon ===\n");

            Console.WriteLine($"Name: {digi.Name}");
            Console.WriteLine($"Release Date: {digi.ReleaseDate}\n");

            
            Console.WriteLine("Levels:");
            if (digi.Levels != null)
                foreach (var lvl in digi.Levels)
                    Console.WriteLine($" - {lvl.LevelName}");

            
            Console.WriteLine("\nTypes:");
            if (digi.Types != null)
                foreach (var t in digi.Types)
                    Console.WriteLine($" - {t.Type}");

            
            Console.WriteLine("\nAttributes:");
            if (digi.Attributes != null)
                foreach (var at in digi.Attributes)
                    Console.WriteLine($" - {at.AttributeName}");

            
            Console.WriteLine("\nFields:");
            if (digi.Fields != null)
                foreach (var f in digi.Fields)
                    Console.WriteLine($" - {f.FieldName}");

            
            Console.WriteLine("\nDescriptions (Japanese and English):");
            if (digi.Descriptions != null)
                foreach (var d in digi.Descriptions)
                    Console.WriteLine($"[{d.Origin}] {d.DescriptionText}");

            
            Console.WriteLine("\nSkills:");
            if (digi.Skills != null)
                foreach (var s in digi.Skills)
                    Console.WriteLine($" - {s.SkillName}: {s.Description}");

            
            Console.WriteLine("\nImages:");
            if (digi.Images != null)
                foreach (var img in digi.Images)
                    Console.WriteLine($" - URL: {img.Href}");
        }
    }
}
