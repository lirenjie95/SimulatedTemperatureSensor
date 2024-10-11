// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace SimulatedTemperatureSensorModule
{
    public class TemperatureDataFactory
    {
        private static readonly Random rand = new Random();
        
        public static MessageBody CreateSensorData(DataGenerationPolicy policy)
        {
            policy = policy ?? new DataGenerationPolicy();
            policy.IncreaseDefectsTypeA();
            policy.IncreaseDefectsTypeB();
            policy.IncreaseDefectsTypeC();
            var messageBody = new MessageBody
            {
                orders = new Orders
                {
                    typeA = policy.OrdersTypeA,
                    typeB = policy.OrdersTypeB,
                    typeC = policy.OrdersTypeC
                },
                defects = new Defects
                {
                    typeA = policy.DefectsTypeA,
                    typeB = policy.DefectsTypeB,
                    typeC = policy.DefectsTypeC
                },
                TimeCreated = string.Format("{0:O}", DateTime.Now)
            };

            return messageBody;
        }
    }
}