using System;
using TMPro;
using UnityEngine;

namespace Asteroid
{
    internal class Interpreter : MonoBehaviour
    {
        [SerializeField] private TMP_Text _text;
        [SerializeField] private TMP_InputField _inputField;
        [SerializeField] private long num;
        private void Start()
        {
            _inputField.onValueChanged.AddListener(Interpret);
            Debug.Log(ToRoman(num));
        }

        private void Interpret(string value)
        {
            if (Int64.TryParse(value,out var number))
            {
                _text.text = ToRoman(number);
            }
        }

        private string ToRoman(long number)
        {
            if (number <0)
            {
                return "0";
            }
            else if (number>1000000)
            {
                double value = number / 1000000;
                var res = Math.Round(value, 1);
                return res.ToString()+"M";
            }
            else if (number > 100000)
            {
                double value = number / 1000;
                var res = Math.Round(value, 1);
                return res.ToString() + "K";

            }
            else if (number > 10000)
            {
                double value = number / 1000;
                var res = Math.Round(value, 1);
                return res.ToString() + "K";
            }
            else if (number > 1000)
            {
                double value = number / 1000;
                var res = Math.Round(value, 1);
                return res.ToString() + "K";
            }
                return number.ToString();
        }
    }
}
