using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Author: Blake
 * 
 * manages the Hologram ship scale, position and roation to match the ship on the grid
 */


public class HolographicObject : MonoBehaviour
{
    public Transform attachedObject;
    public Transform panel;

    public float differnceInScale = 0.001f;

    Vector3 offSet;
    Vector3 scaleChange;


    // Start is called before the first frame update
    private void Start()
    {
        transform.SetParent(panel);
        scaleChange = new Vector3(0.01f, 0.01f, 0.01f);
        offSet = new Vector3(0.0f, 0.3f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        //Update my position to match the ship's position
        transform.localScale = scaleChange;
        transform.rotation = attachedObject.rotation; 
        transform.position = attachedObject.position * differnceInScale + (offSet + panel.position);
    }
}