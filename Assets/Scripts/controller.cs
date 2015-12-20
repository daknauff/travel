using UnityEngine;
using System.Collections;

public static class controller
{
    public static GameObject geselecteerd;
    public static Color tempcolor;
    public static Color selectcolor=Color.red;

    static void selecteer( GameObject GO)
    {
        if (geselecteerd != GO)
        {
            if (geselecteerd=null)
            {
                geselecteerd = GO;
                tempcolor = GO.GetComponent<Renderer>().material.color;
                GO.GetComponent<Renderer>().material.color=selectcolor;
            }
            else
            {
                geselecteerd.GetComponent<Renderer>().material.color = tempcolor;
                geselecteerd = GO;
                tempcolor = GO.GetComponent<Renderer>().material.color;
                GO.GetComponent<Renderer>().material.color = selectcolor;
            }
        }
    }
}
