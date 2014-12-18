using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessEngine
{
    class Evaluation
    {

        public int scoreEvaluation()
        {
            return 0;
        }

        public int alphaBetaMax(int alpha, int beta, int depthleft)
        {
            if (depthleft == 0)
            {
                Console.WriteLine("Evaluate!");
                //return evaluate();
            }

            foreach (int i in moves)
            {
                score = alphaBetaMin(alpha, beta, depthleft - 1);
                if (score >= beta)
                {
                    return beta;
                }
                if (score > alpha)
                {
                    return alpha;
                }
            }
            return alpha;
        }

        public int alphaBetaMin(int alpha, int beta, int depthleft)
        {
            if (depthleft == 0)
            {
                Console.WriteLine("Evaluate!");
                //return evaluate();
            }

            foreach (int i in moves)
            {
                score = alphaBetaMin(alpha, beta, depthleft - 1);
                if (score >= beta)
                {
                    return beta;
                }
                if (score > alpha)
                {
                    return alpha;
                }
            }
            return alpha;
        }
    }


}
