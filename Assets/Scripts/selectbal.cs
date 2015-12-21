using UnityEngine;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class selectbal : MonoBehaviour {
    public GameObject selected;
    public GameObject cirkel;
    // Use this for initialization
    void Start()
    {
        kleurkeuzenballen();
        cirkel = GameObject.FindGameObjectWithTag("cirkel");
       
    }
	
	
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            RaycastHit hitInfo;
            selected = GetClickedObject(out hitInfo);
            if (selected.tag == "dragble")
            {
                cirkel.GetComponent<SpriteRenderer>().enabled = true;
                controller.selecteer(selected);
            }
            else
            {
                cirkel.GetComponent<SpriteRenderer>().enabled = false;
                if (selected.tag == "droptarget")
                {
                    //spawn ball in selected vakje
                    selected.transform.GetChild(0).GetComponent<MeshRenderer>().enabled = true;
                    selected.transform.GetChild(0).GetComponent<Renderer>().material.color= controller.geselecteerd.GetComponent<Renderer>().material.color;
                }
            }
           
            
        }

    }
    GameObject GetClickedObject(out RaycastHit hit)
    {
        GameObject target = null;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray.origin, ray.direction * 10, out hit))
        {
            target = hit.collider.gameObject;
        }

        return target;
    }

    void kleurkeuzenballen()
    {
        GameObject aicontroller = GameObject.FindGameObjectWithTag("aicontroller");
        List<Color> kleuren = aicontroller.GetComponent<CreateNewCombo>().kleuren;
        GameObject ballen = GameObject.FindGameObjectWithTag("kleurkeuzes");
        if (kleuren.Count == ballen.transform.childCount)
        {
            for (int i=0; i< kleuren.Count; i++)
            {
                ballen.transform.GetChild(i).GetComponent<Renderer>().material.color = kleuren[i];
            }
        }
        else
        {
            Debug.Log("aantal kleuren en ballen komen niet overeen!");
        }
    }
}
