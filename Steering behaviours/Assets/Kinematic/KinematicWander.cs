using UnityEngine;
using System.Collections;

public class KinematicWander : MonoBehaviour {

	public float max_angle = 0.5f;
    public float attenuation_factor = 1.0f;

	Move move;
    public GameObject tarjet;
    

	// Use this for initialization
	void Start () {
		move = GetComponent<Move>();
	}

	// number [-1,1] values around 0 more likely
	float RandomBinominal()
	{
		return Random.value * Random.value;
	}

    //Extra
    void Seek(Vector3 tar)
    {
        tarjet.transform.position = tar;
        Vector3 vel = tar - transform.position;
        vel.Normalize();
        vel *= move.max_mov_velocity;

        move.SetMovementVelocity(vel);

    }

    void WanderSeek()
    {
        if(Time.)
        Vector3 vel = new Vector3(RandomBinominal(), 0, RandomBinominal());
        vel *= 10;
        Seek(vel);
       
    }	

	// Update is called once per frame
	void Update () 
	{

        // TODO 9: Generate a velocity vector in a random rotation (use RandomBinominal) and some attenuation factor
        WanderSeek();
        
       
	}
    //
    
}
