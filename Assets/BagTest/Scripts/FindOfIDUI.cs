using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FindOfIDUI : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private Button findButton;
    [SerializeField] private BagUI bagUI;
    private void Start()
    {
        findButton.onClick.AddListener(FindItem);
    }

    private void FindItem()
    {
        int id;
        if (int.TryParse(inputField.text, out id))
        {
            bagUI.HighlightItem(id);
        }
        else
        {
            Debug.Log("Invalid ID input.");
        }
    }
}
