using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplyModule : SampleScript
{
    [SerializeField]
    private GameObject prefab;

    [SerializeField]
    [Min(0)]
    [Tooltip("����������")]
    private int Count;

    [SerializeField]
    [Min(0)]
    [Tooltip("���")]
    private float Step;

    [ContextMenu("������")]
    public void Use()
    {
        for (int i = 0; i < Count; i++)
        {
            Instantiate(prefab, prefab.transform.position + new Vector3(0, 0, Step), Quaternion.identity, transform);
        }
    }

    
}
