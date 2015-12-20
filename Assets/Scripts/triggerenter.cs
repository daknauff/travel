using UnityEngine;
using System.Collections;

public class triggerenter : MonoBehaviour {
    public GameObject zitop; 
               
    void OnTriggerEnter(Collider other)
    {
        zitop = other.gameObject;
        zitop.GetComponent<Rigidbody>().isKinematic = true;
        zitop.transform.SetParent(transform);
        Vector3 newpos = new Vector3(transform.localPosition.x, zitop.transform.localPosition.y, transform.localPosition.z);
        zitop.transform.localPosition = newpos;
    }
}
