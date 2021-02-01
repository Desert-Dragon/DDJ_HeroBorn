using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {debug.Log("Player detected --- ATTACK!");
        
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(other.name == "Player")
        {debug.log("Player out of range, resume patrol");
        }
    }

}
