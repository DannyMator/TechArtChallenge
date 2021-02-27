using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraSwitcher : MonoBehaviour
{
    public CinemachineVirtualCamera[] cameras;
    public int activeCamera = 0;
    public bool autoSwitch = true;
    public float autoSwitchInterval = 5.0f;
    private float autoSwitchTimer;

    public void Start(){
        activeCamera = Mathf.Clamp(activeCamera,0,cameras.Length);
        SwitchCamera(activeCamera);

        autoSwitchTimer = autoSwitchInterval;
    }

    public void Update(){
        if(autoSwitch){
            autoSwitchTimer -= Time.deltaTime;

            if(autoSwitchTimer < 0){
                NextCamera();
                autoSwitchTimer = autoSwitchInterval;
            }
        }
    }

    public void AutoSwitchToggle(){
        autoSwitch = !autoSwitch;
        if(autoSwitch){
            autoSwitchTimer = autoSwitchInterval;
        }
    }

    public void NextCamera(){
        activeCamera = (activeCamera + 1) % cameras.Length;
        SwitchCamera(activeCamera);
    }
    public void PreviousCamera(){
        activeCamera -= 1;
        if(activeCamera<0) activeCamera = cameras.Length - 1;
        SwitchCamera(activeCamera);
    }

    public void SwitchCamera(int cameraIndex){
        activeCamera = cameraIndex;
        for(int i = 0; i < cameras.Length; i++){
            if(i == activeCamera){
                cameras[i].m_Priority = 1;
            } else {
                cameras[i].m_Priority = 0;
            }
        }
    }
}
