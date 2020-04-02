namespace Tema2
{
        public class Land : RealEstateAgency
        {
            public Land(decimal price, string type, int cadastral_number, double surface) : base(price,type,cadastral_number,surface) { }
            public override decimal calculate_commission()
            {
                if (type == "urban") {
                    if (surface < 3000)
                        return price * 0.02m;
                    else if (surface > 3000 || surface < 10000)
                        return price * 0.035m;
                    else
                        return price * 0.05m;
                }
                else if(type == "rural"){
                if (surface < 3000)
                    return price * 0.01m;
                else if (surface > 3000 || surface < 10000)
                    return price * 0.015m;
                else
                    return price * 0.03m;
                }
                return price;
            }
        }
   }


