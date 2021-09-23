using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionsBehaviour : MonoBehaviour
{
    private GameObject art;
    public SpriteRenderer artSpriteRenderer;
    public collectableSO collectedObj;
    public CollectionSO collection;
    

    private void Awake()
    {
        ConfigCollectable();
    }

    public void SwapCollectable()
    {
        collectedObj = collectable;
        ConfigCollectabe();
    }

    private void ConfigCollectabe()
    {
        art = GetComponentInChildren<Transform>().gameObject;
        artSpriteRenderer = GetComponentsInChildren<SpriteRenderer>();
        if (artSpriteRenderer != null)
        {
            artSpriteRenderer.sprite = collectedObj.art2D;
            artSpriteRenderer.color = collectedObj.artColorTint;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        collection.Collect(collectedObj);
        EnableDisableCollectable(false);
    }

    private void EnableDisableCollectable(bool value)
    {
        art.SetActive(value);
        GetComponent<Collider>().enabled = value;
    }
}
