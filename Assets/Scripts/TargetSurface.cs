using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TargetSurface : MonoBehaviour
{
    private GameObject whole;

    // Start is called before the first frame update
    void Start()
    {
        whole = transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {        
        var targetScript = whole.GetComponent<Target>();
        targetScript.OnSurfaceHitted();
    }
}
