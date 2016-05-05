using UnityEngine;
using System.Collections;

public class MPHEndGamePrint : MPHEndGame
{
    public string _message;

    public override void DoAction()
    {
        Debug.Log(_message);
    }
}
