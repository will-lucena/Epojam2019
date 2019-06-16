using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Developer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI nameField;
    [SerializeField] private TextMeshProUGUI roleField;
    [SerializeField] private Image photoField;

    public void setValues(string name, string role, Sprite photo)
    {
        nameField.SetText(name);
        roleField.SetText(role);
        photoField.sprite = photo;
    }
}
