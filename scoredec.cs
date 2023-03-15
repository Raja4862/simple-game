using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoredec : MonoBehaviour
{
    private bird Bird;
    // Start is called before the first frame update
    void Start()
    {
        Bird = GameObject.Find("Bird").GetComponent<bird>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="Player")
        {
          Bird.updatescore();
        }
    }
}
