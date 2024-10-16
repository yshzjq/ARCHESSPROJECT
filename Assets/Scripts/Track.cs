using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARCore;
using UnityEngine.XR.ARFoundation;
using UnityEngine.SceneManagement;


public class Track : MonoBehaviour
{
    public ARTrackedImageManager manager;

    public List<GameObject> list = new List<GameObject>();

    Dictionary<string,GameObject> dict = new Dictionary<string,GameObject>();

    public GameObject imageTrackingSuccessMessage;

    GameObject trackedImageObject;

    public Transform SpawnPosition;

    public TextMeshProUGUI informationUpdateText;

    public GameObject ChessInformation;

    public ARSession arsession;

    bool IsViewMessage = false;

    string trackedname;

    public informatiionScripts information;
    

    void Awake()
    {
        foreach (GameObject o in list)
        {
            dict.Add(o.name, o); 
        }
    }

    void OnChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {

        foreach (ARTrackedImage t in eventArgs.added)
        {
            if (IsViewMessage == false)
            {
                // ������ ��ü �� ���� ����
                informationUpdateText.text = t.referenceImage.name + " ��(��) �����Ǿ����ϴ�.\n\n������ ���ðڽ��ϱ�?";
                IsViewMessage = true;

                trackedname = t.referenceImage.name;
                trackedImageObject = dict[t.referenceImage.name];

                imageTrackingSuccessMessage.SetActive(true);
            }
           
        }
        information.OutputInformation(trackedname);
    }

    
      
     

    // ��ư ��ɵ�
    public void NoticeYesBtn()
    {
        imageTrackingSuccessMessage.SetActive(false);

        trackedImageObject.SetActive(true);
        ChessInformation.SetActive(true);
        
    }

    public void NoticeNoBtn()
    {
        IsViewMessage = false;
        
        imageTrackingSuccessMessage.SetActive(false);
        trackedImageObject = null;

        arsession.Reset();
    }

    public void InformationCancelBtn()
    {
        IsViewMessage = false;
        
        trackedImageObject.SetActive(false);
        ChessInformation.SetActive(false);
        trackedImageObject = null;

        arsession.Reset();
    }
    // ��ư ��ɵ�

    void OnEnable()
    {
        manager.trackedImagesChanged += OnChanged;
    }



}
