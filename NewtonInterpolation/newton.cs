using System;
using System.Collections.Generic;



namespace NewtonInterpolation
{

    
    public class InsufficientPointsException : Exception
    {
        public InsufficientPointsException() { }
    }

    public class UnbalancedPointsException : Exception
    {
        public UnbalancedPointsException() { }
    }

    public class Newton
    {
        ///<summary>
        /// 
        ///</summary>
        ///<param name="xPts">Array of x points</param>
        ///<param name="yPts">Array of y points</param>
        ///<param name="size">Number of points. More than 2</param>
        ///

        public static float NewtonInterpolate(float[] xPts, float[] yPts, float xCoord)
        {
            int size;
            float yCoord;

            // Unbalanced points
            if (xPts.Length != yPts.Length)
            {
                throw new UnbalancedPointsException();
            }
            else
            {
                size = xPts.Length;
            }

            // Insufficient number of points
            if (size < 2)
            {
                throw new InsufficientPointsException();
            }

            float[] bPoints = new float[size];

            // Add first b point
            bPoints[0] = yPts[0];
            yCoord = bPoints[0];

            // Each iteration = new layer = yPts-1
            for (int i=1; i<size; i++)
            {
                yPts = GetNextLayer(i, xPts, yPts);
                bPoints[i] = yPts[0];
            }

            // Interpolate xCoord into the graph
            for (int i=1; i < size; i++)
            {
                float temp = bPoints[i];
                for (int j=0; j < i; j++)
                {
                    temp *= xCoord - xPts[j];
                }
                yCoord += temp;
            }
            return yCoord;
        }
        
        /// <summary>
        /// Computes for the next layer of y points
        /// </summary>
        /// <param name="nLayer">Number of current layer</param>
        /// <param name="size">Initial size of points</param>
        /// <param name="xPts">Initial array of x points</param>
        /// <param name="yPts">Previous array of y points</param>
        /// <returns></returns>
        static private float[] GetNextLayer(int nLayer, float[] xPts, float[] yPts)
        {
            int size = yPts.Length;
            float[] nextLayer = new float[size-1];

            for (int i=0; i<(size-1); i++)
            {
                nextLayer[i] = (yPts[i+1]-yPts[i]) / (xPts[i+nLayer]-xPts[i]);
            }
            return nextLayer;
        }
    }
}
