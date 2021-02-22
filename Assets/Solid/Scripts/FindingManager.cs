using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindingManager : MonoBehaviour
{
    private IRayProvider _rayProvider;
    private IFindingResponse _findingResponse;
    private IFinder _finder;
    private Transform _CurrentTransform;

    private void Awake()
    {
        _rayProvider = GetComponent<IRayProvider>();
        _finder = GetComponent<IFinder>();
        _findingResponse = GetComponent<IFindingResponse>();
    }
    // Update is called once per frame
    void Update()
    {
        if (_CurrentTransform != null)
        {
            _findingResponse.OnLose(_CurrentTransform);
        }

        var ray = _rayProvider.RayCreate();
        _finder.Check(ray);
        _CurrentTransform =_finder.GetFinding();
        if (_CurrentTransform != null)
        {
            _findingResponse.OnFind(_CurrentTransform);
        }
    }
}
