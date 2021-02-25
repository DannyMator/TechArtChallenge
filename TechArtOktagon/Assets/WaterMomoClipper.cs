using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterMomoClipper : MonoBehaviour
{
    private Animator anim;

    public void Start(){
        anim = GetComponent<Animator>();
    }
    public void OnTriggerEnter(Collider other){
        if(other.tag == "MomoStep"){
            anim.SetTrigger("Clip");
        }
    }
}
