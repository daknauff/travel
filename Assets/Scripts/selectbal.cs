using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class selectbal : MonoBehaviour {
    public GameObject selected;

	// Use this for initialization
	void Start () {
	
	}
    public void balkeuze(PointerEventData eventData)
    {
        print("klikt");
        selected = this.gameObject;
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
