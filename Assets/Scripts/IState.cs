﻿using UnityEngine;

public interface IState
{
    void Enter();
    void Enter(Vector3 target);
    void Exit();
    void Update();
}