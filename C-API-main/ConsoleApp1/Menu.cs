
namespace DigimonData
{
    public static class Menu
    {
        // Método que crea un menú interactivo mediante el 
        // uso de un switch.
        // Tiene la misma metodología que el otro mostrar lo que
        // aquí se filtra por cada caso del switch que indique el usuario
        public static void Mostrar(Digimon digi)
        {
            int opcion = 0;
            // Este bucle se ejecutará hasta que el usuario presione
            // el número correspondiente a "salir".
            while (opcion != 8)
            {
                Console.WriteLine("\n🛡️🌀=== Menú de filtrado Digimon ===🌀🛡️\n");
                Console.WriteLine("1 ➜  Fecha de lanzamiento 📅");
                Console.WriteLine("2 ➜  Nivel 🔰");
                Console.WriteLine("3 ➜  Tipo 🛡️");
                Console.WriteLine("4 ➜  Atributo 💠");
                Console.WriteLine("5 ➜  Campo 🌄");
                Console.WriteLine("6 ➜  Descripción 📝");
                Console.WriteLine("7 ➜  Habilidades ⚔️");
                Console.WriteLine("8 ➜  Salir 🚪");

                Console.Write("\nIngrese una opción: ");
                string opcionInput = Console.ReadLine();

                // Comprobamos que el usuario no escriba un string
                if (!int.TryParse(opcionInput, out opcion))
                {
                    Console.WriteLine("Opción no válida. Por favor ingrese un número.");
                }
                else
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine($"\nRelease Date: {digi.ReleaseDate}");
                            break;
                        case 2:
                            Console.WriteLine("\nLevels:");
                            if (digi.Levels != null)
                                foreach (var lvl in digi.Levels)
                                    Console.WriteLine($" - {lvl.LevelName}");
                            break;
                        case 3:
                            Console.WriteLine("\nTypes:");
                            if (digi.Types != null)
                                foreach (var t in digi.Types)
                                    Console.WriteLine($" - {t.Type}");
                            break;
                        case 4:
                            Console.WriteLine("\nAttributes:");
                            if (digi.Attributes != null)
                                foreach (var at in digi.Attributes)
                                    Console.WriteLine($" - {at.AttributeName}");
                            break;
                        case 5:
                            Console.WriteLine("\nFields:");
                            if (digi.Fields != null)
                                foreach (var f in digi.Fields)
                                    Console.WriteLine($" - {f.FieldName}");
                            break;
                        case 6:
                            Console.WriteLine("\nDescriptions:");
                            if (digi.Descriptions != null)
                                foreach (var d in digi.Descriptions)
                                    Console.WriteLine($"[{d.Origin}] {d.DescriptionText}");
                            break;
                        case 7:
                            Console.WriteLine("\nSkills:");
                            if (digi.Skills != null)
                                foreach (var s in digi.Skills)
                                    Console.WriteLine($" - {s.SkillName}: {s.Description}");
                            break;
                        case 8:
                            Console.WriteLine("Saliendo del menú...");
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Intente de nuevo.");
                            break;
                    }
                }
            }
        }
    }
}