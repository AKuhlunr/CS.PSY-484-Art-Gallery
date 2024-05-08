using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class AttatchPokeToFinger : MonoBehaviour
{

    public Transform pokePoint;

    private XRPokeInteractor pokeInteract;

    void SetPokeAttatchPoint()
    {
        if (pokePoint == null) { 
            Debug.Log("Attatch point null: Poke interactor");
            return;
        }
        if (pokeInteract == null)
        {
            Debug.Log("Interact is null: Poke interactor");
            return;
        }

        pokeInteract.attachTransform = pokePoint;


    }
    // Start is called before the first frame update
    void Start()
    {
        pokeInteract = transform.parent.parent.GetComponentInChildren<XRPokeInteractor>();
        SetPokeAttatchPoint();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
