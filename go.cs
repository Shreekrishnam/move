using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class go : MonoBehaviour
{
    public float t;
    // Start is called before the first frame update
    void Start()
    {
        t=1f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(t*Input.GetAxis("Horizontal")*Time.deltaTime,t*Input.GetAxis("Jump")*Time.deltaTime,t*Input.GetAxis("Vertical")*Time.deltaTime);
    }
}
