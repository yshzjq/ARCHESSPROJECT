using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class informatiionScripts : MonoBehaviour
{
    public TextMeshProUGUI informationNameText;

    public TextMeshProUGUI informationValueText;

    public RawImage AttackImage;

    public TextMeshProUGUI informationchessText;

    public List<string> informationName = new List<string>();

    public List<string> informationValue = new List<string>();

    public List<Texture> informationAttackImage = new List<Texture>();

    public List<string> informationchess = new List<string>();

    Dictionary<string, string> namedict = new Dictionary<string, string>();
    Dictionary<string, string> valuedict = new Dictionary<string, string>();
    Dictionary<string, Texture> attackdict = new Dictionary<string, Texture>();
    Dictionary<string, string> chessdict = new Dictionary<string, string>();

    void Start()
    {
        for(int i = 0;i<informationName.Count;i++)
        {
            namedict.Add(informationName[i], informationName[i]);
            valuedict.Add(informationName[i], informationValue[i]);
            attackdict.Add(informationName[i], informationAttackImage[i]);
            chessdict.Add(informationName[i], informationchess[i]);
        }
    }

    // Update is called once per frame
    public void OutputInformation(string name)
    {
        informationNameText.text = "기물 : " + namedict[name];
        informationValueText.text = "점수 : " + valuedict[name];
        AttackImage.texture = attackdict[name];
        informationchessText.text = chessdict[name];
    }

}
