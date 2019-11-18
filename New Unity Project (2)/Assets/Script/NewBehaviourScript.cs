using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public int speed = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveObject();
        

    }

    void moveObject()
    {
        /*
        float keyHorizontal = Input.GetAxis("Horizontal");

        float keyVertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * speed * Time.smoothDeltaTime * keyHorizontal, Space.World);

        transform.Translate(Vector3.up * speed * Time.smoothDeltaTime * keyVertical, Space.World);*/

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }
}
