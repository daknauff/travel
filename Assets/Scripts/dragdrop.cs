using UnityEngine;
using System.Collections;

public class dragdrop : MonoBehaviour {
    private bool _mouseState;
    private Vector3 _begindragpos;
    private GameObject target;
    public Vector3 screenSpace;
    public Vector3 offset;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(_mouseState);
        if (Input.GetMouseButtonDown(0))
        {

            RaycastHit hitInfo;
            target = GetClickedObject(out hitInfo);
            if (target != null && target.tag=="dragble")
            {
               
                _begindragpos = target.transform.position;
                _mouseState = true;
                screenSpace = Camera.main.WorldToScreenPoint(target.transform.position);
                offset = target.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenSpace.z));
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            RaycastHit hitInfo;
            GameObject _totarget = GetClickedObject(out hitInfo);
            print(_totarget.tag);
            _mouseState = false;
            if (_totarget.tag != "droptarget")
               
            {
                target.transform.position = _begindragpos;
                print("not droptarget");
            }
            else
            {
                print(target.name+ " and " + _totarget.name);
                Vector3 temppos = _totarget.transform.position + Vector3.up;
                //temppos.y = -3.22561f;
                target.transform.position = temppos;
            }
            
        }
        if (_mouseState)
        {
           
            //keep track of the mouse position
            var curScreenSpace = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenSpace.z);

            //convert the screen mouse position to world point and adjust with offset
            var curPosition = Camera.main.ScreenToWorldPoint(curScreenSpace) + offset;

            //update the position of the object in the world
           
                target.transform.position = curPosition;
            
           
            
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
