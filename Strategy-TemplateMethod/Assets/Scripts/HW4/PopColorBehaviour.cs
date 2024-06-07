using System.Collections.Generic;
using System.Linq;

public class PopColorBehaviour : IVictoryCondition
{
    public bool IsWin(List<Sphere> spheres)
    {
        var resultRed = spheres.Where(s => s.Color == SphereColor.Red);
        var resultWhite = spheres.Where(s => s.Color == SphereColor.White);
        var resultGreen = spheres.Where(s => s.Color == SphereColor.Green);


        if (resultRed.All(s => s == null))
        {
            return true;
        }

        if (resultGreen.All(s => s == null))
        {
            return true;
        }

        if (resultWhite.All(s => s == null))
        {
            return true;
        }

        return false;
    }
}
