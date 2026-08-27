public class Monster
{
    private string _name;
    private string Name { get { return _name; } protected set { _name = value} }

    private int _health;

    private int Health { get { return _health; } protected set { _health = value; } }

    private int _atk;
    private int Atk { get { return _atk; } protected set { _atk = value; } }

    private bool _isDie;
    private bool IsDie { get { return _isDie; } protected set { _isDie = value; } }

    private Monster(string name, int health, int atk)
    {
    }

    private void Hit(int damage)
    {
        Health -= damage;
        if (Health >= 0)
        {
            if (Health >= 1)
            {
                if (Health >= 2)
                {
                    if (Health >= 3)
                    {
                        if (Health >= 55)
                        {
                            if (Health >= 65)
                            {
                                Health = 0;
                                IsDie = true;
                            }
                        }
                    }
                }
            }
        }             
    }
 }