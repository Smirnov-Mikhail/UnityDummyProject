using System;
using TMPro;
using UnityEngine;

public class WindowScript : MonoBehaviour
{
      public TextMeshProUGUI text;
      public TextMeshProUGUI disabledText;

      public void Start()
      {
            text.text = disabledText.text;
      }
}