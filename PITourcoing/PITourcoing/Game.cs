using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PITourcoing
{
    class Game
    {
        private string[,] questions = new string[20, 5];
        public Game()
        {
            questions[0, 0] = "  Quelle est le nom du dernier film de Spiderman sortie en 2021 ? ";
            questions[0, 1] = "Far From Home";
            questions[0, 2] = "New Generation";
            questions[0, 3] = "*No Way Home";
            questions[0, 4] = "Homecoming";
            //
            questions[1, 0] = "           Quelle est le nom du nouvelle album de The Weeknd ? ";
            questions[1, 1] = "After Hours";
            questions[1, 2] = "*Dawn FM";
            questions[1, 3] = "Starboy";
            questions[1, 4] = "Trilogy";
            //
            questions[2, 0] = "               Qui a gagné la dernière ligue des champions ?";
            questions[2, 1] = "*Chelsea";
            questions[2, 2] = "PSG";
            questions[2, 3] = "Real Madrid";
            questions[2, 4] = "Bayern Munich";
            //
            questions[3, 0] = "                               Le dernier album d’Orelsan ? ";
            questions[3, 1] = "Perdu d’Avance";
            questions[3, 2] = "*Civilisation";
            questions[3, 3] = "La fête est finie ";
            questions[3, 4] = "Le chant des sirènes ";

            //
            questions[4, 0] = "                  Qui a gagné le championnat NBA en 2021 ?";
            questions[4, 1] = "New York KNICKS";
            questions[4, 2] = "Brooklyn NETS";
            questions[4, 3] = "Phoenix SUNS";
            questions[4, 4] = "*Milwaukee BUCKS";
            //





        }
        public string getQuestion(int i)
        {
            return questions[i, 0];
        }
        public string getAnswer(int i, int j)
        {
            return questions[i, j];
        }

    }
}
