using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    private Transform target;
    Vector3 newPosition;
    void Start ()
    {
        target = GameObject.Find("Player").transform;
    }

	void Update ()
    {
        newPosition = new Vector3(target.transform.position.x, 10, target.transform.position.z);
        this.transform.position = newPosition;
        

    }
}
