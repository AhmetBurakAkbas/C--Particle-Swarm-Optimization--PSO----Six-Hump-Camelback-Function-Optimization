using System;
using System.Collections.Generic;

namespace PSO_Ahmet_Burak_Akbas
{
    public class PSOAlgorithm
    {
        private int particleCount;
        private int maxIterations;
        private double c1, c2, w;
        private double minBound, maxBound;
        private List<Particle> particles;
        private Particle[] pbest;
        private Particle gbest;
        public List<double> ConvergenceHistory { get; private set; }
        public double[] GlobalBestPosition { get; private set; }
        public double GlobalBestFitness { get; private set; }
        private static readonly Random globalRandom = new Random(DateTime.Now.Millisecond);

        public PSOAlgorithm(int particleCount, double minBound, double maxBound, double c1, double c2, double w, int maxIterations)
        {
            this.particleCount = particleCount;
            this.maxIterations = maxIterations;
            this.c1 = c1;
            this.c2 = c2;
            this.w = w;
            this.minBound = minBound;
            this.maxBound = maxBound;
            this.particles = new List<Particle>();
            this.ConvergenceHistory = new List<double>();
            this.GlobalBestPosition = new double[2];
            this.GlobalBestFitness = double.MaxValue;
        }

        public void Run(System.Func<double[], double> objectiveFunction)
        {
            particles.Clear();
            pbest = new Particle[particleCount];

            double rangeSize = maxBound - minBound;
            for (int i = 0; i < particleCount; i++)
            {
                Particle p = new Particle(minBound, maxBound, objectiveFunction);
                particles.Add(p);

                pbest[i] = new Particle(minBound, maxBound, objectiveFunction);
                pbest[i].x1 = p.x1;
                pbest[i].x2 = p.x2;
                pbest[i].v1 = p.v1;
                pbest[i].v2 = p.v2;
                pbest[i].BestFitness = p.Fitness;
            }

            int initialBestIndex = 0;
            for (int i = 1; i < particleCount; i++)
            {
                if (Math.Abs(particles[i].Fitness) < Math.Abs(particles[initialBestIndex].Fitness))
                {
                    initialBestIndex = i;
                }
            }

            gbest = new Particle(minBound, maxBound, objectiveFunction);
            gbest.x1 = particles[initialBestIndex].x1;
            gbest.x2 = particles[initialBestIndex].x2;
            gbest.v1 = particles[initialBestIndex].v1;
            gbest.v2 = particles[initialBestIndex].v2;
            gbest.BestFitness = particles[initialBestIndex].Fitness;

            GlobalBestFitness = gbest.BestFitness;
            GlobalBestPosition[0] = gbest.x1;
            GlobalBestPosition[1] = gbest.x2;

            ConvergenceHistory.Clear();
            ConvergenceHistory.Add(gbest.BestFitness);

            double initialW = w;
            double finalW = 0.4; 

            for (int iter = 0; iter < maxIterations; iter++)
            {
                double currentW = initialW - ((initialW - finalW) * iter / maxIterations);

                for (int j = 0; j < particleCount; j++)
                {
                    if (Math.Abs(particles[j].Fitness) < Math.Abs(pbest[j].BestFitness))
                    {
                        pbest[j].x1 = particles[j].x1;
                        pbest[j].x2 = particles[j].x2;
                        pbest[j].v1 = particles[j].v1;
                        pbest[j].v2 = particles[j].v2;
                        pbest[j].BestFitness = particles[j].Fitness;
                    }
                }

                bool improved = false;
                for (int j = 0; j < particleCount; j++)
                {
                    if (Math.Abs(pbest[j].BestFitness) < Math.Abs(gbest.BestFitness))
                    {
                        gbest.x1 = pbest[j].x1;
                        gbest.x2 = pbest[j].x2;
                        gbest.v1 = pbest[j].v1;
                        gbest.v2 = pbest[j].v2;
                        gbest.BestFitness = pbest[j].BestFitness;
                        GlobalBestFitness = gbest.BestFitness;
                        GlobalBestPosition[0] = gbest.x1;
                        GlobalBestPosition[1] = gbest.x2;
                        improved = true;
                    }
                }

                ConvergenceHistory.Add(gbest.BestFitness);

                for (int j = 0; j < particleCount; j++)
                {
                    double r1x = RandomValue(0, 1);
                    double r1y = RandomValue(0, 1);
                    double r2x = RandomValue(0, 1);
                    double r2y = RandomValue(0, 1);

                    particles[j].v1 = currentW * particles[j].v1 +
                                   c1 * r1x * (pbest[j].x1 - particles[j].x1) +
                                   c2 * r2x * (gbest.x1 - particles[j].x1);

                    particles[j].v2 = currentW * particles[j].v2 +
                                   c1 * r1y * (pbest[j].x2 - particles[j].x2) +
                                   c2 * r2y * (gbest.x2 - particles[j].x2);

                    double velocityLimit = rangeSize * 0.1;
                    particles[j].v1 = Math.Max(Math.Min(particles[j].v1, velocityLimit), -velocityLimit);
                    particles[j].v2 = Math.Max(Math.Min(particles[j].v2, velocityLimit), -velocityLimit);

                    particles[j].x1 += particles[j].v1;
                    particles[j].x2 += particles[j].v2;

                    // Boundary control
                    if (particles[j].x1 < minBound)
                    {
                        particles[j].x1 = minBound;
                        particles[j].v1 *= -0.5; 
                    }
                    if (particles[j].x1 > maxBound)
                    {
                        particles[j].x1 = maxBound;
                        particles[j].v1 *= -0.5; 
                    }
                    if (particles[j].x2 < minBound)
                    {
                        particles[j].x2 = minBound;
                        particles[j].v2 *= -0.5; 
                    }
                    if (particles[j].x2 > maxBound)
                    {
                        particles[j].x2 = maxBound;
                        particles[j].v2 *= -0.5; 
                    }

                    particles[j].UpdateFitness();
                }

                if (!improved && iter > 10 && iter % 5 == 0)
                {
                    for (int j = 0; j < particleCount; j++)
                    {
                        if (RandomValue(0, 1) < 0.2)
                        {
                            double perturbAmount = rangeSize * 0.05 * (1.0 - (double)iter/maxIterations);
                            particles[j].x1 += RandomValue(-perturbAmount, perturbAmount);
                            particles[j].x2 += RandomValue(-perturbAmount, perturbAmount);

                            particles[j].x1 = Math.Max(Math.Min(particles[j].x1, maxBound), minBound);
                            particles[j].x2 = Math.Max(Math.Min(particles[j].x2, maxBound), minBound);

                            particles[j].UpdateFitness();
                        }
                    }
                }
            }
        }

        private static readonly object lockObj = new object();
        public double RandomValue(double min, double max)
        {
            lock (lockObj)
            {
                return globalRandom.NextDouble() * (max - min) + min;
            }
        }
    }
}
