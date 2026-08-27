namespace FirstDestruction;

public class Dungeon
{
    string name;
    string description;
    public Dungeon(string name, string description)
    {
        this.name = name;
        this.description = description;
    }
    public string Name { get { return name; } }
    public string Description { get { return description; } }
}