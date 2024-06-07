using System.Collections.Generic;

public interface IVictoryCondition
{
    bool IsWin(List<Sphere> spheres);
}
