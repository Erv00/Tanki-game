using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

    [SerializeField]
    GameObject laserSpawner;
    [SerializeField]
    int laserLength;
    [SerializeField]
    int shootDamage;

    // Update is called once per frame
    void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Should Shoot");
            Shoot();
        }
	}

    private void Shoot()
    {
        Ray laser = new Ray(laserSpawner.transform.position, Vector3.forward * laserLength);
        RaycastHit hitInfo;
        Debug.DrawRay(laserSpawner.transform.position, (laserSpawner.transform.position- transform.position) * laserLength, Color.red,2);
        if(Physics.Raycast(laser,out hitInfo))
        {
            Debug.Log("Hit something");
            if(hitInfo.collider.tag == "Tank")
            {
                Debug.Log("We've hit a tank");
                
            }
        }
    }

    private void DealDamageToTank(Health hScript)
    {
        hScript.TakeDamage(gameObject, shootDamage);
    }
}
