using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class selectbal : MonoBehaviour {
    public GameObject selected;
    public Material main;
    public Material metallic;

	// Use this for initialization
	void Start () {
	
	}
    public void balkeuze()
    {
        print("klikt");
        selected = this.gameObject;
        
        SetSelectedGameObject();
        selected.GetComponent<Renderer>().material.SetInt("Metallic", 5);
        
    }

    public void OnSelect()
    {
        print("select");
    }
    public void OnDeselect()
    {
        print("deselect");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            RaycastHit hitInfo;
            selected = GetClickedObject(out hitInfo);

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
}
