using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutLineFindingResponse : MonoBehaviour,IFindingResponse
{
    public void OnFind(Transform selection)
    {
        var selectionRenderer = selection.GetComponent<Outline>();
        if (selectionRenderer != null)
        {
            selectionRenderer.OutlineWidth=10;
        }
    }

    public void OnLose(Transform selection)
    {
        var selectionRenderer = selection.GetComponent<Outline>();
        if (selectionRenderer != null)
        {
            selectionRenderer.OutlineWidth = 0;

        }
    }

}
