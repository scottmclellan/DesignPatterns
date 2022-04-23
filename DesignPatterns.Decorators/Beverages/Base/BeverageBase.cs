using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorators
{
    public abstract class BeverageBase : IBeverage
    {
        public BeverageBase(SizeEnum size)
        {
            Size = size;
        }

        public SizeEnum Size { get; set; } = SizeEnum.Small;
        public virtual string Description { get; set; } = "Unknown Beverage";

        public virtual decimal UnitCost { get; set; }
        public virtual decimal TotalCost { 
            get            
            {
                decimal sizeMultiple = 1.0M;

                switch (Size)
                {
                    case SizeEnum.Small:
                        sizeMultiple = 0.75M;
                        break;
                    case SizeEnum.Medium:
                        sizeMultiple = 1.0M;
                        break;
                    case SizeEnum.Large:
                        sizeMultiple = 1.25M;
                        break;
                    case SizeEnum.ExtraLarge:
                        sizeMultiple = 1.5M;
                        break;
                    default:
                        break;
                }

                return UnitCost * sizeMultiple;
            }

        }
    }
}
