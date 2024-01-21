using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IRoom
{
    public void PlayerEntered(Vector3 doorPos);
    public Vector3 GetRoomPosition();
}
