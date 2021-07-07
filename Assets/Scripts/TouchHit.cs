using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchHit : MonoBehaviour
{
    private void OnEnable()
    {
        TouchManager.Instance.touchUpdateEvent += Touch;
    }

    private void OnDisable()
    {
        TouchManager.Instance.touchUpdateEvent -= Touch;
    }

    private void Touch(Vector2 position)
    {
        
        Ray ray = Camera.main.ScreenPointToRay(position);
        if(Physics.Raycast(ray, out RaycastHit raycastHit))
        {
            if(raycastHit.collider.gameObject == gameObject)
            {
                GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
            }
        }
    }
}
