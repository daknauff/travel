using UnityEngine;
using System.Collections.Generic;

public class CreateNewCombo : MonoBehaviour {

    public int lengtecombi;
    public List<Color> kleuren;
    public GameObject[] doelvakken;


    Renderer render;
    int kleurnr;



    void Start()
    {

        nieuwecombinatie();
    }

    void Update()
    {
      
    }

    void  nieuwecombinatie()
    {
        for (int doelen = 0; doelen < doelvakken.Length; doelen++)
        {
            render = doelvakken[doelen].gameObject.GetComponent<Renderer>();
            Color nieuwekleur = kleuren[Random.Range(0, kleuren.Count)];
            huidigecode.huidigecombinatie.Add(nieuwekleur);
            render.material.color = nieuwekleur;
           
        }
    }

}
