using UnityEngine;
using System.Collections;

public class Board : MonoBehaviour
{
    protected bool _isLanded;

    #region Property
    public bool IsLanded
    {
        get
        {
            return this._isLanded;
        }
    }
    #endregion // ! Property

    public virtual void Init(BoardData data) { }
}
