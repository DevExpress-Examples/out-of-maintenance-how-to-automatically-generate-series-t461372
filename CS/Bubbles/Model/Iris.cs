#region #Model
namespace Bubbles {
    public class IrisData {
        string species;
        double sepalWidth;
        double sepalLength;
        double petalWidth;
        double petalLength;

        public string Species { get { return species; } }
        public double SepalWidth { get { return sepalWidth; } }
        public double SepalLength { get { return sepalLength; } }
        public double PetalWidth { get { return petalWidth; } }
        public double PetalLength { get { return petalLength; } }

        public IrisData(string species, double sepalWidth, double sepalLength, double petalWidth, double petalLength) {
            this.species = species;
            this.sepalWidth = sepalWidth;
            this.sepalLength = sepalLength;
            this.petalWidth = petalWidth;
            this.petalLength = petalLength;
        }
    }
}
#endregion #Model