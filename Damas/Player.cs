using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Damas {
    public class Player : User {
        public float Experience {
            get => default(int);
            set {
            }
        }

        public History History {
            get => default(History);
            set {
            }
        }

        public void Play() {
            throw new System.NotImplementedException();
        }

        public void VerifyPlay() {
            throw new System.NotImplementedException();
        }

        public void Read() {
            throw new System.NotImplementedException();
        }

        public void Save() {
            throw new System.NotImplementedException();
        }
    }
}