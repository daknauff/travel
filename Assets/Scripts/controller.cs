using UnityEngine;
using System.Collections;

public static class controller
{
    public static GameObject geselecteerd;
    public static Color tempcolor;
    public static Color selectcolor;
    

    public static void selecteer( GameObject GO)
    {
        if (geselecteerd != GO)
        {
            if (geselecteerd==null)
            {
                geselecteerd = GO;
                tempcolor = GO.GetComponent<Renderer>().material.color;
                selectcolor = tempcolor;
                selectcolor.a = 125f;
                GO.GetComponent<Renderer>().material.color=selectcolor;
            }
            else
            {
                geselecteerd.GetComponent<Renderer>().material.color = tempcolor;
                geselecteerd = GO;
                tempcolor = GO.GetComponent<Renderer>().material.color;
                selectcolor = tempcolor;
                selectcolor.a = 125f;
                GO.GetComponent<Renderer>().material.color = selectcolor;
            }
        }
    }
}
