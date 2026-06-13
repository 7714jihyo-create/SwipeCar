using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CarController : MonoBehaviour
{
    GameObject flag;

    float speed=0;
    Vector2 startPos;

    // Start is called before the first frame update
    private void Start()
    {
        this.flag = GameObject.Find("flag");
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            
            this.startPos = Input.mousePosition;
        }
        else if(Input.GetMouseButtonUp(0)){            
            Vector2 endpos = Input.mousePosition;
            float swipelength = endpos.x - this.startPos.x;
            this.speed = swipelength / 500.0f;
            GetComponent<AudioSource>().Play();
        }
        
        transform.Translate(this.speed,0,0);
        this.speed *= 0.98f;
    }
}
