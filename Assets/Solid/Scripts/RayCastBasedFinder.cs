using UnityEngine;
public class RayCastBasedFinder:MonoBehaviour,IFinder
{
    [SerializeField] public string findingTag = "FindingObj";
    public Transform _transform;
    public Transform GetFinding()
    {
        return this._transform;
    }

    public void Check(Ray ray)
    {
        this._transform = null;
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            var transform = hit.transform;
            if (transform.CompareTag(this.findingTag))
            {
                this._transform = transform;
            }
        }
    }
}