using System;

namespace Tema2
{
    class CommissionCalculator {
        public decimal CalculateCommission(RealEstateAgency rea, decimal price) {
            var commission =GetCommission(rea);
            return price * commission;
        }
        public decimal CalculateTotalPrice(RealEstateAgency rea, decimal price) {
            return price + price * GetCommission(rea);
        }

        public decimal GetCommission(RealEstateAgency rea) {
            if (rea is Studio) {
                if (rea.yearBuilt < 1990)
                {
                    if (rea.surface < 15 || rea.surface > 30)
                        throw new Exception("No studios with this surface! Please introduce a valid value for surface(15-30 square meters).");
                    else if (rea.surface <= 30)
                        return 0.008m;
                }
                else
                {
                    if (rea.surface < 15 || rea.surface > 30)
                        throw new Exception("No studios with this surface! Please introduce a valid value for surface(15-30 square meters).");
                    else if (rea.surface <= 30)
                        return 0.012m;
                }
                return 0m;
            }
            if (rea is Apartment) {
                if (rea.yearBuilt < 1990)
                {
                    if (rea.surface < 30 || rea.surface > 90)
                        throw new Exception("No apartments with this surface! Please introduce a valid value for surface(30-90 square meters).");
                    else if (rea.surface <= 60)
                        return 0.016m;
                }
                else
                {
                    if (rea.surface < 30 || rea.surface > 90)
                        throw new Exception("No apartments with this surface! Please introduce a valid value for surface(30-90 square meters).");
                    else if (rea.surface <= 60)
                        return 0.02m;
                }
                return 0m;
            }
            if (rea is House) {
                if (rea.floors < 1 || rea.floors > 3)
                    throw new Exception("No houses with " + rea.floors + " floor/floors. Please verifiy that dates are correct!");
                else if (rea.floors > 0 || rea.floors < 2)
                {
                    if (rea.yearBuilt < 1990)
                    {
                        if (rea.surface < 50 || rea.surface > 350)
                            throw new Exception("No houses with this surface!Please introduce a valid value for surface(50-350 square meters).");
                        else if (rea.surface <= 350)
                            return 0.01m;
                    }
                    else
                    {
                        if (rea.surface < 50 || rea.surface > 350)
                            throw new Exception("No houses with this surface!Please introduce a valid value for surface(50-350 square meters).");
                        else if (rea.surface <= 350)
                            return 0.015m;
                    }
                }
                else if (rea.floors >= 2 || rea.floors <= 3)
                {
                    if (rea.yearBuilt < 1990)
                    {
                        if (rea.surface < 50 || rea.surface > 350)
                            throw new Exception("No houses with this surface!Please introduce a valid value for surface(50-350 square meters).");
                        else if (rea.surface <= 350)
                            return 0.015m;
                    }
                    else
                    {
                        if (rea.surface < 50 || rea.surface > 350)
                            throw new Exception("No houses with this surface!Please introduce a valid value for surface(50-350 square meters).");
                        else if (rea.surface <= 350)
                            return 0.025m;
                    }
                }

                throw new InvalidOperationException("Please verify the number of floors!");      
            }
            if (rea is Land) {
                if (rea.type.ToLower() == "urban")
                {
                    if (rea.surface < 3000)
                        return 0.02m;
                    else if (rea.surface > 3000 || rea.surface < 10000)
                        return 0.035m;
                    else
                        return 0.05m;
                }
                else if (rea.type.ToLower() == "rural")
                {
                    if (rea.surface < 3000)
                        return 0.01m;
                    else if (rea.surface > 3000 || rea.surface < 10000)
                        return 0.015m;
                    else
                        return 0.03m;
                }
                throw new Exception("Invalid type of land(Please verify that type are rural/urban)");
            }
            throw new InvalidOperationException("Unknown estate type or land!");
        }
    }

}



