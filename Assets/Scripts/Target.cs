using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// –Ê‚É“–‚½‚Á‚½Žž
    /// </summary>
    public void OnSurfaceHitted()
    {
        Destroy(gameObject);
    }
}
