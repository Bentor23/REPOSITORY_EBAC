using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    

public class helloworld : MonoBehaviour
{
    int X;
   
    // Start is called before the first frame update
    void Start()
    {
        X = 1;
        Debug.LogWarning("hey! pon atención");
        Debug.LogError("Ya huele a quemado");
    }
    private void Awake()
    {
        Debug.Log("Hey!, aqui es awake");   
    } 

    private void OnEnable()
    {
        Debug.LogWarning("Hola! existo! esto es OnEnable");
    }

    private void FixedUpdate()
    {
        Debug.Log("Yo aparesco cada 50 frames, estoy en FixedUpdate");
    }

    private void LateUpdate()
    {
        Debug.LogError("Éste llega tarde por ser LateUpdate");
    }

    private void OnDisable()
    {
        Debug.Log("Si no existo, yo aparezco, OnDisable");
    }


    // Update is called once per frame
    void Update()
    {
       //  X = X + 1;
       //  Debug.Log(X);
    }
}
