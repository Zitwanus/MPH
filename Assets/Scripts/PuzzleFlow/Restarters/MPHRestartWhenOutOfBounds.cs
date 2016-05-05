using UnityEngine;
using System.Collections;

public class MPHRestartWhenOutOfBounds : MonoBehaviour
{
    public Bounds _bounds;
    

    void Update()
    {
        if (_bounds.Contains(transform.position) == false)
        {
            MPHPuzzleManager.Instance.Restart();
        }
    }
}
