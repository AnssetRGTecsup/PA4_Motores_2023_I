using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRendererWater : MonoBehaviour
{
    LineRenderer agua;
    void Awake(){
        agua = GetComponent<LineRenderer>();
    }
    void Start()
    {
        agua.positionCount=2;
        
    }

    // Update is called once per frame
    void Update()
    {
        agua.SetPosition(0,transform.position);
        agua.SetPosition(1,new Vector2(transform.position.x+5,transform.position.y));
    }
}
