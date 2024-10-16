using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fade : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    void Start()
    {

        StartCoroutine(fadeout());
    }

    IEnumerator fadeout()
    {
        yield return new WaitForSeconds(8f);

        for(int i = 0;i<=100;i++) 
        {
            canvasGroup.alpha = i / 100f;
            yield return new WaitForSeconds(0.05f);
        }

        yield return new WaitForSeconds(5f);

        StartCoroutine(fadein());
    }

    IEnumerator fadein()
    {
        for (int i = 100; i >= 0; i--)
        {
            canvasGroup.alpha = i / 100f;
            yield return new WaitForSeconds(0.05f);
        }

        SceneManager.LoadScene("SampleScene");
    }


}
