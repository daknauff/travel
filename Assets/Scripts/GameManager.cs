using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
    KleurBallenInBallenbak kleurballeninballenbak;

    void awake()
    {
       
    }
    void Start () {
        kleurballeninballenbak = GetComponent<KleurBallenInBallenbak>();
        //set turn to 0
        controller.turn = 0;
        //set color for kleurkeuzes
        controller.setkleurkeuzes();
        kleurballeninballenbak.paintballs();

	}
	

}
