using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunActions
{
   public class ClassRunActions
    {

        public async void Run()
        {
            try
            {
                Action[] actions = new Action[]{new Action(FirstAction),
                                                 new Action(SecondAction),
                                                    new Action(ThirdAction),
                new Action(FourthAction)};
                int counter = 0;

                while (counter < actions.Length)
                {
                     
                  await  Task.Run(actions[counter]);
                    counter++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong due to\n" + ex.Message);

            }
        }

       

        private void FirstAction()
        {
            Console.WriteLine("This is First Action.");
        }
        private void SecondAction()
        {
            Console.WriteLine("This is Second Action.");
        }

        private void ThirdAction()
        {
            Console.WriteLine("This is Third Action.");
        }

        private void FourthAction()
        {
            Console.WriteLine("Actions Completed.");
        }

    }


}
