using UnityEngine;
using System.Collections;

public class MPHEndGameRestart : MPHEndGame
{
    public override void DoAction()
    {
        MPHPuzzleManager.Instance.Restart();
    }
}
