using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Player
    {
        private int _id;
        private string _name;
        private Sign _sign;
        private int score;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public int Score
        {
            get { return score; }
            set { score = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public Sign Sign
        {
            get { return _sign; }
            set { _sign = value; }
        }
        public Player(int id, string name)
        {
            this._id = id;
            this._name = name;
        }
    }
    public enum Sign
    {
        X,O
    }
}
