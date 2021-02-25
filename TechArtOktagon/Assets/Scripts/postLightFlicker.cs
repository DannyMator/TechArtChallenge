using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PostLightFlicker : MonoBehaviour
{
    private Animator anim;
    public float minTime;
    public float maxTime;
    [Range (0f,1f)]
    public float offTimeRatio = 0.5f;
    private float timer;
    private bool lightOn = true;
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("LightOn",lightOn);
        RestartTimer();
    }

    void Update()
    {
        timer -= Time.deltaTime;

        if(timer < 0){
            lightOn = !lightOn;
            anim.SetBool("LightOn",lightOn);
            RestartTimer();
        }
    }

    void RestartTimer(){
        timer = Random.Range(minTime,maxTime);
        if(!lightOn) timer *= offTimeRatio;
    }
}
