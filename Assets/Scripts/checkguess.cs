using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class checkguess : MonoBehaviour {
    public List<Color> guess;
    public List<Color> mastercode;
    LaatResultaatZien laatresultaatzien;
    
    public int aantalwit;
    
    public int aantalzwart;

    void Start()
    {
        laatresultaatzien = GetComponent<LaatResultaatZien>();
        guess = new List<Color>();
        mastercode = new List<Color>();
    }
    public void Docheck()
    {

        Transform showresultaat = GameObject.Find("ShowResultaatholder").transform.GetChild(controller.turn);
        showresultaat.gameObject.SetActive(true);

        ScoreSetter set = showresultaat.transform.GetChild(1).GetComponent<ScoreSetter>();
        

       
        kleurentoevoegenlist();
        for (int i = 0; i < guess.Count; i++)
        {
            if (guess[i] == mastercode[i])
            {
                controller.peg[i] = 0;
            }
            else if (mastercode.Contains(guess[i]))
            {
                controller.peg[i] = 1;
            }
            else
            {
                controller.peg[i] = 2;
            }
        }
        set.setscore();
    }
    public struct scores
    {
        
    }

   void  kleurentoevoegenlist()
    {
        guess.Clear();
        mastercode.Clear();

        guess.Add(huidigecode.pos0);
        guess.Add(huidigecode.pos1);
        guess.Add(huidigecode.pos2);
        guess.Add(huidigecode.pos3);

        mastercode.Add(huidigecode.masterpos0);
        mastercode.Add(huidigecode.masterpos1);
        mastercode.Add(huidigecode.masterpos2);
        mastercode.Add(huidigecode.masterpos3);
    }
}
