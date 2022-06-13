///directing class for CSE210 greed game. -Eric Poole
namespace CSE210-Greed.directing.Game{

    public class Director{

        private KeyboardService keyboardService = null;
        private VideoService videoService = null;

        ///Setting the intilisation of the director class.
        public Director(KeyboardService keyboardService, VideoService videoService)
        {
            this.keyboardService = keyboardService;
            this.videoService = videoService;
        }

        ///start game function allows you to start game and calls the different aspects of the game.
        public void StartGame(Cast cast){
            videoService.OpenWindow();
            while (videoService.IsWindowOpen()){
                GetInputs();
                SetUpdates();
                PushOutputs();
            }
            videoService.CloseWindow();
        }
        
        // pulls the users inputs
        public void GetInputs{
            Console.WriteLine("getting inputs");
            Actor robot = cast.GetFirstActor("robot");
            Point velocity = keyboardService.GetDirection();
            robot.SetVelocity(velocity);     
        }
        public void SetUpdates{
            Console.WriteLine("setting updates");

        }
        public void PushOutputs{
            Console.WriteLine("push outputs");

        }
    }
}