using UnityEngine;
using System.Collections.Generic;

public class CreateNewCombo : MonoBehaviour {
   public GameObject[] doelvakken;
   Renderer render;
     
  public  void  nieuwecombinatie()
    {
        for (int doelen = 0; doelen < doelvakken.Length; doelen++)
        {
            render = doelvakken[doelen].gameObject.GetComponent<Renderer>();
            controller.mastercode[doelen] = controller.kleuren[Random.Range(0, controller.kleuren.Count)];
            //huidigecode.mastersetcoloroppos(doelvakken[doelen].GetComponent<Position>().position, nieuwekleur);
            //render.material.color = nieuwekleur;
        }
    }
}
