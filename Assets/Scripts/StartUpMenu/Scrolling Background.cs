using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    public float speed = 1.0f;
    private Vector3 currentPosition;
    private Vector3 resetPosition = new Vector3(-62, 0, 0);
    private Vector3 startPosition = new Vector3(0, 0, 0);
    
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        currentPosition = transform.position;
        if (currentPosition.x <= resetPosition.x)
        {
           transform.position = startPosition;
        }
        
        
    }
}
