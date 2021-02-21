using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindingManager : MonoBehaviour
{
    [SerializeField] private string findingTag = "FindingObj";

    private IFindingResponse _findingResponse;
    private Transform _transform;


    private void Awake()
    {
        _findingResponse = GetComponent<IFindingResponse>();
    }
    // Update is called once per frame
    void Update()
    {
        if(_transform!=null)
        {
            _findingResponse.OnLose(_transform);
        }

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        _transform = null;
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit ))
        {
            var transform = hit.transform;
            if(transform.CompareTag(findingTag))
            {
                _transform = transform;
            }
        }

        if(_transform!=null)
        {
            _findingResponse.OnFind(_transform);
        }
    }
}
