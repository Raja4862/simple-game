using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipegen : MonoBehaviour
{
    public GameObject pillars;
    public Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Genaratepillars());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Genaratepillars()
    {
        while(true)
        {
        yield return new WaitForSeconds(4f);
        float randy =Random.Range(-1f,3.5f);
        pos = new Vector3(4f,randy,0f);
        Instantiate(pillars,pos,Quaternion.identity);
    }
    }
}
