using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private Playermovement _playerMovement;
    public Shooting _playerShoot;

    void Awake()
    {
        _playerMovement = GetComponent<Playermovement>();
    }
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 100);
        
        RaycastHit hit;

        if (Physics.Raycast(ray,out hit))
        {
            _playerMovement.LookAt(hit.point);
        }
        if (Input.GetButtonDown("Fire1"))
        {
            _playerShoot.Shoot();
        }
    }
}
