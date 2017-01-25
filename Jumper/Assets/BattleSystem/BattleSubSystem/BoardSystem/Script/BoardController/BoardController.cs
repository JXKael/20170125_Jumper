using UnityEngine;
using System.Collections;

public class BoardController : SubSystem
{
    protected BoardConfig _config;
    protected BoardControllerState _state;
    [SerializeField]
    protected BoardSimulater _simulater;
    [SerializeField]
    protected GameObject _container;

    #region Property
    public BoardConfig Config
    {
        get
        {
            return this._config;
        }
    }
    public BoardControllerState State
    {
        get
        {
            return this._state;
        }
    }
    public BoardSimulater Simulater
    {
        get
        {
            return this._simulater;
        }
    }
    public GameObject Container
    {
        get
        {
            return this._container;
        }
    }
    #endregion

    #region MonoBehaviour
    void Start()
    {
        this.Initing(new BoardConfig());
    }
    void Update()
    {
        this.Updating();
    }
    #endregion

    public void Initing(ISubSystemConfig config)
    {
        this._config = config as BoardConfig;
        this._state = new BoardControllerState(this);
        this._simulater.Init(this);
    }

    public void Updating()
    {
        this._state.Update();
    }

    public void Destroying()
    {
        
    }

    public void GenerateBoard(EBoardType type)
    {
        if (Random.Range(0.0f, 1.0f) <= this._config.rate)
        {
            BoardSimulaterData data = new BoardSimulaterData();
            data.type = type;
            data.line = this._config.lines[Random.Range(0, this._config.lineNum)];
            data.offset = Random.Range(this._config.l_offset, this._config.r_offset);
            data.container = this._container;
            data.speed = this._config.speed;
            this._simulater.GenerateBoard(data);
        }
    }
}
