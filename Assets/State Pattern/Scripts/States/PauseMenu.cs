using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern {


    public class PauseMenu : MenuState
    {
        private MenuSystem menuSystem;

        public PauseMenu(MenuSystem menuSystem) : base (menuSystem)
        {
            this.menuSystem = menuSystem;
            menuSystem.EnablePauseMenu();
        }

        public override void ResumeGame(MenuStateMachine menu)
        {
            Debug.Log ("You've resumed the game.");
            menuSystem.DisablePauseMenu();
            menu.SetState(new GameMenu(menuSystem));
        }
        public override void RestartGame(MenuStateMachine menu)
        {
            Debug.Log ("You've restarted the game.");
            menuSystem.DisablePauseMenu();
            menu.SetState(new MainMenu(menuSystem));
        }
        public override void QuitGame(MenuStateMachine menu)
        {
            Application.Quit();
        }

    }
}