using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteAlways]
public class Script_Pedana : MonoBehaviour
{
    [SerializeField] private float amplitude;
    [SerializeField] private float speed;
    [SerializeField][Range(0,1)] int x;
    [SerializeField][Range(0,1)] int y;
    [SerializeField][Range(0,1)] int z;

    Vector3  trs;
    // Start is called before the first frame update
    void Start()
    {
        trs=  transform.position;
       
    }
    float time=0;
    // Update is called once per frame
    void FixedUpdate()
    {
  
           time = Time.deltaTime +time;
            Vector3 pos=  new Vector3(
            Mathf.Sin(time*speed)*amplitude *x,
            Mathf.Sin(time*speed)*amplitude * y,
            Mathf.Sin(time*speed)*amplitude * z
            );
        transform.position=trs+pos;
    }
}
