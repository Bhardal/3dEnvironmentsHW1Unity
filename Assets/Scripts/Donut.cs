using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Donut : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;
    [SerializeField] private GameObject _Donut;

    public string InteractionPrompt => _prompt;

    public bool Interact(Interactor interactor)
    {
        _Donut.SetActive(false);
        return true;
    }
}
