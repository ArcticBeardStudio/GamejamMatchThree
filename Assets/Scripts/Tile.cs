﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public int xIndex;
    public int yIndex;

    Board m_board;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	void Init(int x, int y, Board board)
    {
        xIndex = x;
        yIndex = y;
        m_board = board;
    }

}