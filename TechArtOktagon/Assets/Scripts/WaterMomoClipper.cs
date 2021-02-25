using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class WaterMomoClipper : MonoBehaviour
{
    private Animator anim;

    public void Start(){
        anim = GetComponent<Animator>();
    }
    public void OnTriggerEnter(Collider other){
        if(other.tag == "Momo"){
            anim.SetTrigger("Clip");
        }
    }
}
