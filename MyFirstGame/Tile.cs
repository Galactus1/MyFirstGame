using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carcassonne
{
    public class Tile
    {
        public FieldPosition FieldPosition { get; set; }
        public CompassPoint Orientation { get; set; } = new CompassPoint() { Direction = RotationDirection.North };
        public Dictionary<string,List<Landscape>> Landscape { get; private set; }
        public Tile()
        {
            SetLandscapes();
        }
        public Tile(int X, int Y)
        {
            SetLandscapes();
            FieldPosition = new FieldPosition(X, Y);
        }
        public Tile(CompassPoint Orientation)
        {
            SetLandscapes();
            this.Orientation = Orientation;
        }
        private void SetLandscapes()
        {
            Landscape = new Dictionary<string, List<Landscape>>();
            Landscape.Add("Pastures", new List<Landscape>());
            Landscape.Add("Roads", new List<Landscape>());
            Landscape.Add("Cities", new List<Landscape>());
            Landscape.Add("Rivers", new List<Landscape>());
        }
    }
}
