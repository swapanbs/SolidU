using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutLineFindingResponse : MonoBehaviour,IFindingResponse
{
    public WealthManager wealthManager;
    public void OnFind(Transform selection)
    {
        var selectionRenderer = selection.GetComponent<Outline>();
        if (selectionRenderer != null)
        {
            selectionRenderer.OutlineWidth=10;
            if(Input.GetKeyDown(KeyCode.C))
            {
                wealthManager.pickUp += 1;
                Debug.Log(wealthManager.pickUp);
                Destroy(selection.gameObject);
            }
        }
    }

    public void OnLose(Transform selection)
    {
        var selectionRenderer = selection.GetComponent<Outline>();
        if (selectionRenderer != null)
        {
            selectionRenderer.OutlineWidth = 0;
            //Destroy(selection.gameObject);
        }
    }

}
