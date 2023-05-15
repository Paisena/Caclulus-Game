using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : Unit
{
    private static Archer archerInstance;

    private void Awake() {
        DontDestroyOnLoad(this);
        if(archerInstance == null)
        {
            archerInstance = this;
        }
        else
        {
            Object.Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
