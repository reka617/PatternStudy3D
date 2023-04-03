using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using Utils;

public class GameProcessor : MonoBehaviour
{
    GameState _state;
    private void Start()
    {
        ChangeGameState(new DefenseRunning());
    }
    // ���� �ӽ��� ������ ���� ���¸� ��������
    void Update()
    {
        if(_state != null)_state.MainLoop();
        
    }
    public void ChangeGameState(GameState state)
    {
        _state = state;
        if(_state != null) _state.OnEnter();
    }
}