﻿using Configuration;
using UnityEngine;

namespace Animal
{
    public class DeadState : State
    {
        public override void Initialize(Subject subject)
        {
            base.Initialize(subject);
            subject.Visual.Dead = true;
            subject.Value = -1.0f;
        }
    }
}