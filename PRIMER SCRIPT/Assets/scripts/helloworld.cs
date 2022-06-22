using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    

public class helloworld : MonoBehaviour
{
    int X;
    public static GameObject esfera;
    // Start is called before the first frame update
    void Start()
    {

        X = 1;
        Debug.LogWarning("hey! pon atención");
        Debug.LogError("Ya huele a quemado");
    }
    private void Awake()
    {
        
    } 

    private void OnEnable()
    {
        
    }

    private void FixedUpdate()
    {
        
    }

    private void LateUpdate()
    {
        
    }

    private void OnDisable()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        X = X + 1;
        Debug.Log(X);
    }
}
