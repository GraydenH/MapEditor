using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://www.youtube.com/watch?v=5NTmxDSKj-Q
public class MousePosition : MonoBehaviour
{
    public Vector3 screenPosition;
    public Vector3 worldPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        screenPosition = Input.mousePosition;
        screenPosition.z = Camera.main.nearClipPlane + 1;
        worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);

        transform.position = worldPosition;
    }
}
