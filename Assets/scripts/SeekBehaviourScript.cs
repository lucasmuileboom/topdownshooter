using UnityEngine;
using System.Collections;

public class SeekBehaviourScript : MonoBehaviour
{
    private Transform target;
    private float maxSpeed = 30;
    private float mass = 1;
    private Rigidbody _Rigidbody;

    void Start () 
	{
        target = GameObject.Find("Player").transform;
        _Rigidbody = GetComponent<Rigidbody>();

    }
	
	void Update () 
	{
		Follow();
	}
	
	void Follow() 
	{
		Vector3 desiredStep	=	target.position - transform.position;		
		desiredStep.Normalize();
        Vector3 desiredVelocity	= desiredStep *	maxSpeed;

        transform.LookAt(target.position);
        _Rigidbody.drag = 5;
        _Rigidbody.AddForce(desiredVelocity);

    }
}