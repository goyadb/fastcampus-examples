using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackManager : MonoBehaviour
{
    [SerializeField] private GameObject panelPrefab;
    [SerializeField] private Transform parent;
    
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(panelPrefab, parent);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
