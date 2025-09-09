using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    
    void Start()
    {
        transform.position = new Vector3(0,0,0);
        transform.localScale = Vector3.one * 2.5f;
        
        Material material = Renderer.material;
        
        material.color = new Color(255,0,0,.5f);
    }
    
    void Update()
    {
        transform.Rotate(-2.0f * Time.deltaTime, -2.0f, 0.0f);
    }
}
