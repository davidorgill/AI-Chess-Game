using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    /// <summary>
    /// Represents each of the 64 individual tiles within the board of a chess game. Each tile is either black or white and is 
    /// numberd exclusively between 0-63.
    /// </summary>
    public abstract class Tile
    {
        //represents the coordinate of an individual tile.
        private int tileCoordinate;

        /// <summary>
        /// constructs the tile with the given coordinate
        /// </summary>
        Tile(int tileCoordinate)
        {
            this.tileCoordinate = tileCoordinate;
        }

        
        public abstract bool isTileOccupied();
        public abstract Piece getPiece();

        /// <summary>
        /// A tile represented as being empty
        /// </summary>
        public class EmptyTile: Tile
        {
            // This constructor will call BaseClass.BaseClass(int i)
            public EmptyTile(int coordinate) : base(coordinate)
            {
            }

            /// <summary>
            /// returns that the tile is empty
            /// </summary>
            /// <returns></returns>
            override public bool isTileOccupied()
            {
                return false;
            }

            /// <summary>
            /// returns that the tile does not have a piece on the board
            /// </summary>
            /// <returns></returns>
            override public Piece getPiece()
            {
                return null;
            }

        }

        /// <summary>
        /// A tile represented by having a piece on it
        /// </summary>
        public class OccupiedTile : Tile
        {
            Piece pieceOnTile;

            // This constructor will call BaseClass.BaseClass(int i)
            public OccupiedTile(int coordinate, Piece pieceOnTile) : base(coordinate)
            {
                this.pieceOnTile = pieceOnTile;
            }

            /// <summary>
            /// returns that the tile is occupied by a piece on the board
            /// </summary>
            /// <returns></returns>
            override public bool isTileOccupied()
            {
                return true;
            }

            /// <summary>
            /// returns the piece on the occupied tile
            /// </summary>
            /// <returns></returns>
            override public Piece getPiece()
            {
                return pieceOnTile; ;
            }

        }



    }
}
