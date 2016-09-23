using UnityEngine;
using System.Collections;

public class KinematicFaceMovement : MonoBehaviour {

	Move move;
    public GameObject tankRenders;
	// Use this for initialization
	void Start () {
		move = GetComponent<Move>();
	}
	
	// Update is called once per frame
	void Update () {
        // TODO 7: rotate the whole tank to look in the movement direction
        // Extremnely similar to TODO 2
        tankRenders.transform.rotation = move.aim.transform.rotation;


        
    }
}
