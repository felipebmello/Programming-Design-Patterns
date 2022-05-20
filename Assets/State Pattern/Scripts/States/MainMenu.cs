using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern {
    public class MainMenu : MenuState
    {
        private MenuSystem menuSystem;

        public MainMenu(MenuSystem menuSystem) : base (menuSystem)
        {
            this.menuSystem = menuSystem;
            menuSystem.EnableMainMenu();
        }

        public override void StartGame(MenuStateMachine menu)
        {
            Debug.Log ("You've started the game.");
            menuSystem.DisableMainMenu();
            menu.SetState(new GameMenu(menuSystem));
        }
        public override void QuitGame(MenuStateMachine menu)
        {
            Debug.Log ("You've quit the game.");
            Application.Quit();
        }
    }
}
