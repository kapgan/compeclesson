using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WarOfTanks.PlayerInput
{
public class InputManager : MonoBehaviour
{
        [SerializeField] private InputData _inputData;
        public void Update()
        {
            _inputData.Horizontal = Input.GetAxis("Horizontal");
            _inputData.Vertical   = Input.GetAxis("Vertical");
        }
    }

}

