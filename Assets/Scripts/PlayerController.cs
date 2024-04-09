using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

namespace HackedDesign
{
    public class PlayerController : MonoBehaviour
    {
        [Header("GameObjects")]
        [SerializeField] private PlayerInput playerInput;
        [SerializeField] private Camera mainCamera;

        private InputAction moveAction;
        private InputAction lookAction;        

        void Awake()
        {
            if (playerInput == null)
            {
                playerInput = GetComponent<PlayerInput>();
            }            

            moveAction = playerInput.actions["Move"];
            lookAction = playerInput.actions["Look"];            
        }

        void Start()
        {
            Reset();
        }

        public void Reset()
        {

        }

        public void UpdateBehaviour()
        {

        }

        public void FixedUpdateBehaviour()
        {

        }
    }
}