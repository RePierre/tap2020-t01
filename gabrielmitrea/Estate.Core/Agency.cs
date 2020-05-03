using System;
using Uaic.Estate.Core.Assets.Base;
using Uaic.Estate.Core.Calculators;
namespace Uaic.Estate.Core
{
   
        public class Agency
        {
            public static void PriceForPropetyType(PropertyType propertyType, string address, decimal amount, IAgentCommisionCalculator agentCommisionCalculator)
            {
                var totalPrice = agentCommisionCalculator.SellPriceWithAgentCommission(amount);
                var agentCommission = agentCommisionCalculator.Commission(amount);
                var initialPrice = agentCommisionCalculator.SellPriceWithoutCommission(amount);
                propertyType.Sell(address, initialPrice, agentCommission, totalPrice);
                Console.WriteLine("Property type: " + propertyType.GetType().Name + "\r\n" + "Address: " + propertyType.Address + "\r\n" + "Initial price: " + propertyType.InitialPrice + "\r\n" + "Agent commission: " + propertyType.AgentCommission + "\r\n" + "Total price: " + propertyType.TotalPrice + "\r\n");
              
               
            }
            public static void PriceForPropetyType1(PropertyType propertyType, decimal cadastralNumber, decimal amount, IAgentCommisionCalculator agentCommisionCalculator)
            {
                var totalPrice = agentCommisionCalculator.SellPriceWithAgentCommission(amount);
                var agentCommission = agentCommisionCalculator.Commission(amount);
                var initialPrice = agentCommisionCalculator.SellPriceWithoutCommission(amount);
                propertyType.Sellland(cadastralNumber, initialPrice, agentCommission, totalPrice);
                Console.WriteLine("Property type: " + propertyType.GetType().Name + "\r\n" + "Cadastral number: " + propertyType.CadastralNumber + "\r\n" + "Initial price: " + propertyType.InitialPrice + "\r\n" + "Agent commission: " + propertyType.AgentCommission + "\r\n" + "Total price: " + propertyType.TotalPrice + "\r\n");
            }

        }
    }


