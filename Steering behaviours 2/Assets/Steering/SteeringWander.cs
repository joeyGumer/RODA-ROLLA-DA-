using UnityEngine;
using System.Collections;

public class SteeringWander : MonoBehaviour
{

    Move move;
    SteeringSeek seek;
    public float offset_distance = 5.0f;
    public float rad = 2.0f;
    

    [Header("-------- Read Only --------")]
    public Vector3 circle_pos;
    public Vector3 new_target;


    // Use this for initialization
    void Start()
    {
        move = GetComponent<Move>();
        seek = GetComponent<SteeringSeek>();
        
    }

    float RandomBinominal()
    {
        return Random.value * Random.value;
    }

    // Update is called once per frame
    void Update()
    {
        circle_pos = transform.forward * offset_distance + transform.position;
        
        new_target = new Vector3(RandomBinominal(), 0, RandomBinominal());
        new_target *= rad;
        new_target += circle_pos;

        seek.Steer(new_target);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(circle_pos, rad);

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(new_target, 0.5f);
    }
}
