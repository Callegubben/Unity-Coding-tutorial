using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    Vector3 cameraPosition;
    [SerializeField]
    private GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        cameraPosition.z = -10;
    }

    // Update is called once per frame
    void Update()
    {
        cameraPosition.x = target.transform.position.x;
        cameraPosition.y = target.transform.position.y;
        this.transform.position = cameraPosition;
    }
}
