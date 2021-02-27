using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
 
public class AutoOrbitalTransposer : MonoBehaviour
{
    public float speed = 10f;
    private CinemachineOrbitalTransposer orbit;
 
    void Start()
    {
        CinemachineVirtualCamera vcam = GetComponent<CinemachineVirtualCamera>();
        if (vcam != null)
            orbit = vcam.GetCinemachineComponent<CinemachineOrbitalTransposer>();
    }
 
    void Update()
    {
        if (orbit != null)
            orbit.m_XAxis.Value += Time.deltaTime * speed;
    }
}
