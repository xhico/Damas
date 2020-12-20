using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Damas {
    public class User {
        public string Name {
            get => default(int);
            set {
            }
        }

        public string Username {
            get => default(int);
            set {
            }
        }

        public string Photo {
            get => default(int);
            set {
            }
        }

        public String Country {
            get => default(int);
            set {
            }
        }

        public int EatenPieces {
            get => default(int);
            set {
            }
        }

        public string Email {
            get => default(int);
            set {
            }
        }

        public virtual void Play() {
            throw new System.NotImplementedException();
        }

        public virtual void Read() {
            throw new System.NotImplementedException();
        }

        public virtual void Save() {
            throw new System.NotImplementedException();
        }

        public void Show() {
            throw new System.NotImplementedException();
        }
    }
}