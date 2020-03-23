/*

* Author: Nathan Bean 

* Edited by: Zachary Terrell

* Class name: Side.cs

* Purpose: Represents the properties of sides
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a side
    /// </summary>
    public abstract class Side : IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

       

        private Size size;
        /// <summary>
        /// Gets the size of the side
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
                NotifyOfSizeChanged();
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }

        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the side
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Gets special instructions
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// Condition for if the size is small
        /// </summary>
        public virtual bool Small
        {
            get
            {
                if(Size == Size.Small)
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
                    NotifyOfSizeChanged();
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
                    NotifyOfSizeChanged();
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
                    NotifyOfSizeChanged();
                }
            }
        }
        /// <summary>
        /// Notifies order if property changes
        /// </summary>
        protected void NotifyOfSizeChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
        }
    }
}
