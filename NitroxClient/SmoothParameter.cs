﻿using UnityEngine;

namespace NitroxClient
{
    public class SmoothParameter
    {
        private const float SMOOTHING_SPEED = 10f;
        public float Target { get; set; } = 0;
        public float SmoothValue { get; private set; } = 0;

        public void FixedUpdate()
        {
            SmoothValue = UWE.Utils.Slerp(SmoothValue, Target, (Target - SmoothValue) * SMOOTHING_SPEED * Time.fixedDeltaTime);
        }
    }
}
