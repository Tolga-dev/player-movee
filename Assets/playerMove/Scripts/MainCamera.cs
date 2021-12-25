using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public GameObject player;

    //get compenent playerýn uinx olmasý gerekli

    // Start is called before the first frame update
    Vector3 PositionCamera;
    void Start()
    {
        PositionCamera = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + PositionCamera;
    }
}
