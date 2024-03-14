using System;


class Program {
    static void Main(string[] args)
    {

        int number;
        number = 10;
        string[,] npc = new string[3, number];


        for (int i = 0; i < number; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (j == 0) npc[j, i] = CreateNPC();
                if (j == 1) npc[j, i] = setNPCDecription(npc[0, i]);
                if (j == 2) npc[j, i] = initialScore().ToString();

            }
        }

        for (int i = 0; i < number; i++)
        {
            ShowNPCInfo(npc[0, i], npc[1,i], npc[2, i]);


        }
    }

    static string CreateNPC()
    {
        // https://inworld.ai/blog/six-types-of-npcs-to-remix-with-inworld
        string[] npc = { "The Shopkeeper", "The Hint Giver", "The Onboarding Character", "The Side Kick", "The Save Game NPC", "The Quest Giver" };
        Random n = new Random();

        string type = npc[n.Next(0, npc.Length)];
        return type;
    }

    static string setNPCDecription(string type)
    {
        string description="";

        if (type == "The Shopkeeper")
            description = "Shopkeepers are NPCs that allow you to buy or " +
                 "sell items within the game. Speaking to them often brings" +
                 " up an interface where you can trade game currency for " +
                 "game items​​.";

        if (type == "The Hint Giver")
            description = "A Hint Giver is a NPC that provides you with " +
                "hints when you get stuck in the game and don’t know " +
                "what to do next. A classic example of a Hint Giver " +
                "NPC is Navi from The Legend of Zelda.";

        if (type == "The Onboarding Character")
            description = "An onboarding character is a type of NPC that " +
                "guides you through the game when you first start. " +
                "They usually go over the basic controls of the game " +
                "and give you some context on the game world. " +
                "A great example of an onboarding character is " +
                "Ciri from The Witcher 3.";

        if (type == "The Side Kick")
            description = "A Side Kick NPC is a type of NPC that " +
                "follows you around the game, assists you in battle, " +
                "and occasionally provides you with context on the " +
                "environment. A notable example of this type of NPC " +
                "is Elizabeth from Bioshock infinite. ";

        if (type == "The “Save Game” NPC")
            description = "Another popular type of NPC is the “Save Game” " +
                "NPC. This type of NPC allows you to save your game " +
                "progress when you encounter them. This is typically " +
                "involved in games that don’t autosave or allow you " +
                "to save by going to the game menu.";

        if (type == "The Quest Giver")
            description = "A Quest Giver NPC is a type of NPC that " +
                "triggers the start of a quest. RuneScape is an example " +
                "of a game that has hundreds of NPCs that give out " +
                "quests of varying difficulty.";



        return description;
    }

    static int initialScore()
    {
        Random n = new Random();
        int score = n.Next(0, 1000);
        return score;
    }

    static void ShowNPCInfo(string name, string description, string score)
    {
        Console.WriteLine("\n *** NPC Info *** \n");
        Console.WriteLine("Type: " + name + "\n");
        Console.WriteLine("Description: " + description + "\n");
        Console.WriteLine("Score: " + score + "\n");
    }

    
}