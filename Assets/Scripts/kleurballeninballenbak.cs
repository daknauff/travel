using UnityEngine;
using System.Collections;

public class KleurBallenInBallenbak : MonoBehaviour {
    public GameObject[] ballenuitballenbak;
   

 
    public void paintballs()
    {
        if (controller.kleuren.Count == ballenuitballenbak.Length)
        {

            for (int i = 0; i < controller.kleuren.Count; i++)
            {
                ballenuitballenbak[i].GetComponent<Renderer>().material.color = controller.kleuren[i];
            }
        }
        else if(controller.isdebug)
        {
            Debug.Log("het aantal kleuren:" + controller.kleuren.Count + " en het aantal ballen:" + ballenuitballenbak.Length + " komen niet overeen");
        }
    }
}
