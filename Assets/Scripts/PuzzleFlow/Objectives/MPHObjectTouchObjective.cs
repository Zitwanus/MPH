using UnityEngine;
using System.Collections;

public class MPHObjectTouchObjective : MPHPuzzleObjective
{
    public GameObject _mainObject;

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject == _mainObject)
        {
            MPHPuzzleManager.Instance.ObjectiveFilled(this);
        }
    }
}
