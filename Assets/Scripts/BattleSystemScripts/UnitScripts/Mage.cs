using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : Unit
{

    private static Mage mageInstance;

    private void Awake()
    {
        DontDestroyOnLoad(this);
        if (mageInstance == null)
        {
            mageInstance = this;
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
