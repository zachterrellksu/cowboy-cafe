/*

* Author: Zachary Terrell 

* Class name: Drink.cs

* Purpose: Represents the base class of the drink

*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace CowboyCafe.Data
{
    /// <summary>
    /// Represents the base class of the drink
    /// </summary>
    public abstract class Drink: IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// The property changed event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the Calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        Size size = Size.Small;
        /// <summary>
        /// Gets and sets the size of the drink
        /// </summary>
        public virtual Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }

        private bool ice = true;
        /// <summary>
        /// Gets and sets whether or not the drink has ice
        /// </summary>
        public virtual bool Ice 
        {
            get
            {
                return ice;
            }
            set
            {
                ice = value;
                NotifyOfPropertyChange("Ice");
            }
        }

        /// <summary>
        /// Condition for if the size is small
        /// </summary>
        public virtual bool Small
        {
            get
            {
                if (Size == Size.Small)
                {
                    return true;
                }
                return false;
            }

            set
            {
                if (value)
                {
                    Size = Size.Small;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                }
            }
        }

        /// <summary>
        /// Condition for if the size is small
        /// </summary>
        public virtual bool Medium
        {
            get
            {
                if (Size == Size.Medium)
                {
                    return true;
                }
                return false;
            }

            set
            {
                if (value)
                {
                    Size = Size.Medium;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                }
            }
        }

        /// <summary>
        /// Condition for if the size is small
        /// </summary>
        public virtual bool Large
        {
            get
            {
                if (Size == Size.Large)
                {
                    return true;
                }
                return false;
            }

            set
            {
                if (value)
                {
                    Size = Size.Large;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                }
            }
        }

        /// <summary>
        /// The special instructions for making the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get;}

        /// <summary>
        /// Notifies order if property changes
        /// </summary>
        /// <param name="propertyName"></param>
        protected void NotifyOfPropertyChange(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }

        /// <summary>
        /// Notifies order if property changes
        /// </summary>
        protected void NotifyOfFlavorChange()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Flavor"));
        }
    }
}
