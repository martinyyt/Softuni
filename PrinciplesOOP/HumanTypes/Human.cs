using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanTypes
{
    class Human
    {
        private string firstName = null;
        private string thirdName = null;

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }
        public string ThirdName
        {
            get
            {
                return thirdName;
            }
            set
            {
                this.thirdName = value;
            }
        }

        public Human(string firstName, string thirdName)
        {
            this.FirstName = firstName;
            this.ThirdName = thirdName;
        }
        public override string ToString()
        {
            return string.Format("{0} {1}", FirstName,ThirdName);
        }
    }
}
