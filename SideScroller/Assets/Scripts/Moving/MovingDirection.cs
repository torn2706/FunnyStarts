using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace TIC.FunnyStarts
{
    public struct MovingDirection : IComponentData
    {
        public float3 value;
    }
}


