using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResolutionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(640, 480, false, 60);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
