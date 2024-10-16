using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class LoadingText : MonoBehaviour
{
    public TextMeshProUGUI text;
    // Start is called before the first frame update
    void OnEnable()
    {
        StartCoroutine(loading());
    }

    public void Doloading()
    {
        gameObject.SetActive(true);
    }

    IEnumerator loading()
    {
        text.text = "Loading.";
        yield return new WaitForSeconds(0.4f);
        text.text = "Loading..";
        yield return new WaitForSeconds(0.4f);
        text.text = "Loading...";
        yield return new WaitForSeconds(0.4f);
        gameObject.SetActive(false);
    }
}
