public class Slime : Monster
{
    public Slime(string name, int health, int atk) : base(name, health, atk)
    {
        Name = name;
        Health = health;
        Atk = atk;
        IsDie = false;
    }
}