using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.FacadeModeAndSingleMode {
    public class FacadeManager {


        private static FacadeManager instant;
        public static FacadeManager Instant {
            get {
                if (instant == null) {
                    instant = new FacadeManager();
                }
                return instant;
            }
        }


        private IGameSystem mArchievementSystem;
        private IGameSystem mCampSystem;
        private IGameSystem mCharacterSystem;
        private IGameSystem mEnergySystem;
        private IGameSystem mGameEventSystem;
        private IGameSystem mStageSystem;

        private IUISystem mCampInfoUISystem;
        private IUISystem mGamePauseUISystem;
        private IUISystem mSoldierInfoUISystem;
        private IUISystem mGameStateInfoUISystem;


        public void OnStart() {
            DebugMy.Log("OnStart", this);

            mArchievementSystem = new ArchievementSystem();
            mCampSystem = new CampSystem();
            mCharacterSystem = new CharacterSystem();
            mEnergySystem = new EnergySystem();
            mGameEventSystem = new GameEventSystem();
            mStageSystem = new StageSystem();

            mCampInfoUISystem = new CampInfoUI();
            mGamePauseUISystem = new GamePauseUI();
            mSoldierInfoUISystem = new SoldierInfoUI();
            mGameStateInfoUISystem = new GameStateInfoUI();

            mArchievementSystem.OnInit();
            mCampSystem.OnInit();
            mCharacterSystem.OnInit();
            mEnergySystem.OnInit();
            mGameEventSystem.OnInit();
            mStageSystem.OnInit();

            mCampInfoUISystem.OnInit();
            mGamePauseUISystem.OnInit();
            mSoldierInfoUISystem.OnInit();
            mGameStateInfoUISystem.OnInit();

        }

        public void OnUpdate() {
            DebugMy.Log("OnUpdate", this);
            mArchievementSystem.OnUpdate();
            mCampSystem.OnUpdate();
            mCharacterSystem.OnUpdate();
            mEnergySystem.OnUpdate();
            mGameEventSystem.OnUpdate();
            mStageSystem.OnUpdate();

            mCampInfoUISystem.OnUpdate();
            mGamePauseUISystem.OnUpdate();
            mSoldierInfoUISystem.OnUpdate();
            mGameStateInfoUISystem.OnUpdate();
        }

        public void OnExit() {
            DebugMy.Log("OnExit", this);
            mArchievementSystem.OnExit();
            mCampSystem.OnExit();
            mCharacterSystem.OnExit();
            mEnergySystem.OnExit();
            mGameEventSystem.OnExit();
            mStageSystem.OnExit();

            mCampInfoUISystem.OnExit();
            mGamePauseUISystem.OnExit();
            mSoldierInfoUISystem.OnExit();
            mGameStateInfoUISystem.OnExit();
        }







    }
}
