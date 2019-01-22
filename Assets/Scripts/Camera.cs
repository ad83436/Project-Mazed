using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform Player;
    private Vector3 offset;
  
    void Start()
    {
        offset = transform.position - Player.position;
    }
  
    void LateUpdate()
    { 
        transform.position = Player.position + offset;
    }
}
