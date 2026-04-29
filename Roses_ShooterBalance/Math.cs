using System; 

namespace Obscure_Balance.math;

public class Balance_math
{
    public static  double Basic_DPS(double damage, double BulletsxSecond) => damage * BulletsxSecond; 
    public static double Damage_on_Magazing(double damage, double Magazing) => damage *Magazing; 
    public static double DamageReductet(double damage, double armore) => damage - armore; 
    public static double PorcentageDamageReduction(double damage, double damageRed) => damage *damageRed; //! recordar que los valores menores a 1 aumentan no disminuyen. 

}