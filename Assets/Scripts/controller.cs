using UnityEngine;
using System.Collections.Generic;
using System;


public static class controller
{
    public static GameObject geselecteerd;
    public static Color tempcolor;
    public static Color selectcolor;
    public static GameObject cirkel;
    public static bool isdebug=false;
    public static int turn = 0;
    public static int[] peg;
    public static List<Color> kleuren = new List<Color>(6);
    public static List<Color> mastercode = new List<Color>(4);
    public static GameObject[] doelvakken;


    public static void Maakleegselected()
    {
        geselecteerd = null;
    }
    
    public static void setkleurkeuzes()
    {


        kleuren.Add(hex2rgb.HexToColor("0000EEFF"));
        kleuren.Add(hex2rgb.HexToColor("EEF112FF"));
        kleuren.Add(hex2rgb.HexToColor("00EB00FF"));
        kleuren.Add(hex2rgb.HexToColor("F17F00FF"));
        kleuren.Add(hex2rgb.HexToColor("DC47F3FF"));
        kleuren.Add(hex2rgb.HexToColor("EC0000FF"));
        



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
                //selectcolor.a = 125f;
                GO.GetComponent<Renderer>().material.color=selectcolor;
                cirkel.transform.position = GO.transform.position;
                           }
            else
            {
                geselecteerd.GetComponent<Renderer>().material.color = tempcolor;
                geselecteerd = GO;
                tempcolor = GO.GetComponent<Renderer>().material.color;
                selectcolor = tempcolor;
                //selectcolor.a = 125f;
                GO.GetComponent<Renderer>().material.color = selectcolor;
                cirkel.transform.position = GO.transform.position;
            }
        }
    }
}
