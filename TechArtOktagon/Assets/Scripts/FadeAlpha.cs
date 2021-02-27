using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(CanvasGroup))]
public class FadeAlpha : MonoBehaviour
{
    public float transitionDuration = 1.0f;
    private CanvasGroup canvasGroup;

    public void Awake(){
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void FadeIn(){
        canvasGroup.alpha = 0.0f;
        StartCoroutine(FadeTransition(transitionDuration, canvasGroup.alpha, 1.0f));
    }
    public void FadeOut(){
        canvasGroup.alpha = 1.0f;
        StartCoroutine(FadeTransition(transitionDuration, canvasGroup.alpha, 0.0f));
    }

    public IEnumerator FadeTransition(float duration, float startVal, float endVal){
        float timer = 0.0f;

        while(timer < duration){
            timer += Time.deltaTime;
            canvasGroup.alpha = Mathf.Lerp(startVal, endVal, timer/duration);
            yield return null;
        }
    }
}
