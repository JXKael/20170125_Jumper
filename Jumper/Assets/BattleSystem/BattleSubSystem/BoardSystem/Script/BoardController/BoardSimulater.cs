using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BoardSimulater : MonoBehaviour
{
    [SerializeField]
    protected List<GameObject> _boardPrefabs = new List<GameObject>(3);

    protected List<Board> _boards;

    protected BoardController _controller;

    #region Property
    public List<Board> Boards
    {
        get
        {
            return _boards;
        }
    }
    #endregion

    public void Init(BoardController controller)
    {        
        _boards = new List<Board>(20);
        this._controller = controller;
    }

    public void GenerateBoard(BoardSimulaterData data)
    {
        GameObject newBoard = Instantiate(GetBoardPrefab(data.type)) as GameObject;
        Board boardCtrl = newBoard.GetComponent<Board>();
        _boards.Add(boardCtrl);
        boardCtrl.transform.SetParent(data.container.transform);
        boardCtrl.transform.localPosition = new Vector3(data.line + data.offset, 0.0f, 0.0f);

        boardCtrl.Init(GetBoardData(data));
        
        data = null;
    }

    protected GameObject GetBoardPrefab(EBoardType type)
    {
        GameObject result = null;
        switch(type)
        {
            case EBoardType.moving: result = _boardPrefabs[0]; break;
            case EBoardType.solid: result = _boardPrefabs[1]; break;
            case EBoardType.time_destroy: result = _boardPrefabs[2]; break;
            default: break;
        }

        return result;
    }

    protected BoardData GetBoardData(BoardSimulaterData data)
    {
        switch (data.type)
        {
            case EBoardType.moving:
                {
                    BoardDataMoving boardData = new BoardDataMoving();
                    boardData.speed = data.speed;
                    return boardData;
                }
            default: return null;
        }
    }
}
