using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text txtPoint;
    int gamePoint = 0;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void GetPoint()
    {
        gamePoint++;
        txtPoint.text = "Point: " + gamePoint.ToString();
    }
}
