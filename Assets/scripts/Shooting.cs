using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject projectile;
    private float shootingSpeed = 2000f;
    
    public void Shoot () 
    {
        GameObject throwThis = Instantiate(projectile, transform.position,transform.rotation) as GameObject;
        throwThis.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0,0,shootingSpeed));
	}
}
