using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern {
    public abstract class MenuState {
        private MenuSystem menuSystem;

        protected MenuState(MenuSystem menuSystem)
        {
            this.menuSystem = menuSystem;
        }

        public virtual void StartGame (MenuStateMachine menu) {

        }
        public virtual void ResumeGame (MenuStateMachine menu){

        }
        public virtual void PauseGame (MenuStateMachine menu){

        }
        public virtual void RestartGame (MenuStateMachine menu){

        }
        public virtual void QuitGame (MenuStateMachine menu){

        }
    }
}