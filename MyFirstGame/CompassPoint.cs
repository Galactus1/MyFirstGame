using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carcassonne
{
    public class CompassPoint
    {
        protected RotationDirection direction = RotationDirection.North;
        /// <summary>
        /// Gets or sets the direction.
        /// </summary>
        /// <value>
        /// The direction.
        /// </value>
        public virtual RotationDirection Direction
        {
            get => direction;
            set
            {
                switch(value)
                {
                    case RotationDirection.N:
                    case RotationDirection.NNE:
                    case RotationDirection.NNW:
                    case RotationDirection.North:
                    case RotationDirection.Up:
                        direction = RotationDirection.North;
                        break;
                    case RotationDirection.E:
                    case RotationDirection.ENE:
                    case RotationDirection.ESE:
                    case RotationDirection.East:
                    case RotationDirection.Right:
                        direction = RotationDirection.East;
                        break;
                    case RotationDirection.S:
                    case RotationDirection.SSE:
                    case RotationDirection.SSW:
                    case RotationDirection.South:
                    case RotationDirection.Down:
                    case RotationDirection.UpsideDown:
                        direction = RotationDirection.South;
                        break;
                    case RotationDirection.W:
                    case RotationDirection.WSW:
                    case RotationDirection.WNW:
                    case RotationDirection.West:
                    case RotationDirection.Left:
                        direction = RotationDirection.West;
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
        /// Initializes a new instance of the <see cref="CompassPoint"/> class.
        /// </summary>
        public CompassPoint() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CompassPoint"/> class.
        /// </summary>
        /// <param name="SubCardinal">The sub cardinal.</param>
        public CompassPoint(SubCardinal SubCardinal)
        {
            Direction = SubCardinal.Direction;
        }
    }
}
