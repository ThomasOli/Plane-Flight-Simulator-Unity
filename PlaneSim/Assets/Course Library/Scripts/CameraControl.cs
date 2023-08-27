using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{ public GameObject player;
    // Start is called before the first frame update
    private Vector3 offset = new Vector3 (0, 5, -20);
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position+offset;
    }
}
