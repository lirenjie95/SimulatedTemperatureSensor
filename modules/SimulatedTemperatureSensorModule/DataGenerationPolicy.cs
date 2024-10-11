// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace SimulatedTemperatureSensorModule
{
    public class DataGenerationPolicy
    {
        private static readonly Random rnd = new Random();

        private const double addOrderRate = 0.5;

        private const double defectRate = 0.03;

        public DataGenerationPolicy()
        {
            OrdersTypeA = 0;
            OrdersTypeB = 0;
            OrdersTypeC = 0;
            DefectsTypeA = 0;
            DefectsTypeB = 0;
            DefectsTypeC = 0;
        }

        public int OrdersTypeA { get; private set; }
        public int OrdersTypeB { get; private set; }
        public int OrdersTypeC { get; private set; }
        public int DefectsTypeA { get; private set; }
        public int DefectsTypeB { get; private set; }
        public int DefectsTypeC { get; private set; }

        public void IncreaseOrdersTypeA()
        {
            if (rnd.NextDouble() > addOrderRate)
            {
                OrdersTypeA++;
            }
        }

        public void IncreaseOrdersTypeB()
        {
            if (rnd.NextDouble() > addOrderRate)
            {
                OrdersTypeB++;
            }
        }

        public void IncreaseOrdersTypeC()
        {
            if (rnd.NextDouble() > addOrderRate)
            {
                OrdersTypeC++;
            }
        }

        public void IncreaseDefectsTypeA()
        {
            int previousOrdersA = OrdersTypeA;
            IncreaseOrdersTypeA();
            if (OrdersTypeA > previousOrdersA && rnd.NextDouble() < defectRate)
            {
                DefectsTypeA++;
            }            
        }

        public void IncreaseDefectsTypeB()
        {
            int previousOrdersB = OrdersTypeB;
            IncreaseOrdersTypeB();
            if (OrdersTypeB > previousOrdersB && rnd.NextDouble() < defectRate)
            {
                DefectsTypeB++;
            }
        }

        public void IncreaseDefectsTypeC()
        {
            int previousOrdersC = OrdersTypeC;
            IncreaseOrdersTypeC();
            if (OrdersTypeC > previousOrdersC && rnd.NextDouble() < defectRate)
            {
                DefectsTypeC++;
            }
        }
    }
}