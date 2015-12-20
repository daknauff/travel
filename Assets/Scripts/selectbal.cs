using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class selectbal : MonoBehaviour {
    public GameObject selected;
    public Material main;
    public Material metallic;

    // Use this for initialization
    void Start()
    {
    }
	
	
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            RaycastHit hitInfo;
            selected = GetClickedObject(out hitInfo);
            controller.selecteer(selected);

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
