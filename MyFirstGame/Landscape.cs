using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carcassonne
{
    /// <summary>
    /// The main Landscape class.
    /// </summary>
    /// <remarks>
    /// Functionality of this class is...
    /// </remarks>
    public class Landscape
    {
        /// <summary>
        /// Gets or sets the parent tile.
        /// </summary>
        /// <value>
        /// The parent tile.
        /// </value>
        public Tile ParentTile { get; set; }
        /// <summary>
        /// Gets or sets the borders.
        /// </summary>
        /// <value>
        /// The borders.
        /// </value>
        public List<CompassPoint> Borders { get; set; }
        /// <summary>
        /// Adds the border.
        /// </summary>
        /// <param name="Border">The border.</param>
        public virtual void AddBorder(CompassPoint Border)
        {
            Borders.Add(Border);
        }
    }
}
