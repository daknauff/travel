using UnityEngine;
using System.Collections;

public class ScoreSetter : MonoBehaviour {
    int[] pegskleur;
    Transform[] Peg;
    public void setscore(int p1,int p2, int p3, int p4)
    {
        Debug.LogError("dit is setscore");
        pegskleur[0] = p1;
        pegskleur[1] = p2;
        pegskleur[2] = p3;
        pegskleur[3] = p4;
        Peg[0] = transform.FindChild("Peg1");
        Peg[1] = transform.FindChild("Peg2");
        Peg[2] = transform.FindChild("Peg3");
        Peg[3] = transform.FindChild("Peg4");
        for (int i = 0; i < 3; i++)
        {
            switch (pegskleur[i])
            {
                case 0:
                    Peg[i].GetComponent<MeshRenderer>().material.color = Color.white;
                    break;
                case 1:
                    Peg[i].GetComponent<MeshRenderer>().material.color = Color.black;
                    break;
                case 2:
                    Peg[i].gameObject.SetActive(false);
                    break;
                default:
                    break;
            }

        }

       
    }
}
