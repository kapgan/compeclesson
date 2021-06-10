using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WarOfTanks.PlayerInput
{
    [CreateAssetMenu(menuName ="War Of Tanks/Input/Input Data")]
    public class InputData : ScriptableObject
    {
        public float Horizontal;
        public float Vertical;
    }
}