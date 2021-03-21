using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoSnow : MonoBehaviour
{
    [SerializeField] private Material[] materials;

    private void Awake()
    {
        for (int i = 0; i < materials.Length; ++i)
        {
            materials[i].SetFloat("_SnowAmount", 0.0f);
        }
    }

    private void Update()
    {
        float snowAmount = (Time.time / 50.0f) % 1.2f;

        for(int i = 0; i < materials.Length; ++i)
        {
            materials[i].SetFloat("_SnowAmount", snowAmount);
        }
    }
}
