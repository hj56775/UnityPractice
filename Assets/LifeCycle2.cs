using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle2 : MonoBehaviour
{
    //Transform : 오브젝트 형태에 대한 기본 컴포넘트,오브젝트와 일대일 대응
    void Start()
    {
        Vector3 vec = new Vector3(5, 0, 0);
        transform.Translate(vec);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vec = new Vector3(
            Input.GetAxis("Horizontal"),
            Input.GetAxis("Vertical"), 
            0);
        transform.Translate(vec);
    }
}
