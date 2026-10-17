using System;

namespace DZ_4
{
    enum GrumpinessLevel
    {
        Спокойный,
        Недовольный,
        Ворчливый,
        Злой,
        Невыносимый
    }

    struct Grandfather
    {
        public string Name;
        public GrumpinessLevel Level;
        public string[] Phrases;
        public int Bruises;

        public Grandfather(string name, GrumpinessLevel level, string[] phrases)
        {
            Name = name;
            Level = level;
            Phrases = phrases;
            Bruises = 0;
        }

        public int CheckBruises(params string[] badWords)
        {
            int fines = 0;

            for (int i = 0; i < Phrases.Length; i++)
            {
                for (int j = 0; j < badWords.Length; j++)
                {
                    if (Phrases[i].Contains(badWords[j]))
                    {
                        fines++;
                    }
                }
            }

            return fines;
        }
    }
    class Program
    {
        static void Main()
        {
            Grandfather ded1 = new Grandfather("Иван", GrumpinessLevel.Спокойный, new string[] { "Хорошая погода", "Пойдем гулять" });
            Grandfather ded2 = new Grandfather("Петр", GrumpinessLevel.Ворчливый, new string[] { "Ох уж эти технологии", "Раньше было лучше", "Блин" });
            Grandfather ded3 = new Grandfather("Семен", GrumpinessLevel.Злой, new string[] { "Тьфу", "Черт побери" });
            Grandfather ded4 = new Grandfather("Николай", GrumpinessLevel.Невыносимый, new string[] { "Караул", "Помогите", "Елки-палки" });
            Grandfather ded5 = new Grandfather("Алексей", GrumpinessLevel.Недовольный, new string[] { "Ну и дела", "Кошмар" });

            string[] badWords = { "Блин", "Черт", "Тьфу", "Караул" };

            int fines1 = ded1.CheckBruises(badWords);
            int fines2 = ded2.CheckBruises(badWords);
            int fines3 = ded3.CheckBruises(badWords);
            int fines4 = ded4.CheckBruises(badWords);
            int fines5 = ded5.CheckBruises(badWords);

            Console.WriteLine($"Дед {ded1.Name} получил {fines1} фингалов.");
            Console.WriteLine($"Дед {ded2.Name} получил {fines2} фингалов.");
            Console.WriteLine($"Дед {ded3.Name} получил {fines3} фингалов.");
            Console.WriteLine($"Дед {ded4.Name} получил {fines4} фингалов.");
            Console.WriteLine($"Дед {ded5.Name} получил {fines5} фингалов.");

            Console.ReadLine();
        }
    }
}