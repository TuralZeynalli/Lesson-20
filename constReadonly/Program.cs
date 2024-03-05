using System;
using System.Collections.Generic;
using System.Text;

namespace constReadonly
{
    class Program
    {
        static void Main(string[] args)
        {
            #region GenericClass

            Generic_Class<Tablet> tabletRamCapasity = new Generic_Class<Tablet>();
            Tablet tablet = new Tablet();
            int ramTab = tabletRamCapasity.ReturnRam(tablet);

            Generic_Class<Telephone> telephoneRamCapasity = new Generic_Class<Telephone>();
            Telephone telephone = new Telephone();
            int ramPhone = telephoneRamCapasity.ReturnRam(telephone);

            Generic_Class<Computer> computerRamCapasity = new Generic_Class<Computer>();
            Computer computer = new Computer();
            int ramComp = computerRamCapasity.ReturnRam(computer);

            Console.WriteLine($"Tablet ram is {ramTab}gb \r\nPhone ram is {ramPhone}gb \r\nComputer ram is {ramComp}gb");

            #endregion

        }
    }
}
