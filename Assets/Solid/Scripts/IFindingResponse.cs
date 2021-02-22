using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IFindingResponse
{
    void OnFind(Transform finding);
    void OnLose(Transform finding);

}
