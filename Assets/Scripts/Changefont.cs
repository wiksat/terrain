using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Changefont : MonoBehaviour
{

    private Text mytext;
    private Font font;
    // Use this for initialization
    void Start()
    {
        mytext = GetComponentInChildren(typeof(Text)) as Text;
        font = Resources.Load("FONT1") as Font;
        mytext.font = font;
    }
}
