using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collision : MonoBehaviour
{
    // Start is called before the first frame update
    public Text textObject;
    public Camera m_camera;
    public Camera r_camera;
    public Canvas canv;
    public GameObject tiger;
    private static float time;

    void Start()
    {
        time = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "MONSTER")
        {
            transform.Translate(new Vector3(1000, 1000, 1000));
            float t = Mathf.Abs(time);
            textObject.GetComponent<Text>().text = "Time :  " + t.ToString();
            m_camera.CopyFrom(r_camera);
            m_camera.enabled = false;
            canv.GetComponent<Canvas>().enabled = true;

        }

    }

}
