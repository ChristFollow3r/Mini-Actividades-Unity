using System;
using TMPro;
using UnityEngine;

public class CracckHeadButton : MonoBehaviour
{
    [SerializeField] private TMP_Text counter;
    int number = 0;

    public void ClickClick()
    {
        number++;
        counter.text = number.ToString();
    }
}
