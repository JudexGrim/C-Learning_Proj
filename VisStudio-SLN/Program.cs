using Learning_Proj.Sections;
using System.Diagnostics;
using System.Xml.Linq;


namespace Learning_Proj
{
    using Learning_Proj.PersonModel.EmolyeeModel;
    using System.Linq;
    using System.Reflection.Metadata;

    internal class Program
    {

        static void Main()
        {
            ////interface initialization
            //bankaccountprocessor bankaccount = new bankaccountprocessor();
            //ipaymentproccessor creditcard = new creditcardprocessor();

            //bankingservice bankaccountservice = new bankingservice(bankaccount);
            //bankingservice creditcardservice = new bankingservice(creditcard);

            Dependancy1 Dep1 = new Dependancy1();
            Dependancy2 Dep2 = new Dependancy2();

            DIExample DIExample = new DIExample();
            DIExample.Dep1 = Dep1;
            DIExample.Dep2 = Dep2;
            DIExample.SetterExample();
            var bruh = "Retard";

            if (bruh == Categories.Retard.ToString()) {



        }
    }
}
