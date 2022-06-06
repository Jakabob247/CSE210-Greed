///directing class for CSE210 greed game. -Eric Poole
namespace CSE210-Greed{

    public class Director{
        ///Setting the intilisation of the director class.
        public void Director(){
            Console.WriteLine("Hello World From the directing class ");
        }
        ///start game function allows you to start game and calls the different aspects of the game.
        public void StartGame(){
            videoService.OpenWindow();
            while (videoService.IsWindowOpen()){
                GetInputs();
                SetUpdates();
                PushOutputs();
            }
        // pulls the users inputs
        public void GetInputs{
            Console.WriteLine("getting inputs");

        }
        public void SetUpdates{
            Console.WriteLine("setting updates");

        }
        public void PushOutputs{
            Console.WriteLine("push outputs");

        }

        }

    }
}