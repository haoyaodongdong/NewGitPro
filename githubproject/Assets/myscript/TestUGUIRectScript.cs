using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestUGUIRectScript : MonoBehaviour
{
    public RectTransform trans;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ButtonEvent()
    {
        Debug.Log("rect.anchorpostion" + trans.anchoredPosition);
        Debug.Log("rec.offmax" + trans.anchorMax);
        Debug.Log("rect.offmin" + trans.offsetMin);
    }
}
