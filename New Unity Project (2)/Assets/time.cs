using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time : MonoBehaviour
{

    private static float time1;
    
    void Start()
    {
        time1 = 0.00f;
    }

    private void Update()
    {
        time1 += Time.deltaTime;
        

        float t = Mathf.Abs(time1);
        Text uiText = GetComponent<Text>();
        uiText.text = string.Format("{0:N2}", time1);
        uiText.text = "Time : " + t.ToString();
    }


    
}
