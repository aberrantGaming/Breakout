using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace aberrantGaming.Breakout
{
    public abstract class UnitMotor : MonoBehaviour
    {
        [Header("Locomotion Setup:")]
        [Tooltip("Add speed for default movement")]
        public float Speed = 2.5f;
        [Tooltip("Lock the unit movement")]
        public bool MovementLocked;
        
        [HideInInspector]
        public Vector2 _input;
        [HideInInspector]
        public Rigidbody _rb;
        [HideInInspector]
        public Collider _col;

        public void Initialize()
        {
            _rb = GetComponent<Rigidbody>();
            _rb.isKinematic = true;

            _col = GetComponent<Collider>();
        }

        public void UpdateMotor()
        {
            if (!(MovementLocked))
                ControlMovement();
        }

        protected virtual void ControlMovement()
        {
            Vector3 tempVect = new Vector3(_input.x, 0, _input.y);
            tempVect = tempVect.normalized * Speed * Time.deltaTime;
            _rb.MovePosition(transform.position + tempVect);
        }
    }
}