using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swap : MonoBehaviour
{
    public Transform player, stat;
    Vector3 temp;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            temp = player.transform.position;
            player.transform.position = stat.transform.position;
            stat.transform.position = temp;
            
        }
    }
}
