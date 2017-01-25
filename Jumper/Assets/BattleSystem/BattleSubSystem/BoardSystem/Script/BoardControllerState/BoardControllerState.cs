using UnityEngine;
using System.Collections;

public class BoardControllerState
{
    protected BoardController _controller;
    protected float _timer;

    public BoardControllerState(BoardController controller)
    {
        this._controller = controller;
        this._timer = _controller.Config.duration;
    }

	public void Update()
    {
        if (_timer >= Time.deltaTime)
        {
            _timer -= Time.deltaTime;
            return;
        }


        _controller.GenerateBoard(EBoardType.moving);

        _timer = _controller.Config.duration;
    }
}
