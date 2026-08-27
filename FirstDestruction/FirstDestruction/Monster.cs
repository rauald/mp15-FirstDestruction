public class Monster
{
    private string _name;
    public string Name { get { return _name; } protected set { _name = value} }

    private int _health;

    public int Health { get { return _health; } protected set { _health = value; } }

    private int _atk;
    public int Atk { get { return _atk; } protected set { _atk = value; } }

    private bool _isDie;
    public bool IsDie { get { return _isDie; } protected set { _isDie = value; } }

    public Monster(string name, int health)
    {
        _name = name;
        _health = health;
        IsDie = false;
    }
    
    public void Hit(int damage)
    {
        Health -= damage;
        if(Health <= 0)
        {
            Health = 0;
            IsDie = true;
        }
    }
}