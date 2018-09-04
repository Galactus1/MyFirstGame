using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carcassonne
{
    public class FieldPosition
    {
        /// <summary>
        /// Gets a value indicating whether this instance is set.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is set; otherwise, <c>false</c>.
        /// </value>
        public bool IsSet
        {
            get
            {
                return XIsSet && YIsSet;
            }
        }
        private int x;
        private bool XIsSet = false;
        /// <summary>
        /// Gets or sets the x.
        /// </summary>
        /// <value>
        /// The x.
        /// </value>
        public int X
        {
            get => x;
            set
            {
                x = value;
                XIsSet = true;
            }
        }
        private int y;
        private bool YIsSet = false;
        /// <summary>
        /// Gets or sets the y.
        /// </summary>
        /// <value>
        /// The y.
        /// </value>
        public int Y
        {
            get => y;
            set
            {
                y = value;
                YIsSet = true;
            }
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldPosition"/> class.
        /// </summary>
        public FieldPosition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldPosition"/> class.
        /// </summary>
        /// <param name="X">The x.</param>
        /// <param name="Y">The y.</param>
        public FieldPosition(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }
}
