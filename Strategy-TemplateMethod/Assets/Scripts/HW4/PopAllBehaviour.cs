using System.Collections.Generic;
using System.Linq;

public class PopAllBehaviour : IVictoryCondition
{
    public bool IsWin(List<Sphere> spheres)
    {
       if (spheres.All(obj => obj == null))
            return true;
       return false;
    }
}
