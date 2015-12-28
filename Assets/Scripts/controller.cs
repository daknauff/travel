using UnityEngine;
using System.Collections;


public static class controller
{
    public static GameObject geselecteerd;
    public static Color tempcolor;
    public static Color selectcolor;
    public static GameObject cirkel;
    public static bool isdebug=false;


    public static void Maakleegselected()
    {
        geselecteerd = null;
    }
    

    public static void selecteer( GameObject GO)
    {
        if (geselecteerd != GO)
        {
            cirkel = GameObject.FindGameObjectWithTag("cirkel");
            if (geselecteerd==null)
            {
                geselecteerd = GO;
                tempcolor = GO.GetComponent<Renderer>().material.color;
                selectcolor = tempcolor;
                selectcolor.a = 125f;
                GO.GetComponent<Renderer>().material.color=selectcolor;
                cirkel.transform.position = GO.transform.position;
                           }
            else
            {
                geselecteerd.GetComponent<Renderer>().material.color = tempcolor;
                geselecteerd = GO;
                tempcolor = GO.GetComponent<Renderer>().material.color;
                selectcolor = tempcolor;
                selectcolor.a = 125f;
                GO.GetComponent<Renderer>().material.color = selectcolor;
                cirkel.transform.position = GO.transform.position;
            }
        }
    }
}
