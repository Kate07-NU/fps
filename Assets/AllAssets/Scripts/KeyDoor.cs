using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDoor : MonoBehaviour
{
    Animation anim = default;
    [SerializeField] GameObject key = default;

    private void Start()
    {
        key.SetActive(false);
        anim = GetComponent<Animation>();
    }

    public void Open()
    {
        anim.Play();
        key.SetActive(true);
    }
}