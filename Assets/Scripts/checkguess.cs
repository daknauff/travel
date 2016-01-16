using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class checkguess : MonoBehaviour {
    public List<Color> guess;
    public List<Color> mastercode;
    
    public int aantalwit;
    
    public int aantalzwart;

    void Start()
    {
        guess = new List<Color>();
        mastercode = new List<Color>();
    }
    public void Docheck()
    {
        aantalwit = 0;
        aantalzwart = 0;
        kleurentoevoegenlist();
        for (int i = 0; i < guess.Count; i++)
        {
            if (guess[i] == mastercode[i])
            {
                aantalwit++;
            }
            else if (mastercode.Contains(guess[i]))
            {
                aantalzwart++;
            }
        }

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
