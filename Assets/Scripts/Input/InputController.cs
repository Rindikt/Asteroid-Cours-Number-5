using System;
using UnityEngine;

namespace Asteroid 
{
    public sealed class InputController : IExecute
    {
        public event Action onCkickLeftMause = delegate() { };
        private InputAxes _inputAxes;
        private float _horizontal;
        private float _vertical;
        private Ship _move;


        public InputController(Ship move)
        {
            _move = move;
            _inputAxes = new InputAxes();
            _inputAxes.InputVertical.AxisOnChange += VerticalOnAxisOnChange;
            _inputAxes.InputHorizontal.AxisOnChange += HorizontalOnAxisOnChange;
        }


        private void VerticalOnAxisOnChange(float value)
        {
            _vertical = value;
        }

        private void HorizontalOnAxisOnChange(float value)
        {
            _horizontal = value;
        }

        public void Execute()
        {
            _inputAxes.Execute();
            _move.Move(_horizontal, _vertical, Time.deltaTime);
            Acceleration();
            OnCkickLeftMause();

        }

        private void Acceleration()
        {
            
          if (Input.GetKeyDown(KeyCode.LeftShift))
          {
               _move.AddAcceleration();
          }

          if (Input.GetKeyUp(KeyCode.LeftShift))
          {
               _move.RemoveAcceleration();
          }
            
        }
        private void OnCkickLeftMause()
        {
            if (Input.GetButtonDown(MauseButtonManager.LEFT_MOUSE_BUTTON))
            {
                onCkickLeftMause.Invoke();
            }

        }
    }
}