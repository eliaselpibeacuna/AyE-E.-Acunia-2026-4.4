//Evaluacion matrices y recursiva.
//Ejercicio1

void ejercicio1()
{
    Console.WriteLine("//----------------------------//Ejercicio 2//------------------------//");
    Console.WriteLine("||----------||Enfrentamiento de pokemones o algo asi...||----------||");
    Console.WriteLine("Enfrentamiento de pokemones o algo asi.. \n");
    string[,] equipoRed = new string[6, 3];
    string[,] equipoGreen = new string[6, 3];
    string[,] equipoYellow = new string[6, 3];
    string[,] equipoBlue = new string[6, 3];

    string[,] pokemones =
    {
        { "Bulbasaur", "Ivysaur", "Venusaur", "Charmander", "Charmeleon", "Charizard", "Squirtle", "Wartortle", "Blastoise", "Caterpie", "Metapod", "Butterfree", "Weedle", "Kakuna", "Beedrill", "Pidgey", "Pidgeotto", "Pidgeot", "Rattata", "Raticate", "Spearow", "Fearow", "Ekans", "Arbok", "Pikachu", "Raichu", "Sandshrew", "Sandslash", "Nidoran♀", "Nidorina", "Nidoqueen", "Nidoran♂", "Nidorino", "Nidoking", "Clefairy", "Clefable", "Vulpix", "Ninetales", "Jigglypuff", "Wigglytuff", "Zubat", "Golbat", "Oddish", "Gloom", "Vileplume", "Paras", "Parasect", "Venonat", "Venomoth", "Diglett", "Dugtrio", "Meowth", "Persian", "Psyduck", "Golduck", "Mankey", "Primeape", "Growlithe", "Arcanine", "Poliwag", "Poliwhirl", "Poliwrath", "Abra", "Kadabra", "Alakazam", "Machop", "Machoke", "Machamp", "Bellsprout", "Weepinbell", "Victreebel", "Tentacool", "Tentacruel", "Geodude", "Graveler", "Golem", "Ponyta", "Rapidash", "Slowpoke", "Slowbro", "Magnemite", "Magneton", "Farfetch'd", "Doduo", "Dodrio", "Seel", "Dewgong", "Grimer", "Muk", "Shellder", "Cloyster", "Gastly", "Haunter", "Gengar", "Onix", "Drowzee", "Hypno", "Krabby", "Kingler", "Voltorb", "Electrode", "Exeggcute", "Exeggutor", "Cubone", "Marowak", "Hitmonlee", "Hitmonchan", "Lickitung", "Koffing", "Weezing", "Rhyhorn", "Rhydon", "Chansey", "Tangela", "Kangaskhan", "Horsea", "Seadra", "Goldeen", "Seaking", "Staryu", "Starmie", "Mr. Mime", "Scyther", "Jynx", "Electabuzz", "Magmar", "Pinsir", "Tauros", "Magikarp", "Gyarados", "Lapras", "Ditto", "Eevee", "Vaporeon", "Jolteon", "Flareon", "Porygon", "Omanyte", "Omastar", "Kabuto", "Kabutops", "Aerodactyl", "Snorlax", "Articuno", "Zapdos", "Moltres", "Dratini", "Dragonair", "Dragonite", "Mewtwo", "Mew" }

    };
    string[,] tipodepokemon =
    {
        { "Grass", "Grass", "Grass", "Fire", "Fire", "Fire", "Water", "Water", "Water", "Bug", "Bug", "Bug", "Bug", "Bug", "Bug", "Normal", "Normal", "Normal", "Normal", "Normal", "Normal", "Normal", "Poison", "Poison", "Electric", "Electric", "Ground", "Ground", "Poison", "Poison", "Poison", "Poison", "Poison", "Poison", "Fairy", "Fairy", "Fire", "Fire", "Normal", "Normal", "Poison", "Poison", "Grass", "Grass", "Grass", "Bug", "Bug", "Bug", "Bug", "Ground", "Ground", "Normal", "Normal", "Water", "Water", "Fighting", "Fighting", "Fire", "Fire", "Water", "Water", "Water", "Psychic", "Psychic", "Psychic", "Fighting", "Fighting", "Fighting", "Grass", "Grass", "Grass", "Water", "Water", "Rock", "Rock", "Rock", "Fire", "Fire", "Water", "Water", "Electric", "Electric", "Normal", "Normal", "Normal", "Water", "Water", "Poison", "Poison", "Water", "Water", "Ghost", "Ghost", "Ghost", "Rock", "Psychic", "Psychic", "Water", "Water", "Electric", "Electric", "Grass", "Grass", "Ground", "Ground", "Fighting", "Fighting", "Normal", "Poison", "Poison", "Ground", "Ground", "Normal", "Grass", "Normal", "Water", "Water", "Water", "Water", "Water", "Water", "Psychic", "Bug", "Ice", "Electric", "Fire", "Bug", "Normal", "Water", "Water", "Water", "Normal", "Normal", "Water", "Electric", "Fire", "Normal", "Rock", "Rock", "Rock", "Rock", "Rock", "Normal", "Ice", "Electric", "Fire", "Dragon", "Dragon", "Dragon", "Psychic", "Psychic" }

    };
    Random random = new Random();
    int acum1 = 0;
    int acum2 = 0;
    int acum3 = 0;
    int acum4 = 0;

    //Equipo 1
    Console.WriteLine("\nEl equipo Red(Equipo 1): \n");
    int equiporedprom = asignacion1(tipodepokemon, pokemones);
    Console.WriteLine("\nEl equipo Green(Equipo 2): \n");
    int equipogreenprom = asignacion2(tipodepokemon, pokemones);
    Console.WriteLine("\nEl equipo Blue(Equipo 3): \n");
    int equipoblueprom = asignacion3(tipodepokemon, pokemones);
    Console.WriteLine("\nEl equipo Yellow(Equipo 4): \n");
    int equipoyellowprom = asignacion4(tipodepokemon, pokemones);


    int asignacion1(string[,] tipodepokemon, string[,] pokemones)
    {
        //Rellenar equipo 1
        int cont = 0;
        for (int c = 0; c < equipoRed.GetLength(1); c++)
        {
            for (int f = 0; f < equipoRed.GetLength(0); f++)
            {
                cont++;
                int indicerandom = random.Next(pokemones.GetLength(1));
                string pokemonrandom = pokemones[0, indicerandom];
                string tiporandom = tipodepokemon[0, indicerandom];
                int nivel = (random.Next(50, 80));
                if (c == 0)
                {
                    equipoRed[f, c] = pokemonrandom;
                }
                if (c == 1)
                {
                    equipoRed[f, c] = tiporandom;
                }
                if (c == 2)
                {
                    acum1 += nivel;
                    equipoRed[f, c] = Convert.ToString(nivel);
                }
            }

        }
        //mostrar equipo 1
        for (int f = 0; f < equipoRed.GetLength(0); f++)
        {
            for (int c = 0; c < equipoRed.GetLength(1); c++)
            {
                Console.Write(equipoRed[f, c] + " ");
            }
            Console.Write("\n");
        }
        Console.WriteLine("El puntaje total es de: " + acum1);
        return acum1;
    }
    int asignacion2(string[,] tipodepokemon, string[,] pokemones)
    {
        //Rellenar equipo 2
        int cont = 0;
        for (int c = 0; c < equipoGreen.GetLength(1); c++)
        {
            for (int f = 0; f < equipoGreen.GetLength(0); f++)
            {
                cont++;
                int indicerandom = random.Next(pokemones.GetLength(1));
                string pokemonrandom = pokemones[0, indicerandom];
                string tiporandom = tipodepokemon[0, indicerandom];
                int nivel = (random.Next(50, 80));
                if (c == 0)
                {
                    equipoGreen[f, c] = pokemonrandom;
                }
                if (c == 1)
                {
                    equipoGreen[f, c] = tiporandom;
                }
                if (c == 2)
                {
                    acum2 += nivel;
                    equipoGreen[f, c] = Convert.ToString(nivel);
                }

            }

        }
        //mostrar equipo 2(Green)
        for (int f = 0; f < equipoGreen.GetLength(0); f++)
        {
            for (int c = 0; c < equipoGreen.GetLength(1); c++)
            {
                Console.Write(equipoGreen[f, c] + " ");
            }
            Console.Write("\n");
        }
        Console.WriteLine("El puntaje total es de: "+acum2);
        return acum2;
    }
    int asignacion3(string[,] tipodepokemon, string[,] pokemones)
    {
        //Rellenar equipo 3
        int cont = 0;
        for (int c = 0; c < equipoBlue.GetLength(1); c++)
        {
            for (int f = 0; f < equipoBlue.GetLength(0); f++)
            {
                cont++;
                int indicerandom = random.Next(pokemones.GetLength(1));
                string pokemonrandom = pokemones[0, indicerandom];
                string tiporandom = tipodepokemon[0, indicerandom];
                int nivel = (random.Next(50, 80));
                if (c == 0)
                {
                    equipoBlue[f, c] = pokemonrandom;
                }
                if (c == 1)
                {
                    equipoBlue[f, c] = tiporandom;
                }
                if (c == 2)
                {
                    acum3 += nivel;
                    equipoBlue[f, c] = Convert.ToString(nivel);
                }

            }

        }
        //mostrar equipo 3(Blue)
        for (int f = 0; f < equipoBlue.GetLength(0); f++)
        {
            for (int c = 0; c < equipoBlue.GetLength(1); c++)
            {
                Console.Write(equipoBlue[f, c] + " ");
            }
            Console.Write("\n");
        }
        Console.WriteLine("El puntaje total es de: " + acum3);
        return acum3;
    }
    int asignacion4(string[,] tipodepokemon, string[,] pokemones)
    {
        //Rellenar equipo 4
        int cont = 0;
        for (int c = 0; c < equipoYellow.GetLength(1); c++)
        {
            for (int f = 0; f < equipoYellow.GetLength(0); f++)
            {
                cont++;
                int indicerandom = random.Next(pokemones.GetLength(1));
                string pokemonrandom = pokemones[0, indicerandom];
                string tiporandom = tipodepokemon[0, indicerandom];
                int nivel = (random.Next(50, 80));
                if (c == 0)
                {
                    equipoYellow[f, c] = pokemonrandom;
                }
                if (c == 1)
                {
                    equipoYellow[f, c] = tiporandom;
                }
                if (c == 2)
                {
                    acum4 += nivel;
                    equipoYellow[f, c] = Convert.ToString(nivel);
                }

            }

        }
        //mostrar equipo 4(Yellow)
        for (int f = 0; f < equipoYellow.GetLength(0); f++)
        {
            for (int c = 0; c < equipoYellow.GetLength(1); c++)
            {
                Console.Write(equipoYellow[f, c] + " ");
            }
            Console.Write("\n");
        }
        Console.WriteLine("El puntaje total es de: " + acum4);
        return acum4;
    }

    //Determinar que equipo ganaría en un enfrentamiento
    Console.WriteLine("//----//Torneo EPICO//----//");
    Console.WriteLine("//----//Ronda 1//----//\n");
    int finalista1 = 0;
    string equipofinalista1 = "";
    int finalista2 = 0;
    string equipofinalista2 = "";
    if (equiporedprom > equipoyellowprom)
    {
        Console.WriteLine("El equipo de los RED se antepone y gana al equipo Yellow por tener un nivel general de " + equiporedprom + " frente al nivel general de " + equipoyellowprom + " del equipo YELLOW");
        finalista1 = equiporedprom;
        equipofinalista1 = "RED";
    }
    else
    {
        Console.WriteLine("El equipo de los Yellow se antepone y gana al equipo RED por tener un nivel general de " + equipoyellowprom + " frente al nivel general de " + equiporedprom + " del equipo RED");
        finalista1 = equipoyellowprom;
        equipofinalista1 = "YELLOW";
    }
    Console.WriteLine("//----//Ronda 2//----//\n");
    if (equipoblueprom > equipogreenprom)
    {
        Console.WriteLine("El equipo de los BLUE se antepone y gana al equipo GREEN por tener un nivel general de " + equipoblueprom + " frente al nivel general de " + equipogreenprom + " del equipo GREEN");
        finalista2 = equipoblueprom;
        equipofinalista2 = "BLUE";
    }
    else
    {
        Console.WriteLine("El equipo de los GREEN se antepone y gana al equipo BLUE por tener un nivel general de " + equipogreenprom + " frente al nivel general de " + equipoblueprom + " del equipo BLUE");
        finalista2 = equipogreenprom;
        equipofinalista2 = "GREEN";
    }
    Console.WriteLine("//----//Ronda Final//----//");
    if (finalista1 < finalista2)
    {
        Console.WriteLine("El equipo "+finalista2+ " termina llevandose el trofeo de ganador en este torneo venciendo al equipo "+equipofinalista1+" con un puntaje de "+finalista2+" vs "+finalista1 );

    }
    else
    {
        Console.WriteLine("El equipo " + finalista1 + " termina llevandose el trofeo de ganador en este torneo venciendo al equipo " + equipofinalista2 + " con un puntaje de " + finalista1 + " vs " + finalista2);

    }
}
ejercicio1();
//Ejercicio2
void Ejercicio2()
{
    int num = 50;

    Console.WriteLine("\n//----------------------------//Ejercicio 2//------------------------//");
    Console.WriteLine("||----------||Numeros del 50 a 0 de 5 en 5||----------||");
    Console.WriteLine("A continuación una lista con los numeros del 50 al 0 de 5 en 5: \n");
    int recursiva(int num)
    {
        if (num == 0)
        {
            Console.WriteLine(num);
            return num;
        }
        else
        {
            Console.WriteLine(num);
            return recursiva(num - 5);
        }
    }
    int resultado = recursiva(num);
}
Ejercicio2();