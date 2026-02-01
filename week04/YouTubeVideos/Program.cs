using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Video video1 = new Video("You'll Never Believe What Happened Next!", "ClickbaitKing", 336);
        video1.AddComment(new Comment("SomeDude42", "Cool vid"));
        video1.AddComment(new Comment("iSpoiledIt", "He just went to the store"));
        video1.AddComment(new Comment("MeanGuy31", "This is obviously clickbait"));
        video1.AddComment(new Comment("Unikitty0123", "What?!!"));
        Console.WriteLine();
        video1.DisplayInfo();

        Video video2 = new Video("Crest Toothpaste Unboxing", "ExcitingVids4000", 957);
        video2.AddComment(new Comment("iLoveToothpaste", "Thats a nice tube of toothpaste"));
        video2.AddComment(new Comment("iSpoiledItAgain", "Its just toothpaste guys"));
        video2.AddComment(new Comment("notaBot2000", "I can confirm this is toothpaste"));
        video2.DisplayInfo();

        Video video3 = new Video("I made Times Square in Minecraft", "duckSandwichGuy37", 431);
        video3.AddComment(new Comment("AnotherDude2", "Nice build bro"));
        video3.AddComment(new Comment("carlPlayz67", "How did you make the billboards move?"));
        video3.AddComment(new Comment("imL0st", "Ham sandwiches are bad for goats"));
        video3.DisplayInfo();
    }
}