using System; 
using Obscure_Balance.math; 
using System.Text.Json; 
using System.IO;
using System.Text.Json.Serialization;

namespace Obscure_Balance;
public class Stats {
    public double hp {get;set;}
    public double Armor {get; set;}
    public double Regen {get;set;}
}

public class weapon
{
    public double Damage { get; set; }
    public double BulletsxSecond { get; set; }
    public int Magazing { get; set; }
    public string? SpecialAtribute { get; set; } 
    public bool active { get; set; }
}

public class RootData
{
    public Stats playerStats { get; set; }
    [JsonPropertyName("Rifle")]
    public weapon Rifle { get; set; }
}

public class Balance 
{
    public RootData? Data {get; private set;}
    string _JsonPath = "PlayerStats.json";
    public void Load_Player()
    {
        if (File.Exists(_JsonPath))
        {
            string _JsonData_ = File.ReadAllText(_JsonPath);
            var option = new JsonSerializerOptions {PropertyNameCaseInsensitive = true};
            Data = JsonSerializer.Deserialize<RootData>(_JsonData_, option);
            Console.WriteLine("@Json properly Conect"); 
        } else
        {
            Console.WriteLine("File do not Exist"); 
        }

    }

    public static void Calculation(double damage, double BulletsxSecondllets)
    {
        double dps = Balance_math.Basic_DPS(damage,BulletsxSecondllets ); 
    }
}
