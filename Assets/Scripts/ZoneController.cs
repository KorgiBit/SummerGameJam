using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ZoneController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _mushroomText;
    [SerializeField] private Collider _collider;

    private void OnTriggerEnter(Collider other)
    {
        if (int.Parse(_mushroomText.text) > 4)
            _collider.enabled = false;
    }
}
