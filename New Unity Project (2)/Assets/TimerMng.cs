using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerMng : MonoBehaviour
{

    private static float time;

    void Start()
    {
        time = 0f;
    }

    private void Update()
    {
        time += Time.deltaTime;

        float t = Mathf.Abs(time);
        Text uiText = GetComponent<Text>();
        uiText.text = "Time :  " + t.ToString();
    }
    
}
