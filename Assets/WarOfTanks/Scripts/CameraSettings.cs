using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WarOfTanks
{
    [CreateAssetMenu(menuName = "War Of Tanks/Came  ",ra/Camera Settings")]
    public class CameraSettings : ScriptableObject
    {
        [Header("Rotation")]
        [SerializeField] private float _rotationLerpSpeed = 1;
        public float RotationLerpSpeed { get { return _rotationLerpSpeed; } }

        [Header("Offset")]
        [SerializeField] private Vector3 _positionOffset;
        public Vector3 PositionOffset { get { return _positionOffset; } }

        [Header("Lerp")]

        [SerializeField] private float _positionLerp=1;
        public float PositionLerp { get { return _positionLerp; } }

    }
}

