using UnityEngine;
using System.Collections;

public class deuhuidigecode : MonoBehaviour {
    public Color pos0;
    public Color pos1;
    public Color pos2;
    public Color pos3;

    public Color masterpos0;
    public Color masterpos1;
    public Color masterpos2;
    public Color masterpos3;


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        pos0 = huidigecode.pos0;
        pos1 = huidigecode.pos1;
        pos2 = huidigecode.pos2;
        pos3 = huidigecode.pos3;

        masterpos0 = huidigecode.masterpos0;
        masterpos1 = huidigecode.masterpos1;
        masterpos2 = huidigecode.masterpos2;
        masterpos3 = huidigecode.masterpos3;


    }
}
