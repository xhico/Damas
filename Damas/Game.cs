using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Damas {
    public class Game {
        public User User_2 {
            get => default(User);
            set {
            }
        }

        public User User_1 {
            get => default(User);
            set {
            }
        }

        public Board Board {
            get => default(Board);
            set {
            }
        }

        public Date BeginDate {
            get => default(int);
            set {
            }
        }

        public Date EndDate {
            get => default(int);
            set {
            }
        }

        public Board Board1 {
            get => default(Board);
            set {
            }
        }

        public void GameReset() {
            throw new System.NotImplementedException();
        }

        public void SinglePlayer() {
            throw new System.NotImplementedException();
        }

        public void MultiPlayer() {
            throw new System.NotImplementedException();
        }

        public int First2Play() {
            throw new System.NotImplementedException();
        }

        public void BeginGame() {
            throw new System.NotImplementedException();
        }

        public int CheckWinner() {
            throw new System.NotImplementedException();
        }

        public void MakePlay() {
            throw new System.NotImplementedException();
        }

        public void PlayAgain() {
            throw new System.NotImplementedException();
        }

        public void ShowPlayerStats() {
            throw new System.NotImplementedException();
        }

        public void EmptySaveFile() {
            throw new System.NotImplementedException();
        }

        public virtual void SaveStats() {
            throw new System.NotImplementedException();
        }

        public virtual void ReadGame() {
            throw new System.NotImplementedException();
        }

        public virtual void SaveGame() {
            throw new System.NotImplementedException();
        }

        public virtual void ReadStats() {
            throw new System.NotImplementedException();
        }
    }
}