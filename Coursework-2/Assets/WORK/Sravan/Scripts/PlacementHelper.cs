using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlacementHelper 
{

    public static List<Direction> FindNeighbour(Vector3Int position, ICollection<Vector3Int> collecction)
    {
        List<Direction> neighbourDirections = new List<Direction>();
        if (collecction.Contains(position+Vector3Int.right))
        {
            neighbourDirections.Add(Direction.Right);
        }
        if (collecction.Contains(position - Vector3Int.right))
        {
            neighbourDirections.Add(Direction.Left);
        }
        if (collecction.Contains(position + new Vector3Int(0,0,1)))
        {
            neighbourDirections.Add(Direction.Up);
        }
        if (collecction.Contains(position + new Vector3Int(0, 0, -1)))
        {
            neighbourDirections.Add(Direction.Down);
        }

        return neighbourDirections;
    }

    internal static Vector3Int GetOffsetFromDirection(Direction direction)
    {
        switch (direction)
        {
            case Direction.Up:
                return new Vector3Int(0,0,1);
            case Direction.Down:
                return new Vector3Int(0, 0, -1);
            case Direction.Left:
                return Vector3Int.left;
            case Direction.Right:
                return Vector3Int.right;
            default:
                break;
        }
        throw new System.Exception("No direction such as " + direction);
    
}

    public static Direction GetReverseDirection(Direction direction)
    { 
        switch (direction)
        {
            case Direction.Up:
                return Direction.Down;
            case Direction.Down:
                return Direction.Up;
            case Direction.Left:
                return Direction.Right;
            case Direction.Right:
                return Direction.Left;
            default:
                break;
        }
        throw new System.Exception("No direction such as " + direction);
    }
}

