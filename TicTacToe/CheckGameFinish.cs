using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class CheckGameFinish
    {


        public void isGameFinished(Player player)
        {
            bool isGameFinished = false;

            Tile[] tiles = player.getPlayerTileArray();

            if (tiles[0].getTileX(). == tiles[1].getTileX() == tiles[2].getTileX())
            {
                isGameFinished = !isGameFinished;
            }


        }
    }
}
