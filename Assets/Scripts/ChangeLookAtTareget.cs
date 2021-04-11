using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLookAtTareget : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject target;
    void Start()
    {
        if( target== null){
            target= this.gameObject;
        }
        
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        Camera.main.gameObject.GetComponent<LookAtTarget>().target=target;
        Camera.main.fieldOfView=60* target.transform.localScale.x;
    }
}
