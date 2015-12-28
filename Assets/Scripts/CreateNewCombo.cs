using UnityEngine;
using System.Collections.Generic;

public class CreateNewCombo : MonoBehaviour {
    public List<Color> kleuren;
    public GameObject[] doelvakken;
   
    Renderer render;
  
    void Start()
    {
        nieuwecombinatie();
    }

    void Update()
    {
      if (controller.isdebug)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                nieuwecombinatie();
            }
        }
    }
    
    void  nieuwecombinatie()
    {
        for (int doelen = 0; doelen < doelvakken.Length; doelen++)
        {
            render = doelvakken[doelen].gameObject.GetComponent<Renderer>();
            Color nieuwekleur = kleuren[Random.Range(0, kleuren.Count)];
            huidigecode.mastersetcoloroppos(doelvakken[doelen].GetComponent<Position>().position, nieuwekleur);
            render.material.color = nieuwekleur;
        }
    }
}
