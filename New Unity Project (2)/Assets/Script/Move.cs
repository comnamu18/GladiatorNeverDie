
using UnityEngine;

using System.Collections;

public class Move : MonoBehaviour
{
    public float speed = 20;
    Vector3 lookDirection;


    void Update()
    {
        moveObject();
    }

    void moveObject()
    {


        float xx = Input.GetAxisRaw("Vertical");
        float zz = Input.GetAxisRaw("Horizontal");
        lookDirection = xx * Vector3.forward + zz * Vector3.right;

        

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.LookRotation(lookDirection);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.LookRotation(lookDirection);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.rotation = Quaternion.LookRotation(lookDirection);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.rotation = Quaternion.LookRotation(lookDirection);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

       
    }

}