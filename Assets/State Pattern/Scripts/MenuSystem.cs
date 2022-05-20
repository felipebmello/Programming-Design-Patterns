using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace StatePattern {

    public interface MenuStateMachine
    {
        void SetState (MenuState newState);
    }
    
    public enum MenuTitle
    {
        MainMenu, 
        GameMenu, 
        PauseMenu
    }

    public class MenuSystem : MonoBehaviour, MenuStateMachine
    {
        private MenuState state;
        private Stack<MenuState> statesStack = new Stack<MenuState>();
        [SerializeField] private GameObject mainUI;
        [SerializeField] private GameObject gameUI;
        [SerializeField] private GameObject pauseUI;

        void Start() {
            state = new MainMenu(this);
        }

        public void StartGame() => state.StartGame(this);
        public void ResumeGame() => state.ResumeGame(this);
        public void PauseGame() => state.PauseGame(this);
        public void RestartGame() => state.RestartGame(this);
        public void QuitGame() => state.QuitGame(this);


        void MenuStateMachine.SetState(MenuState newState){
            state = newState;
        }

        public void EnableMainMenu() 
        {
            mainUI.SetActive(true);
        }
        public void DisableMainMenu() 
        {
            mainUI.SetActive(false);

        }

        public void EnableGameMenu() 
        {
            gameUI.SetActive(true);

        }
        public void DisableGameMenu() 
        {
            gameUI.SetActive(false);

        }

        public void EnablePauseMenu() 
        {
            pauseUI.SetActive(true);

        }
        public void DisablePauseMenu() 
        {
            pauseUI.SetActive(false);

        }
    }
}