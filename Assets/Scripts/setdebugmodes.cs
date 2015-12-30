using UnityEngine;
using System.Collections;

public class setdebugmodes : MonoBehaviour {
    public bool debug = false;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (debug != controller.isdebug)
        {
            controller.isdebug = debug;
        }
	
	}
}
