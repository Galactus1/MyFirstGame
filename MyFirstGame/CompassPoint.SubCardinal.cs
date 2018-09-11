using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carcassonne
{
    public class SubCardinal : CompassPoint
    {
        /// <summary>
        /// Gets or sets the direction.
        /// </summary>
        /// <value>
        /// The direction.
        /// </value>
        public override RotationDirection Direction
        {
            get => direction;
            set
            {
                switch (value)
                {
                    case RotationDirection.N:
                    case RotationDirection.North:
                    case RotationDirection.Up:
                        direction = RotationDirection.North;
                        break;
                    case RotationDirection.NNE:
                        direction = RotationDirection.NNE;
                        break;
                    case RotationDirection.ENE:
                        direction = RotationDirection.ENE;
                        break;
                    case RotationDirection.E:
                    case RotationDirection.East:
                    case RotationDirection.Right:
                        direction = RotationDirection.East;
                        break;
                    case RotationDirection.ESE:
                        direction = RotationDirection.ESE;
                        break;
                    case RotationDirection.SSE:
                        direction = RotationDirection.SSE;
                        break;
                    case RotationDirection.S:
                    case RotationDirection.South:
                    case RotationDirection.Down:
                    case RotationDirection.UpsideDown:
                        direction = RotationDirection.South;
                        break;
                    case RotationDirection.SSW:
                        direction = RotationDirection.SSW;
                        break;
                    case RotationDirection.WSW:
                        direction = RotationDirection.WSW;
                        break;
                    case RotationDirection.W:
                    case RotationDirection.West:
                    case RotationDirection.Left:
                        direction = RotationDirection.West;
                        break;
                    case RotationDirection.WNW:
                        direction = RotationDirection.WNW;
                        break;
                    case RotationDirection.NNW:
                        direction = RotationDirection.NNW;
                        break;
                    case RotationDirection.NE:
                    case RotationDirection.SE:
                    case RotationDirection.SW:
                    case RotationDirection.NW:
                        direction = RotationDirection.Undefined;
                        break;
                    default:
                        direction = RotationDirection.North;
                        break;
                }
            }
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubCardinal"/> class.
        /// </summary>
        public SubCardinal() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubCardinal"/> class.
        /// </summary>
        /// <param name="CompassPoint">The compass point.</param>
        public SubCardinal(CompassPoint CompassPoint)
        {
            Direction = CompassPoint.Direction;
        }
        /// <summary>
        /// Rotates the direction clockwise.
        /// </summary>
        public override void RotateDirectionClockwise()
        {
            switch (direction)
            {
                case RotationDirection.North:
                case RotationDirection.East:
                case RotationDirection.South:
                case RotationDirection.West:
                    base.RotateDirectionClockwise();
                    break;
                case RotationDirection.NNE:
                    direction = RotationDirection.ESE;
                    break;
                case RotationDirection.ENE:
                    direction = RotationDirection.SSE;
                    break;
                case RotationDirection.ESE:
                    direction = RotationDirection.SSW;
                    break;
                case RotationDirection.SSE:
                    direction = RotationDirection.WSW;
                    break;
                case RotationDirection.SSW:
                    direction = RotationDirection.WNW;
                    break;
                case RotationDirection.WSW:
                    direction = RotationDirection.NNW;
                    break;
                case RotationDirection.WNW:
                    direction = RotationDirection.NNE;
                    break;
                case RotationDirection.NNW:
                    direction = RotationDirection.ENE;
                    break;
            }
        }
        /// <summary>
        /// Rotates the direction anticlockwise.
        /// </summary>
        public override void RotateDirectionAntiClockwise()
        {
            switch (direction)
            {
                case RotationDirection.North:
                case RotationDirection.East:
                case RotationDirection.South:
                case RotationDirection.West:
                    base.RotateDirectionAntiClockwise();
                    break;
                case RotationDirection.NNE:
                    direction = RotationDirection.WNW;
                    break;
                case RotationDirection.ENE:
                    direction = RotationDirection.NNW;
                    break;
                case RotationDirection.ESE:
                    direction = RotationDirection.NNE;
                    break;
                case RotationDirection.SSE:
                    direction = RotationDirection.ENE;
                    break;
                case RotationDirection.SSW:
                    direction = RotationDirection.ESE;
                    break;
                case RotationDirection.WSW:
                    direction = RotationDirection.SSE;
                    break;
                case RotationDirection.WNW:
                    direction = RotationDirection.SSW;
                    break;
                case RotationDirection.NNW:
                    direction = RotationDirection.WSW;
                    break;
            }
        }
        /// <summary>
        /// Flips the direction.
        /// </summary>
        public override void FlipDirection()
        {
            switch (direction)
            {
                case RotationDirection.North:
                case RotationDirection.East:
                case RotationDirection.South:
                case RotationDirection.West:
                    base.FlipDirection();
                    break;
                case RotationDirection.NNE:
                    direction = RotationDirection.SSW;
                    break;
                case RotationDirection.ENE:
                    direction = RotationDirection.WSW;
                    break;
                case RotationDirection.ESE:
                    direction = RotationDirection.WNW;
                    break;
                case RotationDirection.SSE:
                    direction = RotationDirection.NNW;
                    break;
                case RotationDirection.SSW:
                    direction = RotationDirection.NNE;
                    break;
                case RotationDirection.WSW:
                    direction = RotationDirection.ENE;
                    break;
                case RotationDirection.WNW:
                    direction = RotationDirection.ESE;
                    break;
                case RotationDirection.NNW:
                    direction = RotationDirection.SSE;
                    break;
            }
        }
    }
}
