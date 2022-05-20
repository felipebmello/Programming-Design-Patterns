using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern {
    public class GameMenu :  MenuState
    {
        private MenuSystem menuSystem;

        public GameMenu(MenuSystem menuSystem) : base (menuSystem)
        {
            this.menuSystem = menuSystem;
            menuSystem.EnableGameMenu();
        }

        public override void PauseGame(MenuStateMachine menu)
        {
            Debug.Log ("You've paused the game.");
            menuSystem.DisableGameMenu();
            menu.SetState(new PauseMenu(menuSystem));
        }
    }
}
