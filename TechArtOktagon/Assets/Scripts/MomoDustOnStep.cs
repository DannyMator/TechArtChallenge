using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MomoDustOnStep : MonoBehaviour
{
    public GameObject particle;
    public void OnTriggerEnter(Collider other){
        if(other.tag == "Momo"){
            Vector3 position = other.transform.position + new Vector3 (0f,0.2f,0f);
            Instantiate(particle, position, Quaternion.Euler(new Vector3(90,0,0)));
        }
    }
}
