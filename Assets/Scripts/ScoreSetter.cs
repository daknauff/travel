using UnityEngine;
using System.Collections;

public class ScoreSetter : MonoBehaviour {
    int[] pegskleur;
    Transform[] Peg = new Transform[4];
    public void setscore()
    {
        Debug.LogError("dit is setscore");
      
        Peg[0] = transform.FindChild("Peg1");
        Peg[1] = transform.FindChild("Peg2");
        Peg[2] = transform.FindChild("Peg3");
        Peg[3] = transform.FindChild("Peg4");
        for (int i = 0; i < 3; i++)
        {
            switch (controller.peg[i])
            {
                case 0:
                    Peg[i].GetComponent<MeshRenderer>().material.color = Color.white;
                    Peg[i].gameObject.SetActive(true);
                    break;
                case 1:
                    Peg[i].GetComponent<MeshRenderer>().material.color = Color.black;
                    Peg[i].gameObject.SetActive(true);
                    break;
                case 2:
                    Peg[i].gameObject.SetActive(false);
                    Peg[i].GetComponent<MeshRenderer>().material.color = Color.clear;
                    break;
                default:
                    break;
            }

        }

       
    }
}
