using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideOnAwake : MonoBehaviour
{
    public void Awake(){
        gameObject.SetActive(false);
    }
}
