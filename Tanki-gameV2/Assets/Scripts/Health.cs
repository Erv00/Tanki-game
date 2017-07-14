using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    [SerializeField]
    private int maxHealth;
    [SerializeField]
    private int health;

    void Start()
    {
        health = maxHealth;
    }

    public bool TakeDamage(GameObject inflicter,int amm)
    {
        if(amm > health)
        {
            health = 0;
            return true;
        }
        health -= amm;
        return false;
    }

}
