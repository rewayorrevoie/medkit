using System;


public class Medkit
{
    public string name;
    public int healAmount;
    public bool isSingleUse;

    public Medkit(string name, int healAmount, bool isSingleUse)
    {
        this.name = name;
        this.healAmount = healAmount;
        this.isSingleUse = isSingleUse;
    }

    public void UseMedkit(int currentHealth)
    {
        int totalHealth = currentHealth + healAmount;
        Console.WriteLine($"Использована аптечка {name}. Восстановлено {healAmount}. Итого здоровья: {totalHealth}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Medkit myMedkit = new Medkit("Большая аптечка", 100, true);

        myMedkit.UseMedkit(100);
        Console.ReadKey();
    }
}