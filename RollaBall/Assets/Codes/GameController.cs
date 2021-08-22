using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace SkipinGame
{

    public sealed class GameController : MonoBehaviour, IDisposable
    {
        private ListExecuteObject _interactiveObject;
        private DisplayEndGame _displayEndGame;
        private DisplayBonuses _displayBonuses;
        private int _countBonuses;
        private CameraController _cameraController;
        private InputController _inputController;

        private void Awake()
        {
            _interactiveObject = new ListExecuteObject();
            _displayEndGame = new DisplayEndGame();
            _displayBonuses = new DisplayBonuses();

            var reference = new Reference();
            _cameraController = new CameraController(reference.PlayerBall.transform,
                reference.MainCamera.transform);
            _interactiveObject.AddExecuteObject(_cameraController);

            _inputController = new InputController(reference.PlayerBall);
            _interactiveObject.AddExecuteObject(_inputController);

            foreach (var o in _interactiveObject)
            {
                if (o is BadBonus badBonus)
                {
                    badBonus.OnCaughtPlayerChange += CaughtPlayer;
                    badBonus.OnCaughtPlayerChange += _displayEndGame.GameOver;
                }
                if (o is GoodBonus goodBonus)
                {
                    goodBonus.OnPointChange += AddBonuse;
                }
            }
        }

        private void CaughtPlayer(string value, Color args)
        {
            Time.timeScale = 0.0f;
        }

        private void AddBonuse(int value)
        {
            _countBonuses += value;
            _displayBonuses.Display(_countBonuses);
        }

        private void Update()
        {
            for (var i = 0; i < _interactiveObject.Length; i++)
            {
                var interactiveObject = _interactiveObject[i];

                if (interactiveObject == null)
                {
                    continue;
                }
                interactiveObject.Execute();
            }
        }
        /*if (interactiveObject is IFlay flay)
        {
            flay.Flay();
        }
        if (interactiveObject is IFlicker flicker)
        {
            flicker.Flicker();
        }
        if (interactiveObject is IRotation rotation)
        {
            rotation.Rotation();
        }
        */

        public void Dispose()
        {
            foreach (var o in _interactiveObject)
            { 
                if (o is BadBonus badBonus)
                {
                    badBonus.OnCaughtPlayerChange -= CaughtPlayer;
                    badBonus.OnCaughtPlayerChange -= _displayEndGame.GameOver; 
                }
                if (o is GoodBonus goodBonus)
                {
                    goodBonus.OnPointChange -= AddBonuse;
                }
            }
        }
    }

}

