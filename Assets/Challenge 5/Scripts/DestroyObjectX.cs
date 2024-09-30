using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectX : MonoBehaviour
{
    void Start()
    {
        //Debug.Log("Destory object general");
        Destroy(gameObject, 2); // destroy particle after 2 seconds //happens every time I click on an object

    }


}
