using System.Collections;
using System.Collections.Generic;
using UnityEngine.Rendering;
using UnityEngine;

 
public class TextLayerController : MonoBehaviour
{
    public int SortingOrder;
 
    // Start is called before the first frame update
    void Start()
    {
        //Order in Layerの数値
        gameObject.layer = SortingOrder;
    }
 
    // Update is called once per frame
    void Update()
    {
 
    }
}