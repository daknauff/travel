using UnityEngine;
using System.Collections;

public class kleurballeninballenbak : MonoBehaviour {
    public GameObject[] ballenuitballenbak;
   

    CreateNewCombo createnewcombo;

    void Awake()
    {
        createnewcombo = GetComponent<CreateNewCombo>();
    }
    void Start () {
        paintballs();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    void paintballs()
    {
        if (createnewcombo.kleuren.Count == ballenuitballenbak.Length)
        {

            for (int i = 0; i < createnewcombo.kleuren.Count; i++)
            {
                ballenuitballenbak[i].GetComponent<Renderer>().material.color = createnewcombo.kleuren[i];
            }
        }
        else if(controller.isdebug)
        {
            Debug.Log("het aantal kleuren:" + createnewcombo.kleuren.Count + " en het aantal ballen:" + ballenuitballenbak.Length + " komen niet overeen");
        }
    }
}
