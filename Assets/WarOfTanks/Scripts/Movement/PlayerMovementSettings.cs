using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WarOfTanks.PlayerInput
{   [CreateAssetMenu(menuName ="War Of Tanks/Player/Movement Settings")]
    public class PlayerMovementSettings : ScriptableObject
    {
        public float HorizontalSpeed=5;
        public float VerticalSpeed = 5;
    }
}
