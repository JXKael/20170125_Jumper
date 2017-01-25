using UnityEngine;
using System.Collections;

public class SubSystem : MonoBehaviour, ISubSystem
{
    public void Initing(ISubSystemConfig config)
    {
        throw new System.NotImplementedException();
    }

    public void Updating()
    {
        throw new System.NotImplementedException();
    }

    public void Destroying()
    {
        throw new System.NotImplementedException();
    }
}
