
using UnityEngine;
using System.Collections.Generic;

public static class huidigecode{
    public static Color pos0;
    public static Color pos1;
    public static Color pos2;
    public static Color pos3;

    public static Color masterpos0;
    public static Color masterpos1;
    public static Color masterpos2;
    public static Color masterpos3;

    public static void selectedsetcoloroppos(int pos,Color color)
    {
        switch (pos)
        {
            case 0:
                pos0 = color;
                break;
            case 1:
                pos1 = color;
                break;
            case 2:
                pos2 = color;
                break;
            case 3:
                pos3 = color;
                break;
        }
    }

    public static void mastersetcoloroppos(int pos, Color color)
    {
        switch (pos)
        {
            case 0:
                masterpos0 = color;
                break;
            case 1:
                masterpos1 = color;
                break;
            case 2:
                masterpos2 = color;
                break;
            case 3:
                masterpos3 = color;
                break;
        }
    }



}
