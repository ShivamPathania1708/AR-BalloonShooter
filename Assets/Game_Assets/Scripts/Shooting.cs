using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject arCamera;
    public LayerMask Balloon;
    
    public void Shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit, Mathf.Infinity, Balloon))
        {
            //if(hit.transform.name == "balloon1(CLone)" || hit.transform.name == "balloon2(CLone)" || hit.transform.name == "balloon3(CLone)")
            {
                Destroy(hit.transform.gameObject);
                
            }
        }
    }
}
