using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Door : MonoBehaviour ,IPointerClickHandler
{
    public bool isOpen = false;
    public Box myBox;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if(!isOpen && myBox.isOpen)
        {
            gameObject.transform.Rotate(new Vector3(0,0,200));
            isOpen = true;
        }
    }
    public void onClickAct()
    {
        if (!isOpen && myBox.isOpen)
        {
            gameObject.transform.Rotate(new Vector3(0, 0, 200));
            isOpen = true;
        }
    }

}
