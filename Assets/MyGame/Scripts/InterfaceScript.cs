using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class InterfaceScript : MonoBehaviour
{  
    public InputField input;
    public Button textButton;
    public Text result;


    public void CopyText()
    {
        result.text = input.text;
    }
}