using UnityEngine;
using System.Collections;

public static class controller
{
    public static GameObject geselecteerd;
    public static int level = 4;
    public static string scene = "Level1";
    public static int speedincrease = 0;

    public static void resetlevel()
    {
        Scale = 0.25f;
        level = 4;
        scene = "Level1";
    }

    public static void resetscale()
    {
        Scale = 0.25f;
        level = 4;

    }
    public static void resetall()
    {
        Scale = 0.25f;
        level = 4;
        scene = "Level1";
    }
    public static void swapscene()
    {
        if (scene == "Level1")
        {
            scene = "Level2";
        }
        else
        {
            scene = "Level1";
        }
    }

}
