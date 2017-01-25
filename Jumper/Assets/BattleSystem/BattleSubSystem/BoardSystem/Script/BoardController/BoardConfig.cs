using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BoardConfig : ISubSystemConfig
{
    public int lineNum;
    public float rate;
    public float duration;

    public List<float> lines;
    public float l_offset;
    public float r_offset;

    public float speed;

    public BoardConfig()
    {
        lineNum = 2;
        rate = 0.5f;
        duration = 2.0f;

        lines = new List<float>(lineNum);
        lines.Add(-2.0f);
        lines.Add(2.0f);
        l_offset = -0.5f;
        r_offset = 0.5f;

        speed = 1.0f;
    }
}
