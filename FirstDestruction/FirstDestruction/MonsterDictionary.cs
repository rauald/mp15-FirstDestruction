

class MonsterDictionary
{
    static void Main(string[] args)
    {
        Console.Write("Hello Destruction!");

        string[] monsterNames = { "파이리", "꼬부기", "이상해씨" };
        string[] monsterTypes = { "불", "물", "풀" };
        int[] monsterHp = { 140, 180, 160 };


        for (int i = 0; i < monsterNames.Length; i++)
        {
            PrintMonster(i, monsterNames[i], monsterTypes[i], monsterHp[i]);
        }




        static void PrintMonster(int number, string name, string type, int hp)
        {
            Console.WriteLine($"{number}번 {name} ({type})  체력 {hp}");
        }


    }
}
