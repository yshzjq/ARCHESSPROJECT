using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class fading : MonoBehaviour
{
    // Start is called before the first frame update

    public float fadeOutTime;


    public void FadeIn(float fadeOutTime, System.Action nextEvent = null)
    {
        StartCoroutine(CoFadeIn(fadeOutTime, nextEvent));
    }

    public void FadeOut(float fadeOutTime, System.Action nextEvent = null)
    {
        StartCoroutine(CoFadeOut(fadeOutTime, nextEvent));
    }

    // ���� -> ������
    IEnumerator CoFadeIn(float fadeOutTime, System.Action nextEvent = null)
    {

        yield return new WaitForSeconds(2f);
        RawImage sr = this.gameObject.GetComponent<RawImage>();
        Color tempColor = sr.color;
        while (tempColor.a < 1f)
        {
            tempColor.a += Time.deltaTime / fadeOutTime;
            sr.color = tempColor;

            if (tempColor.a >= 1f) tempColor.a = 1f;

            yield return null;
        }

        sr.color = tempColor;
        if (nextEvent != null) nextEvent();

        
    }

    // ������ -> ����
    IEnumerator CoFadeOut(float fadeOutTime, System.Action nextEvent = null)
    {
        RawImage sr = this.gameObject.GetComponent<RawImage>();
        Color tempColor = sr.color;
        while (tempColor.a > 0f)
        {
            tempColor.a -= Time.deltaTime / fadeOutTime;
            sr.color = tempColor;

            if (tempColor.a <= 0f) tempColor.a = 0f;

            yield return null;
        }
        sr.color = tempColor;
        if (nextEvent != null) nextEvent();

        FadeIn(2f);
    }

    private void Start()
    {
        FadeOut(fadeOutTime);
    }
}

