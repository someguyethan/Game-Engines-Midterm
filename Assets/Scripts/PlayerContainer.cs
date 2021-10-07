using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerContainer : MonoBehaviour
{
    public int health = 10;
    public Text text;

    private void Update()
    {
        text.text = health.ToString();
    }
}
