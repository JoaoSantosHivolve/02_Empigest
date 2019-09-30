using Operation1;
using Operation2;
using Operation3;
using Operation4;
using UnityEngine;
using System;

public class GameManager : Singleton<GameManager>
{
    public Operation1.Operation1 Operation1;
    public Operation2.Operation2 Operation2;
    public Operation3.Operation3 Operation3;
    public Operation4.Operation4 Operation4;
    public OperationMisc OperationMisc;
}
