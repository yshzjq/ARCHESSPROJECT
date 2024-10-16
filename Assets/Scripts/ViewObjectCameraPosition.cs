using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ViewObjectCameraPosition : MonoBehaviour
{
    RectTransform chessobjecttransform;
    void Start()
    {
        chessobjecttransform = GetComponent<RectTransform>();
    }
    void Update()
    {
        
       chessobjecttransform.Rotate(new Vector3(0f,10f,0f) * Time.deltaTime);
    }
}
