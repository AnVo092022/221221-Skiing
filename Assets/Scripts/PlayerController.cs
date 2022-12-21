using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D myBody;
    public float torqueValue = 1f;

    // Start is called before the first frame update
    void Start()
    {
        myBody= GetComponent<Rigidbody2D>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) 
        {
            myBody.AddTorque(torqueValue);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            myBody.AddTorque(-torqueValue);
        }


    }
}
