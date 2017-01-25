using UnityEngine;
using System.Collections;

public class BoardMoving : Board
{
    protected Vector3 _position;
    [HideInInspector]
    public float speed;

    protected BoardDataMoving _data;

    public override void Init(BoardData data)
    {
        this._data = data as BoardDataMoving;
    }

	// Use this for initialization
	void Start()
    {        
        _position = this.transform.localPosition;
	}
	
	// Update is called once per frame
	void FixedUpdate()
    {
        _position.y -= _data.speed * Time.deltaTime;
        this.transform.localPosition = _position;
	}
}
