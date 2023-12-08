using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] int breakableBlocks;
    SceneLoader loader;
    private void Start()
    {
        loader = GetComponent<SceneLoader>();
    }
    // Start is called before the first frame update
    public void CountBreakableBlocks()
    {
        breakableBlocks++;
    }
    public void BlockDestroyed()
    {
        breakableBlocks--;
        if(breakableBlocks <= 0)
        {
            loader.LoadnextScene();
        }
    }
}
