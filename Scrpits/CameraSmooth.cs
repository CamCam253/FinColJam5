using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSmooth : MonoBehaviour
{
    GameObject camPos;
    [SerializeField] GameObject camFollowPos;
    void Start()
    {
        camPos = this.gameObject;
    }
    void Update()
    {
        transform.position = Vector3.Lerp(camPos.transform.position, camFollowPos.transform.position, Time.deltaTime);
    }
}
