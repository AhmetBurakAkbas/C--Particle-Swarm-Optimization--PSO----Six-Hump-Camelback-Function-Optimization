using System;

namespace PSO_Ahmet_Burak_Akbas
{
    public class Particle
    {
        public double x1, x2;
        public double v1, v2;
        public double BestX1, BestX2;
        public double BestFitness;
        public double Fitness;
        private double minBound, maxBound;
        private static readonly object lockObj = new object();
        private static readonly Random rnd = new Random();
        private Func<double[], double> objectiveFunction;

        public Particle(double minBound, double maxBound, Func<double[], double> objectiveFunction = null)
        {
            this.minBound = minBound;
            this.maxBound = maxBound;
            this.objectiveFunction = objectiveFunction;

            x1 = RandomValue();
            x2 = RandomValue();
            v1 = RandomValue(-1, 1);
            v2 = RandomValue(-1, 1);

            UpdateFitness();

            BestX1 = x1;
            BestX2 = x2;
            BestFitness = Fitness;
        }

        public double SixHumpCamel(double x1, double x2)
        {
            return 4 * Math.Pow(x1, 2) - 2.1 * Math.Pow(x1, 4) + (1.0 / 3.0) * Math.Pow(x1, 6) + x1 * x2 - 4 * Math.Pow(x2, 2) + 4 * Math.Pow(x2, 4);
        }

        public double RandomValue()
        {
            lock (lockObj)
            {
                return rnd.NextDouble() * (maxBound - minBound) + minBound;
            }
        }

        public double RandomValue(double min, double max)
        {
            lock (lockObj)
            {
                return rnd.NextDouble() * (max - min) + min;
            }
        }

        public void UpdateFitness()
        {
            if (objectiveFunction != null)
            {
                double[] position = new double[] { x1, x2 };
                Fitness = objectiveFunction(position);
            }
            else
            {
                Fitness = SixHumpCamel(x1, x2);
            }
        }
    }
}
