using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translate : MonoBehaviour
{
    public float TranslateSpeed = 1;

    public Vector3 Direction = new Vector3(0, 1, 0);
    
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Direction * TranslateSpeed * Time.deltaTime);
    }
}
